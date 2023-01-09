using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class DialogueManager: MonoBehaviour
{
  public TextMeshProUGUI nameText;
  public TextMeshProUGUI dialogueText;
  public GameObject continueButton;

  private List<string> sentences;
  private int counter;

  // Start is called before the first frame update
  void Start()
  {
    sentences = new List<string>();
    counter = 0;
  }

  public void StartDialogue( Dialogue dialogue )
  {
    //Debug.Log("Starting convo with " + dialogue.name);
    nameText.text = dialogue.name;

    sentences.Clear();

    foreach (string sentence in dialogue.sentences)
    {
      sentences.Add(sentence);
    }
    DisplayNextSentence();
    continueButton.SetActive(true);
  }

  public void DisplayNextSentence()
  {
    if (counter == sentences.Count)
    {
      EndDialogue();
      return;
    }
    else
    {
      string sentence = sentences[counter];
      counter++;
      //Debug.Log(sentence);
      dialogueText.text = sentence;
    }

  }

  void EndDialogue()
  {
    Debug.Log("End of convo");
    dialogueText.text = "";
    nameText.text = "";
    continueButton.SetActive(false);
  }
}
