using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePointSystem : MonoBehaviour
{
    Text text;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        score = 0;
        text.text = score.ToString();
    }

    public void AddScoreEmail()
    {
        score += 100; //will make it more complicated based on "Time Left" & "Difficulty Level" which is based on time/stamina/health. 
        text.text = score.ToString();
    }

    public void AddScorePopUp()
    {
        //for pop up
    }
}