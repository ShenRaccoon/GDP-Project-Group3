using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindEmail : MonoBehaviour
{
    public GameObject textBoxOnCanvas;

    void Awake()
    {
        textBoxOnCanvas = GameObject.Find("Textbox1");

        EmailShuffle util = new EmailShuffle();

        textBoxOnCanvas.GetComponent<Text>().text = util.Shuffle();
            
    }

}

