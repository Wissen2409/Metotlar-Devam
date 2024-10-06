
// c#da bir metot başka bir metodu çağırabilir. Bu çağırma da bir sınır yoktur.


using System.Collections;




#region Örnek : Bir metot içerisinden başka bir metodu çağırmak
/*DersleriGetir("2.Sınıf");

static ArrayList Hazirla(string ders)
{
    SortedList dersler = new SortedList();
    dersler.Add("1.Sınıf", new ArrayList() { "Türkçe", "Matematik" });
    dersler.Add("2.Sınıf", new ArrayList() { "Türkçe", "Matematik", "Fizik" });
    dersler.Add("3.Sınıf", new ArrayList() { "Türkçe", "Matematik", "Beden" });
    dersler.Add("9.Sınıf", new ArrayList() { "Türkçe", "Matematik", "Tarih" });

    ArrayList liste = (ArrayList)dersler[ders];
    return liste;
}
static void DersleriGetir(string ders)
{
    // bu metot hazirla metodunu çağırıyor, Hazirla metodu, geriye arraylist dönen bir metot,
    // aynı zamanda DersleriGetir metoduna gelen string parametreyi, Hazirla metoduna gönderdik
    ArrayList liste = Hazirla(ders);
    foreach (string s in liste){

        Console.WriteLine(s);
    }
}
*/

#endregion

#region Bir strig  içerisinde kaç tane rakam olduğunu bize söyleyen uygulama

RakamlariBul("bu örn2ekte, 3 üç tane r4k4m v4r");
static bool Rakammi(char value){

    return char.IsDigit(value);
}
static void RakamlariBul(string value){

    int rakamToplam = 0;
    for(int i =0;i<value.Length;i++){

        // başka bir metodu çağırdık!!!
        bool rakammi = Rakammi(value[i]);
        if(rakammi){
            rakamToplam++;
        }

    }
    Console.WriteLine("Girmiş olduğunuz metinde, {0} adet rakam vardır" ,rakamToplam);
}


#endregion





