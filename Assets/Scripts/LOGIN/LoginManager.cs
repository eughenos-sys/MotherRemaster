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
    public Image img;
    public TMPro.TextMeshProUGUI txtUser;
    public TMPro.TextMeshProUGUI txtPassword;
    void Awake()
    {
        img.transform.position = new Vector3(0, 0, 0);
        img.DOFade(0, 3);
        //qua dentro ti  inizializzi un server e poi lo converti in json e lo salvi in locale con PlayerPrefs.SetStirng("key","json")

    }

    public void executeLogin()
    {
        var usr = txtUser.text;
        var pwd = txtPassword.text;
        User u = new User() { user = usr, password = pwd, credit = 100, rank = 100 };
        if (!PlayerPrefs.HasKey(usr))
        {
            PlayerPrefs.SetString(usr, JsonUtility.ToJson(u));
            SceneManager.LoadScene("DESKTOP");
        }
        else
        {
            u = JsonUtility.FromJson<User>(PlayerPrefs.GetString(usr));
            if (u.password == pwd)
            {
                GameData.player = u;
                SceneManager.LoadScene("DESKTOP");
            }
            else
            {
                //error message
            }
        }

    }
}
