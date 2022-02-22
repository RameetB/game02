using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawningSphere : MonoBehaviour
{
    public GameObject spawnPrefab;
    public scoreManager scoreManager;

    public float xPos = 0f, yPos = 0f, zPos = 2f;
    public int hp = 5, points = 5;

    public float sizeScale = .2f;    
    void OnMouseDown () {
        hp--;

        transform.localScale += Vector3.one * sizeScale;

        if (hp == 0) {

            Destroy(gameObject);

            scoreManager.increaseScore(points);

            spawnNew();
        }
    }
    void spawnNew() {
        
        xPos = Random.Range(-12.0f, 12.0f);
        yPos = Random.Range(-5.2f, 7.3f);
        int newHp = Random.Range(0,11);
        hp = newHp;
        points = newHp;
        Vector3 spawnPos = new Vector3(xPos, yPos, zPos);
        Instantiate(spawnPrefab, spawnPos, Quaternion.identity);
    }
}
