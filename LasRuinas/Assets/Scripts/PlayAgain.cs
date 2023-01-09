using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain: MonoBehaviour
{
  public void StartGameOver()
  {
    SceneManager.LoadScene("OpeningScene");
  }

  [SerializeField] private TextMeshProUGUI playButton;

  public void ButtonPress()
  {
    playButton.text = "New Game";
    SceneManager.LoadScene("Tutorial");
  }
}
