using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    bool j;
    bool h;
    float o2 = -1;
    float p2 = 0;
    float o1 = 1;
    float p1 = 0;
    float d2 = -1;
    float s2 = 0;
    float d1 = 1;
    float s1 = 0;
    public NewBehaviourScript v;
    public Rigidbody d;
    public float speed = 2f;
    public float sen = 2f;
    public Transform s;
    CharacterController player;
    Vector3 position2;
    public CharacterController rb1;
    bool b5 = true;
    float moveFB;
    float moveLR;
    float rotX;
    float rotY;
    public Transform rb;
    private Animator animator;
    float yRot;
    float y;
    bool ga;
    float yRot1;
    float y1;
    float y12;
    bool b;
    public AudioSource a;
    public AudioSource a1;
    public AudioSource a2;
    public AudioSource a3;
    public AudioSource a4;
    public AudioSource p;
    public AudioSource p7;
 AudioSource po;
    float rotationSpeed;
    void Start()
    {
        player = GetComponent<CharacterController>();
        animator = this.GetComponent<Animator>();
    }
    void Update()
    {
        if (player.isGrounded)
        {
            a2.enabled = true;
            Vector3 move = new Vector3(moveLR, 0, moveFB);
            move = transform.rotation * move;
            if (b == true)
            {
                animator.SetFloat("X", Input.GetAxis("Vertical") * speed);
                animator.SetFloat("Y", Input.GetAxis("Horizontal") * speed);
                player.Move(move * Time.deltaTime);
                moveFB = Input.GetAxis("Vertical") * speed;
                moveLR = Input.GetAxis("Horizontal") * speed;
                rotX = Input.GetAxis("Mouse X") * sen;
                rotY = Input.GetAxis("Mouse Y") * sen;
                y += rotY;
                y1 += rotX;
                transform.Rotate(0, rotX, 0);
                if (y >= -100 && y <= 100)
                {
                    rb.rotation = Quaternion.Euler(-y, y1, 0);
                }

                if (Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("d") || Input.GetKey("a"))
                {
                    a1.enabled = true;
                }
                else
                {
                    a1.enabled = false;
                }
                if (Input.GetKey(KeyCode.Space)||Input.GetKeyDown(KeyCode.Space))
                {
                    a4.enabled = true;
                    animator.SetBool("d", true);

                }
                else
                {
                    a4.enabled = false;
                    animator.SetBool("d", false);
                }
                if ( Input.GetKey(KeyCode.LeftShift))
                {
                    speed = 4;
                    animator.SetBool("d1", true);
                        a3.enabled = true;
                    if (h == true)
                    {
                        p7.enabled = true;
                    }
                }
                else
                {
                    p7.enabled = false;
                        a3.enabled = false;
                    speed = 2;
                    animator.SetBool("d1", false);
                }

                Vector3 move1 = new Vector3(moveLR, 0, moveFB);

                move1 = rb1.transform.rotation * move1;

                if (Input.GetKey("u"))
                {
                    move1 = move;
                    rb1.Move(-move1 * Time.deltaTime);
                }
                if (Input.GetKey("y"))
                {


                    move1 = move;
                    rb1.Move(move1 * Time.deltaTime);


                }
                if (Input.GetKeyDown("."))
                {
                    if (s1 < 1)
                    {
                        Vector3 position = rb.position;
                        position.y += d1;
                        rb.position = position;
                        s1 += d1;
                        s2 += d1;
                    }
                }
                if (Input.GetKeyDown(","))
                {
                    if (s2 > -2)
                    {
                        Vector3 position = rb.position;
                        position.y += d2;
                        rb.position = position;
                        s2 += d2;
                        s1 += d2;
                    }
                }
            }
            if (Input.GetKey(KeyCode.LeftControl) && !Input.GetKey("w") && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.Space))
            {
                animator.SetBool("d3", true);
                a.enabled = (true);

                b = false;
            }
            else
            {
                animator.SetBool("d3", false);
                b = true;
                a.enabled = (false);

            }

        }
        else
        {
            position2.y -= 10;

        }

    }
      
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "fo") 
           
        {
            h = true;
        }
  

       else  if(other.gameObject.tag == "ho")
        {
            h = false;
            p7.enabled = false;
        }


    }


    }


