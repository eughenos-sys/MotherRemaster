using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RootBreakerBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI rootbreaker;
    private float charTime = 0.0f;
    public float interpolationPeriod = 3.0f;
    private int charactersFound=0;
    private int passwordSize=12;
    void Start()
    {
        Debug.Log("ciao");
        
    }

    // Update is called once per frame
    void Update()
    {
         if(charactersFound <passwordSize){
                 charTime+=Time.deltaTime;
        //         var txtLenght=rootbreaker.text.Length;
                if (charTime <  interpolationPeriod)
                {
                    
                    rootbreaker.text = rootbreaker.text.Substring(0,charactersFound);
                    rootbreaker.text += (char)Random.Range(33, 126);
                    
                }
               else{
                   
                       charTime=0.0f;
                   charactersFound++;
               }
         }
    }
}
