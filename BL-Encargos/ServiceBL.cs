﻿using DAL_ENCARGOS;
using ENT_Encargos;

namespace BL_Encargos
{
    public class ServiceBL
    {
        /// <summary>
        /// Devuleve un Listado De Misiones
        /// </summary>
        /// <returns>listado</returns>
        public static List<Mision> ObtenerListadoDeMisiones()
        {
            return ServiceDAL.ObtenerListadoDeMisiones();
        }

        public static List<Candidato> ObtenerListadoDeCandidatosPorMision(int dificultad)
        {
            return ServiceDAL.ObtenerListadoDeCandidatosPorMision(dificultad);

        }

        public static List<Mision> ObtenerCandidato(int id)
        {
            return ServiceDAL.ObtenerCandidato(id);

        }
    }
}
