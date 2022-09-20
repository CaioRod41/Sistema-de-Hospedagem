namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int QuantidadeHospedes = hospedes.Count;
           
            if(QuantidadeHospedes <= Suite.Capacidade){
                this.Hospedes = hospedes;
            }else{
                Console.WriteLine($"Quantidade de hospede excede o limite máximo!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int hospedes = Hospedes.Count;
            return hospedes;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = DiasReservados * Suite.ValorDiaria;
            const decimal DESCONTO = 0.10M;
            decimal valorDescontado = valor - (valor * DESCONTO);

            
            if (DiasReservados >= 10)
            {
                return valorDescontado;
            }

            return valor;
        }
    }
}