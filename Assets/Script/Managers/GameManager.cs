using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BaseSingletonPattern;


namespace PlantVsZombieClone
{
    public class GameManager : Singleton<GameManager>
    {

        #region VariableArea
        public GameObject go;
        public BattleManager BattleMng;
        public CardManager CardMng;
        public GridManager GridMng;
        public InputManager InputMng;
        public LevelManager LevelMng;
        public LifeManager LifeMng;
        public PlayerManager PlayerMng;
        public PoolManager PoolMng;
        public UiManager UiMng;
        #endregion

        private void Start()
        {
            Setup();
        }

        void Setup()
        {
            getBattleManager();
            getCardManager();
            getInputManager();
            getLevelManager();
            getLifeManager();
            getPlayerManager();
            getPooolManager();
            getUiManager();
        }

        void onChangeScene()
        {

        }

        void setScenePatameters()
        {
        }

        #region Getter
        /// <summary>
        /// Funzione che si occupa di recuperare il BattleManager
        /// </summary>
        /// <returns></returns>
        public BattleManager getBattleManager()
        {
            if (BattleMng == null) return BattleMng = FindObjectOfType<BattleManager>();
            else return BattleMng;
        }

        /// <summary>
        /// Funzione che si occupa di recuperare il CardManager
        /// </summary>
        /// <returns></returns>
        public CardManager getCardManager()
        {
            if (CardMng == null) return CardMng = FindObjectOfType<CardManager>();
            else return CardMng;
        }

        /// <summary>
        /// Funzione che si occupa di recuperare l'input Manager
        /// </summary>
        /// <returns></returns>
        public InputManager getInputManager()
        {
            if (InputMng == null) return InputMng = FindObjectOfType<InputManager>();
            else return InputMng;
        }

        /// <summary>
        /// Funzione che si occupa di recuperare il Level Manager
        /// </summary>
        /// <returns></returns>
        public LevelManager getLevelManager()
        {
            if (LevelMng == null) return LevelMng = FindObjectOfType<LevelManager>();
            else return LevelMng;
        }

        /// <summary>
        /// Funzione che si occupa di recuperare il Life Manager
        /// </summary>
        /// <returns></returns>
        public LifeManager getLifeManager()
        {
            if (LifeMng == null) return LifeMng = FindObjectOfType<LifeManager>();
            else return LifeMng;
        }

        /// <summary>
        /// Funzione che si occupa di recuperare il Player Manager
        /// </summary>
        /// <returns></returns>
        public PlayerManager getPlayerManager()
        {
            if (PlayerMng == null) return PlayerMng = FindObjectOfType<PlayerManager>();
            else return PlayerMng;
        }

        /// <summary>
        /// Funzione che si occupa di recuperare il Level Manager
        /// </summary>
        /// <returns></returns>
        public PoolManager getPooolManager()
        {
            if (PoolMng == null) return PoolMng = FindObjectOfType<PoolManager>();
            else return PoolMng;
        }
        /// <summary>
        /// Funzione che si occupa di recuperare il Ui Manager
        /// </summary>
        /// <returns></returns>
        public UiManager getUiManager()
        {
            if (UiMng == null) return UiMng = FindObjectOfType<UiManager>();
            else return UiMng;
        }

        #endregion
    }

}