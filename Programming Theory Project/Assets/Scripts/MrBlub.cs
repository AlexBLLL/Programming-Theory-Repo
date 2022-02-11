using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrBlub : Objects
{

    protected override void ShowDescriptionText()
    {
        name = "Mr. Blub";
        age = 67;
        description = "he like bread";

        descriptionText.text = $"name: {name}\nage: {age}\n\ndesc: {description}";
    }

}

