using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Image img;
    void Awake()
    {
        img.transform.position = new Vector3(0, 0, 0);
        img.DOFade(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
