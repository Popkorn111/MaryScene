using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Task : MonoBehaviour
{
    public bool EndDialog;
    private bool QuestFinished = false;
    public GameObject Dialog1;
    public GameObject Dialog2;
    public Quest_Event QE;
    public bool Fin_Dialog;
    private bool onHide;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1") && QuestFinished)
        {
            Dialog1.SetActive(false);
            Dialog2.SetActive(true);
        }
        
        if (EndDialog == true)
        {
            Time.timeScale = 1;
            QE.Quest1 = true;
            Dialog1.SetActive (false);
            EndDialog = false;
        }
        else if (QE.end_Quest1 == true)
        {
            Fin_Dialog = true;
            QE.end_Quest1 = false;
        }
        else if (Fin_Dialog == true)
        {
            Time.timeScale = 1;
            QE.Quest1 = false;
            Dialog1.SetActive (false);
        }
        
    }
    
    
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "MainCamera")
        {
            if (Fin_Dialog == false)
            {
                Time.timeScale = 0;
                if (QE.end_Quest1 == false)
                    Dialog1.SetActive(true);
            }
            else
                QuestFinished = true;
        } 
    }
}
