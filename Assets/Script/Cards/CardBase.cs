using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlantVsZombieClone
{
    public class CardBase : MonoBehaviour, IAttack
    {
        public CardData Data;

        public CardData Init(CardData _data)
        {
            Data = _data;
            return Data;
        }
        public int Attack { get { return Data.attack; } set { Data.attack = value; } }

        public void DoDamange()
        {

        }
    }


}
