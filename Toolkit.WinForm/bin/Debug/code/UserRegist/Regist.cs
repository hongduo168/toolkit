/*
**本类代码由代码生成器自动生成，可以根据需要修改
**生成时间：2019/7/3 16:06:06
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminFrameWork.Constant;
using AdminFrameWork.Mvc;
using Microsoft.AspNetCore.Mvc;
using AdminFrameWork.RepositoryPattern;
using Microsoft.AspNetCore.Http;
using Plugin.App.ViewModel.User;

namespace Plugin.App.Controllers.v1
{

    public partial class UserController : Controller
    {


		[HttpPost("regist")]
        public RegistResponseModel Regist(RegistRequestModel request)
        {
            try
            {
                return new RegistResponseModel() { Status = AjaxStatus.Normal };
            }
            catch (Exception)
            {
                return new RegistResponseModel() { Status = AjaxStatus.Error, Message = "服务器繁忙，请稍后重试！" };
            }
        }
    }
}