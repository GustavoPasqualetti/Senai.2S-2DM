﻿using Microsoft.EntityFrameworkCore;
using WebAPI.InLock.DbFirst.Contexts;
using WebAPI.InLock.DbFirst.Domains;
using WebAPI.InLock.DbFirst.Interface;

namespace WebAPI.InLock.DbFirst.Repositores
{
    public class EstudioRepository : IEstudioRepository
    {
        InLockContext ctx = new InLockContext();

        public void Atualizar(Guid id, Estudio estudio)
        {
            throw new NotImplementedException();
        }

        public Estudio BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Estudio estudio)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Estudio> Listar()
        {
            return ctx.Estudios.ToList();
        }

        public List<Estudio> ListarComJogos()
        {
            return ctx.Estudios.Include(e => e.Jogos).ToList();
        }
    }
}
