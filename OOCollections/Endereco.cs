using System;
using System.Collections.Generic;
using System.Text;

namespace OOCollections
{
    public enum TipoEndereco
    {
        Residencial = 1,
        Comercial = 2,
        Academico = 3,
        Outros = 4
    }
    public class Endereco : IEndereco
    {
        public int ID { get; set; }
        public TipoEndereco TipoEndereco { get; set; }

        public string DescricaoTipoEndereco { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Consultar()
        {
            switch (this.TipoEndereco)
            {
                case TipoEndereco.Residencial:
                    this.DescricaoTipoEndereco = "Residencial";
                    break;
                case TipoEndereco.Comercial:
                    this.DescricaoTipoEndereco = "Comercial";
                    break;
                case TipoEndereco.Academico:
                    this.DescricaoTipoEndereco = "Acadêmico";
                    break;
                case TipoEndereco.Outros:
                    this.DescricaoTipoEndereco = "Outros";
                    break;
                default:
                    this.DescricaoTipoEndereco = "Não Especificado";
                    break;
            }

            StringBuilder sbEndereco = new StringBuilder();
            sbEndereco.AppendLine("Tipo de Endereço: " + this.DescricaoTipoEndereco);

            sbEndereco.AppendLine("Logradouro: " + this.Logradouro);
            sbEndereco.AppendLine("Complemento: " + this.Complemento);
            sbEndereco.AppendLine("Bairro: " + this.Bairro);
            sbEndereco.AppendLine("Cidade: " + this.Cidade);

            return sbEndereco.ToString();


        }
    }
}
