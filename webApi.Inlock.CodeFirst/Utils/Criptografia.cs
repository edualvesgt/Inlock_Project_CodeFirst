namespace webApi.Inlock.CodeFirst.Utils
{
    public static class Criptografia
    {
        /// <summary>
        /// Gera uma Hash Apartir de uma senha 
        /// </summary>
        /// <param name="senha">A senha que receberar a Hash</param>
        /// <returns>Senha Criptografada </returns>
        public static string GerarHash(string senha )
        {
            return BCrypt.Net.BCrypt.HashPassword( senha );
        }

        /// <summary>
        /// VErifica se a Hash da senha Informada e Igual a Hash salva no banco 
        /// </summary>
        /// <param name="senhaForm"> Senha INformada pelo Usuario</param>
        /// <param name="senhaBanco"> Senha salva no banco de dados </param>
        /// <returns> true ou false (senha e verdadeira)</returns>
        public static bool  CompararHash (string senhaForm , string senhaBanco )
        {
            return BCrypt.Net.BCrypt.Verify(senhaBanco, senhaForm );
        }
    }
}
