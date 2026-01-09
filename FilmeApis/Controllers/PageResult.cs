namespace FilmeApis.Controllers;

public class PageResult<T>
{
   
        public int TotalRegistros { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
        public IEnumerable<T> Itens { get; set; }
    
}
