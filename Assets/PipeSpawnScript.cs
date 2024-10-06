using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    private float timer = 0f;
    public float pipeRate = 2f;
    public int lowestPoint = -10;
    public int highestPoint = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        // When timer equals 2
        if (timer < pipeRate)
        {
            // Timer increase
            timer += Time.deltaTime;
        }
        // Else
        else
        {
            // Instatiate the pipe
            SpawnPipe();
            // And reset the timer
            timer = 0f;
        }
    }
    // Function to spawn the pipe gameobject
    void SpawnPipe()
    {
        //Instantiate the pipe in this game object x trasform position and in a random y position and in the rotation of the tranform
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint)), transform.rotation);
    }
}
