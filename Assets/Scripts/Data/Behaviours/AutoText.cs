using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.Audio;

public class AutoText : MonoBehaviour
{

    int currentPosition = 0;
    public float Delay = 0.01f;
    private string currentString;
    public string Text = "Advanced Megabios Plug and Play BIOS Extension v2.02a<br>Copyright(C) 2022, Advanced Megabios Corp.<br>";

    public AudioSource src;

    public Canvas canvas;

    readonly string[] additionalLines = { "<br>",
        "    Rilevamento CPU      ... ",
        "Warbit Ecostar 1000 [ 1015 Mhz ]<br>",
        "    Rilevamento Flashram ... ",
        "47-Logic Ulisse 1 Gyga [ 1024 MByte ]<br>",
        "    Rilevamento Rete     ... ",
        "Mill Comm Etherlord 8M [ 8192 Kbps ]<br>",
        "Inizializzazione dispositivo di avvio ... ",
        "47-Logic Ulisse 1 Gyga<br>",
        "Avvio di Mother in corso ... <br>",
        "Inizializzazione del Kernel (sys.kernel)   ... ",
        "OK<br>",
        "Caricamento Sistema Base (sys.system)      ... ",
        "OK<br>",
        "Caricamento Applicativi (sys.applications) ... ",
        "OK<br>",
        "Avvio Interfaccia di Rete (sys.network)    ... ",
        "OK<br>",
        "Accesso a Mother in corso, attendere prego ... @"
    };

    // Use this for initialization
    IEnumerator Init()
    {
        while (true)
        {
            foreach (var s in additionalLines)
            {
                Text += s;
                if (currentPosition < Text.Length)
                    if (Text[currentPosition] == '<')
                    {
                        GetComponent<TextMeshProUGUI>().text += "<br>";
                        currentPosition += 4;
                    }
                    else if (Text[currentPosition] == '@')
                    {
                        canvas.GetComponent<CanvasGroup>().DOFade(0, 2f);
                        src.DOFade(0, 2f).OnComplete(() =>
                        {
                            SceneManager.LoadScene("LOGIN");
                        });
                    }

                    else
                    {
                        GetComponent<TextMeshProUGUI>().text += Text[currentPosition];
                        currentPosition++;
                    }

                yield return new WaitForSeconds(Delay);
            }
        }
    }

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(Init());
    }
}
