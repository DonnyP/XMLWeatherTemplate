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
        int day;

        List<ForecastClass> days = new List<ForecastClass>();

        public loadScreen()
        {
            InitializeComponent();
            // get information about current and forecast weather from the internet
            GetData();

            // take info from the current weather file and display it to the screen
            ExtractCurrent();

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
                            windSpeed.Text = grandChild.Attributes["name"].Value;
                        }
                    }
                }

            }
        }

        private void ExtractForecast()
        {
            string rain, high, low, windDirection, windSpeed, date;
            rain = high = low = windDirection = windSpeed = date = "";


            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData7Day.xml");

            //create a node variable to represent to parent element
            XmlNode parent;
            parent = doc.DocumentElement;

            // int day = 1;

            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "forecast")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        switch (day)
                        {
                            case 1:
                                #region day 1
                                if (grandChild.Name == "time")
                                {
                                    date = grandChild.Attributes["days"].Value;
                                }
                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "symbol")
                                    {
                                        rain = greatGrandChild.Attributes["name"].Value + " ";
                                    }

                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        windDirection = greatGrandChild.Attributes["name"].Value + "";
                                    }

                                    if (greatGrandChild.Name == "windSpeed")
                                    {
                                        windSpeed = greatGrandChild.Attributes["mps"].Value;
                                    }
                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        high = greatGrandChild.Attributes["max"].Value;
                                        low = greatGrandChild.Attributes["min"].Value;
                                    }
                                }
                                ForecastClass fc = new ForecastClass(high, low, windDirection, windSpeed, rain, date);
                                days.Add(fc);
                                day++;
                                #endregion
                                break;
                            case 2:
                                #region day 2
                                if (grandChild.Name == "time")
                                {
                                    date = grandChild.Attributes["days"].Value;
                                }
                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "symbol")
                                    {
                                        rain = greatGrandChild.Attributes["name"].Value + " ";
                                    }

                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        windDirection = greatGrandChild.Attributes["name"].Value + "";
                                    }

                                    if (greatGrandChild.Name == "windSpeed")
                                    {
                                        windSpeed = greatGrandChild.Attributes["mps"].Value;
                                    }
                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        high = greatGrandChild.Attributes["max"].Value;
                                        low = greatGrandChild.Attributes["min"].Value;
                                    }
                                }
                                ForecastClass fc2 = new ForecastClass(high, low, windDirection, windSpeed, rain, date);
                                days.Add(fc2);
                                day++;
                                #endregion
                                break;

                            case 3:
                                #region day 3
                                if (grandChild.Name == "time")
                                {
                                    date = grandChild.Attributes["days"].Value;
                                }
                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "symbol")
                                    {
                                        rain = greatGrandChild.Attributes["name"].Value + " ";
                                    }

                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        windDirection = greatGrandChild.Attributes["name"].Value + "";
                                    }

                                    if (greatGrandChild.Name == "windSpeed")
                                    {
                                        windSpeed = greatGrandChild.Attributes["mps"].Value;
                                    }
                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        high = greatGrandChild.Attributes["max"].Value;
                                        low = greatGrandChild.Attributes["min"].Value;
                                    }
                                }
                                ForecastClass fc3 = new ForecastClass(high, low, windDirection, windSpeed, rain, date);
                                days.Add(fc3);
                                day++;
                                #endregion
                                break;
                            case 4:
                                #region day 4
                                if (grandChild.Name == "time")
                                {
                                    date = grandChild.Attributes["days"].Value;
                                }
                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "symbol")
                                    {
                                        rain = greatGrandChild.Attributes["name"].Value + " ";
                                    }

                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        windDirection = greatGrandChild.Attributes["name"].Value + "";
                                    }

                                    if (greatGrandChild.Name == "windSpeed")
                                    {
                                        windSpeed = greatGrandChild.Attributes["mps"].Value;
                                    }
                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        high = greatGrandChild.Attributes["max"].Value;
                                        low = greatGrandChild.Attributes["min"].Value;
                                    }
                                }
                                ForecastClass fc4 = new ForecastClass(high, low, windDirection, windSpeed, rain, date);
                                days.Add(fc4);
                                day++;
                                #endregion
                                break;
                            default:
                                break;
                        }
                    }
                }


























                //check each child parent element
                //foreach (XmlNode child in parent.ChildNodes)
                //{
                //    if (child.Name == "forecast")
                //    {
                //        foreach (XmlNode grandChild in child.ChildNodes)
                //        {
                //            foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                //            {
                //                if (greatGrandChild.Name == "temperature")
                //                {
                //                    switch (day)
                //                    {
                //                        case 1:
                //                            minOutput.Text = greatGrandChild.Attributes["min"].Value;
                //                            maxOutput.Text = greatGrandChild.Attributes["max"].Value;
                //                            break;
                //                        case 2:
                //                            min2Output.Text = greatGrandChild.Attributes["min"].Value;
                //                            max2Output.Text = greatGrandChild.Attributes["max"].Value;
                //                            break;
                //                        default:
                //                            break;
                //                    }

                //                }
                //                if (greatGrandChild.Name == "clouds")
                //                {
                //                    switch (day)
                //                    {
                //                        case 1:
                //                            day1Clouds.Text = greatGrandChild.Attributes["value"].Value;
                //                            day++;
                //                            break;
                //                        case 2:
                //                            day2Clouds.Text = greatGrandChild.Attributes["value"].Value;
                //                            day++;
                //                            break;
                //                        default:
                //                            break;
                //                    }
                //                }

                //            }
                //        }
                //    }

                //}

            }
        }


        private void MakePictureParent()
        {

        }


        private void day1Button_Click(object sender, EventArgs e)
        {
            minOutput.Text = days[0].high + " C";
            maxOutput.Text = days[0].low + " C";
            windDirection.Text = days[0].windDirection;
            windSpeed.Text = days[0].windSpeed;
        }

        private void day2Button_Click(object sender, EventArgs e)
        {
            minOutput.Text = days[1].high + " C";
            maxOutput.Text = days[1].low + " C";
            windDirection.Text = days[1].windDirection;
            windSpeed.Text = days[1].windSpeed;
        }

        private void day3Button_Click(object sender, EventArgs e)
        {

            minOutput.Text = days[2].high + " C";
            maxOutput.Text = days[2].low + " C";
            windDirection.Text = days[2].windDirection;
            windSpeed.Text = days[2].windSpeed;
        }

        private void day4Button_Click(object sender, EventArgs e)
        {

            minOutput.Text = days[3].high + " C";
            maxOutput.Text = days[3].low + " C";
            windDirection.Text = days[3].windDirection;
            windSpeed.Text = days[3].windSpeed;
        }
    }
}

