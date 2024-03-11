using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPackSpawnScript : MonoBehaviour
{
    public GameObject ammoPack;
    public float heightOffest = 10f;
    public float widthOffest = 10f;
    public bool ammoPackExists = false;
    public AmmoScript ammo;
    public AmmoPackSpawnScript ammoSpawn;

    // Start is called before the first frame update
    void Start()
    {
        ammo = GameObject.FindGameObjectWithTag("AmmoManager").GetComponent<AmmoScript>();
        ammoSpawn = GameObject.FindGameObjectWithTag("AmmoPackSpawner").GetComponent<AmmoPackSpawnScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ammo.ammoCount == 0 && !ammoPackExists)
        {
            ammoPackExists = true;
            ammoSpawn.SpawnAmmoPack();
        }
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
