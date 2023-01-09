using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGameButtonController: MonoBehaviour
{
  [SerializeField] private TextMeshProUGUI playButton;

  public void ButtonPress()
  {
    playButton.text = "New Game";
    SceneManager.LoadScene("Tutorial");
  }
}
