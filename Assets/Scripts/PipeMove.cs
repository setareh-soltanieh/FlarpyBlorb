using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -23;
    public float speedIncreaseRate = 0.1f;
    public float maxSpeed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Increase speed over time but cap it at maxSpeed
        moveSpeed = Mathf.Min(moveSpeed + (speedIncreaseRate * Time.deltaTime), maxSpeed);

        transform.position = transform.position + (Vector3.left * (moveSpeed)) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        } 
    }
}
