using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticePlayerController : MonoBehaviour
{
    public float speed = 10;
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
    }
}
