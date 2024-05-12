using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class HideAndUnhideButtons : MonoBehaviour
{
    public GameObject[] buttons;
    public TextMeshProUGUI textMesh;
    private Man man = new Man();
    private Woman woman = new Woman();
    private string textForTMP ;

    public void Hide(String buttonName)
    {
        foreach(GameObject button in buttons)
        {
            button.SetActive(false);
        }
        if(buttonName == "manmonday") textForTMP = (man.MondayGenerateWorkoutProgram());
        if (buttonName == "manwendsday") textForTMP = (man.WendsdayGenerateWorkoutProgram());
        if (buttonName == "manfriday") textForTMP = (man.FridayGenerateWorkoutProgram());

        if (buttonName == "womanmonday") textForTMP = (woman.MondayGenerateWorkoutProgram());
        if (buttonName == "womanwendsday") textForTMP = (woman.WendsdayGenerateWorkoutProgram());
        if (buttonName == "womanfriday") textForTMP = (woman.FridayGenerateWorkoutProgram());
        textMesh.text = textForTMP;
    }
    public void UnHide(GameObject[] buttons)
    {
        foreach (GameObject button in buttons)
        {
            button.SetActive(true);
        }
    }
    
}
