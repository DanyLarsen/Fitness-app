using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ChangeScenes : MonoBehaviour
{
    public HideAndUnhideButtons hideAndUnhideButtons; // Reference to the HideAndUnhideButtons script
    public TextMeshProUGUI textMesh;
    public void MoveChangeScene(int sceneID)
    {
        Debug.Log("HITME");
        SceneManager.LoadScene(sceneID);
    }

    public void ChangeSceneWithVar(int sceneID)
    {
        // Check if any button is active
        bool anyButtonActive = false;
        foreach (GameObject button in hideAndUnhideButtons.buttons)
        {
            if (button.activeSelf)
            {
                anyButtonActive = true;
                break;
            }
        }

        if (anyButtonActive)
        {
            Debug.Log("HITME");
            SceneManager.LoadScene(sceneID);
        }
        else
        {
            // Activate all buttons if none are active
            textMesh.text = "";
            foreach (GameObject button in hideAndUnhideButtons.buttons)
            {
                button.SetActive(true);
            }
        }
    }
}