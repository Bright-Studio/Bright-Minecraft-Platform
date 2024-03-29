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
            "Hypixel", "Blocksmc", "�仨����", "Remiaft", "KKCraft", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] ServerIPList = new[]
        {
            "mc.hypixel.net", "blocksmc.com", "wdsj.net", "mc.remiaft.com", "mc.163mc.cn", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] ServerSynopsisList = new[]
        {
            //Hypixel
            "����������MinecraftС��Ϸ������", 
            //Blocksmc
            "��һ������MinecraftС��Ϸ��������Ϊ���ߵ�¼", 
            
            "���ڵ�С��Ϸ������", 
            
            "���ڵ�С��Ϸ������",

            "���ڵ�С��Ϸ������", 
            
            "Warm", 
            
            "Balmy", 
            
            "Hot", 
            
            "Sweltering", 
            
            "Scorching"
        };
        private static readonly string[] ServerVersionList = new[]
        {
            "ȫ�汾", "ȫ�汾", "ȫ�汾", "ȫ�汾", "ȫ�汾", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
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
