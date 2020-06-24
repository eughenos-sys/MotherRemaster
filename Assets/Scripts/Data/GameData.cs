using System.Collections;
using System.Collections.Generic;
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

        if (PlayerPrefs.HasKey("servers") && PlayerPrefs.HasKey("users") && PlayerPrefs.HasKey("softwares") && PlayerPrefs.HasKey("hardwares")){
            Servers = JsonUtility.FromJson<List<Server>>(PlayerPrefs.GetString("servers"));
            Users = JsonUtility.FromJson<List<User>>(PlayerPrefs.GetString("users"));
            Software = JsonUtility.FromJson<List<Software>>(PlayerPrefs.GetString("Software"));
            Hardware = JsonUtility.FromJson<List<Hardware>>(PlayerPrefs.GetString("Hardware"));
        }
    }
}