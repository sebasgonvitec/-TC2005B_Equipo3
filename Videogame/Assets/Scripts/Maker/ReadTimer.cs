/*
 Script to read time of level from input field

 Sebasti�n Gonz�lez Villacorta - A01029746
 Karla Valeria Mondrag�n Rosas - A01025108
 Andre�na Isable San�nez Rico - A01024927

 26/05/2022
 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadTimer : MonoBehaviour
{

    public static float input;
    public static int inputInt;

    public void ReadStringInput(string s) 
    {
        input = float.Parse(s);
        //Debug.Log(input);
        inputInt = int.Parse(s);
    }
}
