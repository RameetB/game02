using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    public void resetGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("reset button pressed");
    }
    public void Update() {
        if (Input.GetKeyDown("t")) {
            resetGame();
        }
    }
}