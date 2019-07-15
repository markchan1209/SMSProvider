using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SMSProviderBackEnd.Common.Helper
{
    /// <summary>
    /// Appsettings.json 操作類
    /// </summary>
    public class Appsettings
    {
        static IConfiguration Configuration { get; set; }

        //static Appsettings()
        //{
        //    //ReloadOnChange = true 当appsettings.json被修改时重新加载
        //    Configuration = new ConfigurationBuilder()
        //    .Add(new JsonConfigurationSource { Path = "appsettings.json", ReloadOnChange = true })//请注意要把当前appsetting.json 文件->右键->属性->复制到输出目录->始终复制
        //    .Build();
        //}


        static Appsettings()
        {
            string Path = "appsettings.json";
            {
                //如果你把配置文件 是 根据环境变量来分开了，可以这样写
                //Path = $"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json";
            }
            var basePath = Microsoft.DotNet.PlatformAbstractions.ApplicationEnvironment.ApplicationBasePath;
            Configuration = new ConfigurationBuilder()
               .SetBasePath(basePath)
               .Add(new JsonConfigurationSource { Path = Path, Optional = false, ReloadOnChange = true })
               .Build();


        }

        /// <summary>
        /// 封装要操作的字符
        /// </summary>
        /// <param name="sections"></param>
        /// <returns></returns>
        public static string app(params string[] sections)
        {
            try
            {
                var val = string.Empty;
                for (int i = 0; i < sections.Length; i++)
                {
                    val += sections[i] + ":";
                }

                return Configuration[val.TrimEnd(':')];
            }
            catch (Exception)
            {
                return "";
            }

        }
    }
}
