using System;
using System.Collections.Generic;

namespace aula05_exercicio_static.Models
{
    public class CorrentistaRepository
    {
        public static int autoIncrement = 1;
        public List<CorrentistaModel> listaCorrentistas = new List<CorrentistaModel>();

        public CorrentistaRepository()
        {
            this.CreateCorrentista(new CorrentistaModel{
                nome = "Correntista 1"
            });

            this.CreateCorrentista(new CorrentistaModel{
                nome = "Correntista 2"
            });

            this.CreateCorrentista(new CorrentistaModel{
                nome = "Correntista 3"
            });
        }

        public void CreateCorrentista(CorrentistaModel correntistaModelo)
        {
            correntistaModelo.id = CorrentistaRepository.autoIncrement++;
            listaCorrentistas.Add(correntistaModelo);
        }

        public void UpdateCorrentista(CorrentistaModel correntistaModelo)
        {
            int index = listaCorrentistas.FindIndex(cor => cor.id == correntistaModelo.id);
            listaCorrentistas[index].nome = correntistaModelo.nome;
        }

        public CorrentistaModel GetCorrentista(int id)
        {
            CorrentistaModel _correntista = listaCorrentistas.Find(cor => cor.id == id);

            return _correntista;
        }

        public List<CorrentistaModel> GetAllCorrentista()
        {
            return listaCorrentistas;
        }

        public void DeleteCorrentista(int id)
        {
            listaCorrentistas.Remove(listaCorrentistas.Find(cor => cor.id == id));
        }
    }
}