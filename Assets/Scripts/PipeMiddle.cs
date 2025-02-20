using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    public Logic logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("LogicTag").GetComponent<Logic>();
        if (logic != null)
        {
            // GameObject was found and Logic component is assigned
            Debug.Log("Logic object found!");
        }
        else
        {
            // GameObject was not found
            Debug.Log("Logic object not found.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            Debug.Log("Collision");
            logic.addScore(1);
        } 
    }
}
