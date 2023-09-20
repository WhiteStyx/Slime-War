using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController33 : MonoBehaviour
{
    int count = 0;
    [SerializeField]private float speed;
    //public Transform LubangE; // Ubah nama variabel dari LubangA1 menjadi LubangE
    public Transform[] Lubang; // Ubah nama variabel dari LubangB1 menjadi LubangF

    private bool isASelected = false;
    private bool isBSelected = false;
    GameObject Something;

    void Start()
    {
        for(int i = 1; i < collider.Length; i++)
        {
            collider[i].enabled = false;
        }
    }


    
    [SerializeField]private Collider2D[] collider;
    void OnMouseDown()
    {
        count++;

        if (count == 1)
        {
            for(int i = 1; i < collider.Length; i++)
            {
                collider[i].enabled = true;
            }

            if (transform.GetChild(0).gameObject != null) {
                Something = transform.GetChild(0).gameObject;
                collider[0].enabled = false;
                }
            
        }

        Debug.Log(Something);
       
        if(Something != null && count > 1)
        {
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Debug.Log(clickPosition);
            Debug.Log(Lubang[1].transform.localPosition);

            

            for(int i = 0; i < Lubang.Length; i++)
            {
                if(Vector2.Distance(clickPosition, Lubang[i].transform.localPosition) < 2.0f)
                {
                    Something.transform.parent = Lubang[i].transform;
                    Something.transform.localPosition = Vector3.zero;
                }
            }
        }
    }
            
}

