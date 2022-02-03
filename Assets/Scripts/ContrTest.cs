using System.Collections;

using UnityEngine;

public class ContrTest : MonoBehaviour
{
    


        Animator mob_animator;


        IEnumerator Start()
    

        {
            mob_animator = GetComponent<Animator>();
           yield return new WaitForSeconds(3);
           mob_animator.SetTrigger("Walk");
        }
    
    public void Set_animator_int(int anim_ID)
    
    {
        mob_animator.SetInteger("Attack_INT", anim_ID);
    }
}
