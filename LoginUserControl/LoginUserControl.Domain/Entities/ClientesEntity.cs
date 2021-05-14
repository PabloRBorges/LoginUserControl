﻿using System.Collections.Generic;

namespace LoginUserControl.Core.Entities
{
    public class Cliente : BaseEntity
    {
		public string Nome { get; set; }
		public string RazaoSocial { get; set; }
		public string Responsavel { get; set; }
		public string CEP { get; set; }
		public string Endereco { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string Estado { get; set; }
		public string LocalGPS { get; set; }
        public List<Contrato> Contratos { get; set; }
    }


}
