using UnityEngine;

[CreateAssetMenu(fileName = "UserConfiguration", menuName = "Mother/User", order = 1)]
public class UserConfiguration : ScriptableObject
{
    public int Id;
    public string Username;
    public string Password;
    public int Ranking;
    public int Credits;
}