using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject2 : MonoBehaviour
{
    public Quest_Event QEvent ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "MainCamera")
        {
            QEvent.end_Quest1 = true;
            Destroy (gameObject);

        }
    }
}
