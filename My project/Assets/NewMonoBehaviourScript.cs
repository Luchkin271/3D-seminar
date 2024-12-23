using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Text Mytext;
    public Text Mybuttontext;
    private int flag = 0;
    private int x1 = 0;
    private int x2 = 0;
    static public List<GameObject> listOfStable;
    public GameObject Mycube1;
    public GameObject Mycube2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Mybuttontext.text = "Activate this Text";
        Mytext.text = "distivate Text";
        Mytext.color = Color.gray;

    }

    // Update is called once per frame
    void UpdateFixed()
    {
        
        foreach (var item in listOfStable)
        {
            float g = (item.GetComponent<Renderer>().material.color.g);
            float b = (item.GetComponent<Renderer>().material.color.b);
            float r = (item.GetComponent<Renderer>().material.color.r);
            item.GetComponent<Renderer>().material.color = Color.HSVToRGB(r<255?g:g==0?g:g-1, r < 255 ? b : b == 0 ? b : b - 1, r--);
            if (r < 1) 
                listOfStable.Remove(item);
        }
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
