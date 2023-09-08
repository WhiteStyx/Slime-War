using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chessman : MonoBehaviour
{
    // References
    public GameObject controller;
    public GameObject movePlate;

    // Positions
    private int xBoard = -1;
    private int yBoard = -1;

    // variabel to keep track of merah biru
    private string player;

    // References for all the sprites that the chesspiece can be
    public Sprite geni, evo_geni, king_geni;
    public Sprite banyu, evo_banyu,king_banyu;

}
