using System.Collections;

using UnityEngine;

public class Dialoggropclav : MonoBehaviour
{
     public Animator anim;
   
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("2"))
        {
            anim.SetTrigger("Trololo");
        }
        
    }


    void OnMouseDown ()
    {
        
        
    }
}