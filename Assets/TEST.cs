using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TEST : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DoStuff");   
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator DoStuff()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("LOGIN");
    }
}
