﻿using InjecaodeDependencia.InputModel;
using InjecaodeDependencia.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InjecaodeDependencia.Services
{
    public interface IJogoService : IDisposable
    {
        Task<List<JogoViewModel>> Obter(int page, int quant);
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id,JogoInputModel jogo);
        Task Remover(Guid id);
    }
}
