using System.Collections;

using UnityEngine;

public class Dialogpoclavishe : MonoBehaviour
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
        if (Input.GetKeyDown("1"))
        {
            anim.SetTrigger("hero");
        }
        
    }


    void OnMouseDown ()
    {
        
        
    }
}
