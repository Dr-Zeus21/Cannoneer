using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceDisplay : MonoBehaviour
{
    Text distanceText;
    GameMaster gameMaster;
    void Start()
    {
        distanceText = GetComponent<Text>();
        gameMaster = FindObjectOfType<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceText.text = gameMaster.GetDistance().ToString();
    }

    public Text getScoreText()
    {
        return distanceText;
    }
}
