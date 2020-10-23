using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnerOnLeave : MonoBehaviour
{
    public GameObject[] objPrefabs;
    public GameObject lastSpawnee;

    private Vector3 translateToAdd;


    public int min = 0;
    public int max = 0;


    void Start()
    {
        // spawn first object in the zone otherwise it can't detect when an object leaves the area.
        SpawnPrefab();
    }

    public void SpawnPrefab() {

        int index = Random.Range(0, objPrefabs.Length);

        GameObject spawnee = GameObject.Instantiate(objPrefabs[index]);

        if (lastSpawnee != null) {
            Vector3 translateToAdd = spawnee.GetComponent<SpawnTranslation>().translationOnSpawn;

            Vector3 lastSpawneePos = lastSpawnee.transform.position;

            // Modifier cette position, par la longueur du denrier spawnee

            BoxCollider coll = lastSpawnee.GetComponent<BoxCollider>();
            lastSpawneePos.x -= coll.bounds.size.x - translateToAdd.x;


            spawnee.transform.position = lastSpawneePos;
           
        } else {
            Vector3 spawnerPos = transform.position;

            spawnerPos.z -= Random.Range(min, max);

            spawnee.transform.position = spawnerPos;
        }
       
        lastSpawnee = spawnee;
    }
}
