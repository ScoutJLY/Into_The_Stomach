using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreMenu : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    // Use this for initialization
    void Start ()
    {
        scoreText.text = "Score: " + PlayerPrefs.GetInt("Score");
        highscoreText.text = "Highscore: " + PlayerPrefs.GetInt("HighScore");
    }
}
