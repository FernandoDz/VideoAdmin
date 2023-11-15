namespace AdminVideoDa.Models
{
    public class AuthResponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
