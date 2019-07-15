using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSProviderBackEnd.Api.AuthHelper;
using static SMSProviderBackEnd.Api.AuthHelper.JwtHelper;

namespace SMSProviderBackEnd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        /// <summary>
        /// 获取JWT的方法
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="sub">角色</param>
        /// <returns></returns>
        [HttpGet]
        [Route("Token")]
        public async Task<object> GetJwtStr(string name, string pass)
        {
            string jwtStr = string.Empty;
            bool suc = false;

            //var user = await _sysUserInfoServices.GetUserRoleNameStr(name, pass);
            var user = "Admin";
            if (user != null)
            {

                TokenModelJwt tokenModel = new TokenModelJwt { Uid = 1, Role = user };

                jwtStr = JwtHelper.IssueJwt(tokenModel);
                suc = true;
            }
            else
            {
                jwtStr = "login fail!!!";
            }

            return Ok(new
            {
                success = suc,
                token = jwtStr
            });
        }
    }
}