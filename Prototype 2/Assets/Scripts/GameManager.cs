using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 3;
    private int highscore = 0;
    public Text scoreText;
    public Text highscoreText;
    

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "SCORE: " + score.ToString();
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddLives(int value)
    {
        lives += value;

        if (lives <= 0)
        {
            Debug.Log("Game Over:");
            lives = 0;
        }
        Debug.Log("Lives = " + lives);

    }
    public void AddScore(int value)
    {
        score += 1;
        scoreText.text = "SCORE: " + score.ToString();
        if (score > highscore)
            PlayerPrefs.SetInt("highscore", score);
        
    }


}
