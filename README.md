# :collision: Marching Squares Algoritmasi Ile Sekil Cizim Programi: :collision:


## Bu projemde Marching Squares Algoritmasi ile her bir ayarini degistirebildigimiz bir sekil ciziyoruz. :fire:

## :point_right: Resime Tıklayarak Videoya gidebilirsiniz.
[![IMAGE ALT TEXT HERE]([https://img.youtube.com/vi/q89COaqWfaI&ab_channel=FurkanY/0.jpg](https://github.com/FurcanY/HyperCasual-ShopSystem/assets/114299899/09906c54-ee53-4ab4-9384-0c05e38705d0))](https://www.youtube.com/watch?v=q89COaqWfaI&ab_channel=FurkanY)

## Marching Squares Algoritmasındaki çizim durumlarını gösteren bir resim.
<img src="https://github.com/FurcanY/HyperCasual-ShopSystem/assets/114299899/03cfb93a-fd64-4a29-b966-213b006ea8fc"  width="720" height="500"  />




### :exclamation: ["Algoritma Dökümanım" İçin Tıklayınız.](https://github.com/FurcanY/MarchingSquares/blob/master/MarchingSquares/MarchingSquares/Document/MarchingSquaresAlgoritmasi.pdf)
### :exclamation: [Marching Squares Algoritması bilgi için tıklayınız(1).](https://www.baeldung.com/cs/marching-squares)
### :exclamation: [Marching Squares Algoritması bilgi için tıklayınız(2).](https://urbanspr1nter.github.io/marchingsquares/)


![Projeici goruntu 1](https://github.com/FurcanY/HyperCasual-ShopSystem/assets/114299899/2c15d14d-6036-47ac-9d94-d2f4ab489941)
![Projeici goruntu 2](https://github.com/FurcanY/HyperCasual-ShopSystem/assets/114299899/2082b46f-c6f1-40d3-b9ea-6111be754011)

### :star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2:
### Sıklık Oranı : Çizilen Şekilde ne kadar boşluk olacağını ayarlar. Bu oranı 100 yaparsak hiçbir şekilde boşluk kalmaz.
### Baslangic Noktasi X ve Baslangic Noktasi Y : bu koordinatlar çizimin nereden başlayacağını ayarlar. 0,0 noktasi formun sol üst köşesi olacaktır.
### Noktalar Arasi Uzaklik : Marching Squares Algoritmasinda çizim yapabilmek için noktalara başvurulur. ( [Algoritma Dökümanı İçin Tıklayınız.](https://github.com/FurcanY/MarchingSquares/blob/master/MarchingSquares/MarchingSquares/Document/MarchingSquaresAlgoritmasi.pdf) ). Bu noktaların arasındakı uzaklığı ayarlayan değişkendir.
### Y Ekseni Nokta Sayısı : Y Ekseninde toplam kaç tane nokta olduğunu tutan değişkendir.
### X Ekseni Nokta Sayısı : X Ekseninde toplam kaç tane nokta olduğunu tutan değişkendir.
### :star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2::star2:

![Projeici goruntu 3](https://github.com/FurcanY/HyperCasual-ShopSystem/assets/114299899/08567fb9-746c-4fd3-a82f-b75e5b8a15e2)



### :star: Bu projeyi yapmamdaki nedenlerim :exclamation:
#### :point_right: Marching Squares Algoritmasını Kavramak ve ilerde Unity Oyun Motoru ile yapacağım oyunlara entegre etmek. (Bir oyunda her seferinde benzersiz mağara oluşturmak için kullanılabilir.)
#### :point_right: Dinamik olarak kullanıcıdan girilen değere göre dizininboyutunu ayarlamayı öğrenmek.
#### :point_right: C# Form'da çizim yapmayı kartezyen koordinatımı oluşturarak yapmak


## Proje İçinden Örnek Kodlar 💾

## :dash: Form1.CS içerisinden oluştur buttonuna basıldığında işlenen kodlar:
      private void button1_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            panel1.Dock = DockStyle.Right;

            listBox1.Items.Clear();
            Terrain = new int[yEkseniNoktaSayisi, xEkseniNoktaSayisi];
            for (int i = 0; i < yEkseniNoktaSayisi; i++)
            {
                for (int j = 0; j < xEkseniNoktaSayisi; j++)
                {
                    Random rnd = new Random();
                    if(rnd.Next(0, 100) < Oran)
                    {
                        Terrain[i, j] = 1;
                    }
                    else
                    {
                        Terrain[i, j] = 0;
                    }
                    


                    listBox1.Items.Add(Terrain[i, j]);
                }
                listBox1.Items.Add("---------");

            }

            for (i = 0; i < yEkseniNoktaSayisi - 1; i++)
            {
                for (j = 0; j < xEkseniNoktaSayisi - 1; j++)
                {
                    int durum = DurumHesapla(Terrain[i + 1, j], Terrain[i + 1, j + 1], Terrain[i, j + 1], Terrain[i, j]);
                    CizimYap(durum);
                }
            }
        }
## :dash: Form1.CS çizim yapmaya yarayan fonksiyonun içerisinden case3'e kadar kodları:

    void CizimYap(int durum)
        {
            Pen pen1 = new Pen(kalemRengi, kalemKalinligi);
            Graphics grakik = CreateGraphics();
            switch (durum)
            {
                case 0:
                    {


                    }
                    break;
                case 1:
                    {
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokY, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik, (j * noktaUzaklik) + baslangicNokY);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik, (j * noktaUzaklik) + baslangicNokY, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik, (j * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik, (j * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokY);

                    }
                    break;
                case 2:
                    {
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik, (j * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik, (j * noktaUzaklik) + baslangicNokY + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik, (j * noktaUzaklik) + baslangicNokY + noktaUzaklik, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokY + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik, (j * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokY + noktaUzaklik);
                    }
                    break;
                case 3:
                    {
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokY, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokY + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokY + noktaUzaklik, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik, (j * noktaUzaklik) + baslangicNokY + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik, (j * noktaUzaklik) + baslangicNokY + noktaUzaklik, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik, (j * noktaUzaklik) + baslangicNokY);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik, (j * noktaUzaklik) + baslangicNokY, (i * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokY);

                    }
                    break;
                
        
        
   ## ✴️ Belki Bakarsın Diye Bırakıyorum ✴️
   ####  GitHub adresime [buradan](https://github.com/FurcanY) ulaşabilirsiniz.
   ####  İnstagram adresime [buradan](https://www.instagram.com/y.furcan/) ulaşabilirsiniz.
   ####  Youtube adresime [buradan](https://www.youtube.com/channel/UCQRXjt0lg2jCnp2NqOAO2Ig) ulaşabilirsiniz.
