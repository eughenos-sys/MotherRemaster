using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class User
{

    public int Id;
    public string UserName;
    public string Password;
    public int UserRanking = 100;
    public int UserCredits = 100;
    public string className
    {
        get
        {
            if (this.UserRanking < 100)
            {
                return "Fool Lamer";
            }
            if (this.UserRanking < 200)
            {
                return "Lamer";
            }
            if (this.UserRanking < 500)
            {
                return "Scripter";
            }
            if (this.UserRanking < 1000)
            {
                return "Coder";
            }
            if (this.UserRanking < 1500)
            {
                return "Code Hacker";
            }
            if (this.UserRanking < 2000)
            {
                return "Cracker";
            }
            if (this.UserRanking < 2500)
            {
                return "Master Cracker";
            }
            if (this.UserRanking < 3000)
            {
                return "Hacker";
            }
            if (this.UserRanking < 3500)
            {
                return "Master Hacker";
            }
            return string.Empty;
        }
    }
    public string mail { get { return UserName + "@mother"; } }
    public int ActiveMissionId { get; set; }
    public List<int> CompletedMissions { get; set; }
    // public List<Conversation> UnreadEmails { get; set; }
    // public List<Conversation> CompletedConversations { get; set; }
    // public HardwareBehaviour CPU { get; set; }
    // public HardwareBehaviour FlashRAM { get; set; }
    // public HardwareBehaviour NetworkInterface { get; set; }
    //public List<ServerBehaviour> KnownServers { get; set; }
    public PlayerOptions Options { get; set; }

}
