﻿using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

//modificado ✌🏼
Console.WriteLine("-".PadLeft(50, '-'));
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
Console.WriteLine("-".PadLeft(50, '-'));
precoInicial = Convert.ToDecimal(Console.ReadLine());

//modificado ✌🏼
Console.WriteLine("-".PadLeft(50, '-'));
Console.WriteLine("Agora digite o preço por hora:");
Console.WriteLine("-".PadLeft(50, '-'));
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    //modificado ✌🏼
    Console.Clear();
    Console.WriteLine("-".PadLeft(50, '-'));
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("-".PadLeft(50, '-'));
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("-".PadLeft(50, '-'));
    Console.WriteLine("4 - Encerrar");
    Console.WriteLine("-".PadLeft(50, '-'));

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            Console.WriteLine("-".PadLeft(50, '-')); //modificado ✌🏼
            break;

        default:
            //modificado ✌🏼
            Console.WriteLine("-".PadLeft(50, '-'));
            Console.WriteLine("Opção inválida");
            Console.WriteLine("-".PadLeft(50, '-'));
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

//modificado ✌🏼
Console.WriteLine("-".PadLeft(50, '-'));
Console.WriteLine("O programa se encerrou");
Console.WriteLine("-".PadLeft(50, '-'));