//Trigger doors using f and g keys

// Sebasti�n Gonz�lez Villacorta
// A01029746
// Karla Valeria Mondrag�n Rosas
// A01025108

// 13/05/2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private DoorSetActive door;
 
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            door.OpenDoor();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            door.CloseDoor();
        }
    }
}
