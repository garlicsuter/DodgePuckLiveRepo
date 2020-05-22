using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PracticeScoreKeeper : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    public int scoreValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = "Score: " + scoreValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
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
