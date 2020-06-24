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
                user = "alfonso", password="123", rank = 2500, credit = 1000
            };
        }
        var user = GameData.player;

        AccountValue.text = user.mail;
        RankValue.text = user.rank.ToString();
        ClassValue.text = user.className;
        CreditsValue.text = user.credit.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetStatString()
    {

    }
}