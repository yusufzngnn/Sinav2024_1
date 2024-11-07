using System;
using TMPro;
using UnityEngine;

public class KarakterKontrol : MonoBehaviour
{
    // Ad Soyad:Bayram Mesut Boyraz
    // Öğrenci Numarası:222011042 


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
        //Alttaki 1.Soru Cevabı
        void update()
        {
            public float hız = 5f;
            void Update ()
            {
                float yatay = Input.GetAxis("Horizontal");
                 float dikey = Input.GetAxis("Vertical");
                 Vector3 hareket = new Vector3(yatay, 0f, dikey);
                 transform.Translate(hareket * hız *Time.deltaTime);
            }
        }
        karakterRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Yazdığınız metodları çağırınız.
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Altatki 3.Soru Cevabı 
        public class GameOver : MonoBehaivour
        {
            public Text oyunBittiText;
            private void Start()
            {
                oyunBittiText.gameObject.setActive;
               private void OnCollisionEnter
               if(other).gameObject.CompareTag("Engel")
               {
                Debug.Log("Oyun Bitti");
                oyunBittiText.gameObject.SetActive;
               }
               
               //Alttaki 4.Soru Cevabı
               public int skor = 0;
               public text skorText;
               private void OnCollisionEnter
               if (other.gameObject.CompareTag) ("puan")
               Destroy(other.gameObject);
            }
        }
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