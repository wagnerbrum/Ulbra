using System;
using System.Collections.Generic;

namespace aula05_exercicio_static.Models
{
    public class ClienteRepository
    {
        public static int autoIncrement = 1;
        public List<ClienteModel> listaClientes = new List<ClienteModel>();

        public ClienteRepository()
        {
            this.CreateCliente(new ClienteModel{
                nome = "Cliente 1",
                cpf = "11111111111"
            });

            this.CreateCliente(new ClienteModel{
                nome = "Cliente 2",
                cpf = "22222222222"
            });

            this.CreateCliente(new ClienteModel{
                nome = "Cliente 3",
                cpf = "33333333333"
            });
        }

        public void CreateCliente(ClienteModel clienteModelo)
        {
            clienteModelo.id = ClienteRepository.autoIncrement++;
            listaClientes.Add(clienteModelo);
        }

        public void UpdateCliente(ClienteModel clienteModelo)
        {
            int index = listaClientes.FindIndex(cli => cli.id == clienteModelo.id);
            listaClientes[index].nome = clienteModelo.nome;
        }

        public ClienteModel GetCliente(int id)
        {
            ClienteModel _cliente = listaClientes.Find(cli => cli.id == id);

            return _cliente;
        }

        public List<ClienteModel> GetAllCliente()
        {
            return listaClientes;
        }

        public void DeleteCliente(int id)
        {
            listaClientes.Remove(listaClientes.Find(cli => cli.id == id));
        }
    }
}