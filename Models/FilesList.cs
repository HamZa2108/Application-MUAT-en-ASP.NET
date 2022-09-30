using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MUAT.Models
{
    public class FilesList
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileDate { get; set; }
        public string FileDetails { get; set; }
        public FilesList()
        {

        }
    }
}