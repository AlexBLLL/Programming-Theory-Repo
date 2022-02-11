using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public abstract class Objects : MonoBehaviour
{
    [SerializeField]
    protected TextMeshProUGUI descriptionText;

    protected int m_age = 0;
    protected string m_name = "object";
    protected string m_description = "object description";

    protected int age
    {
        get { return m_age; } 
        set
        {
            if (value < 0.0f)
            {

                Debug.LogError("You can't set a negative age");

            }
            else
            {
                m_age = value; // original setter now in if/else statement
            }
        } 
    }
    new protected string name
    {
    get { return m_name; } // getter returns backing field
set
{ m_name = value; } // setter uses backing field
}
 
    protected string description
        {
    get { return m_description; } // getter returns backing field
set
{ m_description = value; } // setter uses backing field
}


    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            ShowDescriptionText();
        }

    }

    protected abstract void ShowDescriptionText();


}
