using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject piece;
    public GameObject bomb;

    public int height, width, nunbombas;
    public GameObject[][] map;

    public static Generate instance;

    public void Awake()
    {
        instance = this; 
    }

    // Start is called before the first frame update
    public void Start()
    {


        //Creamos un array con todos los elementos
        map = new GameObject[width][];
        for(int i = 0; i< map.Length; i++)
        {
            map[i] = new GameObject[height];
        }
    }

    public void GenerateBoard()
    {

    }
    
}
