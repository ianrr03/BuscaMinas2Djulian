using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casilla : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnMouseDown()
    //{
    //    if (!estaRevelada)
    //    {
    //        estaRevelada = true;
    //        GetComponent<SpriteRenderer>().sprite
    //    }
    //}

    private void RevelarCasillasAlrededor()
    {
        for (int i = 1; i<= 1;  i++)
            for (int j = -1; j<= 1; j++)
            {
                int fila =(int) (transform.position.x + i);
                int columna = (int) (transform.position.y + j);
            }
    }//ReveladorCasillasAlrededor
}//Casilla
