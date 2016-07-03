using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;  //We can controll the speed of the player here.
    public Rigidbody rb;

    public void PlayerMove(float xAxis)
    {
        //if you're not moving Left or Right
        if (xAxis != 0)
        {
            if (xAxis > 0)
            {
                rb.AddForce(transform.right * playerSpeed);
            }
        }
    }
}
