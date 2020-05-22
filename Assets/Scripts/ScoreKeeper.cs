using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    //variables to hold the text and value of the score
    private TextMeshProUGUI scoreText;
    public int scoreValue;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            UpdateScore();
        }
    }

    public void UpdateScore()
    {
        scoreValue += 5;
        scoreText.text = "Score: " + scoreValue.ToString();
    }
}
