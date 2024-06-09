﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public GameObject[] firstGroup;
    public GameObject[] secondGroup;
    public GameObject button2;
    public Activator button;
    public Material normal;
    public Material transparent;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Cube") || other.CompareTag("Player")){
            Debug.Log("Есть контакт!!!");
            foreach (GameObject first in firstGroup)
            {
                first.GetComponent<Renderer>().material = normal;
                first.GetComponent<Collider>().isTrigger = false;
            }
            foreach (GameObject second in secondGroup)
            {
                second.GetComponent<Renderer>().material = transparent;
                second.GetComponent<Collider>().isTrigger = true;
            }
            GetComponent<Renderer>().material = transparent;
            button.GetComponent<Renderer>().material = transparent;
            button2.GetComponent<Renderer>().material = normal;
        }

    }
}
