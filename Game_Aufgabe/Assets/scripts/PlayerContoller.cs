using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{

    public float movementspeed = 2f;
    public float RotationspeedX = 2f;
    public float RotationspeedY = 2f;
    public float negativgravityforce = 4f;
    public float gravity = 5f;
    CharacterController player;
    public bool INvertedAXis = false;
    public bool Jumping = false;
    public GameObject Camera;
    float moveforwbackw;
    float movesideways;
    float upforce;

    float LOOKX;
    float LOOKY;

    // Use this for initialization
    void Start()
    {
        player = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        Movement();

      
        if (Input.GetButtonDown("JUMP"))
        {
            Jumping = true;
        }
        JUMP();
    }

    public void JUMP()
    {
        if (player.isGrounded)
        {
            if (Jumping == false)
            {
                upforce = (-gravity);
            }
            else
            {
                upforce = negativgravityforce;
            }
        }
        else
        {
            upforce += (-gravity) * Time.deltaTime;
            upforce = Mathf.Clamp(upforce, -50, negativgravityforce);
            Jumping = false;
        }
    }
    public void JUMP(float number)
    {
        if (player.isGrounded)
        {
            if (Jumping == false)
            {
                upforce = (-gravity);
            }
            else
            {
                upforce = negativgravityforce*number;
            }
        }
        else
        {
            upforce += (-gravity) * Time.deltaTime;
            upforce = Mathf.Clamp(upforce, -50, negativgravityforce);
            Jumping = false;
        }
    }

    void Movement()
    {
        movesideways = Input.GetAxis("Horizontal") * movementspeed;
        moveforwbackw = Input.GetAxis("Vertical") * movementspeed;
        Vector3 movement = new Vector3(movesideways, upforce, moveforwbackw);

        LOOKX = Input.GetAxis("Mouse X") * RotationspeedX;
        LOOKY = Input.GetAxis("Mouse Y") * RotationspeedY;
        transform.Rotate(0, LOOKX, 0);
        if (INvertedAXis)
        {
            Camera.transform.Rotate(-LOOKY, 0, 0);
        }
        else
        {
            Camera.transform.Rotate(LOOKY, 0, 0);
        }
        movement = transform.rotation * movement;
        player.Move(movement * Time.deltaTime);
    }
}
