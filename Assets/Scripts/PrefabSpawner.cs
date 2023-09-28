using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Transform[] tablePositions;
    public float spawnHeightOffset = 1f;
    public float spawnZoffset = -1f;
    public float spawnXoffset = 1f;

    void Start()
    {
        // Iterate through the table positions and spawn the prefab at each location
        foreach (Transform tablePosition in tablePositions)
        {
            Vector3 spawnPosition = tablePosition.transform.position + Vector3.up * spawnHeightOffset + Vector3.forward * spawnZoffset + Vector3.back * spawnXoffset;
            Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}
