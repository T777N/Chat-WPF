using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Funk();
        }
            public void Funk()
            {

            if (textbox.Text != "")
            {
                //mesaj1.Content = textbox.Text;
                //textbox.Text = "";
            if(textbox.Text == "salam"|| textbox.Text == "Salam"|| textbox.Text == "SALAM"|| textbox.Text == "Salam Alekum"|| textbox.Text == "Salam alekum"|| textbox.Text == "salam Alekum" || textbox.Text == "salamalekum")
            {
                    string cavab = "Alekum Salam";

                    message1(textbox.Text);
                    message2(cavab);
                    
                   
            }
            else if(textbox.Text == "necesen"|| textbox.Text == "necesen?"||
                    textbox.Text == "Necesen?"|| textbox.Text == "Necesen"|| textbox.Text == "NECESEN?"||
                    textbox.Text == "NECESEN" || textbox.Text == "ne var ne yox")
            {
                    string cavab = "Salamatcilix sende?";

                    message1(textbox.Text);
                    message2(cavab);
                    
                   
            } 
                else if(textbox.Text == "hardasan?"|| textbox.Text == "Hardasan?"||
                    textbox.Text == "Haradasan?"|| textbox.Text == "Haradasan"|| textbox.Text == "HARDASAN?"||
                    textbox.Text == "HARADASAN" || textbox.Text == "hardasan")
            {
                    string cavab = "evde";

                    message1(textbox.Text);
                    message2(cavab);
                    
                   
            }
                else if(textbox.Text == "saqol"|| textbox.Text == "Saqol"||
                    textbox.Text == "SAQOL"|| textbox.Text == "sagol"|| textbox.Text == "Sagol"||
                    textbox.Text == "SAGOL" || textbox.Text == "sagol yaxsiyam" ||
                    textbox.Text == "yaxsiyam" || textbox.Text == "Yaxsiyam" ||
                    textbox.Text == "YAXSIYAM" || textbox.Text == "Salamatcilixdi"||
                    textbox.Text == "SALAMATCILIXDI" || textbox.Text == "wukur"||
                    textbox.Text == "Sukur" || textbox.Text == "sukur")
            {
                    string cavab = "Teki Yaxsi ol";

                    message1(textbox.Text);
                    message2(cavab);
                    
                   
            } 
                else if(textbox.Text == "belede"|| textbox.Text == "Belede"||
                    textbox.Text == "BELEDE"|| textbox.Text == "pisem"|| textbox.Text == "Pisem"||
                    textbox.Text == "PISEM" || textbox.Text == "nastrenyam yoxdu" ||
                    textbox.Text == "yaxsiyam" || textbox.Text == "yaxsi deyilem" ||
                    textbox.Text == "halim yoxdur" || textbox.Text == "yaxsi deylem"||
                    textbox.Text == "basim agriyir" || textbox.Text == "halim yoxdu"||
                    textbox.Text == "xesteyem" || textbox.Text == "xesdeyem")
            {
                    string cavab = "Her sey Yaxsi olacaq ...";

                    message1(textbox.Text);
                    message2(cavab);
                    
                   
            }
            
                else
                {
                    string cavab = "ne?";

                    message1(textbox.Text);
                    message2(cavab);
                }
            

            }
            textbox.Text = "";
            }

        public void message1(string Mesaj1)
        {

            mesaj9_1.Content = mesaj8.Content;
            mesaj9.Content = mesaj8_1.Content;
            
            mesaj8_1.Content = mesaj7.Content;
            mesaj8.Content = mesaj7_1.Content;
            
            mesaj7_1.Content = mesaj6.Content;
            mesaj7.Content = mesaj6_1.Content;
            
            mesaj6_1.Content = mesaj5.Content;
            mesaj6.Content = mesaj5_1.Content; 
            
            mesaj5_1.Content = mesaj4.Content;
            mesaj5.Content = mesaj4_1.Content;
            
            mesaj4_1.Content = mesaj3.Content;
            mesaj4.Content = mesaj3_1.Content;
            
            mesaj3_1.Content = mesaj2.Content;
            mesaj3.Content = mesaj2_1.Content; 
            
            mesaj2_1.Content = mesaj1.Content;
            mesaj2.Content = mesaj1_1.Content;

            mesaj1.Content = Mesaj1;
            mesaj1_1.Content = "";

            
        }
        
        public void message2(string Mesaj1)
        {

            mesaj9_1.Content = mesaj8.Content;
            mesaj9.Content = mesaj8_1.Content;
            
            mesaj8_1.Content = mesaj7.Content;
            mesaj8.Content = mesaj7_1.Content;
            
            mesaj7_1.Content = mesaj6.Content;
            mesaj7.Content = mesaj6_1.Content;
            
            mesaj6_1.Content = mesaj5.Content;
            mesaj6.Content = mesaj5_1.Content; 
            
            mesaj5_1.Content = mesaj4.Content;
            mesaj5.Content = mesaj4_1.Content;
            
            mesaj4_1.Content = mesaj3.Content;
            mesaj4.Content = mesaj3_1.Content;
            
            mesaj3_1.Content = mesaj2.Content;
            mesaj3.Content = mesaj2_1.Content; 
            
            mesaj2_1.Content = mesaj1.Content;
            mesaj2.Content = mesaj1_1.Content;

            mesaj1_1.Content = Mesaj1;
            mesaj1.Content = "";
           

            
        }

       

     

       
    }
}
