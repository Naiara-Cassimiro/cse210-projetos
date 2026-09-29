public class Endereco
{
    private string _rua;
    private string _cidade;
    private string _estadoProvincia;
    private string _pais;

    public Endereco(string rua, string cidade, string estadoProvincia, string pais)
    {
        _rua = rua;
        _cidade = cidade;
        _estadoProvincia = estadoProvincia;
        _pais = pais;
    }

    public bool EstaNosEUA()
    {
        return _pais.ToLower() == "usa";
    }

    public string GetEnderecoCompleto()
    {
        return $"{_rua}\n{_cidade}, {_estadoProvincia}\n{_pais}";
    }
}