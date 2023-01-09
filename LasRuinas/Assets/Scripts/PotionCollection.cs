using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PotionCollection : MonoBehaviour
{
  public int potionCounter = 0;
  public TextMeshProUGUI potionCounterText;
  // audio source for collecting potions
  public AudioSource potionCollectSound;

  public AudioSource hatinFrogSound;

  private void OnTriggerEnter2D( Collider2D collision )
  {
    if(collision.gameObject.tag == "Potion")
    {
      // play sound
      potionCollectSound.Play();
      // i need something that checks if the player collects a potion
      // i also need to remove the potion
      Destroy(collision.gameObject);
      // i also need to count the potion
      potionCounter++;
      potionCounterText.text = "Potions: " + potionCounter.ToString();
      //Debug.Log("Potions: " + potionCounter);
    }

    // if we hit enemy, lose a potion
    if(collision.gameObject.tag == "HatinFrog" && potionCounter >= 0)
    {
      hatinFrogSound.Play();
      potionCounter--;
      Destroy(collision.gameObject);
      potionCounterText.text = "Potions: " + potionCounter.ToString();
    }
    else if(collision.gameObject.tag == "HatinFrog" && potionCounter <= 0)
    {
      // you lose a life and start the level over
      Debug.Log("You lose a life and start the level over");
    }
  }
}
