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
        var usr= txtUser.text;
        var pwd=txtPassword.text;
        UserBehaviour u =new UserBehaviour() {user=usr, password=pwd};
        if(!PlayerPrefs.HasKey(usr)){
            PlayerPrefs.SetString(usr,JsonUtility.ToJson(u));
            SceneManager.LoadScene("DESKTOP",LoadSceneMode.Additive);
        }else{
            u=JsonUtility.FromJson<UserBehaviour>(PlayerPrefs.GetString(usr));
            if(u.password==pwd){
                SceneManager.LoadScene("DESKTOP",LoadSceneMode.Additive);
            }else{
                //error message
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
