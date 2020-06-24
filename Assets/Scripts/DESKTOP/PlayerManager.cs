using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public TextMeshProUGUI AccountValue;
    public TextMeshProUGUI RankValue;
    public TextMeshProUGUI CreditsValue;
    public TextMeshProUGUI ClassValue;

    // Start is called before the first frame update
    void Start()
    {
        if (GameData.player == null)
        {
            GameData.player = new User(){
                UserName = "alfonso", Password="123", UserRanking = 2500, UserCredits = 1000
            };
        }
        var user = GameData.player;

        AccountValue.text = user.mail;
        RankValue.text = user.UserRanking.ToString();
        ClassValue.text = user.className;
        CreditsValue.text = user.UserCredits.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetStatString()
    {

    }
}