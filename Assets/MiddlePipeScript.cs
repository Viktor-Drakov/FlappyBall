using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePipeScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        // Find a game object with tag logic and get component LogicScript
        logic = GameObject.FindWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Increase a value in the function AddScore 
        logic.AddScore(1);
    }
}
