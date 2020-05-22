using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PracticePlayerController : MonoBehaviour
{
    public float speed = 10;
    public float xRange = 6.2f;
    public float yRange = 4.1f;
    public GameObject Puck;
    public GameObject Blocky;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Blocky, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);

        //practice an interating FOR loop!
        //It should print i=1, i=2. i=3
        for (int i = 0; i<3; i++)
        {
            print("i = " + i);
        }
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

        if(transform.position.x < -xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y);
        }

        if (transform.position.y > yRange)
        {
            transform.position = new Vector2(transform.position.x, yRange);
        }

        if (transform.position.y < -yRange)
        {
            transform.position = new Vector2(transform.position.x, -yRange);
        }
    }

    public void NewGame()
    {
        SceneManager.LoadScene(0);
    }
}
