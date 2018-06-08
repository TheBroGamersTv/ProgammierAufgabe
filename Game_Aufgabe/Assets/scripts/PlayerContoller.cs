using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerContoller : MonoBehaviour
{
    [Header ("Playermovemt")]
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
    bool issprinting = false;
    [Header("Timestop")]
    public bool Timestop = false;
    public bool TimestopAllowed = true;
    public float normaltime = 1000;
    public float MaxTimestoptime = 2f;
    public float currenttimestoptime = 0;

    float LOOKX;
    float LOOKY;

    // Use this for initialization
    void Start()
    {
        //here we attach the playercontoller to player when the script has a charaktercontroller
        player = this.GetComponent<CharacterController>();
       
    }

    // Update is called once per frame
    void Update()
    {

        Movement();
        if(Input.GetKeyDown(KeyCode.Z)&&TimestopAllowed)
        {
            //Timestop = true;
            //TimestopAllowed = false;
            //Time.timeScale = 0.001f;
            
        }
        //if(Timestop)
        //{
        //    currenttimestoptime = Time.deltaTime;
        //    if(currenttimestoptime<=MaxTimestoptime)
        //    {
        //        currenttimestoptime = 0;
        //        Timestop = false;
        //        Time.timeScale=1.0f;
        //    }
        //}
        
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            issprinting = !issprinting;
        }
        //with this funktion we ask if the button is pressed in the input menü Interact witch is space.
        if (Input.GetButtonDown("JUMP"))
        {
            Jumping = true;
        }
        JUMP();
    }
    public void Inverted(bool IsInverted)
    {
        INvertedAXis = IsInverted;
        Debug.Log(IsInverted);
    }

    public void JUMP()
    {
        //if the player is above something then it funktions.
        if (player.isGrounded)
        {
            if (Jumping == false)
            {
                //insted of (-gravity) we could use the unity physiks.gravity but i wanted to be able to change the gravity 
                upforce = (-gravity);
            }
            else
            {
                //thats where the player gets the jump 
                upforce = negativgravityforce;
            }
        }
        else
        {
            //when the player is falling some longer time, the gravity increses with tim.deltaTime,tim.deltaTime means 1 sec
            if(!Timestop)
                upforce += (-gravity) * Time.deltaTime;
            else
                upforce += (-gravity) * Time.deltaTime*normaltime;
            //here we set the player a max min gravity 
            upforce = Mathf.Clamp(upforce, -50, negativgravityforce);
            Jumping = false;
        }
    }
    //as like above but necesary for the jumpad
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
        //with this funktion we ask if the button is pressed in the input menü Horizontal witch is A and D.
        movesideways = Input.GetAxis("Horizontal") * movementspeed;
        //with this funktion we ask if the button is pressed in the input menü Vertical witch is W and S.
        moveforwbackw = Input.GetAxis("Vertical") * movementspeed;
        
        //we initalisize a vector3 with 3 numbers, where the player is going
        Vector3 movement = new Vector3(movesideways, upforce, moveforwbackw);

        //we want to see where our mouse looks so we get our mouse position x and y and we times it by rotationspeed because you can change it in the settings for people who like it faster
        LOOKX = Input.GetAxis("Mouse X") * RotationspeedX;
        LOOKY = Input.GetAxis("Mouse Y") * RotationspeedY;
        //the trick here is we want to move the player by the x and the Camera by y and when wie dont inverted it, it looks the opposite dir
        transform.Rotate(0, LOOKX, 0);
        if (INvertedAXis)
        {
            Camera.transform.Rotate(-LOOKY, 0, 0);
        }
        else
        {
            Camera.transform.Rotate(LOOKY, 0, 0);
        }
        //we set the rotation * the movement to look in that direktion
        if (issprinting)
        {
            movement = transform.rotation * movement*2.5f;
        }
        else
        {
            movement = transform.rotation * movement;
        }
        //luckily unity has made a method where theplayercontoller moves to the point we are telling him.
        //time.deltaTime is a funktion where for every Pc it looks beween the time of the last frame and the new Frame , that means if you have a good pc you have a small number
        //but if you have a bad pc you have a big number so the movement is for everyone constant.
        if (!Timestop)
        {
            player.Move(movement * Time.deltaTime);
        }
        else
        {
            player.Move(movement*Time.deltaTime*normaltime*1000);
        }
    }
}
