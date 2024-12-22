using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Text Mytext;
    public Text Mybuttontext;
    private int flag=0; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Mybuttontext.text = "Activate this Text";
        Mytext.text = "distivate Text";
        Mytext.color = Color.gray;

    }

    // Update is called once per frame
    void Update()
    {
    }
    public void isonclick()
    {
        if (flag == 0)
        {
            Mybuttontext.text = "Disactivate this Text";
            Mytext.text = "You activate this Text";
            flag = 1;
            Mytext.color = Color.green;
        }
        else
        {
            Mybuttontext.text = "Activate this Text";
            Mytext.text = "You distivate this Text";
            flag = 0;
            Mytext.color = Color.gray;
        }

    }
   
}
