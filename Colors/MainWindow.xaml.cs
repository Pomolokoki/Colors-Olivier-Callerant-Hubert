using Colors.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Colors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region do not edit
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Change color of the middle zone
        /// </summary>
        /// <param name="color"></param>
        private void ChangeColor(Color color)
        {
            panelColor.Background = new SolidColorBrush(color);
        }

        /// <summary>
        /// Change the values of RGB sliders
        /// </summary>
        /// <param name="value">the new RGB value</param>
        private void ChangeRGB(RGB value)
        {
            redSlider.Value = value.Red;
            greenSlider.Value = value.Green;
            blueSlider.Value = value.Blue;
        }

        /// <summary>
        /// THe user has pressed the validate button of RGB zone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserChangeRGB(object sender, RoutedEventArgs e)
        {
            try
            {
                RGB rgb = new RGB(Int32.Parse(redText.Text), Int32.Parse(greenText.Text), Int32.Parse(blueText.Text));
                ChangeColor(rgb.ToColor());
                ChangeCMYB(rgb.ToCMYB());
                ChangeHSL(rgb.ToHSL());
                ChangeHTML(rgb.ToHTML());
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }
        /// <summary>
        /// Use has changed the red slider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void redSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            redText.Text = e.NewValue.ToString("000");
        }

        private void blueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            blueText.Text = e.NewValue.ToString("000");
        }

        private void greenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            greenText.Text = e.NewValue.ToString("000");
        }

        private void cyanSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            cyanText.Text = e.NewValue.ToString("000");
        }

        private void magentaSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            magentaText.Text = e.NewValue.ToString("000");
        }

        private void yellowSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            yellowText.Text = e.NewValue.ToString("000");
        }

        private void blackSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            blackText.Text = e.NewValue.ToString("000");
        }

        private void hueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            hueText.Text = e.NewValue.ToString("000");
        }

        private void saturationSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            saturationText.Text = e.NewValue.ToString("000");
        }

        private void luminanceSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            luminanceText.Text = e.NewValue.ToString("000");
        }
        #endregion


        #region code to edit
        /// <summary>
        /// Change the CMYB sliders
        /// </summary>
        /// <param name="value">the new color</param>
        private void ChangeCMYB(CMYB value)
        {
            // todo : same thing as CHangeRGB
        }

        /// <summary>
        /// Change the HSL sliders
        /// </summary>
        /// <param name="value">the new color</param>
        private void ChangeHSL(HSL value)
        {
            // todo : same thing as CHangeRGB
        }

        /// <summary>
        /// Change the HTML text
        /// </summary>
        /// <param name="value">the new color</param>
        private void ChangeHTML(HTML value)
        {
            // todo : same thing as CHangeRGB
        }

        /// <summary>
        /// The user has pressed the validate button of CMYB zone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserChangeCMYB(object sender, RoutedEventArgs e)
        {
            // todo : same thing as UserCHangeRGB but, with CMYB and not RGB
        }

        /// <summary>
        /// The user has pressed the validate button of HSL zone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserChangeHSL(object sender, RoutedEventArgs e)
        {
            // todo : same thing as UserCHangeCMYB but, with HSL and not RGB
        }

        /// <summary>
        /// The user has pressed the validate button of HTML zone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserChangeHTML(object sender, RoutedEventArgs e)
        {
            // todo : same thing as UserCHangeRGB but, with HTML and not RGB
        }


        #endregion


    }
}
