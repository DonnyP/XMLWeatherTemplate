using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Net;

namespace XMLWeather
{
    public partial class loadScreen : UserControl
    {
        public loadScreen()
        {
            InitializeComponent();
            // get information about current and forecast weather from the internet
            GetData();

            // take info from the current weather file and display it to the screen
            //ExtractCurrent();

            // take info from the forecast weather file and display it to the screen
            ExtractForecast();
        }
        private static void GetData()
        {
            WebClient client = new WebClient();

            string currentFile = "http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0";
            string forecastFile = "http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";

            //client.DownloadFile(currentFile, "WeatherData.xml");
            //client.DownloadFile(forecastFile, "WeatherData7Day.xml");
        }

        private void ExtractCurrent()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData.xml");

            //create a node variable to represent the parent element
            XmlNode parent;
            parent = doc.DocumentElement;

            //check each child of the parent element
            foreach (XmlNode child in parent.ChildNodes)
            {
                // TODO if the "city" element is found display the value of it's "name" attribute
                if (child.Name == "city")
                {
                    cityOutput.Text = child.Attributes["name"].Value;
                }

                if (child.Name == "temperature")
                {
                    currentTempOut.Text = child.Attributes["value"].Value;
                }
                if (child.Name == "wind")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        if (grandChild.Name == "speed")
                        {
                            windDescOut.Text = grandChild.Attributes["name"].Value;
                        }
                    }
                }

            }
        }

        private void ExtractForecast()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData7Day.xml");

            //create a node variable to represent to parent element
            XmlNode parent;
            parent = doc.DocumentElement;

            int day = 1;

            //check each child parent element
            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "forecast")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                        {
                            if (greatGrandChild.Name == "temperature")
                            {
                                switch (day)
                                {
                                    case 1:
                                        minOutput.Text = greatGrandChild.Attributes["min"].Value;
                                        maxOutput.Text = greatGrandChild.Attributes["max"].Value;
                                        break;
                                    case 2:
                                        min2Output.Text = greatGrandChild.Attributes["min"].Value;
                                        max2Output.Text = greatGrandChild.Attributes["max"].Value;
                                        break;
                                    default:
                                        break;
                                }

                            }
                            if (greatGrandChild.Name == "clouds")
                            {
                                switch (day)
                                {
                                    case 1:
                                        day1Clouds.Text = greatGrandChild.Attributes["value"].Value;
                                        day++;
                                        break;
                                    case 2:
                                        day2Clouds.Text = greatGrandChild.Attributes["value"].Value;
                                        day++;
                                        break;
                                    default:
                                        break;
                                }
                            }

                        }
                    }
                }

            }

        }


        private void MakePictureParent()
        {

        }

    }
}

