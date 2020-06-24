using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class POST : MonoBehaviour
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
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("LOGIN");
    }
}
