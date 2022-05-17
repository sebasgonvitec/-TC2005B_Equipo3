//Open and Close door functions

// Sebasti�n Gonz�lez Villacorta
// A01029746
// Karla Valeria Mondrag�n Rosas
// A01025108

// 13/05/2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSetActive : MonoBehaviour
{

    public void OpenDoor()
    {
        gameObject.SetActive(false);
    }

    public void CloseDoor()
    {
        gameObject.SetActive(true);
    }
}

    
