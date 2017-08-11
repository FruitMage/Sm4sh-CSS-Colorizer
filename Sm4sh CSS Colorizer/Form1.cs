using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sm4sh_CSS_Colorizer
{
    public partial class Form1 : Form
    {
        //Color 1 offsets
        int offsetColor1Rx;
        int offsetColor1Ry;
        int offsetColor1Gx;
        int offsetColor1Gy;
        int offsetColor1Bx;
        int offsetColor1By;
        int offsetColor1Ax;
        int offsetColor1Ay;
        //Color 2 offsets
        int offsetColor2Rx;
        int offsetColor2Ry;
        int offsetColor2Gx;
        int offsetColor2Gy;
        int offsetColor2Bx;
        int offsetColor2By;
        int offsetColor2Ax;
        int offsetColor2Ay;
        //Color 3 offsets
        int offsetColor3Rx;
        int offsetColor3Ry;
        int offsetColor3Gx;
        int offsetColor3Gy;
        int offsetColor3Bx;
        int offsetColor3By;
        int offsetColor3Ax;
        int offsetColor3Ay;
        //Color 4 offsets
        int offsetColor4Rx;
        int offsetColor4Ry;
        int offsetColor4Gx;
        int offsetColor4Gy;
        int offsetColor4Bx;
        int offsetColor4By;
        int offsetColor4Ax;
        int offsetColor4Ay;
        //Color 4 offsets
        int offsetColor5Rx;
        int offsetColor5Ry;
        int offsetColor5Gx;
        int offsetColor5Gy;
        int offsetColor5Bx;
        int offsetColor5By;
        int offsetColor5Ax;
        int offsetColor5Ay;

        string charaLMPath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            try
            {
                openCharaLM.ShowDialog();
                charaLMPath = openCharaLM.FileName;
                string charaLM = openCharaLM.FileName;
                //Read from chara.lm
                byte[] charaBytes = File.ReadAllBytes(charaLMPath);
                findColorOffsets();
                //Combining Color Bytes
                //Color 1
                int color1Red = charaBytes[offsetColor1Ry];
                int color1Green = charaBytes[offsetColor1Gy];
                int color1Blue = charaBytes[offsetColor1By];
                int color1Alpha = charaBytes[offsetColor1Ay];
                //Color 2
                int color2Red = charaBytes[offsetColor2Ry];
                int color2Green = charaBytes[offsetColor2Gy];
                int color2Blue = charaBytes[offsetColor2By];
                int color2Alpha = charaBytes[offsetColor2Ay];
                //Color 3
                int color3Red = charaBytes[offsetColor3Ry];
                int color3Green = charaBytes[offsetColor3Gy];
                int color3Blue = charaBytes[offsetColor3By];
                int color3Alpha = charaBytes[offsetColor3Ay];
                //Color 4
                int color4Red = charaBytes[offsetColor4Ry];
                int color4Green = charaBytes[offsetColor4Gy];
                int color4Blue = charaBytes[offsetColor4By];
                int color4Alpha = charaBytes[offsetColor4Ay];
                //Color 5
                int color5Red = charaBytes[offsetColor5Ry];
                int color5Green = charaBytes[offsetColor5Gy];
                int color5Blue = charaBytes[offsetColor5By];
                int color5Alpha = charaBytes[offsetColor5Ay];
                //Test if offset X of each color is 01, if it is, set the color to 255.
                //1
                if (charaBytes[offsetColor1Rx].ToString("X2") == "01" && charaBytes[offsetColor1Ry].ToString("X2") == "00")
                {
                    color1Red = 255;
                }
                if (charaBytes[offsetColor1Gx].ToString("X2") == "01" && charaBytes[offsetColor1Gy].ToString("X2") == "00")
                {
                    color1Green = 255;
                }
                if (charaBytes[offsetColor1Bx].ToString("X2") == "01" && charaBytes[offsetColor1By].ToString("X2") == "00")
                {
                    color1Blue = 255;
                }
                if (charaBytes[offsetColor1Ax].ToString("X2") == "01" && charaBytes[offsetColor1Ay].ToString("X2") == "00")
                {
                    color1Alpha = 255;
                }
                //2
                if (charaBytes[offsetColor2Rx].ToString("X2") == "01" && charaBytes[offsetColor2Ry].ToString("X2") == "00")
                {
                    color2Red = 255;
                }
                if (charaBytes[offsetColor2Gx].ToString("X2") == "01" && charaBytes[offsetColor2Gy].ToString("X2") == "00")
                {
                    color2Green = 255;
                }
                if (charaBytes[offsetColor2Bx].ToString("X2") == "01" && charaBytes[offsetColor2By].ToString("X2") == "00")
                {
                    color2Blue = 255;
                }
                if (charaBytes[offsetColor2Ax].ToString("X2") == "01" && charaBytes[offsetColor2Ay].ToString("X2") == "00")
                {
                    color2Alpha = 255;
                }
                //3
                if (charaBytes[offsetColor3Rx].ToString("X2") == "01" && charaBytes[offsetColor3Ry].ToString("X2") == "00")
                {
                    color3Red = 255;
                }
                if (charaBytes[offsetColor3Gx].ToString("X2") == "01" && charaBytes[offsetColor3Gy].ToString("X2") == "00")
                {
                    color3Green = 255;
                }
                if (charaBytes[offsetColor3Bx].ToString("X2") == "01" && charaBytes[offsetColor3By].ToString("X2") == "00")
                {
                    color3Blue = 255;
                }
                if (charaBytes[offsetColor3Ax].ToString("X2") == "01" && charaBytes[offsetColor3Ay].ToString("X2") == "00")
                {
                    color3Alpha = 255;
                }
                //4
                if (charaBytes[offsetColor4Rx].ToString("X2") == "01" && charaBytes[offsetColor4Ry].ToString("X2") == "00")
                {
                    color4Red = 255;
                }
                if (charaBytes[offsetColor4Gx].ToString("X2") == "01" && charaBytes[offsetColor4Gy].ToString("X2") == "00")
                {
                    color4Green = 255;
                }
                if (charaBytes[offsetColor4Bx].ToString("X2") == "01" && charaBytes[offsetColor4By].ToString("X2") == "00")
                {
                    color4Blue = 255;
                }
                if (charaBytes[offsetColor4Ax].ToString("X2") == "01" && charaBytes[offsetColor4Ay].ToString("X2") == "00")
                {
                    color4Alpha = 255;
                }
                //5
                if (charaBytes[offsetColor5Rx].ToString("X2") == "01" && charaBytes[offsetColor5Ry].ToString("X2") == "00")
                {
                    color5Red = 255;
                }
                if (charaBytes[offsetColor5Gx].ToString("X2") == "01" && charaBytes[offsetColor5Gy].ToString("X2") == "00")
                {
                    color5Green = 255;
                }
                if (charaBytes[offsetColor5Bx].ToString("X2") == "01" && charaBytes[offsetColor5By].ToString("X2") == "00")
                {
                    color5Blue = 255;
                }
                if (charaBytes[offsetColor5Ax].ToString("X2") == "01" && charaBytes[offsetColor5Ay].ToString("X2") == "00")
                {
                    color5Alpha = 255;
                }
                //Color Conversion
                Color color1 = ColorTranslator.FromHtml("#" + color1Red.ToString("X2") + color1Green.ToString("X2") + color1Blue.ToString("X2"));
                Color color2 = ColorTranslator.FromHtml("#" + color2Red.ToString("X2") + color2Green.ToString("X2") + color2Blue.ToString("X2"));
                Color color3 = ColorTranslator.FromHtml("#" + color3Red.ToString("X2") + color3Green.ToString("X2") + color3Blue.ToString("X2"));
                Color color4 = ColorTranslator.FromHtml("#" + color4Red.ToString("X2") + color4Green.ToString("X2") + color4Blue.ToString("X2"));
                Color color5 = ColorTranslator.FromHtml("#" + color5Red.ToString("X2") + color5Green.ToString("X2") + color5Blue.ToString("X2"));
                //Set Colors
                colorDisplay1.BackColor = color1;
                colorDisplay2.BackColor = color2;
                colorDisplay3.BackColor = color3;
                colorDisplay4.BackColor = color4;
                colorDisplay5.BackColor = color5;
                //Set Alpha
                alphaBox1.Value = color1Alpha;
                alphaBox2.Value = color2Alpha;
                alphaBox3.Value = color3Alpha;
                alphaBox4.Value = color4Alpha;
                alphaBox5.Value = color5Alpha;
                colors.Enabled = true;
                //Console.WriteLine("Byte: 0x" + offsetColor1Rx.ToString("X9") + " | 0x" + charaBytes[offsetColor1Rx].ToString("X2"));
            }
            catch
            {
                MessageBox.Show("Unknown Error", "Sm4sh CSS Colorizer");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            //Color Conversion
            string color1 = colorDisplay1.BackColor.R.ToString("X2") + colorDisplay1.BackColor.G.ToString("X2") + colorDisplay1.BackColor.B.ToString("X2");
            char[] color1Char = color1.ToCharArray();
            string color2 = colorDisplay2.BackColor.R.ToString("X2") + colorDisplay2.BackColor.G.ToString("X2") + colorDisplay2.BackColor.B.ToString("X2");
            char[] color2Char = color2.ToCharArray();
            string color3 = colorDisplay3.BackColor.R.ToString("X2") + colorDisplay3.BackColor.G.ToString("X2") + colorDisplay3.BackColor.B.ToString("X2");
            char[] color3Char = color3.ToCharArray();
            string color4 = colorDisplay4.BackColor.R.ToString("X2") + colorDisplay4.BackColor.G.ToString("X2") + colorDisplay4.BackColor.B.ToString("X2");
            char[] color4Char = color4.ToCharArray();
            string color5 = colorDisplay5.BackColor.R.ToString("X2") + colorDisplay5.BackColor.G.ToString("X2") + colorDisplay5.BackColor.B.ToString("X2");
            char[] color5Char = color5.ToCharArray();
            //Color 1
            int color1RedX = 0;
            int color1RedY = Int32.Parse(color1Char[0].ToString() + color1Char[1].ToString(), NumberStyles.HexNumber);
            int color1BlueX = 0;
            int color1BlueY = Int32.Parse(color1Char[2].ToString() + color1Char[3].ToString(), NumberStyles.HexNumber);
            int color1GreenX = 0;
            int color1GreenY = Int32.Parse(color1Char[4].ToString() + color1Char[5].ToString(), NumberStyles.HexNumber);
            int color1AlphaX = 0;
            int color1AlphaY = Decimal.ToInt32(alphaBox1.Value);
            //Color 2
            int color2RedX = 0;
            int color2RedY = Int32.Parse(color2Char[0].ToString() + color2Char[1].ToString(), NumberStyles.HexNumber);
            int color2BlueX = 0;
            int color2BlueY = Int32.Parse(color2Char[2].ToString() + color2Char[3].ToString(), NumberStyles.HexNumber);
            int color2GreenX = 0;
            int color2GreenY = Int32.Parse(color2Char[4].ToString() + color2Char[5].ToString(), NumberStyles.HexNumber);
            int color2AlphaX = 0;
            int color2AlphaY = Decimal.ToInt32(alphaBox2.Value);
            //Color 3
            int color3RedX = 0;
            int color3RedY = Int32.Parse(color3Char[0].ToString() + color3Char[1].ToString(), NumberStyles.HexNumber);
            int color3BlueX = 0;
            int color3BlueY = Int32.Parse(color3Char[2].ToString() + color3Char[3].ToString(), NumberStyles.HexNumber);
            int color3GreenX = 0;
            int color3GreenY = Int32.Parse(color3Char[4].ToString() + color3Char[5].ToString(), NumberStyles.HexNumber);
            int color3AlphaX = 0;
            int color3AlphaY = Decimal.ToInt32(alphaBox3.Value);
            //Color 4
            int color4RedX = 0;
            int color4RedY = Int32.Parse(color4Char[0].ToString() + color4Char[1].ToString(), NumberStyles.HexNumber);
            int color4BlueX = 0;
            int color4BlueY = Int32.Parse(color4Char[2].ToString() + color4Char[3].ToString(), NumberStyles.HexNumber);
            int color4GreenX = 0;
            int color4GreenY = Int32.Parse(color4Char[4].ToString() + color4Char[5].ToString(), NumberStyles.HexNumber);
            int color4AlphaX = 0;
            int color4AlphaY = Decimal.ToInt32(alphaBox4.Value);
            //Color 5
            int color5RedX = 0;
            int color5RedY = Int32.Parse(color5Char[0].ToString() + color5Char[1].ToString(), NumberStyles.HexNumber);
            int color5BlueX = 0;
            int color5BlueY = Int32.Parse(color5Char[2].ToString() + color5Char[3].ToString(), NumberStyles.HexNumber);
            int color5GreenX = 0;
            int color5GreenY = Int32.Parse(color5Char[4].ToString() + color5Char[5].ToString(), NumberStyles.HexNumber);
            int color5AlphaX = 0;
            int color5AlphaY = Decimal.ToInt32(alphaBox5.Value);
            //FF to 01 00
            //1
            if (color1RedY == 255)
            {
                color1RedX = 1;
                color1RedY = 0;
            }
            if (color1BlueY == 255)
            {
                color1BlueX = 1;
                color1BlueY = 0;
            }
            if (color1GreenY == 255)
            {
                color1GreenX = 1;
                color1GreenY = 0;
            }
            if (color1AlphaY == 255)
            {
                color1AlphaX = 1;
                color1AlphaY = 0;
            }
            //2
            if (color2RedY == 255)
            {
                color2RedX = 1;
                color2RedY = 0;
            }
            if (color2BlueY == 255)
            {
                color2BlueX = 1;
                color2BlueY = 0;
            }
            if (color2GreenY == 255)
            {
                color2GreenX = 1;
                color2GreenY = 0;
            }
            if (color2AlphaY == 255)
            {
                color2AlphaX = 1;
                color2AlphaY = 0;
            }
            //3
            if (color3RedY == 255)
            {
                color3RedX = 1;
                color3RedY = 0;
            }
            if (color3BlueY == 255)
            {
                color3BlueX = 1;
                color3BlueY = 0;
            }
            if (color3GreenY == 255)
            {
                color3GreenX = 1;
                color3GreenY = 0;
            }
            if (color3AlphaY == 255)
            {
                color3AlphaX = 1;
                color3AlphaY = 0;
            }
            //4
            if (color4RedY == 255)
            {
                color4RedX = 1;
                color4RedY = 0;
            }
            if (color4BlueY == 255)
            {
                color4BlueX = 1;
                color4BlueY = 0;
            }
            if (color4GreenY == 255)
            {
                color4GreenX = 1;
                color4GreenY = 0;
            }
            if (color4AlphaY == 255)
            {
                color4AlphaX = 1;
                color4AlphaY = 0;
            }
            //5
            if (color5RedY == 255)
            {
                color5RedX = 1;
                color5RedY = 0;
            }
            if (color5BlueY == 255)
            {
                color5BlueX = 1;
                color5BlueY = 0;
            }
            if (color5GreenY == 255)
            {
                color5GreenX = 1;
                color5GreenY = 0;
            }
            if (color5AlphaY == 255)
            {
                color5AlphaX = 1;
                color5AlphaY = 0;
            }
            //Save the file
            byte[] charaLMBytes = File.ReadAllBytes(charaLMPath);
            //1
            charaLMBytes[offsetColor1Rx] = Convert.ToByte(color1RedX);
            charaLMBytes[offsetColor1Ry] = Convert.ToByte(color1RedY);
            charaLMBytes[offsetColor1Bx] = Convert.ToByte(color1BlueX);
            charaLMBytes[offsetColor1By] = Convert.ToByte(color1BlueY);
            charaLMBytes[offsetColor1Gx] = Convert.ToByte(color1GreenX);
            charaLMBytes[offsetColor1Gy] = Convert.ToByte(color1GreenY);
            charaLMBytes[offsetColor1Ax] = Convert.ToByte(color1AlphaX);
            charaLMBytes[offsetColor1Ay] = Convert.ToByte(color1AlphaY);
            //2
            charaLMBytes[offsetColor2Rx] = Convert.ToByte(color2RedX);
            charaLMBytes[offsetColor2Ry] = Convert.ToByte(color2RedY);
            charaLMBytes[offsetColor2Bx] = Convert.ToByte(color2BlueX);
            charaLMBytes[offsetColor2By] = Convert.ToByte(color2BlueY);
            charaLMBytes[offsetColor2Gx] = Convert.ToByte(color2GreenX);
            charaLMBytes[offsetColor2Gy] = Convert.ToByte(color2GreenY);
            charaLMBytes[offsetColor2Ax] = Convert.ToByte(color2AlphaX);
            charaLMBytes[offsetColor2Ay] = Convert.ToByte(color2AlphaY);
            //3
            charaLMBytes[offsetColor3Rx] = Convert.ToByte(color3RedX);
            charaLMBytes[offsetColor3Ry] = Convert.ToByte(color3RedY);
            charaLMBytes[offsetColor3Bx] = Convert.ToByte(color3BlueX);
            charaLMBytes[offsetColor3By] = Convert.ToByte(color3BlueY);
            charaLMBytes[offsetColor3Gx] = Convert.ToByte(color3GreenX);
            charaLMBytes[offsetColor3Gy] = Convert.ToByte(color3GreenY);
            charaLMBytes[offsetColor3Ax] = Convert.ToByte(color3AlphaX);
            charaLMBytes[offsetColor3Ay] = Convert.ToByte(color3AlphaY);
            //4
            charaLMBytes[offsetColor4Rx] = Convert.ToByte(color4RedX);
            charaLMBytes[offsetColor4Ry] = Convert.ToByte(color4RedY);
            charaLMBytes[offsetColor4Bx] = Convert.ToByte(color4BlueX);
            charaLMBytes[offsetColor4By] = Convert.ToByte(color4BlueY);
            charaLMBytes[offsetColor4Gx] = Convert.ToByte(color4GreenX);
            charaLMBytes[offsetColor4Gy] = Convert.ToByte(color4GreenY);
            charaLMBytes[offsetColor4Ax] = Convert.ToByte(color4AlphaX);
            charaLMBytes[offsetColor4Ay] = Convert.ToByte(color4AlphaY);
            //5
            charaLMBytes[offsetColor5Rx] = Convert.ToByte(color5RedX);
            charaLMBytes[offsetColor5Ry] = Convert.ToByte(color5RedY);
            charaLMBytes[offsetColor5Bx] = Convert.ToByte(color5BlueX);
            charaLMBytes[offsetColor5By] = Convert.ToByte(color5BlueY);
            charaLMBytes[offsetColor5Gx] = Convert.ToByte(color5GreenX);
            charaLMBytes[offsetColor5Gy] = Convert.ToByte(color5GreenY);
            charaLMBytes[offsetColor5Ax] = Convert.ToByte(color5AlphaX);
            charaLMBytes[offsetColor5Ay] = Convert.ToByte(color5AlphaY);
            
            File.WriteAllBytes(charaLMPath, charaLMBytes);
        }

        public void findColorOffsets()
        {
            byte[] charaBytes = File.ReadAllBytes(charaLMPath);
            //Console.WriteLine("Byte: 0x" + offsetColor1Rx.ToString("X9") + " | 0x" + charaBytes[offsetColor1Rx].ToString("X2"));
            int lastByte = 0;
            string currentByte = "";
            for (int i = 0; i < charaBytes.Length; i++)
            {
                currentByte = charaBytes[i].ToString("X2");
                lastByte = i - 1;
                //Console.WriteLine("Byte: 0x" + i.ToString("X9") + " | 0x" + currentByte);
                if (lastByte >= 0)
                {
                    if (charaBytes[lastByte].ToString("X2") == "F0")
                    {
                        if (charaBytes[i].ToString("X2") == "02")
                        {
                            //Color 1 offsets
                            offsetColor1Rx = i + 1737;
                            offsetColor1Ry = i + 1738;
                            offsetColor1Gx = i + 1739;
                            offsetColor1Gy = i + 1740;
                            offsetColor1Bx = i + 1741;
                            offsetColor1By = i + 1742;
                            offsetColor1Ax = i + 1743;
                            offsetColor1Ay = i + 1744;
                            //Color 2 offsets
                            offsetColor2Rx = i + 1745;
                            offsetColor2Ry = i + 1746;
                            offsetColor2Gx = i + 1747;
                            offsetColor2Gy = i + 1748;
                            offsetColor2Bx = i + 1749;
                            offsetColor2By = i + 1750;
                            offsetColor2Ax = i + 1751;
                            offsetColor2Ay = i + 1752;
                            //Color 3 offsets
                            offsetColor3Rx = i + 1753;
                            offsetColor3Ry = i + 1754;
                            offsetColor3Gx = i + 1755;
                            offsetColor3Gy = i + 1756;
                            offsetColor3Bx = i + 1757;
                            offsetColor3By = i + 1758;
                            offsetColor3Ax = i + 1759;
                            offsetColor3Ay = i + 1760;
                            //Color 4 offsets
                            offsetColor4Rx = i + 1761;
                            offsetColor4Ry = i + 1762;
                            offsetColor4Gx = i + 1763;
                            offsetColor4Gy = i + 1764;
                            offsetColor4Bx = i + 1765;
                            offsetColor4By = i + 1766;
                            offsetColor4Ax = i + 1767;
                            offsetColor4Ay = i + 1768;
                            //Color 4 offsets
                            offsetColor5Rx = i + 1769;
                            offsetColor5Ry = i + 1770;
                            offsetColor5Gx = i + 1771;
                            offsetColor5Gy = i + 1772;
                            offsetColor5Bx = i + 1773;
                            offsetColor5By = i + 1774;
                            offsetColor5Ax = i + 1775;
                            offsetColor5Ay = i + 1776;
                            /*
                            Console.WriteLine("Found Flame Color Offsets:");
                            Console.WriteLine("Byte: 0x" + offsetColor1Rx.ToString("X9") + " | 0x" + charaBytes[offsetColor1Rx].ToString("X2"));
                            Console.WriteLine("Byte: 0x" + offsetColor1Ry.ToString("X9") + " | 0x" + charaBytes[offsetColor1Ry].ToString("X2"));
                            Console.WriteLine("Byte: 0x" + offsetColor1Gx.ToString("X9") + " | 0x" + charaBytes[offsetColor1Gx].ToString("X2"));
                            Console.WriteLine("Byte: 0x" + offsetColor1Gy.ToString("X9") + " | 0x" + charaBytes[offsetColor1Gy].ToString("X2"));
                            Console.WriteLine("Byte: 0x" + offsetColor1Bx.ToString("X9") + " | 0x" + charaBytes[offsetColor1Bx].ToString("X2"));
                            Console.WriteLine("Byte: 0x" + offsetColor1By.ToString("X9") + " | 0x" + charaBytes[offsetColor1By].ToString("X2"));
                            Console.WriteLine("Byte: 0x" + offsetColor1Ax.ToString("X9") + " | 0x" + charaBytes[offsetColor1Ax].ToString("X2"));
                            Console.WriteLine("Byte: 0x" + offsetColor1Ay.ToString("X9") + " | 0x" + charaBytes[offsetColor1Ay].ToString("X2"));
                            */
                            break;
                        }
                    }
                }
            }
        }

        //Alpha 1
        private void alphaBox1_ValueChanged(object sender, EventArgs e)
        {
            alphaSlider1.Value = Decimal.ToInt32(alphaBox1.Value);
        }

        private void alphaSlider1_Scroll(object sender, EventArgs e)
        {
            alphaBox1.Value = alphaSlider1.Value;
        }

        //Alpha 2
        private void alphaBox2_ValueChanged(object sender, EventArgs e)
        {
            alphaSlider2.Value = Decimal.ToInt32(alphaBox2.Value);
        }

        private void alphaSlider2_Scroll(object sender, EventArgs e)
        {
            alphaBox2.Value = alphaSlider2.Value;
        }

        //Alpha 3
        private void alphaBox3_ValueChanged(object sender, EventArgs e)
        {
            alphaSlider3.Value = Decimal.ToInt32(alphaBox3.Value);
        }

        private void alphaSlider3_Scroll(object sender, EventArgs e)
        {
            alphaBox3.Value = alphaSlider3.Value;
        }

        //Alpha 4
        private void alphaBox4_ValueChanged(object sender, EventArgs e)
        {
            alphaSlider4.Value = Decimal.ToInt32(alphaBox4.Value);
        }

        private void alphaSlider4_Scroll(object sender, EventArgs e)
        {
            alphaBox4.Value = alphaSlider4.Value;
        }

        //Alpha 5
        private void alphaBox5_ValueChanged(object sender, EventArgs e)
        {
            alphaSlider5.Value = Decimal.ToInt32(alphaBox5.Value);
        }

        private void alphaSlider5_Scroll(object sender, EventArgs e)
        {
            alphaBox5.Value = alphaSlider5.Value;
        }


        //Color Setting
        private void colorSelect1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            colorDisplay1.BackColor = colorDialog1.Color;
        }
        private void colorSelect2_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            colorDisplay2.BackColor = colorDialog2.Color;
        }
        private void colorSelect3_Click(object sender, EventArgs e)
        {
            colorDialog3.ShowDialog();
            colorDisplay3.BackColor = colorDialog3.Color;
        }
        private void colorSelect4_Click(object sender, EventArgs e)
        {
            colorDialog4.ShowDialog();
            colorDisplay4.BackColor = colorDialog4.Color;
        }
        private void colorSelect5_Click(object sender, EventArgs e)
        {
            colorDialog5.ShowDialog();
            colorDisplay5.BackColor = colorDialog5.Color;
        }
    }
}
