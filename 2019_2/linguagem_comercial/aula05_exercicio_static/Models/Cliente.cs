using System.Collections.Generic;

namespace aula05_exercicio_static.Models
{
    public class Cliente
    {
        public List<ClienteModel> listaClientes = new List<ClienteModel>();

        public Cliente()
        {
            listaClientes.Add(new ClienteModel{
                nome = "Usuario 1",
                cpf = "00000000000"
            });

            listaClientes.Add(new ClienteModel{
                nome = "Usuario 2",
                cpf = "1111111111"
            });

            listaClientes.Add(new ClienteModel{
                nome = "Usuario 3",
                cpf = "2222222222"
            });
        }

        public void CreateCliente(ClienteModel clienteModelo)
        {
            listaClientes.Add(clienteModelo);
        }

        public void UpdateCliente(ClienteModel clienteModelo)
        {
            foreach(ClienteModel cliente in listaClientes)
            {
                if(cliente.cpf == clienteModelo.cpf)
                {
                    cliente.nome = clienteModelo.nome;
                    break;
                }
            }
        }

        public ClienteModel GetCliente(string cpf)
        {
            ClienteModel _cliente = null;

            foreach(ClienteModel cliente in listaClientes)
            {
                if(cliente.cpf == cpf)
                {
                    _cliente = cliente;
                    break;
                }
            }

            return _cliente;
        }

        public List<ClienteModel> GetAllCliente()
        {
            return listaClientes;
        }

        public void DeleteCliente(string cpf)
        {
            foreach(ClienteModel cliente in listaClientes)
            {
                if(cliente.cpf == cpf)
                {
                    listaClientes.Remove(cliente);
                    break;
                }
            }
        }
    }
}