using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
  //[SerializeField] public string name;
  //[SerializeField] public string[] sentences;
  public string name;
  [TextArea(3, 10)]
  public string[] sentences;
}
