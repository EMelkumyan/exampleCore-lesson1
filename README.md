# exampleCore-lesson1

1) оголосили список 
   private static List<WeatherForecast> WeatherForecasts { get; set; }

2) ініціалізували його в конструкторі
   static WeatherForecastController()
        {
            WeatherForecasts = new List<WeatherForecast>();
        }
        
3) повернули список в [HttpGet]
   return WeatherForecasts;  

4) написали post запит
        [HttpPost]
        public void Create(WeatherForecast weatherForecast)
        {
            WeatherForecasts.Add(weatherForecast);
        }
