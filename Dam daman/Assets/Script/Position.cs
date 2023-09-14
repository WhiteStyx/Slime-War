using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    public GameObject controller;

    private int xBoard = -1;
    private int yBoard = -1;
    
    public GameObject banyu, geni;

    public void Activate()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");

    }
}
