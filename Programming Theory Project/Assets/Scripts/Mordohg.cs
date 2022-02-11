using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mordohg : Objects
{
    protected override void ShowDescriptionText()
    {
        name = "Mordohg, the eye of the oblivion";
        
        description = "he is the beginning and end. the alpha and the omega. he is";

        descriptionText.text = $"name: {name}\n\nage: age of the universe \n\ndesc: {description}";
    }

}
