using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattren
{
   internal class ResourceManager : IResourceManager
    {

        private readonly List<Lables> Getlables;
        private readonly IResourceFetch lablesinstance;
        private Dictionary<string, string> translatelabels = new Dictionary<string, string>();
        public ResourceManager(string language)
        {
            lablesinstance = LabelDatasource.GetInstance;
            Getlables = (List<Lables>)lablesinstance.Getlablesource(language);
            foreach(var item in Getlables)
            {
                translatelabels.TryAdd(item.lable, item.translated);
            }
          
        }
        public string AskLabel(string name)
        {
            string transalated = name;
            if (translatelabels.TryGetValue(name,out transalated))
                transalated = translatelabels[name];
            return transalated;
        }
    }
}
