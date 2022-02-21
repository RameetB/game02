using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawningSphere : MonoBehaviour
{
    public GameObject spawnPrefab;
    public float xPos = 0f, yPos = 0f, zPos = 2f;
    public int hp = 5;
    void Start() {
        if (spawnPrefab != null) {
        Instantiate(spawnPrefab, Vector3.zero, Quaternion.identity);
        } else {
            Debug.LogError("spawnPrefab not selected.");
        }
    }

    void OnMouseDown () {
        hp--;
        transform.localScale += new Vector3(.2f,.2f,.2f);
        if (hp == 0) {
            Destroy(gameObject);
            if (spawnPrefab != null) {
                spawnNew();
            } else {
                Debug.LogError("Cannot respawn no prefab loaded.");
            }
        }
    }

    void spawnNew() {
        
        xPos = Random.Range(-12.0f, 12.0f);
        yPos = Random.Range(-5.2f, 7.3f);
        Vector3 spawnPos = new Vector3(xPos, yPos, zPos);
        Instantiate(spawnPrefab, spawnPos, Quaternion.identity);
    }
}
