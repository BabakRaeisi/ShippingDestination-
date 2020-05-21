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



namespace POD_destinations
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           if (textBox.Text == " امام خمینی" | textBox.Text== "بندر امام خمینی")
            { label1.Content = "فاصله به مایل دریایی"+ "\n" +560 + "miles"; }
            else if (textBox.Text == "بوشهر" | textBox.Text == "بندر بوشهر")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 435 + "miles"; }
            else if (textBox.Text == "خارک" | textBox.Text == "بندر ")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 450 + "miles"; }
            else if (textBox.Text == "گناوه" | textBox.Text == "بندر گناوه")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 460 + "miles"; }
            else if (textBox.Text == "کیش" | textBox.Text == "جزیره کیش")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 170 + "miles"; }
            else if (textBox.Text == "سیری" | textBox.Text == "جزیره سیری")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 135 + "miles"; }
            else if (textBox.Text == "ابوموسی" | textBox.Text == "جزیره ابوموسی")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 115 + "miles"; }
            else if (textBox.Text == "لنگه" | textBox.Text == "بندر لنگه")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 130 + "miles"; }
            else if (textBox.Text == "قشم" | textBox.Text == "جزیر قشم")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 13 + "miles"; }
            else if (textBox.Text == "جاسک" | textBox.Text == "بندر جاسک")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 145 + "miles"; }
            else if (textBox.Text == "چاه بهار" | textBox.Text == "بندر چاه بهار")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 305 + "miles"; }
            else if (textBox.Text == "فارسی" | textBox.Text == "جزیره فارسی")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 393 + "miles"; }
            else if (textBox.Text == "لاوان" | textBox.Text == "جزیره لاوان")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 198 + "miles"; }
            else if (textBox.Text == "هنگام" | textBox.Text == "جزیره هنگام")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 46 + "miles"; }
            else if (textBox.Text == "لارک" | textBox.Text == "جزیره لارک")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 21 + "miles"; }
            else if (textBox.Text == "هرمز" | textBox.Text == "جزیره هرمز")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 11 + "miles"; }
            else if (textBox.Text == "طاهری" | textBox.Text == "جزیره طاهری")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 267 + "miles"; }
            else if (textBox.Text == "تنب بزرگ" )
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 91 + "miles"; }
            else if (textBox.Text == "تنب کوچک")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 83 + "miles"; }
            else if (textBox.Text == "خرمشهر")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 545 + "miles"; }
            else if (textBox.Text == "ابادان")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 542 + "miles"; }
            else if (textBox.Text == "لنگه - کیش")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 47 + "miles"; }
            else if (textBox.Text == "لنگه - لاوان")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 100 + "miles"; }
            else if (textBox.Text == "لنگه - سیری")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 42 + "miles"; }
            else if (textBox.Text == "عسلویه")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 230 + "miles"; }
            else if (textBox.Text == "کرگان")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 55 + "miles"; }
            else if (textBox.Text == "کویت")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 550 + "miles"; }
            else if (textBox.Text == "قطر - دها")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 320 + "miles"; }
            else if (textBox.Text == "شارجه")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 120 + "miles"; }
            else if (textBox.Text == "عمان - مسقط")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 255 + "miles"; }
            else if (textBox.Text == "دبی")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 140 + "miles"; }
            else if (textBox.Text == "عجمان")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 115 + "miles"; }
            else if (textBox.Text == "ام القوین")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 117 + "miles"; }
            else if (textBox.Text == "راس الخیمه")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 95 + "miles"; }
            else if (textBox.Text == "خورفكان")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 120 + "miles"; }
            else if (textBox.Text == "فجیره")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 135 + "miles"; }
            else if (textBox.Text == "جبل علی")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 150 + "miles"; }
            else if (textBox.Text == "دمام")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 335 + "miles"; }
            else if (textBox.Text == "بحرین")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 341 + "miles"; }
            else if (textBox.Text == "کراچی پاکستان")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 500 + "miles"; }
            else if (textBox.Text == "ابوظبی")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 255 + "miles"; }
            else if (textBox.Text == "مینا سقر")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 62 + "miles"; }
            else if (textBox.Text == "سلاله عمان")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 250 + "miles"; }
            else if (textBox.Text == "ابوفلوس")
            { label1.Content = "فاصله به مایل دریایی" + "\n" + 545 + "miles"; }
            else { label1.Content = "مقصد وجود ندارد یا نام به درستی وارد نشده"; }


        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
