using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ServerType { Commerce, News, Mail, Chat }

[CreateAssetMenu(fileName = "ServerConfiguration", menuName = "Mother/Server", order = 1)]
    public class ServerConfiguration : ScriptableObject
    {
        public int MapX;
        public int MapY;
        public string ServerName;
        public string IPAddress;
        public string WelcomeText;
        public string ServerType;
        public string TerminalInterface;
        public float CPU;
        public float NetworkInterface;
        public string Protection;
        public int ProtectionLevel;
        public bool HasFireWall;
        public string FirewallMask;
        public bool CantBeNuked;
        public bool CantBeHacked;
        public bool CantBeDestroyed;
        public bool AllowRandomMission;
        public string MissGenFaction;
        public List<UserConfiguration> Users;
        public List<FileBehaviour> Contents;

        public ServerConfiguration()
        {
           Users = new List<UserConfiguration>();
            Contents = new List<FileBehaviour>();

    }
}
