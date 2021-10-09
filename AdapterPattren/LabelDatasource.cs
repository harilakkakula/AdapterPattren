using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattren
{
   public sealed class LabelDatasource: IResourceFetch
    {
        readonly List<Lables> lblsource = new List<Lables>();
        public static Lazy<LabelDatasource> labelDatasourceinstance = new(() => new LabelDatasource());
        private LabelDatasource()
        {

        }

        public static LabelDatasource GetInstance
        {
            get { return labelDatasourceinstance.Value; }
        }

        public List<Lables> Getlablesource(string Language)
        {
            lblsource.Add(new Lables() { isactive = true, Id = 1, lable = "Name", language = "telugu", translated = "పెరూ" });
            lblsource.Add(new Lables() { isactive = true, Id = 2, lable = "Mobile", language = "telugu", translated = "మొబైల్" });
            lblsource.Add(new Lables() { isactive = true, Id = 3, lable = "Name", language = "english", translated = "Name" });
            lblsource.Add(new Lables() { isactive = true, Id = 4, lable = "Mobile", language = "english", translated = "Name" });
            return lblsource.Where(x=>x.language==(Language)).ToList();

        }
    }

    public class Lables
    {
        public int Id { get; set; }
        public string lable { get; set; }
        public string translated { get; set; }
        public string language { get; set; }
        public bool isactive { get; set; }

    }
}
