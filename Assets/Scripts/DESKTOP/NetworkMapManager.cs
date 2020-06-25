using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkMapManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform MapTransform;
    public GameObject Node;
    private List<Node> Nodes = new List<Node>();

    public LineRenderer Line;
    void Start()
    {
        List<Vector3> positions = new List<Vector3>();
        Line.gameObject.transform.SetParent(MapTransform, false);
        //localhost
        positions.Add(new Vector3(890, 577));
        foreach (var item in GameData.Servers)
        {
            var x = Instantiate(Node);
            x.transform.SetParent(MapTransform, false);
            x.GetComponent<RectTransform>().anchoredPosition = new Vector3(383, 311, 0);
            x.transform.localScale = new Vector3(1, 1, 1);
            x.GetComponent<Node>().Discovered = true;
            Nodes.Add(x.GetComponent<Node>());
            positions.Add(new Vector3(item.MapX, item.MapY, 0));
        }

        Line.SetPositions(positions.ToArray());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
