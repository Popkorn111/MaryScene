using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubText : MonoBehaviour
{

    public string[] textSubtitle;

    public Text subtext;
    public float NextText;
    public int endVoice;
    private float timer;
    private int i;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        subtext.text = textSubtitle[i];
        timer += 1 * Time.deltaTime;
        if (timer >= NextText)
        {
            i += 1;
            timer = 0;
        }
        
    }
}
