using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColummPool : MonoBehaviour
{

    public int colummPoolSize = 5;
    public GameObject colummPrefab;
    public float spawnRate = 4f;

    private GameObject[] columms;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;


    // Start is called before the first frame update
    void Start()
    {
        columms = new GameObject[colummPoolSize];
        for (int i = 0; i < colummPoolSize; i++)
        {
            columms[i] = (GameObject)Instantiate (colummPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
