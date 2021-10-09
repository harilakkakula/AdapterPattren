using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattren
{
    internal interface ITranslater
    {
        string Transalate(string lable);

    }

    public  class Translate : ITranslater
    {

        IResourceManager manager;
         public Translate(string Language)
        {
            manager = new ResourceManager(Language);
        }
        
        public string Transalate(string lable)
        {
            return manager.AskLabel(lable);
        }
    }
}
