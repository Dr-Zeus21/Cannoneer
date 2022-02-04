using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCollider : MonoBehaviour
{
  public bool hit = false;
  [SerializeField] public AudioClip hitSound;
  [SerializeField] [Range(0,1)] public float hitVolume = .75f;
  private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        hit = true;

        AudioSource.PlayClipAtPoint(hitSound, Camera.main.transform.position, hitVolume);
    }
}
