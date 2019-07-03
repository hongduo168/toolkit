/*
**本类代码由代码生成器自动生成，请勿手动修改，如需修改，请添加同名partial class
**生成时间：2019/7/3 15:29:24
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminFrameWork.Mvc;

namespace Plugin.App.ViewModel.User
{
    public partial class LoginRequestModel : AjaxRequest
    {
			/// <summary>
			/// 密码
			/// </summary>
			/// <value></value>
			public string Password { get; set; }
			
			/// <summary>
			/// 用户名
			/// </summary>
			/// <value></value>
			public string Username { get; set; }
			
			/// <summary>
			/// 存储登录
			/// </summary>
			/// <value></value>
			public bool Remember { get; set; }
			
    }
}