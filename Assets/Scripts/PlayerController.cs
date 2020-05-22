using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private float xRange = 6.0f;
    private float yRange = 4.15f;
    public GameObject Puck;
    public GameObject Blocky;
    public GameObject scoreText;
    public GameObject gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Blocky, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);

        //for (int i = 0; i <= 500; i++)
        //{
        //    Debug.Log("i = " + i);
        //    Instantiate(Blocky, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            NewGame();
        }

        //move Player
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        //print("the value of moveHorizontal: " + moveVertical);

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        //Debug.Log("movement: " + movement);

        transform.Translate(movement * speed * Time.deltaTime);

        //Keep me in the xRange
        if (transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange, transform.position.y);
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y);
        }

        if (transform.position.y > yRange)
        {
            transform.position = new Vector2(transform.position.x,yRange );
        }

        if (transform.position.y < -yRange)
        {
            transform.position = new Vector2(transform.position.x, -yRange);
        }
    }

   

    private void OnTriggerEnter2D(Collider2D other)
    {
        // If the other object is tagged as "Blocky", add 5 points
        if (other.gameObject.CompareTag("Blocky"))
        {
            
            scoreText.GetComponent<ScoreKeeper>().UpdateScore();
            Destroy(other.gameObject);
            Instantiate(Blocky, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange)), Quaternion.identity);
        }

        if (other.gameObject.CompareTag("Puck"))
        {
            gameOverText.SetActive(true);
            Time.timeScale = 0;
        }
    }


    public void NewGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
