using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowForHit : MonoBehaviour
{
    
    public bool paint = false;
    public GameObject screen;
    public GameObject loseScreen;
    private int[] linepuntos = new int[3];

    public LinesSo[] lineStage1;

    public LinesSo[] lineStage2;

    public FloatSo puntos;

    public ShopSo shop;

    public Text[] lineName;
    public Image[] lineImage;
    
    public Text lineNameR;
    public Image lineImageR;

    private int random;

    private int[] line;

    private bool correctL = false;

    private bool chose = false;

    public Text puntosActualesT;

    private int puntosActuales;

    void Start()
    {
        Time.timeScale = 1.0f;
    }

    void Update()
    {
        if(paint == true){
            screen.SetActive(true);
        }
        else
        {
            screen.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            if(shop.buyAvility1 == true)
            {
                Time.timeScale = 0.3f;
            }else
            {
                Time.timeScale = 0.4f;
            }
            paint = true;
            Rand();
        }
        correctL = false;
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            paint = false;
            if(correctL == false && shop.buyAvility2 != true)
            {
                Time.timeScale = 0.0f;
                loseScreen.SetActive(true);
            }
            if(correctL == true || shop.buyAvility2 == true)
            {
                Time.timeScale = 1f;
                Destroy(col.gameObject);
                chose = false;
                if(correctL == false)
                {
                    shop.buyAvility2 = false;
                }
                puntosActualesT.text = puntosActuales.ToString();
            }
        }
    }

    void Rand()
    {
        for(int i = 0; i < 3; i++)
        {
            random = Random.Range(0, 9);

            //lineName[i].text = lineStage1[random].name;
            lineImage[i].sprite = lineStage1[random].Artwork;

            linepuntos[i] = lineStage1[random].points;

        }
        
        random = Random.Range(0,3);

        //lineNameR.text = lineName[random].text;
        lineImageR.sprite = lineImage[random].sprite;
    }

    public void Chose1()
    {
        if(lineImageR.sprite == lineImage[0].sprite && chose == false)
        {
            chose = true;
            correctL = true;
            puntos.Value += linepuntos[0];
            puntosActuales += linepuntos[0];
        }
    }

    public void Chose2()
    {
        if(lineImageR.sprite == lineImage[1].sprite && chose == false)
        {
            chose = true;
            correctL = true;
            puntos.Value += linepuntos[1];
            puntosActuales += linepuntos[1];
        }
    }

    public void Chose3()
    {
        if(lineImageR.sprite == lineImage[2].sprite && chose == false)
        {
            chose = true;
            correctL = true;
            puntos.Value += linepuntos[2];
            puntosActuales += linepuntos[2];
        }
    }

}
