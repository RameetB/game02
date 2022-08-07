using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowlingBall : MonoBehaviour
{
   public float forwardForce, leftBorder, rightBorder, moveIncrements, angleIncrements;
   public Rigidbody rigidBody;

    

   public void Bowl () {
       rigidBody.AddForce(transform.forward * forwardForce, ForceMode.Impulse);
   }

   public void moveLeft() {
        if(transform.position.x > leftBorder){
            transform.position += new Vector3 (-moveIncrements, 0, 0);
        }
   }
   public void moveRight() {
        if(transform.position.x < rightBorder){
            transform.position += new Vector3 (moveIncrements, 0, 0);
        }
   }
   public void moveAngle() {
    
 }
}
