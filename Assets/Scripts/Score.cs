using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int ScoreCount = 0;
    public Text TxtScore;

    void Start() {
        TxtScore.text = "Score: " + ScoreCount;
    }

    void Update() {
        InvokeRepeating("UpdateScore", 0.1f, 5.0f);
    }
    
    void UpdateScore() {
        ScoreCount++;
        TxtScore.text = "Score: " + ScoreCount;
    }
}
