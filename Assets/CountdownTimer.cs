using System.Collections;
using TMPro;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public int timeLeft = 60;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        timerText.text = timeLeft.ToString();
        StartCoroutine("LoseTime");
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (timeLeft < 0)
        {
            PlayerPrefs.SetInt("Score", player.GetComponent<Shooting>().score);
            if (player.GetComponent<Shooting>().score > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", player.GetComponent<Shooting>().score);
            }

            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");

        }
        else
            timerText.text = timeLeft.ToString();
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
