public class Operacoes
{
    private string connectionString = "";
    public int Criar(Tarefa tarefa)
    {
            using(var conexao = new MySqlConnectionString))
    {
        conexao.Open();
        string sql = @"INSERT INTO tarefa(nome, descricao, dataCriacao, status, dataExecucao)
                     VALUES @nome, @descricao, @dataCriacao, @Status, @dataExecucao);
                     SELECT LAST_INSERT_ID();";
        using (var cmd = new MySqlComand(sql, conexao))           
        {
            cmd.Parameters.AddwithValue("@nome", tarefa.Nome);
            cmd.Parameters.AddwithValue("@descricao", tarefa.Descricao);
            cmd.Parameters.AddwithValue("@dataCriacao", tarefa.DataCriacao);
            cmd.Parameters.AddwithValue("@status", tarefa.Status);
            cmd.Parameters.AddwithValue("@dataExecucao", tarefa.DataExecucao);
         
            return Convert.ToInt32(cmd.ExecuteScalar());
        }  

    }
}
        public  Tarefa Buscar(int id)
        {
            return null;
        }
        public List<Tarefa> Listar()
    {
        return Array.Empty<Tarefa>();
    }
    public void Alterar (Tarefa tarefa)
    {

    }
        public void Excluir(int id)
    {

    }
}