using System;
using TMPro;
using UnityEngine;

public class KarakterKontrol : MonoBehaviour
{
    // Ad Soyad: Yusuf Zengin
    // Öğrenci Numarası: 232011045


    //+ Soru 1: Karakteri yön tuşları ile hareket ettiren kodu, HareketEt fonksiyonu içerisine yazınız.
    //+ Soru 2: Karakterin zıplamasını sağlaması beklenen Zipla metodu doğru bir şekilde çalışmıyor, koddaki hatayı düzeltin.
    //+ Soru 3: Karakterin 'Engel' tag'ine sahip objeye temas ettiğinde metin objesine "Oyun Bitti!" yazısını yazdırınız.
    //+ Soru 4: Karakterin 'Puan' tag'ine sahip objeye temas ettiğinde skoru 1 arttırınız ve metin objesine yazdırınız.

    // Not: Engel ve Puan nesnelerinin isTrigger özelliği aktiftir.


    public TMP_Text metin;
    private Rigidbody2D karakterRb;

    public float hiz = 5f;
    public float ziplamaGucu = 5f;

    public int skor = 0;

    void Start()
    {
        karakterRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Yazdığınız metodları çağırınız.
        HareketEt();
        Zipla();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Soru 3 ve soru 4 burada çözülecek.
        if (other.gameObject.CompareTag("Puan"))
        {
            skor += 1;
            Destroy(other.gameObject);
            metin.text = "score: " + skor;
        }

        if (other.gameObject.CompareTag("Engel"))
        {
            metin.text="Oyun Bitti!"
            Destroy(other.gameObject);

        }
    }
    void HareketEt()
    {
        if (Input.GetKey(KeyCode.A))
        {
            karakterRb.AddForce(UnityEngine.Vector2.left * (hiz * Time.deltaTime));

        }
        if (Input.GetKey(KeyCode.D))
        {
            karakterRb.AddForce(UnityEngine.Vector2.right * (hiz * Time.deltaTime));
        }
    }
    void Zipla()
    {
        // Space tuşuna basınca karakter zıplamalı ancak aşağıdaki kod hatalı.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
           karakterRb.AddForce(UnityEngine.Vector2.up * (ziplamaGucu * Time.deltaTime));
        }
    }
}