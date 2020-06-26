using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using TMPro;
using UnityEngine;

public class MomPadBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_InputField text;
    void Start()
    {
        text.text=GameData.player.MomPadText;
    }

    public void Save()
    {
        GameData.player.MomPadText = text.text;
        PlayerPrefs.SetString(GameData.player.UserName,JsonConvert.SerializeObject(GameData.player));
        Destroy(this.gameObject);
    }
}
