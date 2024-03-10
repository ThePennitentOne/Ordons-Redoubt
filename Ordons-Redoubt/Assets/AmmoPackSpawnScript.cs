using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPackSpawnScript : MonoBehaviour
{
    public GameObject ammoPack;
    public float heightOffest = 10f;
    public float widthOffest = 10f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnAmmoPack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnAmmoPack()
    {
        float lowestPoint = transform.position.y - heightOffest;
        float highestPoint = transform.position.y + heightOffest;
        float leftestPoint = transform.position.x - widthOffest;
        float rightestPoint = transform.position.x + widthOffest;

        Instantiate(ammoPack, new Vector3(Random.Range(leftestPoint, rightestPoint), Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
