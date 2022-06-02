/*
 Script to read name of level from input field

 Sebasti�n Gonz�lez Villacorta - A01029746
 Karla Valeria Mondrag�n Rosas - A01025108
 Andre�na Isable San�nez Rico - A01024927

 26/05/2022
 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadLevelName : MonoBehaviour
{
    public string levelName;

    public void ReadStringInput(string s) 
    {
        levelName = s;
        //Debug.Log(levelName);
    }

    public string GetLevelName()
    {
        return levelName;
    }
}
