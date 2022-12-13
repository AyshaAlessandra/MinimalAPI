using System.Text.Json.Serialization;

namespace ApiCatalogo.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }

        //uma categoria pode ter mais de um produto.

        [JsonIgnore]
        public ICollection<Produto> Produtos { get; set; }
    }
}
