namespace HttpExampl_28_11_2023
{
    internal class Program
    {
        static  async Task Main(string[] args)
        {
            // установить программу postman ---- 28-11-2023
            // // 1.создание http - клиента
            //HttpClient httpClient = new HttpClient();
            // // 2.выполнение запроса
            // HttpResponseMessage respons = await httpClient.GetAsync("http://numbersapi.com/random");
            // // 3. считать
            // string responsBody =  await respons.Content.ReadAsStringAsync();
            // Console.WriteLine(responsBody);
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage respons = await httpClient.GetAsync($"http://numbersapi.com/{10}");
            string responsBody =  await respons.Content.ReadAsStringAsync();
            Console.WriteLine(responsBody);
            Console.WriteLine($"Код ответа: {(int)respons.StatusCode}");
           
        }
    }
}