﻿using System;
using System.Collections.Generic;

namespace Orix.MeuControle.Repository.Contracts.Base
{
    public interface ILeitura<TClasse>
    {
        TClasse Buscar(Int32 id);

        List<TClasse> Listar();
    }
}
