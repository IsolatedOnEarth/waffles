using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactermovementcomponent : MonoBehaviour {

    public float Acceleration = 100.0f;
    public float MaxVelocity = 10.0f;

    private bool Sprint;
    public float MaxSpr Int Velocity;



    private Rigidbody RB;

    Vector3 InputVector;

    // Use this for initialization
      void Start(){

        RB = GetComponent<Rigidbody>();
    }

    void Movement(Rigidbody rb, Vector3 IPVector, float Accel, float MaxVel) {

        IPVector.x = Input.GetAxisRaw("Horizontal");
        IPVector.z = Input.GetAxisRaw("Vertical");

        rb.AddForce(IPVector * Accel * Time.deltaTime);


        
   
        //set velocity to the clamp
        rb.velocity = Vectorclamp(rb.velocity, -MaxVel, MaxVel, true, false);
    }

    //public class KeyCodeExample : MonoBehaviour
    //{
    //    void Update()
    //    {
    //        if (Input.GetKeyDown(KeyCode.Shift))
    //        {
    //            Debug.Log("Shift was pressed.");
    //        }
    //}


    //stops axis from going out of bounds
    public Vector3 Vectorclamp(Vector3 CurrentVector, float Min, float Max, bool ClampX = true, bool ClampY = true, bool ClampZ = true) {

        Vector3 Result = CurrentVector;

        if (ClampX == true) {
            Result.x = Mathf.Clamp(CurrentVector.x, Min, Max);
        }
         if (ClampY == true) {
            Result.y = Mathf.Clamp(CurrentVector.y, Min, Max);
    }
        if (ClampZ == true){
            Result.z = Mathf.Clamp(CurrentVector.z, Min, Max);
        }
        return Result;
    }
    // Update is called once per frame
    void Update(){

        Movement(RB, InputVector, Acceleration, MaxVelocity);

        if (Sprint == true)
        {
           Current
        }
    }
}
