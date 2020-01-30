namespace Banco
{
    public class Cliente
    {
        public string nome;
        public double pagamento;

        public double divida;
        
        public double troco;



        public Cliente()
        {
            
        }

        public Cliente(string nome, double pagamento, double divida, double troco)
        {
            this.nome = nome; 
            this.pagamento = pagamento;
            this.divida = divida;
            this.troco = troco;
        }

    }
}