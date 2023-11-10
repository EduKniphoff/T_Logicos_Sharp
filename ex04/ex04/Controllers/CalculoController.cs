using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

//Configurando o controller conforme orientação da tutora
[ApiController]
[Route("[controller]")]

public class CalculoController : ControllerBase
{
    private readonly ILogger<CalculoController> _logger;
    public CalculoController(ILogger<CalculoController> logger)
    {
        _logger = logger;
    }
    [HttpPost]


    //Por fim o cálculo que vai definir se o valor é de um triangulo pitagorico ou nao
    public String Post(string ru)
    {
        var a = Math.Pow(int.Parse(ru.ElementAt(ru.Length - 3).ToString()), 2);
        var b = Math.Pow(int.Parse(ru.ElementAt(ru.Length - 2).ToString()), 2);
        var c = Math.Pow(int.Parse(ru.ElementAt(ru.Length - 1).ToString()), 2);

        var resposta = "Não é um triangulo pitagorico.";

        if (c == (a + b)) {
            resposta = "É um triangulo pitagorico.";
        }

        var options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),

            WriteIndented = true
        };
        return JsonSerializer.Serialize(resposta,options);

    }

}

