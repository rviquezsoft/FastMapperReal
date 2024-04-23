using FastMember;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastMapperReal
{
    public class Mapper<Source, Destination> where Source : class, new() where Destination : class, new()
    {
        public Destination Map(Source source)
        {
            var destination = new Destination();

            var sourceAccessor = TypeAccessor.Create(typeof(Source));
            var sourceMembers = sourceAccessor.GetMembers();

            var destinationAccessor = TypeAccessor.Create(typeof(Destination));
            var destinationMembers = destinationAccessor.GetMembers();

            foreach (var sourceMember in sourceMembers)
            {
                //Verificar si la propiedad existe en Destination
                if (destinationAccessor != null && destinationMembers.Count > 0 &&
                    destinationMembers.Any(destMember => destMember.Name == sourceMember.Name))
                {
                    var value = sourceAccessor[source, sourceMember.Name];
                    if (value is null)
                    {
                        continue;
                    }
                    destinationAccessor[destination, sourceMember.Name] = value;
                }
            }

            return destination;
        }
    }
}
