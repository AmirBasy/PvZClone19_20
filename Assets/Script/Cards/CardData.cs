using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PlantVsZombieClone
{
    [CreateAssetMenu(fileName = "Card", menuName = "ScriptableObjects/NewCard", order = 1)]
    public class CardData : ScriptableObject
    {
        #region Variables
        public string CardDescription, CardName;
        public int attack;
        public int EnergyCost;
        public int Life;
        public GameObject CardView;
        public CategoryType CategoryType;
        public TribeType TribeType;



        #endregion

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public enum TribeType
    {
        blablabla,
        fagioli,Turco
    }

    public enum CategoryType
    {
        forest,
        Water, Sand
    }
}


