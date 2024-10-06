using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapForce = 10f;
    public bool isBallDead = false;
    public GameObject gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isBallDead)
        {
            //If the space input is pressed
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //The ball goes up in the flapForce value per second
                rb.velocity = Vector2.up * flapForce;
            }
        }
    }

    // Function for detect the collision and if have the collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Set boolean of the ball died to true
        isBallDead = true;
        // Activate the game over screen
        gameOverScreen.SetActive(true);
    }
}
