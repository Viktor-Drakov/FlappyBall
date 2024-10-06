using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    // Function to increament the score and update UI score
    public void AddScore(int value)
    {
        // Increament score with the actual value
        playerScore += value;
        // Update the UI score
        scoreText.text = playerScore.ToString();
    }

    // Function to restart the scene
    public void Restart()
    {
        // Restart the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        this.gameObject.SetActive(false);
    }
}
