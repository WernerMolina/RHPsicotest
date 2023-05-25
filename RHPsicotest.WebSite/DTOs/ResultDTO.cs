using RHPsicotest.WebSite.Models;
using System.Collections.Generic;

namespace RHPsicotest.WebSite.DTOs
{
    public class ResultDTO
    {
        public int IdTest { get; set; }

        public List<Result> Results { get; set; }
    }
}
