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
using ThinkLib;

namespace MyStrings
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(length("qwe"), 3);
            Tester.TestEq(length("q"), 1);
            Tester.TestEq(length("hguhfipolq"), 10);
            Tester.TestEq(length(""), 0);
            Tester.TestEq(length("     "), 0);


        }

        int length (string x)
        {
            int count = 0;
            foreach(char a in x)
                
            {
                if(a == ' ')
                {
                    continue;
                }
                count++;
            }
            return count;
        }

        bool contains (string s, string subs)
        {
            
            int count = 0;
            foreach(char a in s)
            {
                if(a == subs[count])
                {
                    count++;
                    if (count == length(subs))
                    {
                        return true;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            return false;
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(contains("qwerty", "w"), true);
            Tester.TestEq(contains("qwerty", "werty"), true);
            Tester.TestEq(contains("qwerty", "zap"), false);
            Tester.TestEq(contains("qwerty", "wet"), false);
            Tester.TestEq(contains("", "w"), false);
            Tester.TestEq(contains("a", " "), false);

        }

        int IndexOf(string s, string subs)
        {
            int count = 0;
            int x = 0;
            foreach (char a in s)
            {
               
                if (a == subs[count])
                {
                    count++;
                    if(count==length(subs))
                    {
                        
                        return x + 1 - length(subs);
                    }
                   
                }
                else
                {
                    count = 0;
                }
                x++;
            }
            return -1;

            
            {
                
            }
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(IndexOf("zapcooldos", "cool"), 3);
            Tester.TestEq(IndexOf("qwerty", "er"), 2);
            Tester.TestEq(IndexOf("computerscienceisfun", "eisf"), 14);
            Tester.TestEq(IndexOf("   table", "bl"), 5);
            Tester.TestEq(IndexOf("ijhgufhdyhfnbmclhappyafhauowfwdklnawlds   ...", "happy"), 16);
            Tester.TestEq(IndexOf("zapcooldos", "xxx"), -1);
            Tester.TestEq(IndexOf("zapcooldos", "ols"), -1);
            Tester.TestEq(IndexOf("sssssag", "sag"), 4);

        }

        string InsertSubString (string s, string x, int pos)
        {
            int i = 0;
            string a = "";
            while (i < pos) 
            {
                a += s[i];
                i++;
            }
            a += x;
            i = pos;
            while((i>=pos)&&(i<length(s)))
            {
                a += s[i];
                i++;
            }
            return a;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(InsertSubString("nicefriend", "tale", 4), "nicetalefriend");
            Tester.TestEq(InsertSubString("nicefriend", "code", 4), "nicecodefriend");
            Tester.TestEq(InsertSubString("hive", "ghfi", 2), "highfive");
            Tester.TestEq(InsertSubString("qqqwerty", "ty", 6), "qqqwertyty");
        }

        int Compare(string x, string y)
        {
            int i = 0;
            foreach (char c in x)
            {
                if (c < y[i])
                {
                    return -1;
                }
                else if((c > y[i]))
                    {
                    return 1;     
                    }
                else if (c == y[i])
                {
                    i++;
                    while (i < length(x) && i < length(y))
                    {
                        if (x == y)
                        {
                            return 0;
                        }
                        else if (c < y[i])
                        {
                            return -1;
                        }
                        else if (c > y[i])
                        {
                            return 1;
                        }
                    }
                }
                i++;
            }
            
            {
                
            }
            if(x==y)
            {
                return 0;
            }
            return 5;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(Compare("abcd", "bcde"), -1);
            Tester.TestEq(Compare("zabcd", "bcde"), 1);
            Tester.TestEq(Compare("qwerty", "qwerty"), 0);
            Tester.TestEq(Compare("qwerty", "qwertyz"), -1);
        }
    }
}
