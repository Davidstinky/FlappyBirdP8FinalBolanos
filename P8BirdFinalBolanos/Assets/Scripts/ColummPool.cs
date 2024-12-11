using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColummPool : MonoBehaviour
{

    public int colummPoolSize = 5;
    public GameObject colummPrefab;
    public float spawnRate = 4f;
    public float colummMin = -1f;
    public float colummMax = 3.5f;

    private GameObject[] columms;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;
    private float spawnXPosition = 10f;
    private int currentColumm = 0;


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
        timeSinceLastSpawned += Time.deltaTime;

        if (GameControl.instance.gameOver == false && timeSinceLastSpawned > spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range(colummMin, colummMax);
            columms [currentColumm].transform.position = new Vector2 (spawnXPosition, spawnYPosition);
            currentColumm++;   
            if (currentColumm >= colummPoolSize)
            {
                currentColumm = 0;
            }
        }
    }
}
