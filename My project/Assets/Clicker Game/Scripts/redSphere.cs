using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redSphere : MonoBehaviour
{
    public int hp = 5;

    public int points = 3;
    public float sizeScale = .2f;
    void OnMouseDown () {


        if (hp == 0) {
            transform.localScale += Vector3.one * sizeScale;

            Destroy(gameObject);
        }
    }

}
