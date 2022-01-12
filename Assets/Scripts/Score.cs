using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text MyScore;
    private int score;   
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        MyScore.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        score = score + 1;
        MyScore.text = "Score: " + score;
    }
}
