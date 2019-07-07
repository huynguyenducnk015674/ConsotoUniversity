using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsotoUniversityAppCore.Web.Configuration
{
    public abstract class DomainEntity<T>
    {
        public T Crt_User { get; set; }
        public T ChgeUser { get; set; }
    }
}
