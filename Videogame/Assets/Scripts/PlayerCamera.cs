//Alternate smooth camera script

// Sebasti�n Gonz�lez Villacorta
// A01029746
// Karla Valeria Mondrag�n Rosas
// A01025108

// 13/05/2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    [SerializeField] Vector3 minValues, maxValues;

    [Range(1, 10)]
    [SerializeField] float smoothFactor;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 boundPosition = new Vector3(
            Mathf.Clamp(targetPosition.x, minValues.x, maxValues.x),
            Mathf.Clamp(targetPosition.y, minValues.y, maxValues.y),
            Mathf.Clamp(targetPosition.z, minValues.z, maxValues.z));

        transform.position = boundPosition;
    }
}
