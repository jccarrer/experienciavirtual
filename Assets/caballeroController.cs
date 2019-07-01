using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caballeroController : MonoBehaviour
{

    public Animator animator;

    
    // Start is called before the first frame update
    //void Start()
    //{
    //    
    //}
    //
    // Update is called once per frame
    void Update()
    {


        //horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        //animator.SetFloat("Speed", Mathf.Abs(horizontalMove));


        if (Input.GetKey("left"))
        {
            if (GetComponent<SpriteRenderer>().flipX == false)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            //transform.Translate(Vector3.up * 11 * Time.deltaTime, Space.World);
            GetComponent<Animator>().SetBool("correr", true);
            gameObject.transform.Translate(-10f * Time.deltaTime, 0, 0);
            
           
            
        }

        if (Input.GetKey("right"))
        {
            if (GetComponent<SpriteRenderer>().flipX==true){
                GetComponent<SpriteRenderer> ().flipX = false;
            }
            GetComponent<Animator>().SetBool("correr", true);
            gameObject.transform.Translate(10f * Time.deltaTime, 0, 0);
            
            //transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("up"))
        {
            transform.Translate(Vector3.up * 15 * Time.deltaTime, Space.World);
            //gameObject.transform.Translate(0, 10f * Time.deltaTime, 0);
        }
        if (Input.GetKey("down"))
        {
            gameObject.transform.Translate(0, -10f * Time.deltaTime, 0);
        }


        if (Input.GetKeyUp("left")|| Input.GetKeyUp("right"))
        {
            GetComponent<Animator>().SetBool("correr", false);
        }







    }
}
