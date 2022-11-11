using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrol : MonoBehaviour
{
    public GameObject patlama;
    OyunKontrol oyunKontrolScripti;

     void Start()
    {
        oyunKontrolScripti = GameObject.Find("_Scripts").GetComponent<OyunKontrol>();
    }

    void OnMouseDown()
    {
       GameObject go = Instantiate(patlama, transform.position,transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.317f);
        oyunKontrolScripti.BalonEkle();
    }
}
