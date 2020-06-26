using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesktopUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void Toggle(GameObject g)
    {
        var go = GameObject.FindGameObjectWithTag(g.name);
        if (!go)
        {
            var x = Instantiate(g);
            x.transform.SetParent(GameObject.Find("GCANVAS").transform, false);
            x.GetComponent<RectTransform>().anchoredPosition = g.transform.position;
            x.transform.localScale = new Vector3(1, 1, 1);
            x.tag = g.name;
        }
        else {
            Destroy(go);
        }

    }
}
