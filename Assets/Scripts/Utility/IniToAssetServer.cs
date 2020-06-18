using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using UnityEditor;
using UnityEngine;


public class IniToAssetServer : MonoBehaviour
{
    public void Start()
    {
        //Load all Server INIs
        var list = Resources.LoadAll<TextAsset>("Servers/");
        foreach (TextAsset file in list)
        {
            var path = string.Concat(Directory.GetCurrentDirectory(), AssetDatabase.GetAssetPath(file));
            path = path.Replace("/", "\\");
            //Still don't understand why it skips a slash.
            path = path.Replace("MotherAssets", "Mother\\Assets");
            var dict = File.ReadAllLines(path)
                .Where(line => !string.IsNullOrEmpty(line) && !ConsistsOfWhiteSpace(line) && !line.StartsWith("//") && !line.StartsWith("/*") && !line.StartsWith("*") && !line.StartsWith("*/") && !line.Contains("//"))
                .Select(line => line.Split(new char[] { '=' }, 2, 0))
                .ToDictionary(parts => parts[0], parts => parts[1]);
            ServerConfiguration s = new ServerConfiguration();
            string temp;
            //Do....... this
            dict.TryGetValue("MapX", out temp);
            if (temp != null) s.MapX = Int32.Parse(temp);
            dict.TryGetValue("MapY", out temp);
            if (temp != null) s.MapY = Int32.Parse(temp);
            dict.TryGetValue("ServerName", out s.ServerName);
            dict.TryGetValue("IP", out s.IPAddress);
            dict.TryGetValue("WelcomeText", out s.WelcomeText);
            dict.TryGetValue("ServerType", out s.ServerType);
            dict.TryGetValue("TerminalInterface", out s.TerminalInterface);
            dict.TryGetValue("ProtectionLevel", out s.Protection);
            dict.TryGetValue("Firewall", out temp);
            if (temp != null) s.HasFireWall = bool.Parse(temp);
            dict.TryGetValue("Cpu", out temp);
            if (temp != null) s.CPU = float.Parse(temp);
            dict.TryGetValue("Net", out temp);
            if (temp != null) s.NetworkInterface = float.Parse(temp);
            dict.TryGetValue("CantBeHacked", out temp);
            if (temp != null) s.CantBeHacked = bool.Parse(temp);
            dict.TryGetValue("CantBeDestroyed", out temp);
            if (temp != null) s.CantBeDestroyed = bool.Parse(temp);
            dict.TryGetValue("CantBeNuked", out temp);
            if (temp != null) s.CantBeNuked = bool.Parse(temp);
            dict.TryGetValue("AllowRandomMission", out temp);
            if (temp != null) s.AllowRandomMission = bool.Parse(temp);
            string x;
            dict.TryGetValue("Users", out x);
            if (x != null && Int32.Parse(x) > 0)
            {
                for (int i = 1; i <= Int32.Parse(x); i++)
                {
                    string ranking, credits;
                    UserConfiguration u = new UserConfiguration();
                    dict.TryGetValue("Username[" + i.ToString() + "]", out u.Username);
                    dict.TryGetValue("Password[" + i.ToString() + "]", out u.Password);
                    dict.TryGetValue("UserRanking[" + i.ToString() + "]", out ranking);
                    dict.TryGetValue("UserCredits[" + i.ToString() + "]", out credits);

                    if (ranking != null) u.Ranking = Int32.Parse(ranking);
                    if (credits != null) u.Credits = Int32.Parse(credits);
                    //TODO: USERCLASS
                    string uPath = "Assets/Data/Users/" + dict["Username[" + i.ToString() + "]"] + ".asset";
                    uPath = uPath.Replace("\"", "");
                    //Need to create the asset file before adding it to another SO
                    AssetDatabase.CreateAsset(u, uPath);
                    s.Users.Add(u);
                }
            }

            string assetpath = "Assets/Data/Servers/" + dict["ServerName"] + ".asset";
            assetpath = assetpath.Replace("\"", "");
            AssetDatabase.CreateAsset(s, assetpath);
        }
    }

    public bool ConsistsOfWhiteSpace(string s)
    {
        foreach (char c in s)
        {
            if (c != ' ') return false;
        }
        return true;

    }
}