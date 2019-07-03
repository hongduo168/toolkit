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
    [Table("tk_interface")]

    [TableName("tk_interface")]
    [PrimaryKey(nameof(SID), AutoIncrement = false)]
    public class ApiInterfaceInfo
    {
        [Key]
        public string SID { get; set; }

        public string ProjectSID { get; set; }


        public string ApiName { get; set; }

        /// <summary>
        /// 生成的控制器名称Controller Name
        /// </summary>
        public string ApiCode { get; set; }

        /// <summary>
        /// 生成的方法名
        /// </summary>
        public string ActionName { get; set; }

        /// <summary>
        /// 生成的URL后缀
        /// </summary>
        public string ActionRoute { get; set; }


        public DateTime LastDateTime { get; set; }


        [Ignore]
        public List<RequestBodyInfo> RequestBodys { get; set; }

        [Ignore]
        public ProjectInfo Project { get; set; }

        [Ignore]
        public List<ResponseBodyInfo> ResponseBodys { get; set; }


        public bool IsResultPaging { get; set; }

        public bool IsResultBool { get; set; }

        public bool IsResultInt { get; set; }

        public bool IsList { get; set; }

    }
}
