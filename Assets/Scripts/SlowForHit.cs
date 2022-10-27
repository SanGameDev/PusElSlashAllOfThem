using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowForHit : MonoBehaviour
{
    
    public bool paint = false;
    public GameObject screen;

    public LinesSo[] lineStage1;

    public LinesSo[] lineStage2;

    public Text[] lineName;
    public Image[] lineImage;

    private int random;

    private int[] line;

    // Update is called once per frame
    void Update()
    {
        if(paint == true){
            screen.SetActive(true);
        }else
        {
            screen.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Time.timeScale = .2f;
            paint = true;
            Rand();
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Time.timeScale = 1f;
            paint = false;
        }
    }

    void LineChek()
    {
        for(int i = 0; i < 3; i++)
        {

        }
    }

    void Rand()
    {
        for(int i = 0; i < 3; i++)
        {
            random = Random.Range(1, 7);
            line[i] = random;
        }
        
    }
}
