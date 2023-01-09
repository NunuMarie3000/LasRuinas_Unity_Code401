using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger: MonoBehaviour
{
  public Dialogue dialogue;

  public void TriggerDialogue()
  {
    FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
  }

  private void Update()
  {
    if(Input.GetMouseButtonDown(0))
    {
      TriggerDialogue();
    }
  }
}
