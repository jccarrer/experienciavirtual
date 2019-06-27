using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caballeroController : MonoBehaviour
{

    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crounch = false;
    // Start is called before the first frame update
    //void Start()
    //{
    //    
    //}
    //
    // Update is called once per frame
    void Update()
    {


        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));


        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(-10f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(10f * Time.deltaTime, 0, 0);
            //transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("up"))
        {
            jump = true;
            transform.Translate(Vector3.up * 11 * Time.deltaTime, Space.World);
            //gameObject.transform.Translate(0, 10f * Time.deltaTime, 0);
        }
        if (Input.GetKey("down"))
        {
            gameObject.transform.Translate(0, -10f * Time.deltaTime, 0);
        }
    }
}
