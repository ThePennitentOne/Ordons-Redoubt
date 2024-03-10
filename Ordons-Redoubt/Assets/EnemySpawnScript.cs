using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate = 2f;
    private float timer = 0f;
    public float heightOffest;
    public float widthOffest;

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    private void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffest;
        float highestPoint = transform.position.y + heightOffest;
        float leftestPoint = transform.position.x - widthOffest;
        float rightestPoint = transform.position.x + widthOffest;

        Instantiate(enemy, new Vector3(Random.Range(leftestPoint, rightestPoint), Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
