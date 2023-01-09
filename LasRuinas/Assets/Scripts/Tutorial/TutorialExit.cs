using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialExit: MonoBehaviour
{
  private void OnTriggerEnter2D( Collider2D collision )
  {
    //if (collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Space))
    if (collision.gameObject.tag == "Player")
    {
      //Debug.Log("wht is happening?");
      SceneManager.LoadScene("LevelOne");
    }
  }
}
