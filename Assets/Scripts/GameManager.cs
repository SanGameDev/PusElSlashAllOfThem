using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform tile;
    public Vector3 startPoint = new Vector3(0, 0, 5);
    [Range(1, 15)]
    public int initSpawnNum = 10;
    [Header("Spawneo de obstaculos")]
    public int timeToSpaw = 5;
    public int timePased = 0;
    
    public GameObject obstaculos;

    private Vector3 nextTileLocation;
    private Quaternion nextTileRotation;

    private Vector3 obstaculeAlt;

    
    private void Start()
    {
        nextTileLocation = startPoint;
        nextTileRotation = Quaternion.identity;
        for (int i = 0; i < initSpawnNum; ++i)
        {
            SpawnNextTile();
        }
    }

    public void SpawnNextTile()
    {
        var newTile = Instantiate(tile, nextTileLocation, nextTileRotation);
        
        var nextTile = newTile.Find("Next Spawn Point");
        nextTileLocation = nextTile.position;
        nextTileRotation = nextTile.rotation;

            timePased++;
        
        float ran = Random.Range(-1.5f, 1.5f);
        
        if (timePased >= timeToSpaw)
        {
            Instantiate(obstaculos, new Vector3(ran, nextTile.position.y, nextTile.position.z), obstaculos.transform.rotation, nextTile);
        }
        
    }
}
