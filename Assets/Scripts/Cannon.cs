using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public bool fired;
    public GameMaster gameMaster;
    [SerializeField] public GameObject cannonBarrel;
    [SerializeField] public GameObject ballPrefab;
    [SerializeField] public AudioClip launchSound;
    public float moveSpeed = 1f;
    public Quaternion rotation;
    public float initialVelocity = 0;
    [SerializeField] [Range(0,1)] public float launchVolume = .75f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!fired && Input.GetKeyDown(KeyCode.Space))
        {
            GameObject ball = Instantiate(ballPrefab, cannonBarrel.transform.position, Quaternion.identity) as GameObject;
            
            var xVel = Mathf.Cos(Mathf.PI * transform.rotation.eulerAngles.z / 180) * gameMaster.initialVelocity;
            var yVel = Mathf.Sin(Mathf.PI * transform.rotation.eulerAngles.z / 180) * gameMaster.initialVelocity;
            ball.GetComponent<Rigidbody2D>().velocity = new Vector2(xVel, yVel);

            AudioSource.PlayClipAtPoint(launchSound, Camera.main.transform.position, launchVolume);
            fired = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            var deltaZ = moveSpeed * Time.deltaTime ;
            rotation = transform.rotation;
            rotation.z += deltaZ;
            transform.rotation = rotation;
        }

        if (Input.GetKey(KeyCode.D))
        {
            var deltaZ = -moveSpeed * Time.deltaTime ;
            rotation = transform.rotation;
            rotation.z += deltaZ;
            transform.rotation = rotation;
        }
    }
}
