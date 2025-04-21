# FastMapperReal
![Nuget](https://img.shields.io/nuget/v/fastmapper?label=FastMapperReal)

FastMapperReal follows a similar philosophy to the FastMember project by mgravell, leveraging efficient techniques for accessing fields and properties in .NET. It is particularly useful in scenarios where type members must be accessed dynamically and their names are only known at runtime.
This project enables fast and efficient runtime manipulation of type members, offering significantly better performance compared to standard .NET reflection.


You should install the NuGet package in Visual Studio or via the console: [https://www.nuget.org/packages/noef](https://www.nuget.org/packages/FastMapperReal)  ![Nuget](https://img.shields.io/nuget/v/fastmapper?label=FastMapperReal)

### Code example:
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

            Task SomeMethod(){ DestinationObject destinationObject = mapper.Map(sourceObject);}
        }
          
