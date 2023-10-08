﻿using Newtonsoft.Json;

namespace MetodologiaDeDesarrolloGrupo3App.Models.Users
{
    public class Usuario
    {
        public Usuario() { }

        public string UserName { get; set; }
        public string Password { get; set; }


        [JsonProperty("NOMBREUSUARIO")]
        public string NombreUsuario { get; set; }

        [JsonProperty("PERFIL")]
        public string Perfil { get; set; }

        [JsonProperty("OBSERVACION")]
        public string Observacion { get; set; }

        [JsonProperty("CODIGOPERFIL")]
        public int CodigoPerfil { get; set; }

        [JsonProperty("ESTADO")]
        public string Estado { get; set; }

        [JsonProperty("COMPANIA")]
        public int Compania { get; set; }

        [JsonProperty("Emisor")]
        public int Emisor { get; set; }

        [JsonProperty("Cargo")]
        public int Cargo { get; set; }

        [JsonProperty("NOMBREEMISOR")]
        public string NombreEmisor { get; set; }

        [JsonProperty("NOMBRECOMPANIA")]
        public string NombreCompania { get; set; }

        [JsonProperty("USUARIOCLIENTE")]
        public string UsuarioCliente { get; set; }

        [JsonProperty("RucUsuario")]
        public string RucUsuario { get; set; }

    }
}
