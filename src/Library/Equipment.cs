//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class Equipment
    {
        public Equipment(string description, double hourlyCost)
        {
            this.Description = description;
            this.HourlyCost = hourlyCost;
        }

        public string Description { get; set; }

        public double HourlyCost { get; set; }
    }
}