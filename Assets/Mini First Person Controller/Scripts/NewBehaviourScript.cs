using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Object1;
   
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
            Debug.Log("in place");
            //Object1.SetActive(true);
            //{
            Vector3 vec = new Vector3(-0.209999993f, 0.0399999991f, 19.0100002f);
            Object1.transform.position = vec;
            //}
            
        }

    }
}
