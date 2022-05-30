//Reaching goal

// Sebasti�n Gonz�lez Villacorta
// A01029746
// Karla Valeria Mondrag�n Rosas
// A01025108

// 13/05/2022

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LevelGoalPlay : MonoBehaviour
{

    public static event Action GoalReachedPlay; //Mostrar pantalla level passed con este evento
    //public static bool levelPassed;

    private void Start()
    {
        //levelPassed = false;
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("Player"))
        {
            //endMessage.text = "GOAL REACHED!!";
            GoalReachedPlay?.Invoke();
            //levelPassed = true;
            //Invoke("ChangeScene", 1);
        }


    }

    //void ChangeScene()
    //{
    //    SceneManager.LoadScene("WinScene");
    //}
}
