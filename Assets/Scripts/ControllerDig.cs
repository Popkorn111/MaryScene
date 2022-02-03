using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControllerDig : MonoBehaviour
{
    public string[] Sentences;
    private int Index = 0;
    public float DialogueSpeed;
    public TextMeshProUGUI DialogueText;

  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            NextSentece();

        }
    }

      void NextSentece()
      {
          if(Index <= Sentences.Length - 1)
          {
              DialogueText.text = "";
              StartCoroutine(WriteSentence());
          }
      }

      IEnumerator WriteSentence()
      {
          foreach(char Character in Sentences[Index].ToCharArray())
          {
              DialogueText.text += Character;
              yield return new WaitForSeconds(DialogueSpeed);
          }
         Index++;
      }

}