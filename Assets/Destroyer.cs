using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    //Much like the start and updatre methods, OnTriggerEnter2D is a unity method
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If the game object that has collided with our trigger is tagged with cleanUp...
        if(collision.gameObject.tag == "CleanUp")
        {
            //Then we use this method to destroy it
            Destroy(collision.gameObject);
        }
    }
}
