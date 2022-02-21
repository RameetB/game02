using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject spawnPrefab;
    public int spawnCount = 5;
    public float spawnOffset = 1.5f;


    void Start () {
        
        if (spawnPrefab != null) {
            spawnEnemies();
        } else {
            Debug.LogError("Cannot spawn enemies! prefab is null or missing.");
        }
    }
    void spawnEnemies () {

        for (int i=0; i <= spawnCount; i++) {
            //for every enemy spawned it moves the location enemies spawn by spawnOffset
            float xPos = i * spawnOffset;
            Vector3 spawnPos = new Vector3(xPos,0,0);
            //
            Instantiate(spawnPrefab, spawnPos, Quaternion.identity);
        }
    }

    
}
