using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Objects : MonoBehaviour
{
   [SerializeField]
    private TextMeshProUGUI descriptionText;

    protected int age = 0;
    new protected string name = "object";
    protected string description = "object description";


    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            ShowDescriptionText();
        }

    }

    public void ShowDescriptionText()
    {
        descriptionText.text = $"name: {name}\nage: {age}\n\ndesc: {description}";
    }
  
}
