using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robert : Objects
{
    
    protected override void ShowDescriptionText()
    {
        name = "Robert";
        age = 47;
        description = "funny guy";

        descriptionText.text = $"name: {name}\nage: {age}\n\ndesc: {description}";
    }

}

