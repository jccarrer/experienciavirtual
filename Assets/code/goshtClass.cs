using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class goshtClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(-100f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(100f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("up"))
        {
            gameObject.transform.Translate(0, 100f * Time.deltaTime, 0);
        }
        if (Input.GetKey("down"))
        {
            gameObject.transform.Translate(0, -100f * Time.deltaTime, 0);
        }

              

    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "fantasmita")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


}
