﻿using System.ComponentModel.DataAnnotations;

namespace CarteiraDoInvestidor.Application.Carteira.Dto
{
    public record CarteiraInputDto(string NomeCarteira, string Descricao, DateTime DataCriacao, List<AtivosInputDto> Ativos);
    public record CarteiraOutputDto(Guid Id, string NomeCarteira, string Descricao, DateTime DataCriacao, List<AtivosInputDto> Ativos);
    public record AtivosInputDto(
        [Required(ErrorMessage = "Nome do ativo é obrigatório")] string Papel,
        [Required(ErrorMessage = "Quantidade de ativos é obrigatório")] int Quantidade,
        [Required(ErrorMessage = "Preço Médio do ativo é obrigatório")] double PrecoMedio,
        [Required(ErrorMessage = "Corretora é obrigatório")] string Corretora);
    public record AtivosOutputDto(Guid Id, string Papel, int Quantidade, double PrecoMedio, string Corretora);
    public record CarteiraUpdateDto(Guid Id, string NomeCarteira, string Descricao, DateTime DataCriacao);
}
