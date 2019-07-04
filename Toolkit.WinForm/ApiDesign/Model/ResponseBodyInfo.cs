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
    [Table("tk_response")]
    [TableName("tk_response")]
    [PrimaryKey(nameof(SID), AutoIncrement = false)]
    public class ResponseBodyInfo
    {
        [Key]
        public string SID { get; set; }

        public string RelationSID { get; set; }

        public string FieldName { get; set; }

        public string FieldCode { get; set; }

        public string DataType { get; set; }

    }
}
