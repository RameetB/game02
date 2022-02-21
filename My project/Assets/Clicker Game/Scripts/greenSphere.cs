using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenSphere : MonoBehaviour
{
        public int hp = 3;

    public int points = 3;
    public float sizeScale = .2f;
    public scoreManager scoreManager;
    void OnMouseDown () {
        hp--;

        transform.localScale += Vector3.one * sizeScale;

        if (hp == 0) {

            Destroy(gameObject);

            scoreManager.increaseScore(points);
        }
    }
}
