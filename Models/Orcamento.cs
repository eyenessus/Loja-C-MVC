using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Loja.Models;
namespace Loja.Models
{
    public class Orcamento
    {
    private static List<ItemOrcamento> lista = new List<ItemOrcamento>();
    //metodos adcionar itens no orcamento e o metodo de listagem
    public static void Incluir(ItemOrcamento item){
        lista.Add(item);
    }
    public static List<ItemOrcamento> Listagem(){
            return lista;
        }
    }
}