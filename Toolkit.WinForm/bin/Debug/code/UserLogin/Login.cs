/*
**本类代码由代码生成器自动生成，可以根据需要修改
**生成时间：2019/7/3 16:06:05
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


		[HttpPost("login")]
        public LoginResponseModel Login(LoginRequestModel request)
        {
            try
            {
                return new LoginResponseModel() { Status = AjaxStatus.Normal };
            }
            catch (Exception)
            {
                return new LoginResponseModel() { Status = AjaxStatus.Error, Message = "服务器繁忙，请稍后重试！" };
            }
        }
    }
}