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
      try
    {
        if (hospedes.Count <= Suite.Capacidade)
        {
            Hospedes = hospedes;
            
        }
        else
        {
            throw new Exception("Capacidade máxima da suíte excedida.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro durante o cadastro de hóspedes: " + ex.Message);
        
    }
    }


    public void CadastrarSuite(Suite suite)
    {
      Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
       return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        decimal valor = DiasReservados * Suite.ValorDiaria;
          
        if (DiasReservados >= 10)
        {
            valor = valor - (valor *0.10m);
            
        } 
        return valor;

    }
  }
}