using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    
    public ShopSo shopSo;
    public FloatSo puntos;

    public GameObject buy1;
    public GameObject buy2;

    public Text monedas;

    void Start()
    {
        monedas.text = puntos.Value.ToString();
        if(shopSo.buyAvility1 == true)
        {
            buy1.SetActive(false);
        }
        if(shopSo.buyAvility2 == true)
        {
            buy2.SetActive(false);
        }
    }

    public void buyAv1()
    {
        if(shopSo.buyAvility1 == false && puntos.Value >= 25)
        {
            shopSo.buyAvility1 = true;
            puntos.Value -= 25;
            monedas.text = puntos.Value.ToString();
            buy1.SetActive(false);
        }

    }

    public void buyAv2()
    {
        if(shopSo.buyAvility2 == false && puntos.Value >= 30)
        {
            shopSo.buyAvility2 = true;
            puntos.Value -= 30;
            monedas.text = puntos.Value.ToString();
            buy2.SetActive(false);
        }
        
    }

}
