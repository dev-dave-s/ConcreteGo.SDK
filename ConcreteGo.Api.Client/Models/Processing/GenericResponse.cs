using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Processing
{
    public class GenericResponse<T>
    {
        public List<T> Response { get; set; } = null!;
    }
}
