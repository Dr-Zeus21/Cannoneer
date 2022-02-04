using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    Text scoreText;
    GameMaster gameMaster;
    void Start()
    {
        scoreText = GetComponent<Text>();
        gameMaster = FindObjectOfType<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = gameMaster.GetScore().ToString();
    }

    public Text getScoreText()
    {
        return scoreText;
    }
}
