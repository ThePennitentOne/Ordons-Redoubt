using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float MoveSpeed = 2f;
    float speedX, speedY;
    Rigidbody2D playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * MoveSpeed;
        speedY = Input.GetAxisRaw("Vertical") * MoveSpeed;
        playerRigidbody.velocity = new Vector2(speedX, speedY);
    }
}
