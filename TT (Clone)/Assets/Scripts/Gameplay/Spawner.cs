using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{   
    [SerializeField] private GameObject LittleCirclePrefab;

    private void Update() 
    {
        if(Input.GetMouseButtonDown(0)) //left click of the mouse
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        Instantiate(LittleCirclePrefab, transform.position, transform.rotation);
    }
}
