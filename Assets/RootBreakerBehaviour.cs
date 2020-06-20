using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RootBreakerBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI rootbreaker;
    private float time = 0.0f;
 public float interpolationPeriod = 1f;
    void Start()
    {
        Debug.Log("ciao");
    }

    // Update is called once per frame
    void Update()
    {
        if(rootbreaker.text.Length<12){
        for(int i=0;i<12;i++)
        {
            time=0.0f;
            while(time<interpolationPeriod){
                time+=Time.deltaTime;
                rootbreaker.text=rootbreaker.text.Substring(0,i);
                rootbreaker.text+=(char)Random.Range(33,126);
            }
}
        }
    }
}
