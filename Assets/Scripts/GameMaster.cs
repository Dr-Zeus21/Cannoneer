using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public WinCollider cactus;
    public Cannon cannon;
    public float distance;
    public float angle;
    public float initialVelocity;
    private int score;
    
    void Start()
    {
        cactus.transform.position = new Vector3(Random.Range(-3f, 8f), -4f, 0f);
        distance = cactus.transform.position.x - cannon.transform.position.x;
        initialVelocity = Random.Range(12f, 20f);
    }

    void Update()
    {
        if (cactus.hit)
        {
            AddToScore(1);
            cactus.transform.position = new Vector3(Random.Range(-3f, 8f), -4f, 0f);
            distance = cactus.transform.position.x - cannon.transform.position.x;
            initialVelocity = Random.Range(12f, 20f);
            cactus.hit = false;
            cannon.fired = false;
        }
        angle = cannon.transform.rotation.eulerAngles.z;
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadInstructionsScene()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public int GetScore()
    {
        return score;
    }

    public void AddToScore(int scoreValue)
    {
        score += scoreValue;
    }

    public float GetDistance()
    {
        return distance;
    }

        public float GetVi()
    {
        return initialVelocity;
    }
}
