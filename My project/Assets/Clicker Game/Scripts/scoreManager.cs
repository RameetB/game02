using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{
  public int score;
  public TextMeshProUGUI scoreText;

    void start() {
        //reset score at the start of the game
        updateScoreText();
    }
  public void increaseScore(int amount) {
      score += amount;
      updateScoreText();
  }

  void updateScoreText() {
      scoreText.text = "score: " + score;
  }


}
