using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace com.draconianmarshmallows.boilerplate.controllers
{
    public abstract class BaseMasterController : MonoBehaviour
    {
        public static BaseMasterController instance { get { return mInstance; } }
        private static BaseMasterController mInstance;

        [Header("Level Information")]
        [SerializeField] string levelsDirectoryPath;
        [SerializeField] string[] levelSceneNames;

        [Header("UI Hooks")]
        [SerializeField] GameObject startMenu;

        //[Header("Debug Options")]
        //[SerializeField] bool sceneDebugMode;
        //public bool sceneDebugMode;

        private BaseLevelController currentLevelController;

        protected virtual void Awake()
        {
            if (mInstance) Destroy(gameObject);
            mInstance = this;
        }

        protected virtual void Start()
        {
        }

        public void startGame()
        {
            startMenu.SetActive(false);
            SceneManager.LoadScene(levelsDirectoryPath + levelSceneNames[0], 
                LoadSceneMode.Additive);
        }

        public virtual void onLevelStarted(BaseLevelController levelController)
        {
            currentLevelController = levelController;
            //Debug.Log("level started !");
        }
    }
}
