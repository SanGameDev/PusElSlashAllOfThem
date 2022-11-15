using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Colicion

public class SlowForHit : MonoBehaviour
{
    
    public bool paint = false;
    public GameObject screen;
    public GameObject loseScreen;
    private int[] linepuntos = new int[3];

    public bool stage1;
    public bool stage2;

    public LinesSo[] lineStage1;

    public LinesSo[] lineStage2;

    public FloatSo puntos;

    public ShopSo shop;

    //public Text[] lineName;
    public Image[] lineImage;
    
    //public Text lineNameR;
    public Image lineImageR;

    private int random;

    private int[] line;

    private bool correctL = false;

    private bool chose = false;

    public TMP_Text puntosActualesT;

    public int puntosActuales;

    public int playerVel;

    void Start()
    {
        Time.timeScale = 1.0f;

        playerVel = 10;
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
                //Time.timeScale = 0.3f;
                playerVel = 4;
            }else
            {
                //Time.timeScale = 0.4f;
                playerVel = 5;
            }


            if(puntosActuales <= 25)
            {
                stage1 = true;
                stage2 = false;
            }
            else if(puntosActuales >= 26)
            {
                stage1 = false;
                stage2 = true;
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
                //Time.timeScale = 0.0f;
                playerVel = 0;
                loseScreen.SetActive(true);
            }
            if(correctL == true || shop.buyAvility2 == true)
            {
                //Time.timeScale = 1f;
                playerVel = 10;
                Destroy(col.gameObject);
                chose = false;
                if(correctL == false)
                {
                    shop.buyAvility2 = false;
                }
                puntosActualesT.text = "Puntos: " + puntosActuales.ToString();
            }
        }
    }

    void Rand()
    {
        for(int i = 0; i < 3; i++)
        {
            random = Random.Range(0, 9);

            if(stage1 == true)
            {
                lineImage[i].sprite = lineStage1[random].Artwork;

                linepuntos[i] = lineStage1[random].points;
            }

            //lineName[i].text = lineStage1[random].name;
            
            if(stage2 == true)
            {
                lineImage[i].sprite = lineStage2[random].Artwork;

                linepuntos[i] = lineStage2[random].points;
            }

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
            puntos.Save();
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
            puntos.Save();
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
            puntos.Save();
        }
    }

}
