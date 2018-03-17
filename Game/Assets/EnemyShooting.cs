using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {

    public Transform posToShootFrom;
    public GameObject projectile;
    public bool detected;
    public Vector2 velocity=new Vector2 (0,0);
    public Vector2 leftBound;
    public Vector2 rightBound;
    public Vector2 speed;
    int dir=1;

    private void Awake()
    {
        posToShootFrom = transform.Find("posToShootFrom");
        if (posToShootFrom == null)
        {
            Debug.Log("no such object");
        }


        leftBound= GameObject.Find("moveBoundLeft").transform.position;
        rightBound= GameObject.Find("moveBoundRight").transform.position;
        transform.position = rightBound;
                  
                   

    }
    private void Start()
    {
        
    }
    private void FixedUpdate()
    {
        //whereToShoot = GameObject.FindGameObjectWithTag("Player").transform;
       
           StartCoroutine(Shooting());
           
        Move();
        

    }

    public IEnumerator Shooting()
    {
        
        yield return new WaitForSecondsRealtime(3);
        Vector2 shoot = new Vector2(posToShootFrom.position.x, posToShootFrom.position.y);
        GameObject obj = Instantiate(projectile,shoot, Quaternion.identity);
        obj.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x,velocity.y * 20);
        Destroy(obj,3f);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            detected = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            detected = false;
        }
    }



    public void Move()
    {
        if (transform.position.x <= leftBound.x)
        {
            dir = 1;
        }
        else if(transform.position.x >=rightBound.x)
        {
            dir = -1;
            
        }
        transform.Translate(speed * dir * Time.deltaTime);
    }
}


