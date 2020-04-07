using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class give_velocity : MonoBehaviour
{
    // Start is called before the first frame update

        public bool start = false;
        public Rigidbody rb;
        public float force;
        public Button bt;




    // Update is called once per frame
    void Update()
    {
     
        if (Input.GetButtonDown("Jump"))
        {
            start = true;
        }


          if (Input.GetButtonDown("Cancel"))
        {
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);

        }

        if(Input.GetKeyDown(KeyCode.Alpha1)){
             SceneManager.LoadScene("Scene 1");
         }

          if(Input.GetKeyDown(KeyCode.Alpha2)){
             SceneManager.LoadScene("Scene 2");
         }

          if(Input.GetKeyDown(KeyCode.Alpha3)){
             SceneManager.LoadScene("Scene");
         }



        if (start)
        {
            rb.AddForce(transform.right * -force);

            start = false;
        }


    
    }




}
