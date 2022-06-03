/*
 Reaching Portal Goal in Maker Mode
 *Almost useless now*

 Sebasti�n Gonz�lez Villacorta - A01029746
 Karla Valeria Mondrag�n Rosas - A01025108
 Andre�na Isable San�nez Rico - A01024927

 26/05/2022
 
 */

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LevelGoal : MonoBehaviour
{
    [SerializeField] Text endMessage;

    public static event Action GoalReached;

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("Player"))
        {
            GoalReached?.Invoke();     
        }


    }
}