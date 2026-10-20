using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public TMP_Text ScoreText;
    public Button PlayAgainButton;
    public GameObject OneBallPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int score = 0;
    public int NumberOfBalls = 0;
    public int maximumBalls = 150;
    public bool GameOver = true;

    void Start()
    {
        InvokeRepeating("AddABall", 1.5F, 1);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = score.ToString();
        AddABall();
    }

    public void AddABall()
    {
        if (!GameOver)
        {
            Instantiate(OneBallPrefab);
            NumberOfBalls++;
            if (NumberOfBalls >= maximumBalls)
            {
                GameOver = true;
                PlayAgainButton.gameObject.SetActive(true);
            }
        }
    }

    public void startGame()
    {
        foreach (GameObject ball in GameObject.FindGameObjectsWithTag("GameController"))
        {
            Destroy(ball);
        }
        PlayAgainButton.gameObject.SetActive(false);
        score = 0;
        NumberOfBalls = 0;
        GameOver = false;
    }

    public void ClickedOnBall()
    {
        score++;
        NumberOfBalls--;
    }
}
