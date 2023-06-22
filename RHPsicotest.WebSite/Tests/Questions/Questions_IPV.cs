using System.Collections.Generic;

namespace RHPsicotest.WebSite.Tests.Questions
{
    public class Questions_IPV
    {
        public byte QuestionNumber { get; set; }
        public string Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }

        public static List<Questions_IPV> GetQuestions()
        {
            return new List<Questions_IPV>
            {
                new Questions_IPV
                {
                    QuestionNumber = 1,
                    Question = "T… debe salir de viaje  con una persona de la que no conoce nad¿Sobre cuál de los siguientes aspectos de esa persona es preferible informar a T. para que el viaje resulte mejor?",
                    OptionA = "Su estilo de vida.",
                    OptionB = "Los puntos que tengan en común.",
                    OptionC = "Su actividad y responsabilidad profesionales."
                },
                new Questions_IPV
                {
                    QuestionNumber = 2,
                    Question = "Entre los siguientes tipos de vendedores de prendas confeccionadas, ¿Cuál es el que tiene más probabilidades de éxito?",
                    OptionA = "El que presente las últimas novedades.",
                    OptionB = "El que tratando de conocer el estilo de su cliente, se interese por su modo de vida.",
                    OptionC = "El que posea una buena capacidad de convencer."
                },
                new Questions_IPV
                {
                    QuestionNumber = 3,
                    Question = "B… tiene un proyecto importante para la promoción de un nuevo producto y va a exponer su idea ante el Comité de Dirección. ¿Cuál de las siguientes cualidades le será más útil para persuadir a su auditorio?",
                    OptionA = "Competencia técnica y un conocimiento perfecto del tema.",
                    OptionB = "Capacidad para modificar sus razonamientos según la actitud del auditorio.",
                    OptionC = "Facultad para mantener el orden de sus ideas a pesar de las interrupciones."
                },
                new Questions_IPV
                {
                    QuestionNumber = 4,
                    Question = "Se envía a G…, contra su voluntad, a un país extranjero, por el cual no se siente atraído en principio, para una estancia de varias semanas. ¿Cuál será su actitud?",
                    OptionA = "Estimar que la duración de su estancia es demasiado corta para conseguir integrarse.",
                    OptionB = "Tratar de aprender la lengua para comprender mejor a este país y vivir más a gusto en él.",
                    OptionC = "No tener más que los contactos estrictamente necesarios para la buena marcha de su trabajo."
                },
                new Questions_IPV
                {
                    QuestionNumber = 5,
                    Question = "Según su opinión, las personas que dicen siempre “su” verdad a los demás, aunque ésta sea desagradable, lo hacen, en general, porque…",
                    OptionA = "No saben controlar sus impulsos y dicen espontáneamente lo que piensan.",
                    OptionB = "No les gusta la hipocresía.",
                    OptionC = "Piensan que esto simplifican las relaciones."
                },
                new Questions_IPV
                {
                    QuestionNumber = 6,
                    Question = "Un buen amigo de C… había comenzado bastante brillantemente su carrera profesional, pero los resultados no han sido los que cabría esperar y terminó teniendo numerosos fracasos. ¿Qué piensa C… acerca de esto?",
                    OptionA = "Que las condiciones no le han sido favorables.",
                    OptionB = "Que no estaba a la altura necesaria.",
                    OptionC = "Que no ha utilizado bien los medios para salir adelante."
                },
                new Questions_IPV
                {
                    QuestionNumber = 7,
                    Question = "B… encuentra, en casa de unos amigos, una persona que aparenta una edad muy inferior a la que realmente tiene. ¿Qué opinara B…?",
                    OptionA = "“Probablemente ha encontrado en la vida lo que le convenía”.",
                    OptionB = "“Tiene buena suerte; es cuestión de naturaleza”.",
                    OptionC = "“Seguramente ha tenido una vida fácil”."
                },
                new Questions_IPV
                {
                    QuestionNumber = 8,
                    Question = "Para expansionarse, S… decide aprender judo. Después de unos meses de entrenamiento se fa cuenta de que progresa muy lentamente. ¿Cuál será su reacción?",
                    OptionA = "Pensando que realmente no está hecho para el judo, elegirá otro deporte.",
                    OptionB = "Convencido de que no está dotado para las actividades corporales buscará otra forma de actividad.",
                    OptionC = "Continuará sus esfuerzos con la esperanza de que seguramente un día sean coronados por el éxito."
                },
                new Questions_IPV
                {
                    QuestionNumber = 9,
                    Question = "P… se acuesta una noche muy fatigado, pero no puede dormirse porque sus vecinos del piso superior han organizado una fiesta muy ruidos¿Qué hará?",
                    OptionA = "Subir y advertir a sus vecinos.",
                    OptionB = "Dar con la escoba algunos golpes en el techo.",
                    OptionC = "Tomar un somnífero y tratar de dormir cueste lo que cueste."
                },
                new Questions_IPV
                {
                    QuestionNumber = 10,
                    Question = "G… que carece de teléfono, llega a una oficina de telégrafos para envía un telegrama a la hora de cerrar. El encargado de dice que es demasiado tarde, que va a cerrar. ¿Qué hará G?",
                    OptionA = "Ir a casa de un amigo que tiene teléfono para poner el telegrama por teléfono.",
                    OptionB = "Convencer al encargado de que su telegrama es muy urgente y que debe salir  inmediatamente.",
                    OptionC = "Ir a una oficina de telégrafos que cierra más tarde."
                },
                new Questions_IPV
                {
                    QuestionNumber = 11,
                    Question = "X… hace un viaje de turismo por un país en que es costumbre discutir los precios. ¿Cuál será su actitud?",
                    OptionA = "Hará pocas compras porque le molesta tener que discutir siempre.",
                    OptionB = "Hará numerosas compras, incluso un poco inútiles, porque le encanta discutir los precios.",
                    OptionC = "Convencido de que le timarían, preferiría los almacenes de precios fijos."
                },
                new Questions_IPV
                {
                    QuestionNumber = 12,
                    Question = "Sin tener en cuenta la formación y competencia necesarias, ¿Cuál de las siguientes direcciones de servicios le gustaría asumir?",
                    OptionA = "Gestión.",
                    OptionB = "Personal.",
                    OptionC = "Publicidad."
                },
                new Questions_IPV
                {
                    QuestionNumber = 13,
                    Question = "Un escritor poco conocido acaba de recibir el premio Planet¿Qué cree usted que preferirá hacer?",
                    OptionA = "Escribir menos y aprovecharse de su éxito para salir, recibir a la gente y hacer una vida de sociedad.",
                    OptionB = "Intentar escribir una obra maestra.",
                    OptionC = "Dedicarse a la pintura e intentar triunfar también en ella."
                },
                new Questions_IPV
                {
                    QuestionNumber = 14,
                    Question = "Si usted se encontrara en una situación de examen en la que pudieran elegir entre dos temas, ¿Cuál escogería?",
                    OptionA = "Un tema ampliamente tratado durante el curso con el que tiene, casi la plena seguridad de alcanzar la nota media necesaria.",
                    OptionB = "Un tema que le permita, con un mínimo de conocimientos, pero con mucha lógica e imaginación, obtener una calificación muy buena pero, quizá, también muy mala.",
                    OptionC = ""
                },
                new Questions_IPV
                {
                    QuestionNumber = 15,
                    Question = "Entre las siguientes actividades de descanso físico en la naturaleza, ¿Cuál prefiere usted?",
                    OptionA = "Una vuelta por la bahía cuando el mar esta agitado.",
                    OptionB = "Un baño de sol en una playa de arena fina, en un hermoso día de verano con el aire en calma.",
                    OptionC = "Un paseo por el campo en primavera."
                },
                new Questions_IPV
                {
                    QuestionNumber = 16,
                    Question = "¿Qué es a su juicio, lo que atrae a más gente en los viajes o estancias en el extranjero?",
                    OptionA = "Los viajes nuevos.",
                    OptionB = "El descubrimiento de otra civilización artística.",
                    OptionC = "El contacto con una población de costumbres muy diferentes."
                },
                new Questions_IPV
                {
                    QuestionNumber = 17,
                    Question = "P… camina rápidamente por la calle y parece que tiene prisa. Un joven que realiza una encuesta le detiene para hacerle algunas preguntas extrañas, pero divertidas. ¿Qué hará P?",
                    OptionA = "Rehusar con firmeza contestar a las preguntas.",
                    OptionB = "Responder rápidamente, porque lo encuentra divertido.",
                    OptionC = "Excusarse de no tener tiempo para responder, sintiendo de verdad no poder hacerlo."
                },
                new Questions_IPV
                {
                    QuestionNumber = 18,
                    Question = "L… trabaja en una empresa en que recibe muy pocas informaciones a nivel oficial. ¿Qué opina usted de ello?",
                    OptionA = "Que será muy difícil obtener información.",
                    OptionB = "Que con “los rumores de pasillo”, eso no constituye el problema.",
                    OptionC = "Que, de hecho, es muy fácil estar informado; bastará con conocer a algunas personas bien situadas."
                },
                new Questions_IPV
                {
                    QuestionNumber = 19,
                    Question = "Son las once de la noche. Hay numerosos vehículos aparcados en la calle, algunos de ellos sobre las aceras; P… ve desde su ventana a uno que trata de abrir la puerta de un coche; parece que no tiene llave y utiliza un destornillador. ¿Qué pensara P…?",
                    OptionA = "“Probablemente es un ratero que trata de robar un coche. ¿y si yo llamase a la policía?”.",
                    OptionB = "“Alguien ha quedado atrapado en la acera y trata de mover un coche para salir”.",
                    OptionC = "“¿Qué estará haciendo? Parece que utiliza un destornillador”."
                },
                new Questions_IPV
                {
                    QuestionNumber = 20,
                    Question = "Cuando un niño ha cometido una gran tontería, ¿Cuál es, a su modo de ver, la mejor reacción?",
                    OptionA = "Castigarle, explicándole por qué se hace.",
                    OptionB = "Explicarle la significación de su tontería situándola en su contexto.",
                    OptionC = "Apelar al amor propio del niño."
                },
                new Questions_IPV
                {
                    QuestionNumber = 21,
                    Question = "B… tiene varios hijos y ha decidido intervenir en la educación sexual de casa uno de ellos. ¿Qué procedimiento le parece a usted que adoptará probablemente?",
                    OptionA = "Reflexionar sobre el asunto y preparar, con el hijo mayor, un tipo de intervención que luego mantendrá con los demás hijos.",
                    OptionB = "Seguir su intuición o sus sentimientos.",
                    OptionC = "Adoptar un modo de proceder distinto para cada hijo."
                },
                new Questions_IPV
                {
                    QuestionNumber = 22,
                    Question = "¿Cuál es para un niño la manera más “astuta” de presentar unas calificaciones escolares poco brillantes?",
                    OptionA = "Enseñarlas lo antes posible para liberarse de ello.",
                    OptionB = "Presentarlas el lunes a la hora del desayuno.",
                    OptionC = "Presentarlas en el momento en que pueda aportar, además, alguna compensación."
                },
                new Questions_IPV
                {
                    QuestionNumber = 23,
                    Question = "El hijo de G… ha entrado en el despacho de su padre a pesar de que este se lo tiene prohibido, y ha derramado un frasco de tinta sobre papeles importantes. G…, furioso, le da un buen tortazo. ¿Qué pensara G… algún tiempo después?",
                    OptionA = "Que un buen azote de vez en cuando no viene mal.",
                    OptionB = "Que tal vez se ha excedido un poco.",
                    OptionC = "Que es conveniente enfadarse de verdad una vez para no tener que volver a hacerlo."
                },
                new Questions_IPV
                {
                    QuestionNumber = 24,
                    Question = "Una persona con la que D… se relaciona muy frecuentemente acaba de jugarle una mala pasad¿Cuál será la reacción de D…?",
                    OptionA = "No muestra ninguna, pero se da cuenta de que le será muy difícil ocultar durante mucho tiempo su resentimiento.",
                    OptionB = "No dice nada porque piensa que el daño causado es tal vez menor de lo que había creído.",
                    OptionC = "Se esfuerza en ocultar su resentimiento para no entorpecer sus futuras relaciones."
                },
                new Questions_IPV
                {
                    QuestionNumber = 25,
                    Question = "N… asiste a una comida. Se da cuenta de que, a causa de una opinión que se le ha escapado, acaba de provocar una situación tensa en el grupo. ¿Qué le parece a usted que será él lo más desagradable?",
                    OptionA = "El sentimiento de que algo va a dificultar notablemente el contacto.",
                    OptionB = "El pensamiento de que se le va a juzgar a causa de esa observación.",
                    OptionC = "El disgusto de haber hablado sin pensar."
                },
                new Questions_IPV
                {
                    QuestionNumber = 26,
                    Question = "P… está jugando a las cartas con sus amigos; a pesar de sus esfuerzos, pierde varias veces seguidas. ¿Cuál es, según usted, su reacción más probable?",
                    OptionA = "“Después de todo, esta tarde he aprendido bastante. Seguramente ganaré la próxima vez”.",
                    OptionB = "“Siempre ocurre lo mismo; el juego de las cartas no se me da bien”.",
                    OptionC = "C.“Realmente no estoy en forma esta tarde”."
                },
                new Questions_IPV
                {
                    QuestionNumber = 27,
                    Question = "R…  está sentado en un cine al lado de personas que no se callan y hacen frecuentes comentarios. ¿Qué hará R…?",
                    OptionA = "Rogarles que se callen.",
                    OptionB = "Cambiarse de lugar.",
                    OptionC = "Concentrarse más en la película para evitar la molestia."
                },
                new Questions_IPV
                {
                    QuestionNumber = 28,
                    Question = "T… trabaja en una gran empresHa efectuado algunos  cambios en la organización del trabajo y es muy criticado por gran parte de sus colegas. ¿Cuál será la reacción de T…?",
                    OptionA = "Tratar de justificar su posición ante sus colegas.",
                    OptionB = "Pensar que, en cualquier caso, nunca se consigue unanimidad.",
                    OptionC = "Replantearse el problema."
                },
                new Questions_IPV
                {
                    QuestionNumber = 29,
                    Question = "¿Qué piensa usted  cuando ve un niño enfrentarse a los adultos?",
                    OptionA = "Está mal educado.",
                    OptionB = "Probablemente tiene serias dificultades en sus relaciones con los demás.",
                    OptionC = "Posee una fuerte responsabilidad."
                },
                new Questions_IPV
                {
                    QuestionNumber = 30,
                    Question = "M… debe contratar a un colaborador que se encargara de la dirección de un servicio. Teniendo en cuenta el hecho de que tendrá responsabilidades jerárquicas, ¿A cuál de las cualidades siguientes dará M… más importancia?",
                    OptionA = "Tener autoridad.",
                    OptionB = "Ser convincente.",
                    OptionC = "Ser justo."
                },
                new Questions_IPV
                {
                    QuestionNumber = 31,
                    Question = "Entre los siguientes estilos de conducir un automóvil en carretera, ¿Cuál es, a su parecer, el más frecuentemente adoptado por los automovilistas?",
                    OptionA = "Pensando en la mecánica y en la seguridad, apenas fuerzan la velocidad de su vehículo.",
                    OptionB = "Estimando que es tan peligroso circula demasiado despacio como demasiado deprisa, adelantan a los vehículos que les obligan a ir lentamente.",
                    OptionC = "Toleran de mala gana no tener vía libre y adelantan sistemáticamente a los vehículos que van delante de ellos."
                },
                new Questions_IPV
                {
                    QuestionNumber = 32,
                    Question = "¿Qué es lo que más valora cuando usted va a un restaurante?",
                    OptionA = "Una buena cocina.",
                    OptionB = "Un ambiente agradable.",
                    OptionC = "La posibilidad de comer el plato especial de la casa."
                },
                new Questions_IPV
                {
                    QuestionNumber = 33,
                    Question = "Una señora va de compras a un almacén que se encuentra bastante lejos de su casEn la puerta el almacén se da cuenta de que ha olvidado su monedero y su talonario de cheques. Sin tener en cuenta el tiempo de que dispone, ¿Qué piensa usted que hará?",
                    OptionA = "Volver a su casa a buscar lo que ha olvidado.",
                    OptionB = "Ver si conoce a alguien por la zona que pueda prestarle dinero o tratar de que le vendan a crédito.",
                    OptionC = "Dejar las compras para otra ocasión y aprovechar la oportunidad para dar un paseo por el barrio."
                },
                new Questions_IPV
                {
                    QuestionNumber = 34,
                    Question = "M… está soltero. Ha tenido un año de trabajo muy fuerte y debe tomar una decisión sobre sus vacaciones. ¿Qué elegirá?",
                    OptionA = "Pasar un mes en la costa para poder leer, caminar y descansar.",
                    OptionB = "Visitar una región del país que no conoce.",
                    OptionC = "Hacer una larga marcha de pie o en bicicleta porque piensa que el deporte es el mejor de los descansos."
                },
                new Questions_IPV
                {
                    QuestionNumber = 35,
                    Question = "¿Cuál es, a su modo de ver, la mejor manera de descansar durante el fin de semana para un hombre que trabaja todos los demás días?",
                    OptionA = "Reunirse con los amigos.",
                    OptionB = "Ir al cine.",
                    OptionC = "Leer."
                },
                new Questions_IPV
                {
                    QuestionNumber = 36,
                    Question = "Si usted dispusiera de un año de libertad y de los medios necesarios para hacer lo que quisiera, ¿Cuál elegiría entre las actividades siguientes?",
                    OptionA = "Dar la vuelta al mundo en solitario a bordo de un velero.",
                    OptionB = "Participar en una carrera automovilística Madrid-Bombay.",
                    OptionC = "Visitar el mayor número posible de países."
                },
                new Questions_IPV
                {
                    QuestionNumber = 37,
                    Question = "Un empleado administrativo, incorporado recientemente a la empresa, pide a X…, uno de sus compañeras, que le preste a una pequeña suma de dinero hasta el mes siguiente. ¿Qué hará X…?",
                    OptionA = " Le prestará el dinero son hacerle ninguna pregunta para no ponerle en un aprieto.",
                    OptionB = "Le prestará el dinero porque a él le gustaría que le hicieran lo mismo si lo necesitara.",
                    OptionC = "No le dará el dinero, considerando que su compañero tiene, probablemente, buenos amigos dispuestos a ayudarle."
                },
                new Questions_IPV
                {
                    QuestionNumber = 38,
                    Question = "B… se ha puesto, sin quererlo, fuera de la legalidad y debe escoger a un abogado para que le defienda. ¿Sobre cuál de los criterios siguientes basará su elección?",
                    OptionA = "Su reputación de elocuencia.",
                    OptionB = "Sus buenas relaciones con la magistratura.",
                    OptionC = "Su perspicacia psicológica."
                },
                new Questions_IPV
                {
                    QuestionNumber = 39,
                    Question = "E… ha sido nombrado recientemente para un puesto que implica responsabilidades jerárquicas importantes. ¿Qué actitud tomara probablemente frente a sus subordinados?",
                    OptionA = "Modificar se forma de mandar según las personas y las circunstancias.",
                    OptionB = "Fijarse un sistema de mando bien elaborado e idéntico para todos.",
                    OptionC = "Basándose en la experiencia, dejarse guiar por su intuición."
                },
                new Questions_IPV
                {
                    QuestionNumber = 40,
                    Question = "R… tiene que hablar sobre informática a empleados que no tienen ningún conocimiento en este campo. ¿Cuál de las siguientes alternativas le planteará menos problemas?",
                    OptionA = " Utilizar un vocabulario comprensible para todo el mundo.",
                    OptionB = "Interesar al auditorio y mantener su atención.",
                    OptionC = "Hacer participar a todos los asistentes."
                },
                new Questions_IPV
                {
                    QuestionNumber = 41,
                    Question = "41. L… asiste a un partido de fútbol entre dos equipos muy conocidos. El partido es muy disputado y los dos equipos rinden al máximo. Entre los espectadores el entusiasmo es tremendo y…",
                    OptionA = "L… se contenta con aplaudir las jugadas más brillantes.",
                    OptionB = "L… es dominado por la agitación general, grita y gesticula como los otros.",
                    OptionC = "L… discute con sus vecinos sobre las jugadas de los futbolistas."
                },
                new Questions_IPV
                {
                    QuestionNumber = 42,
                    Question = "42. B… atraviesa la calle por un paso de peatones con el semáforo en rojo. Un coche llega a gran velocidad y se detiene repentinamente a pocos centímetros de B… ¿Cuál va a ser la reacción inmediata de este?",
                    OptionA = "Hará una observación irónica al mismo tiempo que maldice interiormente al conductor.",
                    OptionB = "Dará airadamente su opinión al conductor sobre su manera de conducir.",
                    OptionC = "Lanzará al conductor algunos insultos que no puede reprimir."
                },
                new Questions_IPV
                {
                    QuestionNumber = 43,
                    Question = "43. A su modo de ver, ¿Cuál es, entre los siguientes aspectos, el más desatendido actualmente en la educación de su hijo?",
                    OptionA = "La aceptación de responsabilidades.",
                    OptionB = "El gusto por el trabajo bien hecho.",
                    OptionC = "La capacidad para desenvolverse solo rápidamente."
                },
                new Questions_IPV
                {
                    QuestionNumber = 44,
                    Question = "44. T… acaba de fracasar en un examen. Uno de sus amigos le dice que algunos fracasos son útiles en la vid¿Qué responderá él?",
                    OptionA = "“Se ve que no estás en mi lugar; yo preferiría no pasar por esto”.",
                    OptionB = "“Puede que tengas razón”.",
                    OptionC = "“Admite, por lo menos, que cuando ocurre es difícil de aceptar”."
                },
                new Questions_IPV
                {
                    QuestionNumber = 45,
                    Question = "45. L… se encuentra en una reunión amistosa. Sabe muy bien que la mayor parte de las personas presentes tienen opiniones muy diferentes a las suyas. ¿Qué piensa usted que hará?",
                    OptionA = "Evitar toda discusión.",
                    OptionB = "Provocar la discusión.",
                    OptionC = "Dar su opinión si no puede evitarlo."
                },
                new Questions_IPV
                {
                    QuestionNumber = 46,
                    Question = "46. ¿Qué cualidad le parece más útil en las relaciones sociales?",
                    OptionA = "La tolerancia.",
                    OptionB = "B.la sinceridad.",
                    OptionC = "La aceptación de compromisos."
                },
                new Questions_IPV
                {
                    QuestionNumber = 47,
                    Question = "47. M… acaba de modificar totalmente se apartamento. Invita a sus amigos a la inauguración. Ente los cumplidos que le hagan, ¿Cuál será para él el más agradable?",
                    OptionA = "Una felicitación sobre su buen gusto.",
                    OptionB = "Un elogio sobre la forma en que ha sacado partido de la disposición de las habitaciones.",
                    OptionC = "Una alabanza a su originalidad, porque su decoración no se parece a ninguna otra ya vista."
                },
                new Questions_IPV
                {
                    QuestionNumber = 48,
                    Question = "48. S… llega en el momento de una discusión entre dos personas a las que conoce poco. El tema del que hablan, muy específico, le es totalmente desconocido y apenas le interesa. ¿Cuál será su reacción?",
                    OptionA = "Interviene para informarse, aun a riesgo de parecer ignorante.",
                    OptionB = "Trata de interesarse porque no quiere parecer incorrecto.",
                    OptionC = "No interviene, porque no puede aportar un punto de vista interesante sobre el asunto."
                },
                new Questions_IPV
                {
                    QuestionNumber = 49,
                    Question = "49. R… llega con retraso a una reunión de copropietarios. ¿Qué es lo que probablemente le molestara más?",
                    OptionA = "La idea de que hayan podido aprovecharse de su ausencia para toma una decisión con la que él no esté de acuerdo.",
                    OptionB = "El temor de tener dificultad para integrarse en la discusión.",
                    OptionC = "La perspectiva de parecer descortés."
                },
                new Questions_IPV
                {
                    QuestionNumber = 50,
                    Question = "50. Se ha pedido a F… un informe lo más objetivo posible sobre su modo de ser. ¿Quién decidirá él que lo haga?",
                    OptionA = "Su mujer.",
                    OptionB = "Un grupo de amigos.",
                    OptionC = "Él mismo."
                },
                new Questions_IPV
                {
                    QuestionNumber = 51,
                    Question = "51. X… quiere construir una cas¿Cuál de las siguientes soluciones elegirá?",
                    OptionA = "Llamar a un arquitecto.",
                    OptionB = "Hacer los planos él mismo y trabajar directamente con un constructor.",
                    OptionC = "Hacer los planes con un amigo que acaba de hacer una casa."
                },
                new Questions_IPV
                {
                    QuestionNumber = 52,
                    Question = "52. T… es un hombre de negocios generalmente muy ocupado. Una cita anulada a última hora le permite tener una mañana libre totalmente imprevista. ¿Cómo cree usted que la utilizará?",
                    OptionA = "Aprovechará para levantarse pronto o pasar la mañana practicando su deporte favorito.",
                    OptionB = "Hará el balance de la semana que acaba de pasar.",
                    OptionC = "Constituirá para él una ocasión muy poco habitual de poder “perder su tiempo” y la aprovechará."
                },
                new Questions_IPV
                {
                    QuestionNumber = 53,
                    Question = "53. D… va a ir a un país del que no conoce nada, para preparar su viaje, ¿Qué cree usted que hará?",
                    OptionA = "Leer libros y guías sobre ese país.",
                    OptionB = "Preguntar a amigos o parientes que conocen bien el país.",
                    OptionC = "Esperar a estar en el país para ver e informarse."
                },
                new Questions_IPV
                {
                    QuestionNumber = 54,
                    Question = "54. Se oye decir frecuentemente decir que si una persona cae de repente sobre la acera a las seis de la tarde, un momento en que las calles están abarrotadas, ningún viandante se detiene para ofrecer su ayuda a la persona en dificultades. ¿A qué cree usted que se debe esta conducta?",
                    OptionA = "A una total indiferencia por lo que puede ocurrir a los demás.",
                    OptionB = "Al miedo ante una situación inesperada.",
                    OptionC = "Al temor de ocuparse de lo que no le compete a uno."
                },
                new Questions_IPV
                {
                    QuestionNumber = 55,
                    Question = "55. Una señora va a consultar a un medico sobre una infección que le parece bastante banal. El médico la interroga ampliamente antes de examinarla. Ella contesta, por supuesto, a las preguntas, pero, en el fondo, ¿Qué pensará?",
                    OptionA = "“En su lugar, yo comenzaría por hacer el examen y preguntaría después”.",
                    OptionB = "“Él debe intentar conocer en qué circunstancias he cogido esta enfermedad”.",
                    OptionC = "“Está bien que me haga preguntas, pero hay algunas en las que no veo relación ninguna con lo que yo tengo”."
                },
                new Questions_IPV
                {
                    QuestionNumber = 56,
                    Question = "56.  C… tiene que contratar empleados de oficina; dispone de poco tiempo. ¿Qué método empleará?",
                    OptionA = "Tener una entrevista con los candidatos.",
                    OptionB = "Examinar cada “curriculum vitae” y sus referencias.",
                    OptionC = "Hacerles una prueba práctica en el trabajo."
                },
                new Questions_IPV
                {
                    QuestionNumber = 57,
                    Question = "57. El mejor delegado de personal es aquel que…",
                    OptionA = "Es un buen negociador.",
                    OptionB = "Está convencido de la justicia de la reivindicación.",
                    OptionC = "Está bien integrado con el personal."
                },
                new Questions_IPV
                {
                    QuestionNumber = 58,
                    Question = "58. la señora D… trata inútilmente de hacer que coma su hijo de cinco años; este se resiste violentamente. ¿Qué hará ella?",
                    OptionA = "Forzarle a comer considerando que el niño lo hace por capricho.",
                    OptionB = "Hacerle un pequeño chantaje del tipo: “demuestra a mama que eres bueno y que la quieres”.",
                    OptionC = "Dejar al niño, pensando que comerá más en la comida siguiente."
                },
                new Questions_IPV
                {
                    QuestionNumber = 59,
                    Question = "59. Se habla frecuentemente del respeto a las “reglas de juego”. En general, se trata de…",
                    OptionA = "Una disposición profunda, estable y claramente definida.",
                    OptionB = "La aceptación a desempeñar en cada instante el papel que conviene.",
                    OptionC = "Una sumisión sincera a las costumbres de un grupo."
                },
                new Questions_IPV
                {
                    QuestionNumber = 60,
                    Question = "60. C… que es aficionado al bricolaje, decide tapizar el mismo sillón valioso. Cuando llega a la mitad de su trabajo se da cuenta de que corre el peligro de fracasar en su intento. ¿Cuál será su decisión?",
                    OptionA = "Confiar el sillón a un especialista que realizara un trabajo impecable.",
                    OptionB = "Deshacer lo que ya ha hecho y comenzar otra vez desde cero.",
                    OptionC = "Dejar durante unos días su trabajo para reemprenderlo cuando este en mejores condiciones."
                },
                new Questions_IPV
                {
                    QuestionNumber = 61,
                    Question = "61. C… va a ir con su mujer al campo durante los días de pascua. Previendo la afluencia, ha reservado billetes de ferrocarril. Salen de su casa a la hora justa, pero un embotellamiento en los alrededores de la estación les hace perder el tren. ¿Cómo cree usted que reaccionará?",
                    OptionA = "“Siempre pasa lo mismo. Si hubieras estado preparada antes no hubiera ocurrido esto”.",
                    OptionB = "“Se han fastidiado las vacaciones… no me apetece nada viajar de pie en el tren siguiente”.",
                    OptionC = "“Qué le vamos a hacer! Voy a devolver lo billetes y nos quedaremos en casa”."
                },
                new Questions_IPV
                {
                    QuestionNumber = 62,
                    Question = "62. A su juicio, la mayoría de los fracasos son debidos a…",
                    OptionA = "Incapacidad.",
                    OptionB = "Coincidencia de circunstancias negativas.",
                    OptionC = "Fallos ocasionales."
                },
                new Questions_IPV
                {
                    QuestionNumber = 63,
                    Question = "63. F… ha encargado una refrigeradorEn su ausencia, lo depositan en casa del conserje. El embalaje esta estropeado, por lo cual la refrigeradora ha sufrido algunos daños. F… decide hacer una gestión ante los servicios de distribución. ¿De qué forma se comportará?",
                    OptionA = "Escribirá a los citados servicios conservando una copia de la carta.",
                    OptionB = "Irá personalmente a reclamar.",
                    OptionC = "Rogará a uno de sus amigos, empleado en esa casa, que intervenga."
                },
                new Questions_IPV
                {
                    QuestionNumber = 64,
                    Question = "64. con ocasión de un viaje organizado, B… se encuentra con personas que no conoce. Al cabo de unos días se da cuenta que la mayoría de las personas le tienen poca simpatía. ¿Cómo cree usted que reaccionará?",
                    OptionA = "Le trae sin cuidado, porque para él lo importante es que el guía sea eficaz.",
                    OptionB = "Está un poco molesto y trata de hacer un esfuerzo para resultar más simpático.",
                    OptionC = "Esto le amarga, en parte, sus vacaciones y propone que, en la próxima ocasión, se irá con sus amigos."
                },
                new Questions_IPV
                {
                    QuestionNumber = 65,
                    Question = "65. R… hace un viaje con algunos amigos. Una tarde el grupo se separa después de haberse puesto de acuerdo en la hora para la salidA lo largo de esta tarde, R… descubre un monumento que le interesa mucho visitar, pero, si lo hace, le será imposible llegar a la cit¿Qué hará?",
                    OptionA = " Hace la visita porque piensa que no tendrá ya ocasión de volver a este lugar y que de todas maneras habrá otros que llegaran tarde también.",
                    OptionB = "Renuncia a esta visita porque le parece más importante no hacer esperar a los demás.",
                    OptionC = "Trata de encontrar a sus amigos para persuadirles de que hagan la visita con él, aun a riesgo de desorganizar la ultima parte del viaje."
                },
                new Questions_IPV
                {
                    QuestionNumber = 66,
                    Question = "66. ¿Cuál de estas profesionales le parece a usted la mas envidiable?",
                    OptionA = "Gerente de una pequeña empresa.",
                    OptionB = "Director adjunto de una empresa internacional.",
                    OptionC = "Asesor científico de alto nivel."
                },
                new Questions_IPV
                {
                    QuestionNumber = 67,
                    Question = "67. A causa de un accidente que ha causado la muerte de los padres de un niño pequeño, J… tiene que encargarse del niño con carácter definitivo. ¿Cuál será la actitud más probable que tendrá a este respecto?",
                    OptionA = "Teme verse obligado a revisar su sistema de educación.",
                    OptionB = "Confía en el buen carácter del niño.",
                    OptionC = "Busca otras alternativas para el niño."
                },
                new Questions_IPV
                {
                    QuestionNumber = 68,
                    Question = "68. Un amigo propone a T… llevarle en su velero a hacer un pequeño crucero. T… nunca ha practicado la vel¿Qué cree usted que decidirá?",
                    OptionA = "Aceptar, pensando que podrá desenvolverse bien.",
                    OptionB = "Arreglárselas para hacer antes algunas horas de vela en la escuela.",
                    OptionC = "No aceptar, ante el temor de ser una molestia para su amigo."
                },
                new Questions_IPV
                {
                    QuestionNumber = 69,
                    Question = "69. T… va hacia el trabajo por su camino habitual. Una furgoneta de reparto le bloquea durante un buen rato en una calle estrechA juicio de usted, ¿Qué será lo más agradable para T…?",
                    OptionA = "La perspectiva de llegar con retraso a su despacho.",
                    OptionB = "El hecho de tener que esperar sin poder moverse ni hacer nada.",
                    OptionC = "Los toques de claxon -inútiles- de otros automovilistas."
                },
                new Questions_IPV
                {
                    QuestionNumber = 70,
                    Question = "70. G… trabaja en una empresa para la que debe efectuar frecuentes desplazamientos. Acostumbra a hacer dos horas de atletismo todas las semanas en una sesión de entrenamiento colectivo. A juicio de usted, ¿Cuál es su actitud en el curso de esta sesión?",
                    OptionA = "Insiste en ciertas especialidades que le permitan mantenerse en buena forma.",
                    OptionB = "Realiza todas las actividades propuestas, pero sin esforzarse demasiado, porque tiene un trabajo cansado.",
                    OptionC = "Se entrega a fondo y frecuentemente termina agotado porque no concibe el deporte de otra manera."
                },
                new Questions_IPV
                {
                    QuestionNumber = 71,
                    Question = "71. Según su criterio, ¿Cuál es la ventaja de tener un perro en un apartamento de la ciudad?",
                    OptionA = "Permitirse sentirse menos solo.",
                    OptionB = "Favorece la ocasión de caminar un poco casa día paseando al perro.",
                    OptionC = "Vigila el apartamento."
                },
                new Questions_IPV
                {
                    QuestionNumber = 72,
                    Question = "72. En el transcurso de una reunión en que S… se ha encontrado con amigos, les propone termina la velada en su casAl enterarse, se une a ellos una persona que se mantenía alejada del grupo a la que él estima poco. ¿Cuál será la reacción de S…?",
                    OptionA = "Piensa que, después de todo, tendrá ocasión de conocer mejor a esta persona.",
                    OptionB = "Estimando que se ha invitado a sí misma, no se ocupara de ella en toda la noche.",
                    OptionC = "Lamenta haber hablado demasiado alto."
                },
                new Questions_IPV
                {
                    QuestionNumber = 73,
                    Question = "73. El director de un centro de delincuentes debe contratar a un nuevo educador. ¿A cuál de estas cualidades dará más importancia?",
                    OptionA = "Ser irreprochable y poder servir de modelo.",
                    OptionB = "Tener buenos conocimientos pedagógicos.",
                    OptionC = "Saber escuchar."
                },
                new Questions_IPV
                {
                    QuestionNumber = 74,
                    Question = "74. Según su opinión, ¿Qué es más importante en una persona que da una fiesta?",
                    OptionA = "Permitir a todos expresarse.",
                    OptionB = "Invitar a personas que puedan coincidir con sus intereses.",
                    OptionC = "Cuidar de que a nadie le falte nada."
                },
                new Questions_IPV
                {
                    QuestionNumber = 75,
                    Question = "75. R… ha de exponer un proyecto a un colega que no conoce. Para que R… pueda hacerse comprender por su interlocutor, es preferible que…",
                    OptionA = "Sepa cuál es su formación académica.",
                    OptionB = "Conozca sus antecedentes profesionales.",
                    OptionC = "Lea el informe sobre un trabajo hecho por su colega."
                },
                new Questions_IPV
                {
                    QuestionNumber = 76,
                    Question = "76. Si tuviera que hacer algún reproche a la profesión médica, ¿Cuál escogería?",
                    OptionA = "No consagra suficiente tiempo a cada enfermo.",
                    OptionB = "Da demasiada importancia al dinero.",
                    OptionC = "Utiliza a menudo un vocabulario incomprensible."
                },
                new Questions_IPV
                {
                    QuestionNumber = 77,
                    Question = "77. N… tiene que escoger un plan de formación para las personas de su departamento. Desearía una formación interesante para todos, pero, a la vez, eficaz y rentable. ¿Qué elegiría?",
                    OptionA = "Un plan organizado en función de las necesidades del departamento y en el que todas las fases estén definidas de antemano.",
                    OptionB = "Un plan que tenga en cuenta a cada participante.",
                    OptionC = "Un plan que incluya de manera regular exámenes de control."
                },
                new Questions_IPV
                {
                    QuestionNumber = 78,
                    Question = "78. M… acaba de tener un ataque de hígado. Sin embargo un amigo le llama para invitarle a comer, precisando que le ha preparado su plato favorito. Supuesto que este plato está contraindicado en este momento, ¿Cuál será la reacción de M…?",
                    OptionA = "Aceptar la invitación pensando que por una vez no hará caso de su régimen.",
                    OptionB = "Proponer que se aplace esta investigación para más adelante, cuando acabe su régimen.",
                    OptionC = ""
                },
                new Questions_IPV
                {
                    QuestionNumber = 79,
                    Question = "79. M… no está satisfecho con la Seguridad Social. Lo que más le desagrada es…",
                    OptionA = "Lo absurdo de algunas disposiciones de esta entidad.",
                    OptionB = "La gran dificultad de atenerse a la complejidad de su reglamentación.",
                    OptionC = "La falta de atención a aspectos que él cree fundamentales."
                },
                new Questions_IPV
                {
                    QuestionNumber = 80,
                    Question = "80. N… ha decidido consagrar una parte de su tiempo libre a ayudar a las personas de la tercera edad. Existen varias posibilidades. ¿Cuál elegirá en último lugar, cuando no hay otras alternativas?",
                    OptionA = "Acompañar a las personas ancianas durante el paseo.",
                    OptionB = "Visitar a una persona mayor cada semana.",
                    OptionC = "Hacer colectas para la construcción de un hogar de ancianos."
                },
                new Questions_IPV
                {
                    QuestionNumber = 81,
                    Question = "81. Entre los siguientes argumentos publicitarios, ¿Cuál tiene más probabilidades de influir en el publico?",
                    OptionA = "El muestrario.",
                    OptionB = "El eslogan.",
                    OptionC = "El testimonio de una “estrella”."
                },
                new Questions_IPV
                {
                    QuestionNumber = 82,
                    Question = "82. En el transcurso de un viaje en tren, D… se encuentra en un comportamiento abarrotado. Su vecino fuma y el humo le molesta mucho. Ya le ha rogado que dejara de fumar, sin resultado. ¿Qué hará?",
                    OptionA = "Pedir el parecer de otros viajeros del comportamiento.",
                    OptionB = "Abrir la ventana.",
                    OptionC = "Hablar de nuevo con su vecino con el objeto de convencerle de que deje de fumar."
                },
                new Questions_IPV
                {
                    QuestionNumber = 83,
                    Question = "83. El director del departamento de una empresa de productos alimenticios desea lanzar al mercado un nuevo postre. Dispone de un presupuesto que puede repartir en los tres conceptos que se citan a continuación. ¿En cuál de ellos empleara más dinero?",
                    OptionA = "En estudios de mercado para conocer los gustos de los futuros compradores.",
                    OptionB = "En publicidad para dar a conocer su producto.",
                    OptionC = "En la investigación en envases y presentación del producto."
                },
                new Questions_IPV
                {
                    QuestionNumber = 84,
                    Question = "84. B… toma parte de una discusión muy animada en el transcurso de la cual sus opiniones son muy atacadas. Entre las actitudes siguientes, ¿Cuál será la que adopte?",
                    OptionA = "Tratar por todos los medios de convencer a los demás.",
                    OptionB = "Divertirse simplemente en el juego de la discusión.",
                    OptionC = "Dejarse convencer cuando vea que sus disposiciones son poco defendibles."
                },
                new Questions_IPV
                {
                    QuestionNumber = 85,
                    Question = "85. Cuando usted va a un restaurante, ¿Qué tipo de plato prefiere?",
                    OptionA = "Uno que ya conoce y que le gusta de modo especial.",
                    OptionB = "La especialidad de la casa.",
                    OptionC = "Un plato exótico que usted desconoce en absoluto."
                },
                new Questions_IPV
                {
                    QuestionNumber = 86,
                    Question = "86. Después de un naufragio, C… llega solo a una isla desierta. El clima es muy agradable y lo vegetación le permitirá encontrar el alimento necesario. ¿Qué es, a su modo de ver, lo que probablemente le planteara menos problemas?",
                    OptionA = "El carácter nuevo e insólito de la situación.",
                    OptionB = "La soledad.",
                    OptionC = "La falta de algunos atractivos de la vida anterior."
                },
                new Questions_IPV
                {
                    QuestionNumber = 87,
                    Question = "87. J… dirige una importante firma automovilista. Puede escoger entre varias políticas comerciales. ¿Cuál elegirá?",
                    OptionA = "Orientar sus esfuerzos para sacar de vez en cuando modelos especiales.",
                    OptionB = "Buscar los efectos de moda y atender a una clientela particular.",
                    OptionC = "Ofrecer de ordinario modelos clásicos."
                }
            };
        }
    }
}
