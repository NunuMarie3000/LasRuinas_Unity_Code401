using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterLevel: MonoBehaviour
{
  private bool enterAllowed;
  private string sceneToLoad;

  private void OnTriggerEnter2D( Collider2D collision )
  {
    if(collision.gameObject.tag == "TutorialExitFlag")
    {
      sceneToLoad = "LevelOne";
      enterAllowed = true;
    }
    else if (collision.gameObject.tag == "LevelOneEnterFlag")
    {
      sceneToLoad = "Tutorial";
      enterAllowed = true;
    }
  }

  private void OnTriggerExit2D( Collider2D collision )
  {
    if(collision.gameObject.tag == "TutorialExitFlag" || collision.gameObject.tag == "LevelOneEnterFlag")
    {
      enterAllowed= false;
    }
  }

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if(enterAllowed && Input.GetKeyDown(KeyCode.Space))
    {
      SceneManager.LoadScene(sceneToLoad);
    }
  }
}
