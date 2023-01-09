using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController: MonoBehaviour
{
  private Rigidbody2D rb2D;

  private float moveSpeed;

  private float jumpForce;

  private bool isJumping;

  private float moveHorizontal;

  public AudioSource jumpSound;

  private float moveVertical;

  // Start is called before the first frame update
  // only runs once
  void Start()
  {
    rb2D = gameObject.GetComponent<Rigidbody2D>();

    moveSpeed = 0.5f;
    jumpForce = 30;
    isJumping = false;
  }

  // Update is called once per frame
  void Update()
  {
    // -1 = Left, 1 = Right, 0 = No keypress/standing still
    moveHorizontal = Input.GetAxisRaw("Horizontal");
    moveVertical = Input.GetAxisRaw("Vertical");
  }

  // updates with the physics engine in unity
  // 
  void FixedUpdate()
  {
    //if going right || left
    if (moveHorizontal > 0.1f || moveHorizontal < -0.1f)
    {
      // Vector2 is an x and y axis, so how much do we wanna move the player left or right
      // we don't wanna also multiply by Time.Deltatime or Time.fixedDeltatime since we're using AddForce, it's applied as default in it's ForceMode
      rb2D.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
    }


    if (!isJumping && moveVertical > 0.1f)
    {
      jumpSound.Play();
      rb2D.AddForce(new Vector2(0f, moveVertical * jumpForce), ForceMode2D.Impulse);
    }
  }

  // collision will be whatever we're hitting in our game
  private void OnTriggerEnter2D( Collider2D collision )
  {
    if(collision.gameObject.tag == "Platform" || collision.gameObject.tag == "CanBeJumpedOn")
    {
      isJumping = false;
    }
  }

  private void OnTriggerExit2D( Collider2D collision )
  {
    if(collision.gameObject.tag == "Platform" || collision.gameObject.tag == "CanBeJumpedOn")
    { 
      isJumping = true;
    }
  }
}
