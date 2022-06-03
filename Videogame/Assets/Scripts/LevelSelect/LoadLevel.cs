/*
 Script to Read File of level and Instantiate the block into the scene

 Sebasti�n Gonz�lez Villacorta - A01029746
 Karla Valeria Mondrag�n Rosas - A01025108
 Andre�na Isable San�nez Rico - A01024927

 26/05/2022
 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


[System.Serializable]

public class LoadLevel : MonoBehaviour
{
    //Array of blocks available to build the level
    public GameObject[] availableBlocks;

    MakerBlock[] blocks;

    //private string levelStringAndre = "15,-3,-16,0<15,-30,2,0<15,-31,2,0<15,-10,-19,0<15,-8,-21,0<14,-9,-20,0<15,1,-12,0<15,-1,-10,0<14,-19,-10,0<14,-14,-9,0<15,-15,-9,0<14,-9,2,0<14,-1,2,0<14,-5,2,0<15,-21,-6,0<16,-22,-5,0<14,-25,-6,0<15,-9,-11,0<15,2,-15,0<14,-4,-16,0<14,3,-14,0<14,6,-14,0<14,0,-11,0<14,-5,-11,0<14,-16,-18,0<14,-24,-18,0<15,-25,-18,0<15,-17,-18,0<15,-18,-23,0<15,-20,-23,0<15,-24,-23,0<14,-25,-23,0<14,-21,-23,0<14,4,-23,0<14,-12,-23,0<15,-10,-23,0<15,-9,-23,0<15,-11,-23,0<15,3,-23,0<15,2,-23,0<15,-29,-12,0<15,-31,-10,0<15,-30,-11,0<15,-27,1,0<15,-29,2,0<15,-28,2,0<15,3,2,0<15,2,2,0<15,1,2,0<3,5,3,0<0,6,1,0<0,5,1,0<0,4,1,0<0,3,1,0<0,2,1,0<0,1,1,0<0,-1,1,0<0,-3,1,0<0,-5,1,0<0,-7,1,0<0,-9,1,0<0,-13,3,0<0,-12,3,0<0,-14,3,0<0,-17,2,0<0,-18,2,0<0,-19,2,0<0,-20,2,0<0,-21,2,0<1,-21,-15.47008,0<1,-21,-17.48501,0<6,-19,-22,0<0,-5,-13,0<0,-4,-13,0<0,-3,-13,0<0,-2,-13,0<0,-1,-13,0<0,0,-13,0<0,1,-13,0<1,-29.01006,-22.48212,0<1,-26.99507,-20.46691,0<1,-26.99487,-22.48212,0<0,-22,-8,0<0,-23,-8,0<0,-24,-8,0<0,-25,-8,0<2,-23.48236,-5.405538,0<0,-23,-7,0<0,-21,-7,0<0,-22,-7,0<0,-24,-7,0<0,-25,-7,0<0,-26,-7,0<1,-12,-17.485,0<13,-1,-23,0<13,-1,-22,0<13,-1,-21,0<9,5,-21,0<10,-33,-9,0<0,-31,-11,0<0,-32,-10,0<0,-34,-13,0<0,-33,-13,0<0,-32,-13,0<0,-31,-13,0<0,-29,-13,0<0,-30,-13,0<0,-30,-12,0<0,-33,-12,0<0,-34,-12,0<0,-31,-12,0<0,-32,-12,0<0,-32,-11,0<0,-33,-11,0<0,-34,-11,0<0,-33,-10,0<0,-34,-10,0<12,-3,-23,0<12,-3,-22,0<12,-3,-21,0<12,-3,-20,0<0,-2,-19,0<0,-1,-19,0<0,-1,-18,0<0,-2,-18,0<0,-1,-20,0<0,-2,-20,0<0,-3,-19,0<0,-3,-18,0<0,-4,-18,0<0,0,-18,0<0,0,-19,0<0,0,-20,0<0,2,-20,0<0,1,-18,0<0,1,-19,0<0,1,-20,0<0,2,-19,0<0,2,-18,0<0,3,-18,0<0,3,-19,0<0,4,-18,0<0,5,-18,0<0,6,-18,0<9,-33,3,0<0,-24,0,0<0,-25,0,0<0,-27,0,0<0,-26,0,0<0,-28,0,0<0,-29,0,0<0,-30,0,0<0,-31,0,0<0,-32,0,0<0,-33,0,0<0,-34,0,0<0,-28,1,0<0,-29,1,0<0,-30,1,0<0,-32,1,0<0,-31,1,0<0,-33,1,0<0,-34,1,0<2,-0.5478317,-15.40551,0<2,4.057749,-13.40552,0<0,-4,-17,0<0,-3,-17,0<1,-3,-7.470078,0<1,-3,-9.485005,0<5,-3,-9,0<0,-1,-12,0<0,0,-12,0<0,-2,-12,0<0,-3,-12,0<0,-4,-12,0<0,-5,-12,0<0,-1,-11,0<0,-2,-11,0<0,-3,-11,0<0,-4,-11,0<0,-2,-17,0<0,-1,-17,0<0,6,-17,0<0,4,-17,0<0,5,-17,0<0,3,-17,0<0,2,-17,0<0,0,-17,0<0,1,-17,0<0,2,-16,0<0,6,-16,0<0,5,-16,0<0,4,-16,0<0,3,-16,0<0,3,-15,0<0,4,-15,0<0,5,-15,0<0,6,-15,0<8,-12,-7,0<8,-15,-22,0<0,-8,-23,0<0,-8,-22,0<0,-9,-22,0<0,-9,-21,0<0,-10,-21,0<0,-10,-20,0<0,-11,-20,0<0,-11,-19,0<0,-12,-19,0<0,-13,-19,0<0,-14,-19,0<0,-15,-19,0<0,-16,-19,0<0,-18,-20,0<11,-17,-9,0<13,-17,-23,0<13,-17,-22,0<13,-17,-21,0<13,-17,-20,0<0,-17,-19,0<0,-15,-12,0<0,-18,-12,0<0,-17,-12,0<0,-16,-12,0<0,-14,-12,0<0,-13,-12,0<0,-11,-13,0<0,-12,-12,0<0,-10,-13,0<0,-9,-13,0<0,-8,-13,0<0,-11,-12,0<0,-9,-12,0<0,-10,-12,0<0,-10,-11,0<0,-12,-11,0<0,-11,-11,0<0,-13,-11,0<0,-14,-11,0<0,-15,-11,0<0,-16,-11,0<0,-17,-11,0<0,-18,-11,0<0,-19,-11,0<0,-11,-10,0<0,-12,-10,0<0,-13,-10,0<0,-14,-10,0<0,-15,-10,0<0,-16,-10,0<0,-17,-10,0<0,-18,-10,0<0,-18,-19,0<0,-19,-19,0<0,-19,-20,0<0,-21,-21,0<0,-22,-21,0<0,-23,-21,0<0,-20,-20,0<0,-20,-19,0<0,-21,-19,0<0,-21,-20,0<0,-22,-20,0<0,-23,-20,0<0,-24,-20,0<0,-22,-19,0<0,-23,-19,0<0,-24,-19,0<0,-25,-19,0<";
    //private string levelTest = "11,-27,-23,0<13,-23,-20,0<13,-23,-21,0<13,-23,-22,0<13,-23,-23,0<";
    //Load level on Start
    void Start()
    {
        OnLoadAlt(PlayerPrefs.GetString("levelString"));
        //OnLoadAlt(levelStringAndre);
    } 
    //Function to load elements from string into the level
    public void OnLoadAlt(string levelString)
    {
        string[] blocks = levelString.Split('<');

        for (int i = 0; i < blocks.Length - 1; i++)
        {
            string[] finalblock = blocks[i].Split(',');
            Instantiate(
                availableBlocks[int.Parse(finalblock[0])],
                new Vector3(
                    float.Parse(finalblock[1]),
                    float.Parse(finalblock[2]),
                    float.Parse(finalblock[3])), Quaternion.identity);
        }
    }

    //Destroys all game objects in the scene
    void Clean()
    {
        blocks = GameObject.FindObjectsOfType<MakerBlock>();
        foreach (var i in blocks)
        {
            Destroy(i.gameObject);
        }
    }

}
