using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Yarn.Unity;
using System;

public class Yarncommandscripts : MonoBehaviour
{
    public Material BlueMat, MagentaMat, GoldMat;

    public GameObject Cylinder;

    public InMemoryVariableStorage yarnInMemoryStorage;

    public TMP_Text feedbackText;
    // Start is called before the first frame update
    void Start()
    {
        feedbackText.text = "";
        Cylinder.GetComponent<MeshRenderer>().material = BlueMat;
    }
    [YarnCommand("Material_Selector")]
    public void MaterialSelector()
    {
        string colourToSet;
        yarnInMemoryStorage.TryGetValue("$colourToSet", out colourToSet);
        Debug.Log(colourToSet);
        if(colourToSet == "Gold")
        {
            Cylinder.GetComponent<MeshRenderer>().material = GoldMat;
        }
        if(colourToSet == "Magenta")
        {
            Cylinder.GetComponent<MeshRenderer>().material = MagentaMat;
        }
    }
    [YarnCommand("Text_Setter")]
    public void TextSetter()
    {
        string Sass;
        yarnInMemoryStorage.TryGetValue("$Sass", out Sass);
        feedbackText.text = Sass + ("Sass");
    }
       

}
