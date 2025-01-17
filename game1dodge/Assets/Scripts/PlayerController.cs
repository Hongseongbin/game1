using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigid;
    public float speed;

    void Start()
    {
        //playerRigid = GetComponent<Rigidbody>();
        speed = 8f;

    }

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput* speed;
        float zSpeed = zInput* speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);

        playerRigid.velocity = newVelocity;
    }

    public void Die()
    {
        gameObject.SetActive(false);
        Debug.Log("GameOver");

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}
