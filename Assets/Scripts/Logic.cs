using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logic : MonoBehaviour
{
    public Text scoreText;
    public int playerScore = 0;
    public GameObject gameOverScreen;
    public AudioSource bibSFX;
    public AudioSource gameOverSFX;

    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        bibSFX.Play();
        Debug.Log("Score added");
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        gameOverSFX.Play();
    }
}
