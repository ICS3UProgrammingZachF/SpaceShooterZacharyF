using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContole : MonoBehaviour
{
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //rigidbody.velocity = some vector3 value;
    }

}
