using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    public Animator wk;
    
   
   
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        
        

       float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 vector = transform.forward * vertical + transform.right * horizontal;
        vector.y=0;
        wk.SetFloat("vertical",vector.magnitude);



        if(vector.magnitude>0.1f)
        {
            if(Input.GetButtonDown("left shift"))
            wk.SetBool("run",true);
            if(Input.GetButtonUp("left shift"))
            wk.SetBool("run",false);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(vector), 3 * Time.deltaTime);
        }



        if(Input.GetKeyDown("s"))
        wk.SetBool("back",true);
        else
        wk.SetBool("back",false);



        bool jp=Input.GetKeyDown("space");
        if(jp==true)
        wk.SetBool("jump",true);
        else
        {
            wk.SetBool("jump",false);
        }



        bool pn=Input.GetButtonDown("Fire1");
        if(pn==true)
        wk.SetBool("punch",true);
        else
        {
            wk.SetBool("punch",false);
        }



        bool kk=Input.GetKeyDown("q");
        if(kk==true)
        wk.SetBool("kick",true);
        else
        {
            wk.SetBool("kick",false);
        }
        


        if(Input.GetKey("r"))
        {
            wk.SetBool("combat",true);
        }
        


        if(Input.GetKey("t"))
        {
            wk.SetBool("combat",false);
        }



        bool dg = Input.GetKeyDown("e");
        if(dg==true)
        wk.SetBool("dodge",true);
        else
        wk.SetBool("dodge",false);
        
        
        
       
    }
    
}
