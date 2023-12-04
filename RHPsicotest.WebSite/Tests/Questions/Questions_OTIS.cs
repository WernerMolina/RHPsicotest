using System.Collections.Generic;

namespace RHPsicotest.WebSite.Tests.Questions
{
    public class Questions_OTIS
    {
        public byte QuestionNumber { get; set; }
        public string Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string OptionE { get; set; }

        public static List<Questions_OTIS> GetQuestions()
        {
            return new List<Questions_OTIS>
            {
                new Questions_OTIS
                {
                    QuestionNumber = 1,
                    Question = "¿Qué expresa mejor lo que es un martillo?",
                    OptionA = "Cosa",
                    OptionB = "Mueble",
                    OptionC = "Arma",
                    OptionD = "Herramienta",
                    OptionE = "Máquina"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 2,
                    Question = "¿Cuál de esas cinco palabras significa lo contrario de GANAR?",
                    OptionA = "Conseguir",
                    OptionB = "Decaer",
                    OptionC = "Perder",
                    OptionD = "Acceder",
                    OptionE = "Ensayar"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 3,
                    Question = "La hierba es para la vaca lo que el pan es para...",
                    OptionA = "La manteca",
                    OptionB = "La Harina",
                    OptionC = "La leche",
                    OptionD = "El hombre",
                    OptionE = "La cosecha"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 4,
                    Question = "¿Qué es para el automóvil lo que el carbón es para la locomotora?",
                    OptionA = "El humo",
                    OptionB = "La motocicleta",
                    OptionC = "Las ruedas",
                    OptionD = "La gasolina",
                    OptionE = "La bocina"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 5,
                    Question = "Los números que vienen aquí debajo forman una serie y uno de ellos no es correcto. ¿Qué número debería ir en su lugar? 5  10  15  20  25  30  35  39",
                    OptionA = "35",
                    OptionB = "40",
                    OptionC = "42",
                    OptionD = "45",
                    OptionE = "48"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 6,
                    Question = "La mano es para el brazo lo que el pie es para...",
                    OptionA = "La pierna",
                    OptionB = "El pulgar",
                    OptionC = "El dedo",
                    OptionD = "El puño",
                    OptionE = "La rodilla"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 7,
                    Question = "De un muchacho que no hace más que hablar de sus cualidades y de su sabiduría, se dice que...",
                    OptionA = "Miente",
                    OptionB = "Bromea",
                    OptionC = "Engaña",
                    OptionD = "Se divierte",
                    OptionE = "Se alaba"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 8,
                    Question = "De una persona que tiene deseos de hacer una cosa pero teme el fracaso, se dice que es...",
                    OptionA = "Seria",
                    OptionB = "Ansiosa",
                    OptionC = "Trabajadora",
                    OptionD = "Enérgica",
                    OptionE = "Tímida"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 9,
                    Question = "El sombreo es para la cabeza lo que el dedal es para...",
                    OptionA = "El dedo",
                    OptionB = "La aguja",
                    OptionC = "El hilo",
                    OptionD = "La mano",
                    OptionE = "La costura"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 10,
                    Question = "El hijo de la hermana de mi padre es mi...",
                    OptionA = "Hermano",
                    OptionB = "Sobrino",
                    OptionC = "Primo",
                    OptionD = "Tío",
                    OptionE = "Nieto"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 11,
                    Question = "¿Cuál de estas cantidades es la mayor?",
                    OptionA = "6,456",
                    OptionB = "8,968",
                    OptionC = "4,265",
                    OptionD = "5,064",
                    OptionE = "4,108"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 12,
                    Question = "Cuando sabemos que un acontecimiento va a pasar sin ninguna clase de dudas, decimos que es...",
                    OptionA = "Probable",
                    OptionB = "Seguro",
                    OptionC = "Dudoso",
                    OptionD = "Posible",
                    OptionE = "Diferido"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 13,
                    Question = "¿Qué palabra indica el lado opuesto de ESTE?",
                    OptionA = "Norte",
                    OptionB = "Polo",
                    OptionC = "Ecuador",
                    OptionD = "Sur",
                    OptionE = "Oeste"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 14,
                    Question = "¿Qué palabra indica lo contrario de soberbia?",
                    OptionA = "Tristeza",
                    OptionB = "Humildad",
                    OptionC = "Pobreza",
                    OptionD = "Variedad",
                    OptionE = "Altanería"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 15,
                    Question = "¿Cuál de estas cinco cosas no debería agruparse a las demás?",
                    OptionA = "Pera",
                    OptionB = "Plátano",
                    OptionC = "Naranja",
                    OptionD = "Pelota",
                    OptionE = "Higo"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 16,
                    Question = "¿Qué definición de estas expresa más exactamente lo que es un reloj?",
                    OptionA = "Una cosa redonda que hace tic-tac",
                    OptionB = "Un aparato que se coloca en las torres",
                    OptionC = "Un instrumento redondo con una cadena",
                    OptionD = "Un instrumento que mide le tiempo",
                    OptionE = "Una cosa redonda que tiene aguja y cristal"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 17,
                    Question = "Si una persona al salir de su casa, da siete pasos hacia la derecha y después retrocede cuatro hacia la izquierda, ¿A cuántos pasos está de su casa?",
                    OptionA = "7",
                    OptionB = "4",
                    OptionC = "11",
                    OptionD = "3",
                    OptionE = "10"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 18,
                    Question = "Si comparamos el automóvil a una carreta, ¿A qué deberíamos comparar una motocicleta?",
                    OptionA = "A la carrera",
                    OptionB = "Al caballo",
                    OptionC = "Al tranvía",
                    OptionD = "Al tren",
                    OptionE = "A la bicicleta"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 19,
                    Question = "¿Cuál es la razón por la cual las fachadas de los comercios están muy iluminadas?",
                    OptionA = "Con el fin de que los transeúntes sepan en donde están",
                    OptionB = "Para que se puedan ver bien los artículos expuestos y la gente sienta deseos de comprar",
                    OptionC = "Porque los comercios pagan muy barata la corriente eléctrica",
                    OptionD = "Para aumenta la iluminación de la calle",
                    OptionE = "Porque el Ayuntamiento les obliga"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 20,
                    Question = "¿Cuál de estas cinco cosas tienen más parecido con manzana, melocotón y pera?",
                    OptionA = "Semilla",
                    OptionB = "Árbol",
                    OptionC = "Ciruela",
                    OptionD = "Jugo",
                    OptionE = "Cascara"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 21,
                    Question = "En el abecedario ¿Qué letra sigue a la K?",
                    OptionA = "La J",
                    OptionB = "La G",
                    OptionC = "La M",
                    OptionD = "La L",
                    OptionE = "La N"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 22,
                    Question = "El rey es a la monarquía lo que el presidente es a...",
                    OptionA = "La Presidenta del Consejo de Ministros",
                    OptionB = "El Senado",
                    OptionC = "La Republica",
                    OptionD = "Un monárquico",
                    OptionE = "Un republicano"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 23,
                    Question = "La lana es para el carnero lo que las plumas son para...",
                    OptionA = "La almohada",
                    OptionB = "El conejo",
                    OptionC = "El pájaro",
                    OptionD = "La cabra",
                    OptionE = "La cama"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 24,
                    Question = "¿Cuál de estas definiciones expresa más exactamente lo que es un cordero?",
                    OptionA = "Un animal terrestre",
                    OptionB = "Un ser que tiene cuatro patas y una cola",
                    OptionC = "Un animal pequeño y avispado",
                    OptionD = "Un carnero joven",
                    OptionE = "Un animalito que come hierba"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 25,
                    Question = "Pesado es a plomo lo que sonoro es a...",
                    OptionA = "Suave",
                    OptionB = "Pequeño",
                    OptionC = "Sólido",
                    OptionD = "Gris",
                    OptionE = "Ruido"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 26,
                    Question = "Mejor es a bueno lo que peor es a...",
                    OptionA = "Muy bueno",
                    OptionB = "Mediano",
                    OptionC = "Malo",
                    OptionD = "Nulo",
                    OptionE = "Superior"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 27,
                    Question = "¿Cuál de estas cosas tiene más parecido con las tenazas, alambre y clavo?",
                    OptionA = "Billete",
                    OptionB = "Hueso",
                    OptionC = "Cuerda",
                    OptionD = "Lápiz",
                    OptionE = "Llave"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 28,
                    Question = "Ante el dolor de los demás normalmente sentimos...",
                    OptionA = "Rabia",
                    OptionB = "Piedad",
                    OptionC = "Desprecio",
                    OptionD = "Indiferencia",
                    OptionE = "Nostalgia"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 29,
                    Question = "Cuando alguien concibe una nueva máquina, se dice que ha hecho una...",
                    OptionA = "Exploración",
                    OptionB = "Adaptación",
                    OptionC = "Renovación",
                    OptionD = "Novedad",
                    OptionE = "Invención"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 30,
                    Question = "¿Qué es para la abeja lo que las uñas son para el gato?",
                    OptionA = "Vuelo",
                    OptionB = "Miel",
                    OptionC = "Alas",
                    OptionD = "Cera",
                    OptionE = "Aguijón"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 31,
                    Question = "Uno de los números de esta serie está equivocado ¿Qué número debería ir en su lugar? 1  7  2  7  3  7  4  7  5  7  6  7  8  7",
                    OptionA = "7",
                    OptionB = "6",
                    OptionC = "5",
                    OptionD = "8",
                    OptionE = "9"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 32,
                    Question = "¿Cuál es la primera razón por la que vemos cada día sustituir los caballos por los automóviles?",
                    OptionA = "Los caballo cada día son más escasos",
                    OptionB = "Los caballos se desbocan fácilmente",
                    OptionC = "Los autos nos hacen ganar tiempo",
                    OptionD = "Los autos son más económicos que los caballos",
                    OptionE = "Las reparaciones de los autos son más baratas que la de los caballos"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 33,
                    Question = "La corteza es para la naranja y la vaina es para el guisante lo que la cascara es para...",
                    OptionA = "La manzana",
                    OptionB = "El huevo",
                    OptionC = "El jugo",
                    OptionD = "El melocotón",
                    OptionE = "La gallina"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 34,
                    Question = "¿Qué es para el criminal lo que el hospital es para el enfermo?",
                    OptionA = "Juez",
                    OptionB = "Orfanato",
                    OptionC = "Doctor",
                    OptionD = "Cárcel",
                    OptionE = "Sentencia"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 35,
                    Question = "Si estos números estuviesen ordenados, ¿Por qué letra empezaría el del centro?",
                    OptionA = "La S",
                    OptionB = "La N",
                    OptionC = "La O",
                    OptionD = "la D",
                    OptionE = "La C"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 36,
                    Question = "A 30 centavos la cartulina, ¿Cuántas podrán comprarse por 3 dólares?",
                    OptionA = "10 cartulinas",
                    OptionB = "5 cartulinas",
                    OptionC = "8 cartulinas",
                    OptionD = "3 cartulinas",
                    OptionE = "25 cartulinas"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 37,
                    Question = "De una cantidad que disminuye se dice que...",
                    OptionA = "Se va",
                    OptionB = "Decrece",
                    OptionC = "Se agota",
                    OptionD = "Muere",
                    OptionE = "Desaparece"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 38,
                    Question = "Hay un refrán que dice no es oro todo lo que reluce y esto significa",
                    OptionA = "Hay oro no brilla",
                    OptionB = "No hay que dejarse llevar por las apariencias",
                    OptionC = "El diamante es más brillante que el oro",
                    OptionD = "No hay que llevar bisutería que imite al oro",
                    OptionE = "Hay gente a quienes les gusta exhibir sus riquezas"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 39,
                    Question = "En una lengua extranjera KOLO quiere decir niño y DAAK KOLO niño bueno. ¿Por cuál letra empieza la palabra que significa bueno en ese idioma?",
                    OptionA = "La D",
                    OptionB = "La K",
                    OptionC = "La M",
                    OptionD = "La S",
                    OptionE = "La A"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 40,
                    Question = "Este refrán, “más vale pájaro en mano que cien volando”, quiere decir",
                    OptionA = "Es preferible poseer una pequeña cosa que esperar una grande",
                    OptionB = "El corazón fuerte no se deja rendir por la adulación",
                    OptionC = "Ningún hombre suele apartarse de la verdad sin engañarse a si mismo",
                    OptionD = "El que está en todas partes no está en ninguna",
                    OptionE = "Cuando se tiene una cosa hay que procurar conservar"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 41,
                    Question = "¿Cuál de estas cinco cosas es más compleja?",
                    OptionA = "Retoño",
                    OptionB = "Hoja",
                    OptionC = "Árbol",
                    OptionD = "Rama",
                    OptionE = "Tronco"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 42,
                    Question = "Si estas palabras estuviesen convenientemente ordenadas para formar una frase ¿Por cuál letra empezaría la tercera palabra? CON  DIME  ERES  QUIEN  DIRE  ANDAS  Y  TE  QUIEN",
                    OptionA = "La D",
                    OptionB = "La Q",
                    OptionC = "La A",
                    OptionD = "La C",
                    OptionE = "La Y"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 43,
                    Question = "Si Jorge es mayor que Pedro, y Pedro es mayor que Juan, entonces Jorge es ________ que Juan.",
                    OptionA = "Mayor",
                    OptionB = "Más pequeño",
                    OptionC = "Iguales",
                    OptionD = "No se puede saber",
                    OptionE = ""
                },
                new Questions_OTIS
                {
                    QuestionNumber = 44,
                    Question = "¿Cuál de estas palabras es la primera que aparece en un diccionario?",
                    OptionA = "Raspador",
                    OptionB = "Queso",
                    OptionC = "Cueva",
                    OptionD = "Noche",
                    OptionE = "Pintura"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 45,
                    Question = "Si las palabras General, Teniente, Soldado, Coronel y Alférez estuviesen colocadas indicando el orden jerárquico que significan, ¿Por qué letra empezaría la del centro?",
                    OptionA = "La G",
                    OptionB = "La T",
                    OptionC = "La S",
                    OptionD = "La C",
                    OptionE = "La A"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 46,
                    Question = "Hay un refrán que dice un grano no hace granero, pero ayuda al compañero, y esto significa",
                    OptionA = "Resuélvete a hacer lo que debes y haz sin falta lo que hayas",
                    OptionB = "Hay que ganarse la vida a fuerza de amor",
                    OptionC = "No se deben menospreciar las cosas pequeñas",
                    OptionD = "En casa pobre no es necesario granero",
                    OptionE = "Las personas deben ayudarse unas a otras"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 47,
                    Question = "Si Juan es mayor que José, y José tiene la misma edad que Carlos, entonces",
                    OptionA = "Carlos es mayor que Juan",
                    OptionB = "Juan y Carlos tienen la misma edad",
                    OptionC = "Carlos es más joven que Juan",
                    OptionD = "Juan es menor que Carlos",
                    OptionE = "José es el menor de los tres"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 48,
                    Question = "Ordenando la frase que viene aquí debajo, ¿Por cuál letra empezaría la última palabra? A  FALTA  TORTAS  BUENAS  PAN  SON  DE",
                    OptionA = "La T",
                    OptionB = "La P",
                    OptionC = "La D",
                    OptionD = "La B",
                    OptionE = "La S"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 49,
                    Question = "Si en una caja grande hubiera dos más pequeñas y dentro de cada una de estas dos hubiera cinco, ¿Cuántas habría en total?",
                    OptionA = "10",
                    OptionB = "12",
                    OptionC = "13",
                    OptionD = "15",
                    OptionE = "8"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 50,
                    Question = "¿Qué indica mejor lo que es una mentira?",
                    OptionA = "Un error",
                    OptionB = "Una afirmación voluntariamente falsa",
                    OptionC = "Una afirmación involuntariamente falsa",
                    OptionD = "Una exageración",
                    OptionE = "Una respuesta inexacta"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 51,
                    Question = "En un idioma extranjero SOTO GRON quiere decir muy caliente y PASS GRON muy frio ¿Por cuál letra empieza la palabra que significa “muy” en ese idioma?",
                    OptionA = "La M",
                    OptionB = "La Y",
                    OptionC = "La S",
                    OptionD = "La G",
                    OptionE = "La P"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 52,
                    Question = "La palabra que mejor expresa que una cosa o institución se mantiene a lo largo del tiempo es...",
                    OptionA = "Permanente",
                    OptionB = "Firme",
                    OptionC = "Estacionaria",
                    OptionD = "Sólida",
                    OptionE = "Verdadera"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 53,
                    Question = "Si Pablo es mayor que Luis y si Pablo es más joven que Andrés, entonces",
                    OptionA = "Andrés es mayor que Luis",
                    OptionB = "Pablo es el más joven",
                    OptionC = "Andrés y Luis tienen la misma edad",
                    OptionD = "El mayor de todos es Luis",
                    OptionE = "Pablo es mayor que Andrés"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 54,
                    Question = "¿Cuál de estas cosas tiene más parecido con serpiente, vaca y gorrión?",
                    OptionA = "Árbol",
                    OptionB = "Muñeca",
                    OptionC = "Carnero",
                    OptionD = "Pluma",
                    OptionE = "Piel"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 55,
                    Question = "Hay un refrán que dice a hierro caliente, batir de repente y esto significa",
                    OptionA = "El hierro batido en frio, es malo",
                    OptionB = "No se pueden hacer varias cosas al mismo tiempo",
                    OptionC = "Hay que saber aprovechar el momento",
                    OptionD = "Los herreros han de trabajar siempre de prisa",
                    OptionE = "El trabajo del hierro es cansado"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 56,
                    Question = "Si las palabras que vienen aquí debajo estuviesen ordenadas ¿Por cuál letra empezaría la del centro? SEMANA  AÑO  HORA  SEGUNDO  DIA  MES   MINUTO",
                    OptionA = "La S",
                    OptionB = "La M",
                    OptionC = "La H",
                    OptionD = "La D",
                    OptionE = "La A"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 57,
                    Question = "El capitán es para el barco lo que el alcalde es para...",
                    OptionA = "El Estado",
                    OptionB = "La provincia",
                    OptionC = "La ciudad",
                    OptionD = "El patrón",
                    OptionE = "El juez"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 58,
                    Question = "Uno de los números de la serie que viene aquí debajo está equivocado ¿Qué numero debería ir en su lugar? 2  3  4  3  2  3  4  3  2  4",
                    OptionA = "1",
                    OptionB = "2",
                    OptionC = "3",
                    OptionD = "6",
                    OptionE = "5"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 59,
                    Question = "Si un pleito se resuelve por mutuas concesiones, se dice que ha habido...",
                    OptionA = "Promesa",
                    OptionB = "Debate",
                    OptionC = "Perdón",
                    OptionD = "Proceso",
                    OptionE = "Convenio"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 60,
                    Question = "La oración que viene aquí debajo tiene las palabras desordenadas. ¿Qué letra debe marcarse atendiendo a la frase ordenada? FRASE  LA  LETRA  SEÑALE  PRIMERA  ESTA  DE",
                    OptionA = "La E",
                    OptionB = "La F",
                    OptionC = "La L",
                    OptionD = "La S",
                    OptionE = "La D"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 61,
                    Question = "En la serie de números que aparece aquí abajo, cuente todos los 5 que están delante de un 7. ¿Cuántos son?",
                    OptionA = "2",
                    OptionB = "3",
                    OptionC = "4",
                    OptionD = "5",
                    OptionE = "6"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 62,
                    Question = "¿Qué indica mejor lo que es un termómetro?",
                    OptionA = "Un tubo de cristal graduado que tiene mercurio",
                    OptionB = "Un instrumento para medir la fiebre",
                    OptionC = "Un aparato muy sensible al calor",
                    OptionD = "Un instrumento para medir la temperatura",
                    OptionE = "Un objeto que utilizan los médicos"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 63,
                    Question = "¿Cuál de estas palabras es la primera que aparece en un diccionario?",
                    OptionA = "Bravo",
                    OptionB = "Busto",
                    OptionC = "Brocha",
                    OptionD = "Bujía",
                    OptionE = "Bretón"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 64,
                    Question = "Uno de los números de la serie que aparece aquí debajo está equivocado ¿Qué numero debería ir en su lugar? 1  2  4  8  12  32  64",
                    OptionA = "10",
                    OptionB = "14",
                    OptionC = "16",
                    OptionD = "24",
                    OptionE = "6"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 65,
                    Question = "¿Cuál de estas palabras significa lo contrario de COMÚN?",
                    OptionA = "Trivial",
                    OptionB = "Vivo",
                    OptionC = "Difícil",
                    OptionD = "Raro",
                    OptionE = "Interesante"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 66,
                    Question = "¿Cuál de estas cinco cosas tienen más parecido con Presidente, Almirante y General?",
                    OptionA = "Barco",
                    OptionB = "Ejercito",
                    OptionC = "Rey",
                    OptionD = "República",
                    OptionE = "Soldado"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 67,
                    Question = "Si las palabras que aparecen aquí debajo estuvieran ordenadas, ¿Por cuál letra empezaría la del centro? Adolescente  Niño  Hombre  Viejo  Bebe",
                    OptionA = "La A",
                    OptionB = "La V",
                    OptionC = "La H",
                    OptionD = "La B",
                    OptionE = "La N"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 68,
                    Question = "¿Cuál de estas definiciones indican más exactamente lo que es un caballo?",
                    OptionA = "Un animal que tiene cola",
                    OptionB = "Un ser viviente",
                    OptionC = "Una cosa que trabaja",
                    OptionD = "Un animal que tira de los carros",
                    OptionE = "Un rumiante"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 69,
                    Question = "Un idioma extranjero BECO PRAC quiere decir un poco de pan, KLUP PRAC un poco de leche y BECO OTOH KLUP PRAC un poco de pan y leche. ¿Por cuál letra empieza la palabra que significa y en dicho idioma?",
                    OptionA = "La K",
                    OptionB = "La P",
                    OptionC = "La B",
                    OptionD = "La O",
                    OptionE = "La Y"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 70,
                    Question = "Si las palabras que aparecen aquí debajo estuviesen convenientemente ordenadas para formar una frase, ¿Por cuál letra empezaría la tercera palabra? MADRUGA  QUIEN  LE  DIOS  A  AYUDA",
                    OptionA = "La A",
                    OptionB = "La M",
                    OptionC = "La Q",
                    OptionD = "La D",
                    OptionE = "La L"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 71,
                    Question = "¿Cuál de estas palabras es la ultima que aparece en un diccionario?",
                    OptionA = "Juez",
                    OptionB = "Nervio",
                    OptionC = "Hora",
                    OptionD = "Norte",
                    OptionE = "Labio"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 72,
                    Question = "Si se ordena la frase que aparece aquí debajo, ¿Qué letra cumple lo que se dice en ella? EN  LETRA  RECUADRO  A  ESCRIBA  LA  EL",
                    OptionA = "La A",
                    OptionB = "La E",
                    OptionC = "La L",
                    OptionD = "La R",
                    OptionE = "La B"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 73,
                    Question = "Uno de los números de la serie que aparece aquí debajo está equivocado, ¿Qué numero debería ir en su lugar? 1  2  5  6  9  10  13  14  16  18",
                    OptionA = "14",
                    OptionB = "17",
                    OptionC = "20",
                    OptionD = "15",
                    OptionE = "16"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 74,
                    Question = "Si un ciclista recorre 250 metros en 25 segundos,  ¿Cuántos metros recorrerá en 12 segundos?",
                    OptionA = "10",
                    OptionB = "5",
                    OptionC = "2",
                    OptionD = "4",
                    OptionE = "25"
                },
                new Questions_OTIS
                {
                    QuestionNumber = 75,
                    Question = "Si la frase que aparece aquí debajo estuviera ordenada, ¿Qué numero cumple lo que en ella se dice? Y SUMA CUATRO ESCRIBA TRES LA UNO DE",
                    OptionA = "3",
                    OptionB = "4",
                    OptionC = "1",
                    OptionD = "7",
                    OptionE = "8"
                }
            };
        }

    }
}
