﻿using Livraria.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Dominio.Interface
{
    public interface IAutorRepositorio<T> : IRepositorio<Autor>
    {
        T BuscarNome(string nome);
    }
}
