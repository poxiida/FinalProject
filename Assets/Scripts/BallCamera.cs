using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject ball;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = ball.transform.position;
    }
}
