using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour {

    Rigidbody2D rb2d;
    
    public GameObject potion;
    public GameObject potionB;
    public float maxSpeed = 10f;
    public bool pause = false;
    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float jumpForce = 700f;

    public Transform Attack;
    
    int maxhealth = 3;
    public int ourHealth;

    public Player2Controller player2;

    private Animator anim;
 
    public GameObject endOfTime;

    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        ourHealth = maxhealth;
        player2 = GameObject.FindGameObjectWithTag("Playerr").GetComponent<Player2Controller>();
        anim = GetComponent < Animator>();
    }
    
    public void resume2()
    {
        pause = false;
    }
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        if (!grounded)
            return;

        float move = Input.GetAxis("Horizontal1");

        if ( player2.ourHealth2 > 0 && endOfTime.activeSelf == false)
             rb2d.velocity = new Vector2(move * maxSpeed, rb2d.velocity.y);

        if (move > 0 && player2.ourHealth2 > 0 && endOfTime.activeSelf == false)
            transform.eulerAngles = new Vector3(0, 180, 0);
        if (move < 0 && player2.ourHealth2 > 0 && endOfTime.activeSelf == false)
            transform.eulerAngles = new Vector3(0, 0, 0);

    }

    float timeStamp = 0;
    float activationTime;
    bool inAir = false;
    void Update()
    {

        if (transform.position.y > -7 && transform.position.y <= -2 &&
            transform.position.x >= 3 && transform.position.x <= 4.2 && potionB.active == true)
        {
            potionB.SetActive(false);
            player2.ourHealth2--;
        }

        if (transform.position.x >= -0.3 && transform.position.x <= 0.50 &&
            transform.position.y > 1.80 && transform.position.y <= 2.03 &&  ourHealth < 3 && potion.active==true)
        {
           
            potion.SetActive(false);
            ourHealth++;
        }

        if (transform.position.y <= -6 && ourHealth > 1 && player2.ourHealth2>0 && endOfTime.activeSelf == false)
        {

            transform.position = new Vector3(-3, 2.2f, 0);
            Sound.PlaySound("life");
            ourHealth--;
        }
        else
        {
            if (transform.position.y <= -6 && player2.ourHealth2 > 0 && endOfTime.activeSelf == false)
            {
                ourHealth =0;
            }
               
        }

        if (Input.GetKeyDown(KeyCode.P) )
            pause = !pause;
       

        if (grounded && Input.GetKeyDown(KeyCode.W) && player2.ourHealth2 > 0 && pause==false && endOfTime.activeSelf == false)
        {
            inAir = true;
            Sound.PlaySound("jump");
            rb2d.AddForce(new Vector2(0, jumpForce));
        }
        else
        {
            inAir = false;
        }
        if (timeStamp <= Time.time && Input.GetKeyDown(KeyCode.F) && endOfTime.activeSelf == false)
        {
            if (transform.eulerAngles.y == 180 )
                Attack.GetComponent<AreaEffector2D>().forceAngle = 45;
            else
                Attack.GetComponent<AreaEffector2D>().forceAngle = 135;
            Attack.GetComponent<AreaEffector2D>().enabled = true;
            timeStamp = Time.time + 3;
            activationTime = Time.time;
        }
        if (Time.time >= activationTime + 0.5f && endOfTime.activeSelf == false)
        {
            Attack.GetComponent<AreaEffector2D>().enabled = false;
            
        }

        anim.SetBool("Grounded", grounded);
        anim.SetBool("W", inAir);

        
    }
}
