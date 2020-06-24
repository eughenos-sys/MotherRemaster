using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Server
{
    public long MapX { get; set; }

    public long MapY { get; set; }

    public string ServerName { get; set; }

    public string Ip { get; set; }

    public string WelcomeText { get; set; }

    public long ServerType { get; set; }

    public long TerminalInterface { get; set; }

    public long Background { get; set; }

     public long ProtectionMode { get; set; }
        public bool Firewall { get; set; }
        public string FirewallMask { get; set; }

    public long Cpu { get; set; }

    public long Net { get; set; }

    public bool CantBeHacked { get; set; }

    public bool CantBeNuked { get; set; }

    public bool CantBeDestroyed { get; set; }

    public bool AllowRandomMission { get; set; }

    public long MissGenFaction { get; set; }

    public List<User> Users { get; set; }

    public List<FileConfiguration> Files { get; set; }
    public Server()
    {
        Users = new List<User>();
        Files = new List<FileConfiguration>();
    }
}
