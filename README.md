# FastMapperReal
![Nuget](https://img.shields.io/nuget/v/fastmapper?label=FastMapperReal)

Realiza cualquier consulta  en mysql o postgres o sql server u oracle en forma asíncrona y retorna los resultados en un objeto JSON o alternativamente en un List<dynamic>()


Se debe instalar el paquete nuget en visual studio o por consola: [https://www.nuget.org/packages/noef](https://www.nuget.org/packages/FastMapperReal)  ![Nuget](https://img.shields.io/nuget/v/fastmapper?label=FastMapperReal)

### Ejemplo de código:
        public class SourceObject
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }
        
        public class DestinationObject
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        
        public class Test
        {
            private readonly Mapper<SourceObject,DestinationObject> _mapper;
            public Test(Mapper<SourceObject,DestinationObject> mapper)
            {
                _mapper=mapper;
            }

            Task SomeMethod(){ var destinationObject = mapper.Map(sourceObject);}
        }
          
     
          
       
FastMapper está basado en el proyecto FastMember desarrollado por mgravell. FastMember proporciona un acceso rápido a los campos y propiedades de los tipos en .NET, lo que resulta especialmente útil cuando se necesita acceso a los miembros de un tipo de forma dinámica y los nombres de los miembros son conocidos solo en tiempo de ejecución. Este proyecto permite una manipulación eficiente de los miembros de los tipos en tiempo de ejecución, mejorando significativamente el rendimiento en comparación con el uso de la reflexión estándar en .NET.
