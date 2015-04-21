using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Sensors.Resources;
using Microsoft.Devices.Sensors;
using Microsoft.Xna.Framework;


namespace Sensors
{
    public partial class MainPage : PhoneApplicationPage
    {
        Accelerometer Acc;
        Gyroscope Gyr;
        Compass Comp;
        
       

        
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void loadAcc(Object sender, RoutedEventArgs e)
        {
            Acc = new Accelerometer();
            Acc.TimeBetweenUpdates = TimeSpan.FromMilliseconds(5);
            Acc.CurrentValueChanged += new EventHandler<SensorReadingEventArgs<AccelerometerReading>>(AccHandler);
            Acc.Start();
        }

        private void LoadGyros(Object sender, RoutedEventArgs e)
        {
            Gyr = new Gyroscope();
            Gyr.TimeBetweenUpdates = TimeSpan.FromMilliseconds(5);
            Gyr.CurrentValueChanged += new EventHandler<SensorReadingEventArgs<GyroscopeReading>>(GyroHandler);
            Gyr.Start();
        }

        private void LoadComp(Object sender, RoutedEventArgs e)
        {
            Comp = new Compass();
            Comp.TimeBetweenUpdates = TimeSpan.FromMilliseconds(5);
            Comp.CurrentValueChanged += new EventHandler<SensorReadingEventArgs<CompassReading>>(CompHandler);
            Comp.Start();
        }

        private void CompHandler(object sender, SensorReadingEventArgs<CompassReading> e)
        {
            Dispatcher.BeginInvoke(() => RefreshUIComp(e.SensorReading));

         //   throw new NotImplementedException();
        }
         
       

        private void GyroHandler(object sender, SensorReadingEventArgs<GyroscopeReading> e)
        {
            Dispatcher.BeginInvoke(() => RefreshUIGyro(e.SensorReading));
           // throw new NotImplementedException();
        }

        private void AccHandler(object sender, SensorReadingEventArgs<AccelerometerReading> e)
        {
            Dispatcher.BeginInvoke(() => RefreshUI(e.SensorReading));
           // throw new NotImplementedException();
        }

        private void RefreshUI(AccelerometerReading accRead)
        {
            Vector3 accDir = accRead.Acceleration;
            Values.Text = "Acelerometro \nx: " + accDir.X.ToString() + "\nY: " + accDir.Y.ToString() + "\nZ: " + accDir.Z.ToString();
        }

        private void RefreshUIGyro(GyroscopeReading Gyroread)
        {
            Vector3 gyroDir = Gyroread.RotationRate;
            ValuesG.Text = "Gyroscopio \nx: " + gyroDir.X.ToString() + "\nY: " + gyroDir.Y.ToString() + "\nZ: " + gyroDir.Z.ToString();
        }

        private void RefreshUIComp(CompassReading Compread)
        {
            Double compDir = Compread.HeadingAccuracy;
            ValuesC.Text ="Brujula \n" +compDir + "°";
        }


      


        // Código de ejemplo para compilar una ApplicationBar traducida
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Establecer ApplicationBar de la página en una nueva instancia de ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crear un nuevo botón y establecer el valor de texto en la cadena traducida de AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crear un nuevo elemento de menú con la cadena traducida de AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}