using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipeScript : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This gameobject go to the value of moveSpeed to the left per second
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        // If the x position is lower to -10
        if (transform.position.x < -10)
        {
            Debug.Log("Pipe destroyed");
            // Destroy this gameobject
            Destroy(gameObject);
        }
    }
}
