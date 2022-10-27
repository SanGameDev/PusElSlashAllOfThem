using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineChushing : MonoBehaviour
{

    public LinesSo[] lineStage1;

    public LinesSo[] lineStage2;

    public Text lineName;
    public Image lineImage;

    public int random;

    // Update is called once per frame
    void Update()
    {
        
    }

    void Rand()
    {
        random = Random.Range(1, 7);
    }
}
