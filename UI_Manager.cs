using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 *This script will be used in Main Menu Scene, So this script must be empty value on the others Scene
 * if there is a value please Insert Null or make it empty on this script
 */
public class UI_Manager : MonoBehaviour
{

    public GameObject Stage_UI;
    public GameObject Chapter_UI;

    public void UCH()
    {
        Chapter_UI.SetActive(false);
        Stage_UI.SetActive(true);
    }
    public void BackWard()
    {
        Chapter_UI.SetActive(true);
        Stage_UI.SetActive(false);
    }
    public void MENU_ACTION_GotoNextSTAGE(string SceneName)//Type the Scene Name In INSPECTOR WINDOW
    {
        Application.LoadLevel(SceneName);
    }
    public void ButtonDebug()
    {
        Debug.Log("Button Works");
    }
    public void MenuClicked()
    {
        Application.LoadLevel("WorkingOnit");
    }
}
