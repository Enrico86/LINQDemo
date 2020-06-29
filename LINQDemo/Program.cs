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

            //var nombresEstudiantes = estudiantes.Select(x => new { x.Nombre, x.Apellido });
            ////La colección IEnumerable ya no es de tipo string sino son instancias (objetos) de la clase NombreCompleto.
            ////Lo que le estamos diciendo aquí es, por cada elemento x del array estudiantes, crea una nueva instancia de la
            ////clase NombreCompleto, y asigna a su propiedad Nombre el valor que había en la propiedad Nombre del elemento que 
            ////estamos iterando en este momento, y asigna a la propiedad Apellido (de NombreCompleto) el valor de la propiedad
            ////Nombre (de Estudiante).
            //foreach (var elemento in nombresEstudiantes)
            ////Aquí vale lo mismo, nombreEstudiantes son objetos NombreCompleto, por lo que para recorrerlo tenemos que especificar
            ////que es este tipo de dato que estamos recorriendo
            //{   
            //    Console.WriteLine($"{elemento.Nombre} {elemento.Apellido}");
            //}

            //var universidadesItalianas = universidades.Where(x =>x.Pais=="Italia");
            ////El método Where recibe como parametro un predicado y va a devolver a la colección universidadesItalianas solo
            ////aquellos elemento de la colección universidades que coincidan con un determinado criterio (resultado true del predicado). 
            ////Por lo que podemos utilizar este método para filtrar los valores de mi colección de origen. En este ejemplo hemos 
            ////filtrado diciendo que copia en la nueva coleccion aquello elementos donde el campo País sea igual a Italia.
            ////Este metodo no transforma el elemento de origen, seguirán siendo objetos de tipo Universidad, pero será 
            ////una colección filtrada.
            //foreach (var universidad in universidadesItalianas)
            //    //Itero en la nueva colección universidadesItalianas (de objetos Universidad) para imprimir en pantalla
            //    //los valores de las propiedades NombreUniversidad y Ciudad
            //{
            //    Console.WriteLine($"La {universidad.NombreUniversidad} de {universidad.Ciudad} se encuentra en Italia");
            //}

            //var nombresUniItalianas1 = universidadesItalianas.Select(x => x.NombreUniversidad);
            ////Y utilizo la nueva colección universidadesItalianas para seleccionar solo un campo (de tipo string) de cada
            ////elemento de esta nueva colección. Por lo tanto esta nueva colección será una colección de cadenas, ya no de objetos

            //var nombresUniItalianas = universidades.Where(x => x.Pais == "Italia").Select(x => x.NombreUniversidad);
            ////Hubiera podido hacerlo todo en la misma línea: primero filtro los elementos (que siguen siendo del mismo tipo),
            ////y luego selecciono solo uno (o algunos) de los campos de los elementos filtrados para crear una nueva colección 
            ////(que será de diferente tipo según el/los campos que haya seleccionado)

            //IEnumerable<string> nombresEstudiantesOrdenados = estudiantes.OrderBy(x => x.Nombre).Select(x=>x.Nombre);
            ////Con el método OrderBy podemos regresar información en un orden en especifico de alguna de las propiedades del
            ////objeto (o si en una colección de números, en orden numérico, o si es de string en alfabético) que se definen 
            ////llaves. Espera recibir por parámetro un método, es decir, un delegado, con el que le pasemos el KeySelector,
            ////que es la llave que mencionamos anteriormente.
            ////Primero ordenamos según el campo nombre con el método OrderBy (y estamos ordenando en una nueva colección 
            ////la antigua colección, es decir los objetos con todos sus campos) y luego con el método Select seleccionamos 
            ////solo el campo de tipo string Nombre para que nuestra nueva colección nombresEstudiantesOrdenados sea una
            ////colección de cadenas string ordenadas alfabeticamente.
            //IEnumerable<string> nombresEstudiantesOrdenados2 = estudiantes.OrderByDescending(x => x.Nombre).Select(x => x.Nombre);
            ////Con el método OrderByDescending podemos ordenar pero de mayor a menor, o de la Z a la A según el caso. Tiene la 
            ////misma sintaxis que el método OrderBy, espera recibir un KeySelector
            //var apellidoNombreOrdenados = estudiantes.OrderBy(x => x.Apellido).ThenByDescending(x => x.Nombre)
            //    .Select(x => new { x.Apellido, x.Nombre });
            ////Con esta línea de código estamos haciendo multiples cosas: primero declaramos una variable (ya que serán objetos 
            ////anonimos con dos propiedades, el Apellido y el Nombre). Para generar la colección de estos objetos anónimos vamos 
            ////primero a ordenar la colección original de objetos estudiantes primero en orden ascendente (OrderBy) según su campo
            ////Apellido, luego vamos a hacer una segunda ordenación en orden discendente (método ThenByDescending) según su campo Nombre.
            ////Y ahora que tenemos la colección ordenada vamos a crear la colección de objetos anonimos creando nuevos objetos 
            ////(new) seleccionando las propiedades Apellido y Nombre de los objetos Estudiante que teníamos previamente ya ordenados
            ////A paridad de orden según el primer campo ordenado, entonces ordenará por (ThenBy) el segundo KeySelector especificado
            //foreach (var elemento in apellidoNombreOrdenados)
            //    //Ya vimos que ahora ya no son strings ni objetos de tipo estudiante, sino objetos anonimos, por lo que en el
            //    //ciclo foreach, igual que en la declaración del tipo de la nueva colección, utilizaremos la palabra var. 
            //{
            //    Console.WriteLine($"{elemento.Apellido} {elemento.Nombre}");
            //}

            //var universidadesPais = universidades.OrderBy(x => x.Pais).ThenBy(x=>x.NombreUniversidad).GroupBy(x => x.Pais);
            ////Creamos una colección de grupos (es lo que devuelve el método GroupBy). Cada grupo está formado por la llave con la
            ////que hemos llevado a cabo la agrupación (en este ejemplo el campo Pais, que es un string) y el elemento (en el 
            ////ejemplo objetos Universidad). Antes de hacer la agrupación hemos utilizado conceptos ya vistos: primero hemos 
            ////ordenado la colección universidades según el Pais y luego según el NombreUniverasidad, y finalmente hemos realizado
            ////la agrupación.

            //foreach (var grupo in universidadesPais)
            ////Hemos visto que universidadesPais es una colección de IGrouping (de grupos), por lo tanto lo llamaremos
            ////grupo y no elemento para que quede más claro, aunque se hubiera podido utilizar la palabra elemento sin 
            ////ningún problema).
            //{
            //    Console.WriteLine($"En el País {grupo.Key} hay {grupo.Count()} universidades:");
            //    //La propiedad Key representa la llave con la que se ha llevado a cabo la agrupación, y utilizamos el método 
            //    //Count para contar cuantos elementos pertenecen a cada grupo (agrupación). Los grupos están compuestos por
            //    //objetos Universidad, por lo tanto
            //    foreach (Universidad universidad in grupo)
            //        //Con este segundo foreach iteramos cada elemento (objeto de tipo Universidad) que forma cada grupo para
            //        //poder así acceder a sus propiedades (del objeto Universidad)
            //    {
            //        Console.WriteLine($"\t{universidad.NombreUniversidad}");
            //        //El \t sirve para tabular una vez antes de imprimir en pantalla el nombre de la universidad
            //    }
            //};

            //int numeroPaises = universidades.Select(x => x.Pais).Distinct().Count();
            //Console.WriteLine(numeroPaises);

            //int numeroPaisesOK = universidades.GroupBy(x => x.Pais).Count();
            //Console.WriteLine(numeroPaisesOK);

            //var join = estudiantes.Select(e => new { e.Nombre, e.Apellido, e.Universidad })
            //    //hasta aquí nada nuevo, creamos una coleccion de objetos anonimos seleccionando unos campos de una colección 
            //    //existente (estudiantes). Dejamos los mismos nombres de los campos que ya tenía la colección estudiantes.
            //    .Join(universidades,e=>e.Universidad, u=>u.NombreUniversidad, (e,u)=>new {e.Nombre, e.Apellido, u.Pais} );
            ////Como primer parametro del método Join tenemos que pasarle la colección de la cual queremos ir a coger los datos
            ////para unirlos a los campos del nuevo objeto anonimo que hemos creado anteriormente. Esta es la razón por la que en el 
            ////objeto anónimo que hemos creado tiene que estar presente el campo (e.Universidad) que utilizaremos para unir 
            ////los campos de la segunda colección (universidades).
            ////El segundo parametro del método Join es el outerKeySelector, que es el campo que tienen en comun ambas colecciones, 
            ////que utilizaremos para unirlas. Tenemos que utilizar el nombre del campo de la colección de objetos anonimos
            ////creada anteriormente. En este ejemplo le hemos dejado el mismo nombre del campo que tenía la colección original 
            ////(estudiantes) de la que hemos empezado la selección, pero si le hubieramos dado un nuevo nombre entonces tendríamos 
            ////que utilizar ese nombre.
            ////Y el tercer parametro es el innerKeySelector, que sería una función para extraer la llave join de cada elemento
            ////de la segunda colección (universidades); en nuestro ejemplo la llave de salida sería NombreUniversidades de la 
            ////colección universidades. Por último tenemos que pasarle un cuarto parámetro, con el que indicamos primero los 
            ////parametros de la expresión lamba (que son cada elemento "e" y "u" de las dos colecciones) y que queremos que de cada
            ////elemento coja algun (o todos si queremos) campo y los junte creando un nuevo objeto anónimo.
            ////Una vez hecho todo esto ya tenemos una nueva colección llamada join de objetos anónimos con los campos que hayamos
            ////definido como cuarto parametro del método Join.

            //foreach (var elemento in join)
            //{
            //    Console.WriteLine($"El estudiante {elemento.Nombre} {elemento.Apellido} estudia en {elemento.Pais}");
            //}

            //var nombreEstudiantes = from nombres in estudiantes select new { nombres.Nombre, nombres.Apellido};
            ////Utilizamos la palabra reservada from para definir un alias para lo que necesitamos coger de la colección 
            ////estudiantes. Con la palabra reservada in definimos en que colección vamos a hacer la consulta. Y con el 
            ////operador de consulta select indicamos, utilizando el alias, cual es el campo que queremos asignar a la colección 
            ////Enumerable nombreEstudiantes. Si seleccionamos solo el campo Nombre que es un tipo de dato string, entonces 
            ////nombreEstudiantes será una colección de strings. Pero también podemos (como en el ejemplo) crear un nuevo
            ////objeto anónimo con algunos de los campos del alias nombres, como por ejemplo el nombre y el apellido. En este
            ////caso la colección nombreEstudiantes ya no será una colección de strings sino de objetos anonimos con los campos
            ////Nombre y Apellido

            //foreach (var estudiante in nombreEstudiantes)
            //{
            //    Console.WriteLine($"{estudiante.Nombre} {estudiante.Apellido}");
            //}

            //var UniversidadesEspaña = from u in universidades where u.Pais == "España" select u.NombreUniversidad;
            ////también hay el operador de consulta where, que utilizaremos para filtrar valores. Definimos un alias (u) de la
            ////colección universidades, filtramos con el operador de consulta where de la misma forma que habíamos hecho 
            ////anteriormente con el método Where (indicamos una expresión booleana que tiene que ser verdadera) y finalmente seleccionamos
            ////el alias u para extraer toda la información de cada elemento u en la nueva colección UniversidadesEspaña. Ésta
            ////será una colección de elementos u, que son del mismo tipo de los elementos de la colección universidades (es decir,
            ////objetos Universidad).
            ////También hubieramos podido seleccionar solo algunos campos del alias u creando un nuevo objeto anonimo, tal como
            ////hicimos en el ejemplo anterior.
            //foreach (var universidad in UniversidadesEspaña)
            //{
            //    Console.WriteLine(universidad);
            //}
            //var UniversidadesEU = from u in universidades where string.Equals(u.Pais, "Estados Unidos") select u.NombreUniversidad;

            //var nombresUniDiscend = from u in universidades orderby u.NombreUniversidad descending select u;

            //var nombresUniversidades = from u in universidades orderby u.NombreUniversidad orderby u.Pais select u; 
            //foreach (var u in nombresUniversidades)
            //{
            //    Console.WriteLine($"{u.Pais}\t{u.NombreUniversidad}");
            //}

            //var uniPais = from u in universidades orderby u.NombreUniversidad orderby u.Pais group u by u.Pais;
            //foreach (var grupo in uniPais)
            //{
            //    Console.WriteLine($"En {grupo.Key} tenemos {grupo.Count()}");
            //    foreach (var uni in grupo)
            //    {
            //        Console.WriteLine($"\tLa {uni.NombreUniversidad} de {uni.Ciudad}");
            //    }
            //}

            //int NumeroUni1 = UniversidadesEspaña.Count();
            //int numeroUni = (from u in universidades select u.NombreUniversidad).Distinct().Count();

            //var join2 = from e in estudiantes
            //    //La primera de las dos colecciones de las que quiero unir los datos con su alias correspondiente
            //            join u in universidades
            //    //La segunda de las dos colecciones de las que quiero unir los datos con su alias correspondiente
            //            on e.Universidad equals u.NombreUniversidad
            //    //Con la clausula on especificamos el campo de la primera colección en el que buscará una coincidencia
            //    //y con la clausula equals va a hacer la comparación con un campo de la segunda colección
            //            select new { e.Nombre, e.Apellido, u.Pais };
            //    //Y finalmente seleccionamos campos de la primera y segunda colección para crear la nueva colección 
            //    //de objetos anonimos join2

            //foreach (var elemento in join2)
            //{
            //    Console.WriteLine(elemento);
            //}

            //var parte = estudiantes.Skip(1).Take(2);
            ////con el método Take indicamos el número de filas de una colección que queremos coger para generar 
            ////una nueva colección de objetos Estudiante (logicamente el mismo tipo de la colección de origen).

            //foreach ( var elemento in parte)
            //{
            //    Console.WriteLine(elemento.Nombre);
            //    //Tenemos acceso a todas las propiedades de la clase Estudiante, ya que en la colección parte
            //    //tenemos de hecho una parte de los objetos que formaban la colección original estudiantes.
            //}
            //Console.WriteLine();

            //foreach (var elemento in estudiantes)
            //{
            //    Console.WriteLine(elemento.Nombre);
            //}

            Console.WriteLine();
            var parteFinal = (from e in estudiantes orderby e.EstudianteID descending select e).Skip(1).Take(2).OrderBy(x=>x.EstudianteID);
            foreach ( var elemento in parteFinal)
            {
                Console.WriteLine(elemento.Nombre);

            }

            var parteFinal2 = estudiantes.Skip(estudiantes.Count()-3).SkipLast(1);
            foreach (var elemento in parteFinal)
            {
                Console.WriteLine(elemento.Nombre);
            }


            var respuesta = estudiantes.Any(x => x.Nombre.StartsWith("H"));
            Console.WriteLine(respuesta);

            var respuesta2 = estudiantes.All(x => x.Apellido!="");


            var primero = estudiantes.FirstOrDefault(x => x.Universidad == "Politecnico di Milano");
            if (primero!=null)
            { 
            Console.WriteLine($"{primero.Nombre} {primero.Apellido}");
            }
            var ultimo = estudiantes.Last();



            Console.ReadLine();

        }
    }
}
