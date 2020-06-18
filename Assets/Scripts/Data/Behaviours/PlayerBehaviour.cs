using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerBehaviour : UserConfiguration {
    public int ActiveMissionId { get; set; }
    public List<int> CompletedMissions { get; set; }
    public List<Conversation> UnreadEmails { get; set; }
    public List<Conversation> CompletedConversations { get; set; }
    public HardwareBehaviour CPU { get; set; }
    public HardwareBehaviour FlashRAM { get; set; }
    public HardwareBehaviour NetworkInterface { get; set; }
    public List<ServerBehaviour> KnownServers { get; set; }
    public PlayerOptions Options { get; set; }
}
