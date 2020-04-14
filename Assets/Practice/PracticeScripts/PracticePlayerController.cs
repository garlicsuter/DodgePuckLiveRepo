using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticePlayerController : MonoBehaviour
{
    public float speed = 10;
    public float xRange = 6.2f;
    private float yRange = 4.4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        //print("Your H axis input:" + Input.GetAxis("Horizontal"));
        float moveVertical = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector2(moveHorizontal, moveVertical) * speed * Time.deltaTime);

        //Keep player within Range (Left and Right sides)
        if(transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange, transform.position.y);
        }
    }
}
