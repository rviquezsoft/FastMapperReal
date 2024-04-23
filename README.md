# FastMapperReal
![Nuget](https://img.shields.io/nuget/v/fastmapper?label=FastMapperReal)

FastMapper is based on the FastMember project developed by mgravell. FastMember provides fast access to fields and properties of types in .NET, which is especially useful when access to type members is needed dynamically and member names are known only at runtime. This project enables efficient manipulation of type members at runtime, significantly improving performance compared to using standard reflection in .NET.


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
          
