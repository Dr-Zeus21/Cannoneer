using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameStatus : MonoBehaviour
{

    // config param
    [SerializeField] int pointsPerBlock = 20;
    [SerializeField] TextMeshProUGUI scoreText = null;
    // state variables
    [SerializeField] int score = 0;


    private void Awake()
    {
        // Singleton Pattern
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToScore()
    {
        score += pointsPerBlock;
        scoreText.text = score.ToString();
    }

    public void ResetGame()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }

}
