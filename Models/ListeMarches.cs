using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MUAT.Models
{
    public class ListeMarches
    {
        public int Id { get; set; }
        public String TitreMarche { get; set; }
        public String LienMarche { get; set; }
        public String ListeDocs { get; set; }
        public String Status { get; set; }

        public ListeMarches()
        {

        }
    }
}