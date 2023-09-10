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

    public void Activate()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");

        //take the instantiated location and adjust the transform
        SetCoords();

    }

    switch (this.name)
    {
        case "geni": this.getComponent<SpriteRenderer>().sprite = geni; break;
        case "evo_geni": this.getComponent<SpriteRenderer>().sprite = evo_geni; break;
        case "king_geni": this.getComponent<SpriteRenderer>().sprite = king_geni; break;

        case "banyu": this.getComponent<SpriteRenderer>().sprite = banyu; break;
        case "evo_banyu": this.getComponent<SpriteRenderer>().sprite = evo_banyu; break;
        case "king_banyu": this.getComponent<SpriteRenderer>().sprite = king_banyu; break;
    }

    public void SetCoords()
    {
        float x = xBoard;
        float y = yBoard;

        x *= 0.66f; 
        y *= 0.66f; 

        x += -2.3f;
        y += -2.3f;

        this.transform.position = new Vector3(x,y,-1.0f);
    }

}
