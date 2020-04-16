using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckController : MonoBehaviour
{
    private int[] direction = {0,1,2,3};
    //public string[] direction2 = { "N", "E", "S", "W" };
    public int moveDirection;
    public float puckSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        moveDirection = direction[Random.Range(0,4)];
        //print("md: " + moveDirection);
    }

    // Update is called once per frame
    void Update()
    {
        if(moveDirection == 0)
        {
            transform.Translate(transform.up * Time.deltaTime * puckSpeed);
        }

        else if (moveDirection == 1)
        {
            transform.Translate(transform.right * Time.deltaTime * puckSpeed);
        }

        else if (moveDirection == 2)
        {
            transform.Translate(transform.up * Time.deltaTime * -puckSpeed);
        }

        else if (moveDirection == 3)
        {
            transform.Translate(transform.right * Time.deltaTime * -puckSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            print("Walllll");
            puckSpeed = -puckSpeed;
        }
        
    }

}
