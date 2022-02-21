using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawningSphere : MonoBehaviour
{
    public GameObject spawnPrefab;
    public float xPos = 0f, yPos = 0f, zPos = 2f;
    public int hp = 0;
    void start() {
        Instantiate(spawnPrefab, Vector3.zero, Quaternion.identity);
        hp = 5;
    }

    void OnMouseDown () {
        hp--;

        if (hp == 0) {
            Destroy(gameObject);
            spawnNew();
        }
    }

    void spawnNew() {
        
        xPos = Random.Range(-12.0f, 12.0f);
        yPos = Random.Range(-5.2f, 7.3f);
        Vector3 spawnPos = new Vector3(xPos, yPos, zPos);
        Instantiate(spawnPrefab, spawnPos, Quaternion.identity);
    }
}
