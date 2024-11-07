using System;
using TMPro;
using UnityEngine;

public class KarakterKontrol : MonoBehaviour
{
    // Ad Soyad: 
    // Öğrenci Numarası: 


    // Soru 1: Karakteri yön tuşları ile hareket ettiren kodu, HareketEt fonksiyonu içerisine yazınız.
    // Soru 2: Karakterin zıplamasını sağlaması beklenen Zipla metodu doğru bir şekilde çalışmıyor, koddaki hatayı düzeltin.
    // Soru 3: Karakterin 'Engel' tag'ine sahip objeye temas ettiğinde metin objesine "Oyun Bitti!" yazısını yazdırınız.
    // Soru 4: Karakterin 'Puan' tag'ine sahip objeye temas ettiğinde skoru 1 arttırınız ve metin objesine yazdırınız.

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
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Soru 3 ve soru 4 burada çözülecek.
    }

    void Zipla()
    {
        // Space tuşuna basınca karakter zıplamalı ancak aşağıdaki kod hatalı.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 ziplamaYonu = new Vector3(UnityEngine.Random.Range(-1f, 1f), 1, UnityEngine.Random.Range(-1f, 1f));
            karakterRb.AddForce(ziplamaYonu * (ziplamaGucu / 2), ForceMode2D.Impulse);
        }
    }
}