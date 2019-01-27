using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour {

    public float x_start, y_start;
    public int columLength, rowLength;
    public float x_space, y_space;
    public GameObject prefab;

	// Use this for initialization
	void Start () {
		for(int i = 0; i < columLength * rowLength; i++)
        {
            Instantiate(prefab, new Vector3(x_start +( x_space * (i % columLength)),y_start+ (-y_space * (i / columLength))), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
