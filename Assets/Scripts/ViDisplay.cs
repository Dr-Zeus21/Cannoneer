using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViDisplay : MonoBehaviour
{
    Text ViText;
    GameMaster gameMaster;
    void Start()
    {
        ViText = GetComponent<Text>();
        gameMaster = FindObjectOfType<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        ViText.text = gameMaster.GetVi().ToString();
    }

    public Text getScoreText()
    {
        return ViText;
    }
}
