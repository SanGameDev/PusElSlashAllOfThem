using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Tooltip("A reference to the tile we want to spawn")]
    public Transform tile;

    [Tooltip("Where the first tile should be placed at")]
    public Vector3 startPoint = new Vector3(0, 0, 5);

    [Tooltip("How many tiles should we create in advance")]
    [Range(1, 15)]
    public int initSpawnNum = 10;

    [Header("Spawneo de obstaculos")]
    //despues de cuantos tiles aparecen los obtaculos
    public int timeToSpaw = 5;
    //cuantos tiles han pasado
    public int timePased = 0;
    
    public GameObject obstaculos;

    /// <summary> 
    /// Where the next tile should be spawned at. 
    /// </summary> 
    private Vector3 nextTileLocation;
    /// <summary> 
    /// How should the next tile be rotated? 
    /// </summary> 
    private Quaternion nextTileRotation;
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    
    private void Start()
    {
        // Set our starting point 
	    // Manage Rotation and Orientation
        nextTileLocation = startPoint;
        nextTileRotation = Quaternion.identity;
        for (int i = 0; i < initSpawnNum; ++i)
        {
            SpawnNextTile();
        }
    }

    /// <summary> 
    /// Will spawn a tile at a certain location and setup the next
    /// position 
    /// </summary> 
    public void SpawnNextTile()
    {
        var newTile = Instantiate(tile, nextTileLocation,
        nextTileRotation);
        
        // Figure out where and at what rotation we should spawn
        // the next item 
        var nextTile = newTile.Find("Next Spawn Point");
        nextTileLocation = nextTile.position;
        nextTileRotation = nextTile.rotation;

            timePased++;
        
        if (timePased >= timeToSpaw)
        {
            Instantiate(obstaculos, new Vector3(0, 1, nextTile.position.z + 15), obstaculos.transform.rotation, nextTile);
        }
        
    }
}
