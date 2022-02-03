using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog_Next2 : MonoBehaviour
{

	public GameObject Text1;
	public GameObject Text2;
	public GameObject Text3;
	public GameObject Text4;
	public GameObject Text5;
	private bool isText1 = true;
	private int state = 0;
	public NPC_Task2 npc_task2Script;
	public bool Fin_Dialog;
	public GameObject ObjectQuest;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown("2"))
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
				state = 4;
			}
            else if (state == 4)
            {
				state = 5;
			}
            else if (state == 5)
			{
				

			}
			
        }
		// if (isText1 == true)
		if (state == 0)
		{
			Text1.SetActive(true);
			Text2.SetActive(false);
			Text3.SetActive(false);
			Text4.SetActive(false);
			Text5.SetActive(false);

		}
		else if (state == 1)
		{
			Text1.SetActive(false);
			Text2.SetActive(true);
			Text3.SetActive(false);
			Text4.SetActive(false);
			Text5.SetActive(false);
		}
		else if (state == 2)
		{
			Text1.SetActive(false);
			Text2.SetActive(false);
			Text3.SetActive(true);
			Text4.SetActive(false);
			Text5.SetActive(false);
		}
		else if (state == 3)
			{
			Text1.SetActive(false);
			Text2.SetActive(false);
			Text3.SetActive(false);
			Text4.SetActive(true);
			Text5.SetActive(false);
		}
		else if (state == 4)
			{
			Text1.SetActive(false);
			Text2.SetActive(false);
			Text3.SetActive(false);
			Text4.SetActive(false);
			Text5.SetActive(true);
		}
		else if (state == 5)
		{
			npc_task2Script.EndDialog = true;
				ObjectQuest.SetActive (true);
		}
	}
	
}