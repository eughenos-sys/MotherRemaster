using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TMPro.TextMeshProUGUI txtUser;
    public TMPro.TextMeshProUGUI txtPassword;
    void Awake()
    {
        //qua dentro ti  inizializzi un server e poi lo converti in json e lo salvi in locale con PlayerPrefs.SetStirng("key","json")
    }

    public void executeLogin()
    {
        var usr = txtUser.text;
        var pwd = txtPassword.text;
        if (!PlayerPrefs.HasKey(usr))
        {
            User u = new User() { UserName = usr, Password = pwd, UserCredits = 100, UserRanking = 100 };
            PlayerPrefs.SetString(usr, JsonUtility.ToJson(u));
            SceneManager.LoadScene("DESKTOP");
        }
        else
        {
            User LoadUser = JsonUtility.FromJson<User>(PlayerPrefs.GetString(usr));
            if (LoadUser.Password == pwd)
            {
                GameData.player = LoadUser;
                SceneManager.LoadScene("DESKTOP");
            }
            else
            {
                //error message
            }
        }

    }
}
