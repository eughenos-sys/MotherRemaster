using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkMapManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform MapTransform;
    public GameObject Node;
    void Start()
    {
        foreach (var item in GameData.Servers)
        {
            var x = Instantiate(Node);
            x.transform.SetParent(MapTransform, false);
            x.GetComponent<RectTransform>().anchoredPosition = new Vector3(383, 311, 0);
            x.transform.localScale = new Vector3(1,1,1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
