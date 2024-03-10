using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 mousePos;
    public GameObject bullet;
    public Transform bulletTransform;
    public bool canFire = true;
    private float timer;
    public float timeBetweenFiring = 0.3f;
    bool playerIsAtCannon = false;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        if (!canFire)
        {
            timer += Time.deltaTime;
            if (timer > timeBetweenFiring)
            {
                timer = 0;
                canFire = true;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && canFire && playerIsAtCannon)
        {
            canFire = false;
            Instantiate(bullet, bulletTransform.position, bulletTransform.rotation);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        playerIsAtCannon = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        playerIsAtCannon = false;
    }
}