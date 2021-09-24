using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Currancy_converter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        double txtr,txtl;
        double Result;
        List<Bind> obj = new List<Bind>();
        public MainPage()
        {
            this.InitializeComponent();
            result.Text = ""; 
           
            /*obj.Add(new Bind
              {
                  CID = "PKR to USD",
                  valueB = 1.00,
                  resultB = 00.00
              });

            combo.DataContext = obj; */

        }
       
        private void value_TextChanged(object sender, TextChangedEventArgs e)
        {
            double txtl = double.Parse(value.Text);
            double d = 0.0095;
            
            if (combo.SelectionBoxItem.ToString() == "PKR" && combol.SelectionBoxItem.ToString() == "USD")
            {
                 result.Text = Convert.ToString(txtl * d);
            }
            else if (combo.SelectionBoxItem.ToString() == "USD" && combol.SelectionBoxItem.ToString() == "PKR")
            {
                result.Text = Convert.ToString(txtl * 104.80);
            }
            else if (combo.SelectionBoxItem.ToString() == "PKR" && combol.SelectionBoxItem.ToString() == "AED")
            {
                result.Text = Convert.ToString(txtl * 0.035);
            }
            else if (combo.SelectionBoxItem.ToString() == "AED" && combol.SelectionBoxItem.ToString() == "PKR")
            {
                result.Text = Convert.ToString(txtl * 28.53);
            }
            else if (combo.SelectionBoxItem.ToString() == "AED" && combol.SelectionBoxItem.ToString() == "USD")
            {
                result.Text = Convert.ToString(txtl * 0.27);
            }
            else if (combo.SelectionBoxItem.ToString() == "USD" && combol.SelectionBoxItem.ToString() == "AED")
            {
                result.Text = Convert.ToString(txtl * 3.67);
            }
            else if (combo.SelectionBoxItem.ToString() == "PKR" && combol.SelectionBoxItem.ToString() == "RMB")
            {
                result.Text = Convert.ToString(txtl * 0.065);
            }
            else if (combo.SelectionBoxItem.ToString() == "RMB" && combol.SelectionBoxItem.ToString() == "PKR")
            {
                result.Text = Convert.ToString(txtl * 15.29);
            }
            else if (combo.SelectionBoxItem.ToString() == "USD" && combol.SelectionBoxItem.ToString() == "RMB")
            {
                result.Text = Convert.ToString(txtl * 6.86);
            }
            else if (combo.SelectionBoxItem.ToString() == "RMB" && combol.SelectionBoxItem.ToString() == "USD")
            {
                result.Text = Convert.ToString(txtl * 0.15);
            }
            else if (combo.SelectionBoxItem.ToString() == "AED" && combol.SelectionBoxItem.ToString() == "RMB")
            {
                result.Text = Convert.ToString(txtl * 1.87);
            }
            else if (combo.SelectionBoxItem.ToString() == "RMB" && combol.SelectionBoxItem.ToString() == "AED")
            {
                result.Text = Convert.ToString(txtl * 0.54);
            }
            else if (combo.SelectionBoxItem.ToString() == "PKR" && combol.SelectionBoxItem.ToString() == "PKR")
            {
                result.Text = Convert.ToString(txtl * 1);
            }
            else if (combo.SelectionBoxItem.ToString() == "USD" && combol.SelectionBoxItem.ToString() == "USD")
            {
                result.Text = Convert.ToString(txtl * 1);
            }
            else if (combo.SelectionBoxItem.ToString() == "AED" && combol.SelectionBoxItem.ToString() == "AED")
            {
                result.Text = Convert.ToString(txtl * 1);
            }
            else if (combo.SelectionBoxItem.ToString() == "RMB" && combol.SelectionBoxItem.ToString() == "RMB")
            {
                result.Text = Convert.ToString(txtl * 1);
            }  
            
        }

       
    }
}
class Bind 
{
   public double valueB
    {
        get;
        set;
    }

   public double resultB
   {
       get;
       set;
   }

   public String CID
   {
       get;
       set;
   }
}

