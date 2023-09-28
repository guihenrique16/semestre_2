namespace WebApi.HealthClinic.Tarde.Utils
{
    public static class Criptografia
    {
        public static String GerarHash(String senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }

        /// <summary>
        /// Verifica se a hash da senha informada e igaual a do banco
        /// </summary>
        /// <param name="senhaForm"> senha informada</param>
        /// <param name="senhaBanco"> senha do banco</param>
        /// <returns></returns>
        public static bool CompararHash(String senhaForm, String senhaBanco)
        {
            return BCrypt.Net.BCrypt.Verify(senhaForm, senhaBanco);
        }
    }
}
