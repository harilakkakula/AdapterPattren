using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattren
{
    interface IResourceFetch
    {
        List<Lables> Getlablesource(string Language);
    }
}
