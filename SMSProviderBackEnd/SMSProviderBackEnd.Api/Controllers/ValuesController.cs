using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMSProviderBackEnd.Models;

namespace SMSProviderBackEnd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        /// <summary>
        /// 取得基本資料
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        /// <summary>
        /// 取得基本資料
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<SMSSecurity> Get(SMSSecurity id)
        {
            return new SMSSecurity();
        }

        // POST api/values
        /// <summary>
        /// 取得基本資料
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        /// <summary>
        /// 取得基本資料
        /// </summary>
        /// <returns></returns>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        /// <summary>
        /// 取得基本資料
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
