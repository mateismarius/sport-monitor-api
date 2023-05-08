namespace SportMonitorAPI.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
        private string? GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A aparut o eroare! Va rugam sa incercati din nou!",
                401 => "Utilizatorul sau parola sunt incorecte",
                404 => "Aceasta resursa nu exista",
                500 => "Eroare server! Va rugam sa incercati din nou!",
                _ => null
            };
        }

    }
}
