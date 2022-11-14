using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{
    
    public ShopSo shopSo;
    public FloatSo puntos;

    public GameObject buy1;
    public GameObject buy2;

    public TMP_Text monedas;
    public float monedas_;

    void Start()
    {
        monedas_ = puntos.Value;
        if(shopSo.buyAvility1 == true)
        {
            buy1.SetActive(false);
        }
        if(shopSo.buyAvility2 == true)
        {
            buy2.SetActive(false);
        }
        monedas.text = "$: " + monedas_.ToString();
    }

    public void buyAv1()
    {
        if(shopSo.buyAvility1 == false && puntos.Value >= 25)
        {
            shopSo.buyAvility1 = true;
            puntos.Value -= 25;
            monedas_ = puntos.Value;
            buy1.SetActive(false);
        }
        monedas.text = "$: " + monedas_.ToString();
    }

    public void buyAv2()
    {
        if(shopSo.buyAvility2 == false && puntos.Value >= 30)
        {
            shopSo.buyAvility2 = true;
            puntos.Value -= 30;
            monedas_ = puntos.Value;
            buy2.SetActive(false);
        }
        monedas.text = "$: " + monedas_.ToString();
    }

}
