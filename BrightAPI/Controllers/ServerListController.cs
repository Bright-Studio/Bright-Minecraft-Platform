using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.NetworkInformation;
using System.Text;

namespace BrightAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServerListController : ControllerBase
    {
        private static readonly string[] ServerNameList = new[]
        {
            "Hypixel", "Blocksmc", "落花星雨", "Remiaft", "KKCraft", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] ServerIPList = new[]
        {
            "mc.hypixel.net", "blocksmc.com", "wdsj.net", "mc.remiaft.com", "mc.163mc.cn", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] ServerSynopsisList = new[]
        {
            //Hypixel
            "世界上最大的Minecraft小游戏服务器", 
            //Blocksmc
            "数一数二的Minecraft小游戏服务器且为离线登录", 
            
            "国内的小游戏服务器", 
            
            "国内的小游戏服务器",

            "国内的小游戏服务器", 
            
            "Warm", 
            
            "Balmy", 
            
            "Hot", 
            
            "Sweltering", 
            
            "Scorching"
        };
        private static readonly string[] ServerVersionList = new[]
        {
            "全版本", "全版本", "全版本", "全版本", "全版本", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly bool[] GenuineList = new[]
        {
            //hypixel
            true, 
            //blocksmc
            false,

            true, false, false, false, false, true, false, false
        
        };

        private static readonly bool[] DomesticList = new[]
{
            //hypixel
            false, 
            //blocksmc
            false,

            true, false, false, false, false, true, false, false

        };

        private readonly ILogger<ServerListController> _logger;

        public ServerListController(ILogger<ServerListController> logger)
        {
            _logger = logger;
        }


        [HttpGet(Name = "GetServerList")]
        public IEnumerable<ServerList> Get()
        {
            return Enumerable.Range(0, 10).Select(index => new ServerList
            {
                ServerName = ServerNameList[index],
                ServerIP = ServerIPList[index],
                ServerSynopsis = ServerSynopsisList[index],
                ServerVersion = ServerVersionList[index],
                Genuine = GenuineList[index],
                Domestic = DomesticList[index]
            })
            .ToArray();
        }
    }
}
