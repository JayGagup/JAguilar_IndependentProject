using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject platesPrefab;
    public GameObject[] tablesPrefab;
    public int tablesPrefabIndex;
    private float Yoffset = .5f;
    private float Zoffset = .5f;
    
    // Start is called before the first frame update
    void Start()
    {
        int tablesPrefabIndex = Random.Range(0, tablesPrefab.Length);
        Vector3 spawnPos = tablesPrefab[tablesPrefabIndex].transform.position + Vector3.up * Yoffset + Vector3.back * Zoffset;
        Instantiate(platesPrefab, spawnPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
        

        

    }

   
}
