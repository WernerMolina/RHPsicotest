using LovePdf.Core;
using LovePdf.Model.Enums;
using LovePdf.Model.Task;
using LovePdf.Model.TaskParams;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Utilities
{
    public static class FileServices
    {
        private static readonly string folderPath = Path.GetFullPath("Z_CVs\\");
        private static readonly IConfiguration _configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        public static async Task<string> SaveCurriculum(IFormFile formFile, string userNameFull)
        {
            ValidateCurriculum(formFile);

            string fileName = $"{userNameFull}_{Guid.NewGuid().ToString().Substring(0, 8)}.pdf";
            string pathFull = folderPath + fileName;

            if (formFile.Length > 1048576)
            {
                byte[] pdfCompress = await PDFCompress(formFile);
                File.WriteAllBytes(pathFull, pdfCompress);
            }
            else
            {
                using var stream = new FileStream(pathFull, FileMode.Create);
                formFile.CopyTo(stream);
            }

            return fileName;
        }

        public static byte[] GetCurriculum(string fileName)
        {
            return File.ReadAllBytes(folderPath + fileName);
        }

        private static void ValidateCurriculum(IFormFile formFile)
        {
            if (Path.GetExtension(formFile.FileName) != ".pdf")
                throw new Exception("El archivo tiene que ser de tipo pdf");

            if (formFile.Length <= 0)
                throw new Exception("El archivo no tiene contenido");

            if (formFile.Length > 5242880)
                throw new Exception("El archivo tiene que pesar menos de 5mb");
        }

        private static async Task<byte[]> PDFCompress(IFormFile formFile)
        {
            string publicKey = _configuration.GetValue<string>("ILovePDF:PublicKey");
            string secretKey = _configuration.GetValue<string>("ILovePDF:SecretKey");

            try
            {
                using var memoryStream = new MemoryStream();
                await formFile.CopyToAsync(memoryStream);
                byte[] pdfBytes = memoryStream.ToArray();

                var lovePdf = new LovePdfApi(publicKey, secretKey);
                var task = lovePdf.CreateTask<CompressTask>();
                var file = task.AddFile(pdfBytes);
                task.Process(new CompressParams
                {
                    CompressionLevel = CompressionLevels.Recommended,
                });

                return await task.DownloadFileAsByteArrayAsync();
            }
            catch (Exception)
            {
                throw new Exception("No se pudo guardar el archivo pdf");
            }
        }
    }
}
