/*
 Reaching Level Goal functionality in Play Mode

 Sebasti�n Gonz�lez Villacorta - A01029746
 Karla Valeria Mondrag�n Rosas - A01025108
 Andre�na Isable San�nez Rico - A01024927

 24/05/2022
 
 */

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LevelGoalPlay : MonoBehaviour
{

    //Event to be triggered when Goal is Reached
    public static event Action GoalReachedPlay;

    //If Player enters Goal Portal Invoke 
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("Player"))
        {
            GoalReachedPlay?.Invoke();
        }
    }
}
