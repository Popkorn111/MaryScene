using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog_Next : MonoBehaviour
{
	public GameObject Text1;
	public GameObject Text2;
	public GameObject Text3;
	private bool isText1 = true;
	private int state = 0;
	public NPC_Task npc_taskScript;
	public bool Fin_Dialog;
	public GameObject ObjectQuest;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown("1"))
		{
			// if (isText1 == true)
			// {
			// 	isText1 = false;
			// }
			if (state == 0)
			{
				state = 1;
			}
			else if (state == 1)
            {
				state = 2;
			}
			else if (state == 2)
			{
				state = 3;
			}
			else if (state == 3)
			{
				

			}
			
        }
		// if (isText1 == true)
		if (state == 0)
		{
			Text1.SetActive(true);
			Text2.SetActive(false);
			Text3.SetActive(false);
		
		}
		else if (state == 1)
		{
			Text1.SetActive(false);
			Text2.SetActive(true);
			Text3.SetActive(false);
			
		}
		else if (state == 2)
		{
			Text1.SetActive(false);
			Text2.SetActive(false);
			Text3.SetActive(true);
		
		}
		else if (state == 3)
		{
			npc_taskScript.EndDialog = true;
				ObjectQuest.SetActive (true);
		}
	}
	
}