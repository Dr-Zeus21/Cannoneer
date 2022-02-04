using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AngleDisplay : MonoBehaviour
{
    Text AngleText;
    Cannon cannon;
    void Start()
    {
        AngleText = GetComponent<Text>();
        cannon = FindObjectOfType<Cannon>();
    }

    // Update is called once per frame
    void Update()
    {
        AngleText.text = cannon.transform.rotation.eulerAngles.z.ToString();
    }

    public Text getScoreText()
    {
        return AngleText;
    }
}
