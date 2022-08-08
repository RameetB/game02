using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowlingBall : MonoBehaviour
{
   public float forwardForce, leftBorder, rightBorder, moveIncrements, angleIncrements = 15.0f;
   public Rigidbody rigidBody;
   public Transform target;
   Quaternion currentRotation;
   Vector3 currentAngle;
    

   public void start () {
    //jordan requested an arrow to indicate angle
   }

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
   public void moveAnglePos() {
    if (transform.localEulerAngles.y <= 60) {
        currentAngle = new Vector3(transform.rotation.x, transform.localEulerAngles.y, transform.rotation.z);
        currentAngle += new Vector3(0, angleIncrements, 0);
        currentRotation.eulerAngles = currentAngle;
        transform.rotation = currentRotation;
        print(transform.localEulerAngles.y);
    }
 }
    public void moveAngleNeg() {
    if (transform.localEulerAngles.y != 300) {
        currentAngle = new Vector3(transform.rotation.x, transform.localEulerAngles.y, transform.rotation.z);
        currentAngle += new Vector3(0, -angleIncrements, 0);
        currentRotation.eulerAngles = currentAngle;
        transform.rotation = currentRotation;
        print(transform.localEulerAngles.y);
    }
    
 }

}
