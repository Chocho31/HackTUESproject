using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    public Vector2 leftBound;
    public Vector2 rightBound;
    public Vector2 speed;
    int dir = 1;

    void Awake()
    {
        //spawning at one place
        // fix not to get the boundaries as childs
        
        leftBound = GameObject.Find("moveBoundLeft").transform.position;
        rightBound = GameObject.Find("moveBoundRight").transform.position;
        transform.position = rightBound;

    }
    public void Move()
    {
        if(transform.position.x <= leftBound.x)
        {
            dir = 1;
        }
        else if(transform.position.x >= rightBound.x)
        {
            dir = -1;

        }
        transform.Translate(speed * dir * Time.deltaTime);
    }

    void Update()
    {
        Move();
    }
}
