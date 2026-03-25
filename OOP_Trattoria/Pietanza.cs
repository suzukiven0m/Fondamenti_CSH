using System.Runtime.CompilerServices;

namespace OOP_Trattoria;
public class Pietanza
{
    private string _nome;
    private double _costo;
    private string _tipo;
    
    
    public string Nome => _nome;
    public double Costo => _costo;
    public string Tipo => _tipo;

    public Pietanza(string nome, double costo, string tipo)
    {
        _nome = nome;
        _costo = costo;
        _tipo = tipo;
    }
}