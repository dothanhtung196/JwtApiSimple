using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtApiSimple.Entities
{
    public class DataResponse<T>
    {
        public DataResponse(int status, string description, T result)
        {
            Status = status;
            Description = description;
            Result = result;
        }
        public int Status { get; set; }
        public string Description { get; set; }
        public T Result { get; set; }
    }
}
