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

    public Text lineNameR;
    public Image lineImageR;

    private int random;

    private int[] line;

    private bool correctL;

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

    void Rand()
    {
        for(int i = 0; i < 3; i++)
        {
            random = Random.Range(1, 7);

            lineName[i].text = lineStage1[random].name;

            Debug.Log(lineStage1[random].name);
        }
        
        random = Random.Range(1,4);

        lineNameR.text = lineName[random].text;
    }

    void Chose1()
    {
        if(lineNameR.text == lineName[0].text)
        {
            correctL = true;
        }
    }

    void Chose2()
    {
        if(lineNameR.text == lineName[1].text)
        {
            correctL = true;
        }
    }

    void Chose3()
    {
        if(lineNameR.text == lineName[2].text)
        {
            correctL = true;
        }
    }

}
