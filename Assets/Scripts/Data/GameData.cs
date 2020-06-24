using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class GameData : MonoBehaviour
{
    private static GameData _instance;
    public static List<Server> Servers = new List<Server>();
    public static List<User> Users = new List<User>();
    public static List<Software> Software = new List<Software>();
    public static List<Hardware> Hardware = new List<Hardware>();

    public static User player;
    void Awake()
    {
        if (!PlayerPrefs.HasKey("pake")){
        PlayerPrefs.SetInt("pake",1);
           PlayerPrefs.SetString("servers","[{\"MapX\":363,\"MapY\":327,\"ServerName\":\"test1.valdenet\",\"IP\":\"192.168.1.100\",\"WelcomeText\":\"File Server Test1 di ValdeNET <br> Questo File Server \u00e8 di propriet di ValdeNET Corporation.\",\"ServerType\":0,\"TerminalInterface\":0,\"Background\":-1,\"Protection\":{\"ProtectionMode\":0,\"Firewall\":false,\"FirewallMask\":\"*.*.*.*\"},\"CPU\":2500,\"NET\":500,\"CantBeHacked\":false,\"CantBeNuked\":false,\"CantBeDestroyed\":false,\"AllowRandomMission\":false,\"MissGenFaction\":0,\"Users\":[{\"UserName\":\"Admin\",\"Password\":\"sexex\",\"UserClass\":-1,\"UserRanking\":50,\"UserCredits\":0}],\"Files\":[{\"FileName\":\"sys.kernel\",\"FileDim\":5,\"FileImg\":-1,\"FileContents\":\"%BIN%\",\"FileOwner\":\"Admin\"},{\"FileName\":\"sys.system\",\"FileDim\":20,\"FileImg\":-1,\"FileContents\":\"%BIN%\",\"FileOwner\":\"Admin\"},{\"FileName\":\"sys.network\",\"FileDim\":10,\"FileImg\":-1,\"FileContents\":\"%BIN%\",\"FileOwner\":\"Admin\"},{\"FileName\":\"dat.customers\",\"FileDim\":42,\"FileImg\":-1,\"FileContents\":\"%BIN%\",\"FileOwner\":\"Admin\"},{\"FileName\":\"dat.payments\",\"FileDim\":38,\"FileImg\":-1,\"FileContents\":\"%BIN%\",\"FileOwner\":\"Admin\"},{\"FileName\":\"log.connections\",\"FileDim\":2,\"FileImg\":-1,\"FileContents\":\"%BIN%\",\"FileOwner\":\"Admin\"}]},{\"MapX\":363,\"MapY\":327,\"ServerName\":\"test2.valdenet\",\"IP\":\"192.168.1.102\",\"WelcomeText\":\"File Server Test2 di ValdeNET <br> Questo File Server \u00e8 di propriet di ValdeNET Corporation.\",\"ServerType\":0,\"TerminalInterface\":0,\"Background\":-1,\"Protection\":{\"ProtectionMode\":0,\"Firewall\":false,\"FirewallMask\":\"*.*.*.*\"},\"CPU\":2000,\"NET\":600,\"CantBeHacked\":false,\"CantBeNuked\":true,\"CantBeDestroyed\":true,\"AllowRandomMission\":false,\"MissGenFaction\":0,\"Users\":[{\"UserName\":\"PwrAdmin\",\"Password\":\"Q2fBW9*Bpz!m\",\"UserClass\":-1,\"UserRanking\":50,\"UserCredits\":0}],\"Files\":[{\"FileName\":\"sys.kernel\",\"FileDim\":5,\"FileImg\":-1,\"FileContents\":\"%BIN%\",\"FileOwner\":\"PwrAdmin\"},{\"FileName\":\"sys.system\",\"FileDim\":20,\"FileImg\":-1,\"FileContents\":\"%BIN%\",\"FileOwner\":\"PwrAdmin\"},{\"FileName\":\"sys.network\",\"FileDim\":10,\"FileImg\":-1,\"FileContents\":\"%BIN%\",\"FileOwner\":\"PwrAdmin\"},{\"FileName\":\"dat.customers\",\"FileDim\":42,\"FileImg\":-1,\"FileContents\":\"%BIN%\",\"FileOwner\":\"PwrAdmin\"},{\"FileName\":\"dat.payments\",\"FileDim\":38,\"FileImg\":-1,\"FileContents\":\"%BIN%\",\"FileOwner\":\"PwrAdmin\"},{\"FileName\":\"log.connections\",\"FileDim\":2,\"FileImg\":-1,\"FileContents\":\"%BIN%\",\"FileOwner\":\"PwrAdmin\"}]}]"); 
        }
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
            //Rest of your Awake code
        }
        else
        {
            Destroy(this);
        }

        if (PlayerPrefs.HasKey("servers") //&& PlayerPrefs.HasKey("users") && PlayerPrefs.HasKey("softwares") && PlayerPrefs.HasKey("hardwares")
        ){
            var svar = PlayerPrefs.GetString("servers");
            Servers = JsonConvert.DeserializeObject<List<Server>>(svar);
            Debug.Log(svar);
            // Users = JsonUtility.FromJson<List<User>>(PlayerPrefs.GetString("users"));
            // Software = JsonUtility.FromJson<List<Software>>(PlayerPrefs.GetString("Software"));
            // Hardware = JsonUtility.FromJson<List<Hardware>>(PlayerPrefs.GetString("Hardware"));
        }
    }
}