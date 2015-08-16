using UnityEngine;
using System.Collections;

public class New : MonoBehaviour {

    float startTime;

   Animator Anim;

	// Use this for initialization
	void Start () {

        Anim = GetComponent<Animator>();
        Anim.SetBool("Hit", false);
	}
	
	// Update is called once per frame
	void Update () {
        
        
        
        Anim.SetBool("Hit", false);
        if (Input.GetMouseButtonDown(1))
        {

            Anim.SetBool("Hit", true);
           // StartCoroutine(MyCoroutine());
        
        }

        if (Input.GetMouseButtonUp(1))
        {

      
            Anim.SetBool("Hit", false);
            // StartCoroutine(MyCoroutine());

        }
        


	}
    //IEnumerator MyCoroutine()
    //{
        

    //   yield WaitForSeconds(0.8f);    //Wait one frame
    //    Anim.SetBool("Hit", false);
    //    return 0;
        
    //}
}
