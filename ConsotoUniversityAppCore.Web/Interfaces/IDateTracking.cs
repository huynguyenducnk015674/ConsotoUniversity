using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsotoUniversityAppCore.Web.Interfaces
{
    public interface IDateTracking
    {
        DateTime Crt_Date { get; set; }
        DateTime ChgeDate { get; set; }
    }
}
