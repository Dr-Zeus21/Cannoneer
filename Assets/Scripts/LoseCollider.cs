using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
  public GameObject gameOverText;
  public GameObject restartButton;
  [SerializeField] public AudioClip hitSound;
  [SerializeField] [Range(0,1)] public float hitVolume = .75f;
  private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        gameOverText.SetActive(true);
        restartButton.SetActive(true);

        AudioSource.PlayClipAtPoint(hitSound, Camera.main.transform.position, hitVolume);
    }
}
