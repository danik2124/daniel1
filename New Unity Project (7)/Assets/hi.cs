using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hi : MonoBehaviour
{
     
    public Transform rb;
    private Transform player;
    private Animator animator;
    float yRot;
    float y;
    bool ga = false;
    float yRot1;
    float y1;
    float y12;
    bool b=true;
    public AudioSource a;
     float rotationSpeed;
    float speed;
    public Rigidbody R;

    // Use this for initialization
    void Start()
    {
        player = this.transform;
        animator = this.GetComponent<Animator>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (b == true) { 
        Vector3 objPos;
        objPos = transform.position;
        yRot = Input.GetAxis("Mouse X") * 5;
        y += yRot;
        if (Input.GetKey("i"))
        {
            y1 += -1;
            if (y1 > -45 && y1 < 45) {

                rb.localRotation = Quaternion.Euler(y1, 0, 0);

            }
        }
        if (Input.GetKey("k"))
        {
            y1 += +1;
            if (y1 > -45 && y1 < 45)
            {
                rb.localRotation = Quaternion.Euler(y1, 0, 0);

            }

        }
        if (Input.GetKey("l"))
        {
            y12 += +1;
            if (y12 > -45 && y1 < 45)
            {
                rb.localRotation = Quaternion.Euler(0, y12, 0);

            }

        }
        if (Input.GetKey("j"))
        {
            y12 += -1;
            if (y12 > -45 && y1 < 45)
            {
                rb.localRotation = Quaternion.Euler(0, y12, 0);

            }

        }
            if (y > -90&&y< 180 + 80)
            {
                player.localRotation = Quaternion.Euler(0, y, 0);
            }
            
        

        if (Input.GetKey("w"))
        {


                if (y > 180-25 && y < 180+25)
                {
                    objPos.z += -0.1f;
                    player.position = objPos;
                    animator.SetBool("d", true);
                }

                    if (y < 45-25 && y > -45+25)
            {
                objPos.z += 0.1f;
                player.position = objPos;
                animator.SetBool("d", true);

            }
            


                if (y > 45+25 && y < 135-25)
            {

                objPos.x += 0.1f;
                player.position = objPos;
                animator.SetBool("d", true);
                   

            }

            else if (y > -135+25 && y < -45-25)
            {

                objPos.x += -0.1f;
                player.position = objPos;
                animator.SetBool("d", true);

            }
                if (y < 45 + 25 &&y> 45 - 25)
                {

                      objPos.x += +0.1f;
                     objPos.z += +0.1f;

                    player.position = objPos;
                    animator.SetBool("d", true);
                }
                if (y > -45 - 25 && y < -45 + 25)
                {
                   objPos.x += -0.1f;
                    objPos.z += +0.1f;
                    player.position = objPos ;
                    animator.SetBool("d", true);
                }
                if (y > 135 - 25 && y < 135 + 25)
                {

                    objPos.x += +0.1f;
                    objPos.z += -0.1f;

                    player.position = objPos;
                    animator.SetBool("d", true);
                }
                if (y > 180 + 25 && y < 180 + 100)
                {
                    objPos.x += -0.1f;
                    objPos.z += -0.1f;
                    player.position = objPos;
                    animator.SetBool("d", true);
                }
            }

        else
        {
            animator.SetBool("d", false);

        }
   
     

        if (Input.GetKey(KeyCode.LeftShift))
        {
                if (y > 180 - 25 && y < 180 + 25)
                {
                    objPos.z += -0.2f;
                    player.position = objPos;
                    animator.SetBool("d1", true);
                }


                if (y > -45 - 25 && y < -45 + 25)
                {
                    objPos.x += -0.2f;
                    objPos.z += +0.2f;
                    player.position = objPos;
                    animator.SetBool("d1", true);
                }
                if (y > 135 - 25 && y < 135 + 25)
                {

                    objPos.x += +0.2f;
                    objPos.z += -0.2f;

                    player.position = objPos;
                    animator.SetBool("d1", true);
                }
                if (y > 180 + 25 && y < 180 + 100)
                {
                    objPos.x += -0.2f;
                    objPos.z += -0.2f;
                    player.position = objPos;
                    animator.SetBool("d1", true);
                }



                if (y < 45 && y > -45)
            {
                objPos.z += 0.2f;
                player.position = objPos;
                animator.SetBool("d1", true);
            }
            if (y > 135 && y < -135)
            {
                objPos.z += -0.2f;
                player.position = objPos;
                animator.SetBool("d1", true);

            }

            if (y > 45 && y < 135)
            {

                objPos.x += 0.2f;
                player.position = objPos;
                animator.SetBool("d1", true);


            }

            else if (y > -135 && y < -45)
            {

                objPos.x += -0.2f;
                player.position = objPos;
                animator.SetBool("d1", true);

            }
        }

        else
        {
            animator.SetBool("d1", false);


        }
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("d3", true);

        }
        else
        {
            animator.SetBool("d3", false);
        }
            if (Input.GetKey("s")){
                if (y < 45 && y > -45)
                {
                    objPos.z += -0.1f;
                    player.position = objPos;
                    animator.SetBool("d5", true);

                }

                if (y > 45 && y < 135)
                {
                    objPos.x += -0.1f;
                    player.position = objPos;
                    animator.SetBool("d5", true);

                }

               else if (y < -45 && y >-135)
                {
                    objPos.x += +0.1f;
                    player.position = objPos;
                    animator.SetBool("d5", true);

                }
                if (y < 45 && y > -45)
                {
                    objPos.z += -0.1f;
                    player.position = objPos;
                    animator.SetBool("d5", true);

                }

                if (y > 45 && y < 135)
                {
                    objPos.x += -0.1f;
                    player.position = objPos;
                    animator.SetBool("d5", true);

                }

                else if (y < -45 && y > -135)
                {
                    objPos.x += +0.1f;
                    player.position = objPos;
                    animator.SetBool("d5", true);

                }
                if (y > -45 - 25 && y < -45 + 25)
                {
                    objPos.x += +0.1f;
                    objPos.z += -0.1f;
                    player.position = objPos;
                    animator.SetBool("d5", true);
                }
                if (y > 135 - 25 && y < 135 + 25)
                {

                    objPos.x += -0.1f;
                    objPos.z += +0.1f;

                    player.position = objPos;
                    animator.SetBool("d5", true);
                }
                if (y > 180 + 25 && y < 180 + 100)
                {
                    objPos.x += +0.1f;
                    objPos.z += +0.1f;
                    player.position = objPos;
                    animator.SetBool("d5", true);
                }
                if (y < 45 + 25 && y > 45 - 25)
                {

                    objPos.x += -0.1f;
                    objPos.z += -0.1f;

                    player.position = objPos;
                    animator.SetBool("d5", true);
                }
                if (y > 180 - 25 && y < 180 + 25)
                {
                    objPos.z += +0.1f;
                    player.position = objPos;
                    animator.SetBool("d5", true);
                }

            }
            else
            {
                animator.SetBool("d5", false);
            }




        }
        
        if (Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("d4", true);
            a.enabled=(true);
            b = false;

        }
        else
        {
            animator.SetBool("d4", false);
            b = true;
            a.enabled = (false);
        }
      
        
        
            //  if (Input.GetKey(KeyCode.DownArrow))
            //  {
            //     if (Input.GetKey(KeyCode.LeftArrow))
            //    { RotateAndmove(90); }
            //    else if (Input.GetKey(KeyCode.RightArrow))
            //   { RotateAndmove(0); }
            //   else
            //   {
            ///       RotateAndmove(45);
            //   }
            //   }

            //  else if (Input.GetKey(KeyCode.LeftArrow))
            // { RotateAndmove(135); }
            // // else if (Input.GetKey(KeyCode.RightArrow))
            // // { RotateAndmove(-45); }
            //  else
            // {
            // animator.SetBool("walking", false);
            //}
            // }
        }
    void OnCollisionEnter(Collision d)
    {

        if (d.collider.tag == "fo")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }

    }
}

