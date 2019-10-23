using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlantVsZombieClone
{
    public interface IAttack
    {
        public int Attack { get; set; }
        void DoDamange();

    } 
}
