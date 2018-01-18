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
using WpfApplication15.Model;

namespace WpfApplication15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WpfApplication15.Model.Model1 db = new WpfApplication15.Model.Model1();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void GetDataArea1()
        {
            GV.Columns.Clear();
            List<Area> data = db.Area.Where(aw => aw.WorkingPeople > 2).ToList();

            GV.Columns.Add(new GridViewColumn() { Header = "AreaID", DisplayMemberBinding = new Binding() { Path = new PropertyPath("AreaID") } });
            GV.Columns.Add(new GridViewColumn() { Header = "FullName", DisplayMemberBinding = new Binding() { Path = new PropertyPath("FullName") } });
            List.ItemsSource = data;
        }

        public void GetDataArea2()
        {
            var data = db.Area.Take(10);
        }

        public void GetDataArea3()
        {
            var data = db.Area.Skip(5).Take(8);
        }

        public void GetDataArea4()
        {
            var data = db.Area.ToList();
            var data2 = data.TakeWhile(dtw => dtw.OrderExecution != null);
        }

        public void GetDataArea5()
        {
            var data = db.Area.ToList();
            var data2 = data.TakeWhile(dtw => dtw.OrderExecution == null);
        }

        public void GetDataArea6()
        {
            var data = db.Area.GroupBy(agb => agb.IP);
        }

        public void GetDataArea7()
        {
            int[] arr = new[] { 22, 23, 24, 25, 26, 27, 28 };
            var data = db.Timer.Where(twh => arr.Contains(twh.AreaId.Value));
        }

        public void GetDataArea8()
        {
            var data = db.Timer.Where(twh => twh.DateFinish != null).Count();
        }

        public void GetDataArea9()
        {
            var data = db.Area.ToList();
            var data2 = data.TakeWhile(tw => tw.OrderExecution != null);
        }

        public void GetDataArea10()
        {
            var data = db.Timer.Join(db.Area, tm => tm.AreaId, ar => ar.AreaId, (tm, ar) => new { tm, ar });
        }

        public void GetDataArea11()
        {
            var data = db.Timer.GroupBy(item => item.DateStart).OrderByDescending(obd => obd.Key.Value);
        }

        public void GetDataArea12()
        {
            var data = db.Area.Where(aw = aw.Wor)
        }

        private void GetData_Click(object sender, RoutedEventArgs e)
        {

        }

        /*
         public void GetDataArea10()
         {
             var data = db.
         }
         */


    }
}
