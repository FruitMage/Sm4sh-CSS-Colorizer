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
        int offsetColor1Rx = 13780;
        int offsetColor1Ry = 13781;
        int offsetColor1Gx = 13782;
        int offsetColor1Gy = 13783;
        int offsetColor1Bx = 13784;
        int offsetColor1By = 13785;
        int offsetColor1Ax = 13786;
        int offsetColor1Ay = 13787;
        //Color 2 offsets
        int offsetColor2Rx = 13788;
        int offsetColor2Ry = 13789;
        int offsetColor2Gx = 13790;
        int offsetColor2Gy = 13791;
        int offsetColor2Bx = 13792;
        int offsetColor2By = 13793;
        int offsetColor2Ax = 13794;
        int offsetColor2Ay = 13795;
        //Color 3 offsets
        int offsetColor3Rx = 13796;
        int offsetColor3Ry = 13797;
        int offsetColor3Gx = 13798;
        int offsetColor3Gy = 13799;
        int offsetColor3Bx = 13800;
        int offsetColor3By = 13801;
        int offsetColor3Ax = 13802;
        int offsetColor3Ay = 13803;
        //Color 4 offsets
        int offsetColor4Rx = 13804;
        int offsetColor4Ry = 13505;
        int offsetColor4Gx = 13806;
        int offsetColor4Gy = 13807;
        int offsetColor4Bx = 13808;
        int offsetColor4By = 13809;
        int offsetColor4Ax = 13810;
        int offsetColor4Ay = 13811;
        //Color 4 offsets
        int offsetColor5Rx = 13812;
        int offsetColor5Ry = 13813;
        int offsetColor5Gx = 13814;
        int offsetColor5Gy = 13815;
        int offsetColor5Bx = 13816;
        int offsetColor5By = 13817;
        int offsetColor5Ax = 13818;
        int offsetColor5Ay = 13819;

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
                byte[] charaBytes = File.ReadAllBytes(charaLM);
                //Combining Color Bytes
                //Color 1
                int color1Red = charaBytes[offsetColor1Rx] + charaBytes[offsetColor1Ry];
                int color1Green = charaBytes[offsetColor1Gx] + charaBytes[offsetColor1Gy];
                int color1Blue = charaBytes[offsetColor1Bx] + charaBytes[offsetColor1By];
                int color1Alpha = charaBytes[offsetColor1Ax] + charaBytes[offsetColor1Ay];
                //Color 2
                int color2Red = charaBytes[offsetColor2Rx] + charaBytes[offsetColor2Ry];
                int color2Green = charaBytes[offsetColor2Gx] + charaBytes[offsetColor2Gy];
                int color2Blue = charaBytes[offsetColor2Bx] + charaBytes[offsetColor2By];
                int color2Alpha = charaBytes[offsetColor2Ax] + charaBytes[offsetColor2Ay];
                //Color 3
                int color3Red = charaBytes[offsetColor3Rx] + charaBytes[offsetColor3Ry];
                int color3Green = charaBytes[offsetColor3Gx] + charaBytes[offsetColor3Gy];
                int color3Blue = charaBytes[offsetColor3Bx] + charaBytes[offsetColor3By];
                int color3Alpha = charaBytes[offsetColor3Ax] + charaBytes[offsetColor3Ay];
                //Color 4
                int color4Red = charaBytes[offsetColor4Rx] + charaBytes[offsetColor4Ry];
                int color4Green = charaBytes[offsetColor4Gx] + charaBytes[offsetColor4Gy];
                int color4Blue = charaBytes[offsetColor4Bx] + charaBytes[offsetColor4By];
                int color4Alpha = charaBytes[offsetColor4Ax] + charaBytes[offsetColor4Ay];
                //Color 5
                int color5Red = charaBytes[offsetColor5Rx] + charaBytes[offsetColor5Ry];
                int color5Green = charaBytes[offsetColor5Gx] + charaBytes[offsetColor5Gy];
                int color5Blue = charaBytes[offsetColor5Bx] + charaBytes[offsetColor5By];
                int color5Alpha = charaBytes[offsetColor5Ax] + charaBytes[offsetColor5Ay];
                //Test if offset X of each color is 01, if it is, set the color to 255.
                //1
                if (charaBytes[offsetColor1Rx] == 1)
                {
                    color1Red = 255;
                }
                if (charaBytes[offsetColor1Gx] == 1)
                {
                    color1Green = 255;
                }
                if (charaBytes[offsetColor1Bx] == 1)
                {
                    color1Blue = 255;
                }
                if (charaBytes[offsetColor1Ax] == 1)
                {
                    color1Alpha = 255;
                }
                //2
                if (charaBytes[offsetColor2Rx] == 1)
                {
                    color2Red = 255;
                }
                if (charaBytes[offsetColor2Gx] == 1)
                {
                    color2Green = 255;
                }
                if (charaBytes[offsetColor2Bx] == 1)
                {
                    color2Blue = 255;
                }
                if (charaBytes[offsetColor2Ax] == 1)
                {
                    color2Alpha = 255;
                }
                //3
                if (charaBytes[offsetColor3Rx] == 1)
                {
                    color3Red = 255;
                }
                if (charaBytes[offsetColor3Gx] == 1)
                {
                    color3Green = 255;
                }
                if (charaBytes[offsetColor3Bx] == 1)
                {
                    color3Blue = 255;
                }
                if (charaBytes[offsetColor3Ax] == 1)
                {
                    color3Alpha = 255;
                }
                //4
                if (charaBytes[offsetColor4Rx] == 1)
                {
                    color4Red = 255;
                }
                if (charaBytes[offsetColor4Gx] == 1)
                {
                    color4Green = 255;
                }
                if (charaBytes[offsetColor4Bx] == 1)
                {
                    color4Blue = 255;
                }
                if (charaBytes[offsetColor4Ax] == 1)
                {
                    color4Alpha = 255;
                }
                //5
                if (charaBytes[offsetColor5Rx] == 1)
                {
                    color5Red = 255;
                }
                if (charaBytes[offsetColor5Gx] == 1)
                {
                    color5Green = 255;
                }
                if (charaBytes[offsetColor5Bx] == 1)
                {
                    color5Blue = 255;
                }
                if (charaBytes[offsetColor5Ax] == 1)
                {
                    color5Alpha = 255;
                }
                //Color Conversion
                Color color1 = ColorTranslator.FromHtml("#" + color1Red.ToString("X") + color1Green.ToString("X") + color1Blue.ToString("X"));
                Color color2 = ColorTranslator.FromHtml("#" + color2Red.ToString("X") + color2Green.ToString("X") + color2Blue.ToString("X"));
                Color color3 = ColorTranslator.FromHtml("#" + color3Red.ToString("X") + color3Green.ToString("X") + color3Blue.ToString("X"));
                Color color4 = ColorTranslator.FromHtml("#" + color4Red.ToString("X") + color4Green.ToString("X") + color4Blue.ToString("X"));
                Color color5 = ColorTranslator.FromHtml("#" + color5Red.ToString("X") + color5Green.ToString("X") + color5Blue.ToString("X"));
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
            }
            catch
            {
                MessageBox.Show("Unknown Error", "Sm4sh CSS Colorizer");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            //Color Conversion
            string color1 = colorDisplay1.BackColor.R.ToString("X2") + colorDisplay1.BackColor.B.ToString("X2") + colorDisplay1.BackColor.G.ToString("X2");
            char[] color1Char = color1.ToCharArray();
            string color2 = colorDisplay2.BackColor.R.ToString("X2") + colorDisplay2.BackColor.B.ToString("X2") + colorDisplay2.BackColor.G.ToString("X2");
            char[] color2Char = color2.ToCharArray();
            string color3 = colorDisplay3.BackColor.R.ToString("X2") + colorDisplay3.BackColor.B.ToString("X2") + colorDisplay3.BackColor.G.ToString("X2");
            char[] color3Char = color3.ToCharArray();
            string color4 = colorDisplay4.BackColor.R.ToString("X2") + colorDisplay4.BackColor.B.ToString("X2") + colorDisplay4.BackColor.G.ToString("X2");
            char[] color4Char = color4.ToCharArray();
            string color5 = colorDisplay5.BackColor.R.ToString("X2") + colorDisplay5.BackColor.B.ToString("X2") + colorDisplay5.BackColor.G.ToString("X2");
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
