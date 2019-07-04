using PetaPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolkit.WinForm.ApiDesign.Model
{
    [Table("tk_project")]
    [TableName("tk_project")]
    [PrimaryKey(nameof(SID), AutoIncrement = false)]
    public class ProjectInfo
    {
        [Key]
        public string SID { get; set; }

        public string ProjectName { get; set; }

        public string Namespace { get; set; }

        public string Version { get; set; }

        [Ignore]
        public List<ApiInterfaceInfo> ApiInterfaces { get; set; }


    }
}
