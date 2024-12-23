using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class NewEmptyCSharpScript : MonoBehaviour
{
    private Color ObjectColor = Color.HSVToRGB(0,0,0);
    private byte red = 0;
    public void OnCollisionEnter(Collision collision)
    {
        ObjectColor = this.GetComponent<Renderer>().material.color;
        this.GetComponent<Renderer>().material.color = ObjectColor = Color.HSVToRGB(ObjectColor.g, ObjectColor.b, red++);
    }
    public void OnCollisionStay(Collision collision)
    {
        if(red<255)
            this.GetComponent<Renderer>().material.color = ObjectColor = Color.HSVToRGB(ObjectColor.g, ObjectColor.b, red++);
        else
            this.GetComponent<Renderer>().material.color = ObjectColor = Color.HSVToRGB(ObjectColor.g++, ObjectColor.b++, ObjectColor.r);
    }
    public void OnCollisionExit(Collision collision)
    {
        if (red != 0)
        {
            NewMonoBehaviourScript.listOfStable.Add(this.GameObject());
        }
        red = 0;
    }
}
