﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Projeto_Interdisciplinar.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Interdisciplinar.DAO
{
    public class ItensPedidoDAO : PadraoDAO<ItensPedidoViewModel>
    {
        protected override SqlParameter[] CriaParametros(ItensPedidoViewModel itensPedido)
        {
            object quantidade = itensPedido.Quantidade;
            object valorUnitario = itensPedido.ValorUnitario;

            if (quantidade == null)
                quantidade = DBNull.Value;
            if (valorUnitario == null)
                valorUnitario = DBNull.Value;

            SqlParameter[] p = new SqlParameter[5];
            p[0] = new SqlParameter("Id", itensPedido.Id);
            p[1] = new SqlParameter("IDPedido", itensPedido.IDPedido);
            p[2] = new SqlParameter("IDProduto", itensPedido.IDProduto);
            p[3] = new SqlParameter("Quantidade", quantidade);
            p[4] = new SqlParameter("ValorUnitario", valorUnitario);

            return p;
        }

        protected override ItensPedidoViewModel MontaModel(DataRow registro)
        {
            ItensPedidoViewModel ip = new ItensPedidoViewModel();
            ip.Id = Convert.ToInt32(registro["Id"]);
            ip.IDPedido = Convert.ToInt32(registro["IDPedido"]);
            ip.IDProduto = Convert.ToInt32(registro["IDProduto"]);

            if (registro["Quantidade"] != DBNull.Value)
                ip.Quantidade = Convert.ToInt32(registro["Quantidade"]);

            if (registro["ValorUnitario"] != DBNull.Value)
                ip.ValorUnitario = Convert.ToDecimal(registro["ValorUnitario"]);

            return ip;
        }

        protected override void SetTabela()
        {
            Tabela = "ItensPedido";
            ChaveIdentity = true;
        }
    }
}