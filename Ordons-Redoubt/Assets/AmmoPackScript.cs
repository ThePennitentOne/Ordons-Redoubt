using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPackScript : MonoBehaviour
{
    public GameObject player;
    public AmmoScript ammo;
    public AmmoPackSpawnScript ammoSpawn;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        ammo = GameObject.FindGameObjectWithTag("AmmoManager").GetComponent<AmmoScript>();
        ammoSpawn = GameObject.FindGameObjectWithTag("AmmoPackSpawner").GetComponent<AmmoPackSpawnScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            ammo.IncreaseAmmo(4);
            ammoSpawn.SpawnAmmoPack();
            Destroy(gameObject);
        }
    }
}