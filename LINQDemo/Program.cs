using System;
using System.Collections.Generic;
using System.Linq;
//Para ver todos los métodos de extensión que nos provee la librería LINQ tenemos que importar este namespace

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante[] estudiantes = new Estudiante[]
            {
                new Estudiante
                {
                    EstudianteID=1,
                    Nombre="Enrico",
                    Apellido="Nocher",
                    Universidad="Politecnico di Torino"
                },
                new Estudiante
                {
                    EstudianteID=2,
                    Nombre="Anais",
                    Apellido="Santiago",
                    Universidad="UIC"
                },
                new Estudiante
                {
                    EstudianteID=3,
                    Nombre="Sergio",
                    Apellido="Montagna",
                    Universidad="Universidad di Torino",
                },
                new Estudiante
                {
                    EstudianteID=2,
                    Nombre="Alessandro",
                    Apellido="Nocher",
                    Universidad="Universidad di Fisioterapia di Verona"
                },
                new Estudiante
                {
                    EstudianteID=5,
                    Nombre="Laie",
                    Apellido="Font",
                    Universidad="Universidad de Barcelona",
                },
                new Estudiante
                {
                    EstudianteID = 6,
                    Nombre = "Rodrigo",
                    Apellido= "Jiménez",
                    Universidad = "Brooklyn"
                },
                new Estudiante
                {
                    EstudianteID = 7,
                    Nombre = "Miguel",
                    Apellido= "Hernández",
                    Universidad = "UNAM"
                },
                new Estudiante
                {
                    EstudianteID = 8,
                    Nombre = "Marilyn",
                    Apellido= "Monroe",
                    Universidad = "UNAM"
                },
                new Estudiante
                {
                    EstudianteID = 9,
                    Nombre = "Leonardo",
                    Apellido = "Estrada",
                    Universidad = "Brooklyn"
                },
                new Estudiante
                {
                    EstudianteID = 10,
                    Nombre = "Ricardo",
                    Apellido = "Rojas",
                    Universidad = "Real de Brasil"
                }
            };
            Universidad[] universidades = new Universidad[]
            {
                new Universidad
                {
                    NombreUniversidad = "Real de Brasil",
                    Ciudad = "Brasilia",
                    Pais = "Brasil"
                },
                new Universidad
                {
                    NombreUniversidad = "Politecnico di Torino",
                    Ciudad = "Torino",
                    Pais = "Italia"
                },
                new Universidad
                {
                    NombreUniversidad = "Universidad di Torino",
                    Ciudad = "Torino",
                    Pais = "Italia"
                },
                new Universidad
                {
                    NombreUniversidad = "Brooklyn",
                    Ciudad = "Nueva York",
                    Pais = "Estados Unidos"
                },
                new Universidad
                {
                    NombreUniversidad = "UNAM",
                    Ciudad = "Ciudad de México",
                    Pais = "México"
                },
                new Universidad
                {
                    NombreUniversidad = "Universidad di Fisioterapia di Verona",
                    Ciudad = "Verona",
                    Pais = "Italia"
                },
                new Universidad
                {
                    NombreUniversidad = "UIC",
                    Ciudad = "Barcelona",
                    Pais = "España"
                },
                new Universidad
                {
                    NombreUniversidad = "Universidad de Barcelona",
                    Ciudad = "Barcelona",
                    Pais = "España"
                },
            };

            var nombresEstudiantes = estudiantes.Select(x => new { x.Nombre, x.Apellido });
            //La colección IEnumerable ya no es de tipo string sino son instancias (objetos) de la clase NombreCompleto.
            //Lo que le estamos diciendo aquí es, por cada elemento x del array estudiantes, crea una nueva instancia de la
            //clase NombreCompleto, y asigna a su propiedad Nombre el valor que había en la propiedad Nombre del elemento que 
            //estamos iterando en este momento, y asigna a la propiedad Apellido (de NombreCompleto) el valor de la propiedad
            //Nombre (de Estudiante).
            foreach (var elemento in nombresEstudiantes)
            //Aquí vale lo mismo, nombreEstudiantes son objetos NombreCompleto, por lo que para recorrerlo tenemos que especificar
            //que es este tipo de dato que estamos recorriendo
            {   
                Console.WriteLine($"{elemento.Nombre} {elemento.Apellido}");
            }

            var universidadesItalianas = universidades.Where(x =>x.Pais=="Italia");
            //El método Where recibe como parametro un predicado y va a devolver a la colección universidadesItalianas solo
            //aquellos elemento de la colección universidades que coincidan con un determinado criterio (resultado true del predicado). 
            //Por lo que podemos utilizar este método para filtrar los valores de mi colección de origen. En este ejemplo hemos 
            //filtrado diciendo que copia en la nueva coleccion aquello elementos donde el campo País sea igual a Italia.
            //Este metodo no transforma el elemento de origen, seguirán siendo objetos de tipo Universidad, pero será 
            //una colección filtrada.
            foreach (var universidad in universidadesItalianas)
                //Itero en la nueva colección universidadesItalianas (de objetos Universidad) para imprimir en pantalla
                //los valores de las propiedades NombreUniversidad y Ciudad
            {
                Console.WriteLine($"La {universidad.NombreUniversidad} de {universidad.Ciudad} se encuentra en Italia");
            }

            var nombresUniItalianas1 = universidadesItalianas.Select(x => x.NombreUniversidad);
            //Y utilizo la nueva colección universidadesItalianas para seleccionar solo un campo (de tipo string) de cada
            //elemento de esta nueva colección. Por lo tanto esta nueva colección será una colección de cadenas, ya no de objetos

            var nombresUniItalianas = universidades.Where(x => x.Pais == "Italia").Select(x => x.NombreUniversidad);
            //Hubiera podido hacerlo todo en la misma línea: primero filtro los elementos (que siguen siendo del mismo tipo),
            //y luego selecciono solo uno (o algunos) de los campos de los elementos filtrados para crear una nueva colección 
            //(que será de diferente tipo según el/los campos que haya seleccionado)



        Console.ReadLine();

        }
    }
}
