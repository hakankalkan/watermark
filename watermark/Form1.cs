using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace watermark
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public static string yol;
        public static string yolSifreli;
        public static int width;
        public static int height;
        public static int widthSifreli;
        public static int heightSifreli;
        public static Bitmap bmp;
        public static Bitmap rbmp;
        public static Bitmap gbmp;
        public static Bitmap bbmp;
        public static Bitmap bmpSifreli;
        public static Bitmap rbmpSifreli;
        public static Bitmap gbmpSifreli;
        public static Bitmap bbmpSifreli;
        public static string[] redBinary = new string[width * height * 8];
        public static string[] greenBinary = new string[width * height * 8];
        public static string[] blueBinary = new string[width * height * 8];
        public static string[] redBinarySifreli = new string[width * height * 8];
        public static string[] greenBinarySifreli = new string[width * height * 8];
        public static string[] blueBinarySifreli = new string[width * height * 8];
        public static string binStr = "";
        public static string bytes;
        public static int sayi;
        public static string binStrSifreli = "";
        public static string bytesSifreli;
        public static int sayiSifreli;
        public void resimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog resimSec = new OpenFileDialog();
            resimSec.Filter = "|*.bmp|All Files|*.*";
            if (resimSec.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            pictureBox1.ImageLocation = resimSec.FileName;
            yol = resimSec.FileName;
            bmp = new Bitmap(yol);

            width = bmp.Width;
            height = bmp.Height;

            Bitmap rbmp = new Bitmap(yol);
            Bitmap gbmp = new Bitmap(yol);
            Bitmap bbmp = new Bitmap(yol);
            

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    rbmp.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));
                }
            }

            int i = 0;
            int[] dizi = new int[width * height];
            
            
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = rbmp.GetPixel(x, y);
                    int t = p.R;
                    dizi[i] = t;

                    i += 1;
                }
            }
            

            redBinary = new string[width * height];
            for (int m = 0; m < width * height; m++)
            {
                string binary = Convert.ToString(dizi[m], 2).PadLeft(8, '0');

                redBinary[m] = binary;
                
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));
                }
            }

            int j = 0;
            int[] dizi2 = new int[width * height];
            
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = gbmp.GetPixel(x, y);
                    int t = p.G;
                    dizi2[j] = t;

                    j += 1;
                }
            }
            greenBinary = new string[width * height];
            for (int m = 0; m < width * height; m++)
            {
                string binary = Convert.ToString(dizi2[m], 2).PadLeft(8, '0');

                greenBinary[m] = binary;
                
            }


            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    bbmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));
                }
            }

            int k = 0;
            int[] dizi3 = new int[width * height];
            
            
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bbmp.GetPixel(x, y);
                    int t = p.B;
                    dizi3[k] = t;
                    k += 1;
                }
            }
            blueBinary = new string[width * height];
            for (int m = 0; m < width * height; m++)
            {
                string binary = Convert.ToString(dizi3[m], 2).PadLeft(8, '0');

                blueBinary[m] = binary;
                
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void metinSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog metinSec = new OpenFileDialog();
            metinSec.Filter = "|*.txt|All Files|*.*";
            if (metinSec.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            
            string yol = metinSec.FileName;
            sayi = File.ReadAllText(metinSec.FileName).Length;
            
            StreamReader sr = new StreamReader(yol);
            string yazi = sr.ReadToEnd();
            int[] intChar = new int[sayi];
            for (int i = 0; i < sayi; i++)
            {
                intChar[i] = Convert.ToInt32(yazi[i]);
            }
            
            binStr = "";

            for (int j = 0; j < sayi; j++)
            {
                binStr += string.Join("", intChar.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
            }
           
        }
        

        private void uygula_Click(object sender, EventArgs e)
        {

            string karakterSayisiBinary = Convert.ToString(sayi, 2).PadLeft(12, '0');
            

            int i = 0;
            while (i < 4)
            {
                var tempredBinary = redBinary[i].Remove(7);
                var tempredBinary2 = tempredBinary.Insert(7, karakterSayisiBinary[3 * i] + "");
                redBinary[i] = tempredBinary2;

                var tempgreenBinary = greenBinary[i].Remove(7);
                var tempgreenBinary2 = tempgreenBinary.Insert(7, karakterSayisiBinary[(3 * i) + 1] + "");
                greenBinary[i] = tempgreenBinary2;

                var tempblueBinary = blueBinary[i].Remove(7);
                var tempblueBinary2 = tempblueBinary.Insert(7, karakterSayisiBinary[(3 * i) + 2] + "");
                blueBinary[i] = tempblueBinary2;

                i++;

            }
            
            int j = 0;
            while (j < (sayi * 8) )
            {
                var tempredBinary3 = redBinary[j + 4].Remove(7);
                var tempredBinary4 = tempredBinary3.Insert(7, binStr[3*j] + "");
                if ((3 * j) >= (sayi * 8)) { break; }
                redBinary[j + 4] = tempredBinary4;
                
                var tempgreenBinary3 = greenBinary[j + 4].Remove(7);
                var tempgreenBinary4 = tempgreenBinary3.Insert(7, binStr[(3*j)+1] + "");
                if ((3 * j) >= (sayi * 8)) { break; }
                greenBinary[j + 4] = tempgreenBinary4;

                var tempblueBinary3 = blueBinary[j + 4].Remove(7);
                var tempblueBinary4 = tempblueBinary3.Insert(7, binStr[(3*j)+2] + "");
                if ((3 * j) >= (sayi * 8)) { break; }
                blueBinary[j + 4] = tempblueBinary4;
                j++;
                
                
            }
            
            int[] redDecimal = new int[width * height];
            int[] xx = new int[8];
            for (int v = 0; v < width * height; v++)
            {
                for (int c = 0; c < 8; c++)
                {
                    xx[c] = Convert.ToInt32(redBinary[v][7 - c].ToString());
                }
                redDecimal[v] = xx[0] + xx[1] * 2 + xx[2] * 4 + xx[3] * 8 + xx[4] * 16 + xx[5] * 32 + xx[6] * 64 + xx[7] * 128;
                
            }
           
            
            int[] greenDecimal = new int[width * height];
            int[] xx2 = new int[8];
            for (int v = 0; v < width * height; v++)
            {
                for (int c = 0; c < 8; c++)
                {
                    xx2[c] = Convert.ToInt32(greenBinary[v][7 - c].ToString());
                }
                greenDecimal[v] = xx2[0] + xx2[1] * 2 + xx2[2] * 4 + xx2[3] * 8 + xx2[4] * 16 + xx2[5] * 32 + xx2[6] * 64 + xx2[7] * 128;
                
            }
            
            int[] blueDecimal = new int[width * height];
            int[] xx3 = new int[8];
            for (int v = 0; v < width * height; v++)
            {
                for (int c = 0; c < 8; c++)
                {
                    xx3[c] = Convert.ToInt32(blueBinary[v][7 - c].ToString());
                }
                blueDecimal[v] = xx3[0] + xx3[1] * 2 + xx3[2] * 4 + xx3[3] * 8 + xx3[4] * 16 + xx3[5] * 32 + xx3[6] * 64 + xx3[7] * 128;
                
            }
            int x=0;
            Bitmap bmpNew = new Bitmap(yol);
            for (int y = 0; y < height; y++)
            {
                while( x < width)
                {
                    bmpNew.SetPixel(x, y, Color.FromArgb(255,redDecimal[x],greenDecimal[x], blueDecimal[x]));
                    x++;
                }
                x = x + width;
            }

            bmpNew.Save("c:\\Users/hakan/Desktop/sifreliResim.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            
        }

        private void sifreliResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog sifreliResimSec = new OpenFileDialog();
            sifreliResimSec.Filter = "|*.bmp|All Files|*.*";
            if (sifreliResimSec.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            pictureBox2.ImageLocation = sifreliResimSec.FileName;
            yolSifreli = sifreliResimSec.FileName;
            bmpSifreli = new Bitmap(yolSifreli);

            widthSifreli = bmpSifreli.Width;
            heightSifreli = bmpSifreli.Height;

            rbmpSifreli = new Bitmap(yolSifreli);
            gbmpSifreli = new Bitmap(yolSifreli);
            bbmpSifreli = new Bitmap(yolSifreli);


            for (int y = 0; y < heightSifreli; y++)
            {
                for (int x = 0; x < widthSifreli; x++)
                {
                    Color p = bmpSifreli.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    rbmpSifreli.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));
                }
            }

            int i = 0;
            int[] dizi = new int[widthSifreli * heightSifreli];


            for (int y = 0; y < heightSifreli; y++)
            {
                for (int x = 0; x < widthSifreli; x++)
                {
                    Color p = rbmpSifreli.GetPixel(x, y);
                    int t = p.R;
                    dizi[i] = t;

                    i += 1;
                }
            }


            redBinarySifreli = new string[widthSifreli * heightSifreli];
            for (int m = 0; m < widthSifreli * heightSifreli; m++)
            {
                string binary = Convert.ToString(dizi[m], 2).PadLeft(8, '0');

                redBinarySifreli[m] = binary;

            }

            for (int y = 0; y < heightSifreli; y++)
            {
                for (int x = 0; x < widthSifreli; x++)
                {
                    Color p = bmpSifreli.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    gbmpSifreli.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));
                }
            }

            int j = 0;
            int[] dizi2 = new int[widthSifreli * heightSifreli];

            for (int y = 0; y < heightSifreli; y++)
            {
                for (int x = 0; x < widthSifreli; x++)
                {
                    Color p = gbmpSifreli.GetPixel(x, y);
                    int t = p.G;
                    dizi2[j] = t;

                    j += 1;
                }
            }
            greenBinarySifreli = new string[widthSifreli * heightSifreli];
            for (int m = 0; m < widthSifreli * heightSifreli; m++)
            {
                string binary = Convert.ToString(dizi2[m], 2).PadLeft(8, '0');

                greenBinarySifreli[m] = binary;

            }


            for (int y = 0; y < heightSifreli; y++)
            {
                for (int x = 0; x < widthSifreli; x++)
                {
                    Color p = bmpSifreli.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    bbmpSifreli.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));
                }
            }

            int k = 0;
            int[] dizi3 = new int[widthSifreli * heightSifreli];
            

            for (int y = 0; y < heightSifreli; y++)
            {
                for (int x = 0; x < widthSifreli; x++)
                {
                    Color p = bbmpSifreli.GetPixel(x, y);
                    int t = p.B;
                    dizi3[k] = t;
                    k += 1;
                }
            }
            blueBinarySifreli = new string[widthSifreli * heightSifreli];
            for (int m = 0; m < widthSifreli * heightSifreli; m++)
            {
                string binary = Convert.ToString(dizi3[m], 2).PadLeft(8, '0');

                blueBinarySifreli[m] = binary;

            }
        }

        private void sifreCoz_Click(object sender, EventArgs e)
        {
            char[] sayilar = new char[12];
            int a = 0;
            int b = 0;
            while (a < 12 && b < 4)
            {
                sayilar[a] = redBinarySifreli[b][7];
                a++;
                sayilar[a] = greenBinarySifreli[b][7];
                a++;
                sayilar[a] = blueBinarySifreli[b][7];
                a++;
                b++;
            }
            
            char[,] karakterler = new char[(sayi*8), 8];
            int i = 0;
            int j = 4;
            int k = 0;
            int sayac = 0;
            
            while (i < sayi  && j < sayi*8)
            {
                karakterler[i, k] = redBinarySifreli[j][7];
                sayac++;
                if (sayac == 8)
                {
                    i++;
                    sayac = 0;
                    k = 0;
                }
                else k++;
                if (i >= sayi) { break; }
                karakterler[i, k] = greenBinarySifreli[j][7];
                sayac++;
                if (sayac == 8)
                {
                    i++;
                    sayac = 0;
                    k = 0;
                }
                
                else k++;
                if (i >= sayi) { break; }
                karakterler[i, k] = blueBinarySifreli[j][7];
                sayac++;
                if (sayac == 8)
                {
                    i++;
                    sayac = 0;
                    k = 0;
                }
                else k++;
                if (i >= sayi) { break; }
                j++;

            }
            
            int[] karakterlerInt = new int[sayi];
            char[] karakterlerSayilar = new char[8];
            for (int y = 0; y < sayi; y++)
            {
                for (int t = 0; t < 8; t++)
                {
                    karakterlerSayilar[t] = karakterler[y, t];
                }
                karakterlerInt[y] = (karakterlerSayilar[0] - '0') * 128 + (karakterlerSayilar[1] - '0') * 64 + (karakterlerSayilar[2] - '0') * 32 + (karakterlerSayilar[3] - '0') * 16 + (karakterlerSayilar[4] - '0') * 8 + (karakterlerSayilar[5] - '0') * 4 + (karakterlerSayilar[6] - '0') * 2 + (karakterlerSayilar[7] - '0') * 1;
            }
           

            char[] c = new char[sayi];
            for(int u=0; u<sayi; u++)
            {
                c[u] = (char)karakterlerInt[u];
            }

            StreamWriter s = new StreamWriter("C:\\Users/hakan/Desktop/sifre.txt");
            try
            {
                
                    for (int z = 0; z < sayi; z++)

                    {
                        s.Write(c[z]);
                    }
                
            }
            catch (Exception q)
            {
                Console.WriteLine("Exception: " + q.Message);
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            StreamReader SR = new StreamReader("C:\\Users/hakan/Desktop/sifre.txt");
            sifrelenecekMetin.Text = SR.ReadLine();
            SR.Close();
            
        }

    }

}

