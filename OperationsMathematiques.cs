using System;
using System.Linq;
using System.Collections.Generic;


namespace H23_Dev_Info_Examen2
{
    public static class OperationsMathematiques
    {
        public static double CalculerMoyenne(List<int> valeurs)
        {
            double moyenne = valeurs.Average();
            if(valeurs == null || valeurs.Count == 0)
            {
                return -1;
            }
            else
            {
                return moyenne;
            }                               
        }
    }
}