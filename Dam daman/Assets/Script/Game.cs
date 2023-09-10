using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject chesspiece;

    private GameObject[,] positions = new GameObjects[8, 8];

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(chesspiece, new Vector3(0, 0, -1), Quaternion.identity);
    }

    
}
