using System;

public class SinirAglari
{
    public int girisBoyutu = 35;
    public int gizliBoyut = 10;
    public int cikisBoyutu = 5;

    public double[,] agirlikGizli;
    public double[,] agirlikCikis;
    private Random rnd = new Random();
    List<(double[] input, double[] target)> egitimData = new List<(double[], double[])>();

    public SinirAglari()
    {
        EgitimVerileriniHazirla();
        agirlikGizli = RastgeleAgirlikOlustur(gizliBoyut, girisBoyutu);
        agirlikCikis = RastgeleAgirlikOlustur(cikisBoyutu, gizliBoyut);
    }

    private double[,] RastgeleAgirlikOlustur(int satir, int sutun)
    {
        double[,] matris = new double[satir, sutun];
        for (int i = 0; i < satir; i++)
            for (int j = 0; j < sutun; j++)
                matris[i, j] = rnd.NextDouble() * 2 - 1;
        return matris;
    }

    private double[] Sigmoid(double[] vektor)
    {
        double[] sonuc = new double[vektor.Length];
        for (int i = 0; i < vektor.Length; i++)
            sonuc[i] = 1.0 / (1.0 + Math.Exp(-vektor[i]));
        return sonuc;
    }

    private double[] Carpim(double[,] matris, double[] vektor)
    {
        int satir = matris.GetLength(0);
        int sutun = matris.GetLength(1);
        double[] sonuc = new double[satir];
        for (int i = 0; i < satir; i++)
            for (int j = 0; j < sutun; j++)
                sonuc[i] += matris[i, j] * vektor[j];
        return sonuc;
    }

    private double[,] AğırlıkGüncelle(double[,] agirliklar, double oran, double[] hata, double[] cikislar)
    {
        int satir = agirliklar.GetLength(0);
        int sutun = agirliklar.GetLength(1);
        for (int i = 0; i < satir; i++)
            for (int j = 0; j < sutun; j++)
                agirliklar[i, j] += oran * hata[i] * cikislar[j];
        return agirliklar;
    }

    private double[] CiktiHatasi(double[] hedef, double[] cikti)
    {
        double[] hata = new double[cikti.Length];
        for (int i = 0; i < cikti.Length; i++)
            hata[i] = (hedef[i] - cikti[i]) * cikti[i] * (1 - cikti[i]);
        return hata;
    }

    private double[] GizliHatasi(double[,] agirliklarCikis, double[] ciktiHatasi, double[] gizliCikti)
    {
        int gizliBoyut = gizliCikti.Length;
        double[] hata = new double[gizliBoyut];
        for (int i = 0; i < gizliBoyut; i++)
        {
            for (int j = 0; j < ciktiHatasi.Length; j++)
                hata[i] += ciktiHatasi[j] * agirliklarCikis[j, i];
            hata[i] *= gizliCikti[i] * (1 - gizliCikti[i]);
        }
        return hata;
    }

    public void Egit(double hataOrani, int iterasyonSayisi)
    {
        for (int iterasyon = 0; iterasyon < iterasyonSayisi; iterasyon++)
        {
            foreach (var (input, hedef) in egitimData)
            {
                var gizli = Sigmoid(Carpim(agirlikGizli, input));
                var cikti = Sigmoid(Carpim(agirlikCikis, gizli));

                var ciktiHata = CiktiHatasi(hedef, cikti);
                var gizliHata = GizliHatasi(agirlikCikis, ciktiHata, gizli);

                agirlikCikis = AğırlıkGüncelle(agirlikCikis, hataOrani, ciktiHata, gizli);
                agirlikGizli = AğırlıkGüncelle(agirlikGizli, hataOrani, gizliHata, input);
            }
        }
    }

    public double[] Tahmin(double[] giris)
    {
        double[] gizli = Sigmoid(Carpim(agirlikGizli, giris));
        double[] cikti = Sigmoid(Carpim(agirlikCikis, gizli));
        return cikti;
    }

    public double[] MatrisiDuzlestir(int[,] mat)
    {
        int rows = mat.GetLength(0);
        int cols = mat.GetLength(1);
        double[] flat = new double[rows * cols];
        for (int y = 0; y < rows; y++)
            for (int x = 0; x < cols; x++)
                flat[y * cols + x] = mat[y, x];
        return flat;
    }

    public double[] OneHotVector(int index, int uzunluk)
    {
        double[] vec = new double[uzunluk];
        vec[index] = 1.0;
        return vec;
    }

    private void EgitimVerileriniHazirla()
    {
        var harfler = new List<(int[,], int)> {
            (new int[7,5] {{0,0,1,0,0},{0,1,0,1,0},{1,0,0,0,1},{1,0,0,0,1},{1,1,1,1,1},{1,0,0,0,1},{1,0,0,0,1}}, 0),
            (new int[7,5] {{1,1,1,1,0},{1,0,0,0,1},{1,0,0,0,1},{1,1,1,1,0},{1,0,0,0,1},{1,0,0,0,1},{1,1,1,1,0}}, 1),
            (new int[7,5] {{0,1,1,1,1},{1,0,0,0,0},{1,0,0,0,0},{1,0,0,0,0},{1,0,0,0,0},{1,0,0,0,0},{0,1,1,1,1}}, 2),
            (new int[7,5] {{1,1,1,1,0},{1,0,0,0,1},{1,0,0,0,1},{1,0,0,0,1},{1,0,0,0,1},{1,0,0,0,1},{1,1,1,1,0}}, 3),
            (new int[7,5] {{1,1,1,1,1},{1,0,0,0,0},{1,0,0,0,0},{1,1,1,1,0},{1,0,0,0,0},{1,0,0,0,0},{1,1,1,1,1}}, 4)
        };

        foreach (var (matris, index) in harfler)
            egitimData.Add((MatrisiDuzlestir(matris), OneHotVector(index, cikisBoyutu)));
    }
}
