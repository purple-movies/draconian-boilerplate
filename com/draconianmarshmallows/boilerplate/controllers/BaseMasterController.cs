using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace com.draconianmarshmallows.boilerplate.controllers
{
    public abstract class BaseMasterController : DraconianBehaviour
    {
        public static BaseMasterController instance { get { return mInstance; } }
        private static BaseMasterController mInstance;

        [Header("Level Information")]
        [SerializeField] private string levelsDirectoryPath;
        [SerializeField] private string[] levelSceneNames;

        [Header("UI Hooks")]
        [SerializeField] GameObject startMenu;

        //[Header("Debug Options")]
        //[SerializeField] bool sceneDebugMode;
        //public bool sceneDebugMode;

        private BaseLevelController currentLevelController;

        protected override void Awake()
        {
            if (mInstance) Destroy(gameObject);
            mInstance = this;
        }

        public void StartGame()
        {
            startMenu.SetActive(false);
            string levelPath = levelsDirectoryPath + levelSceneNames[0];

            #if UNITY_EDITOR
            try { SceneManager.UnloadSceneAsync(levelPath); }
            catch (ArgumentException ignore) { }
            #endif

            StartCoroutine(loadLevel(levelPath));
        }

        private IEnumerator loadLevel(string levelPath)
        {
            var result = SceneManager.LoadSceneAsync(levelPath, LoadSceneMode.Additive);
            while ( ! result.isDone) yield return new WaitForEndOfFrame();
            
            SceneManager.SetActiveScene(SceneManager.GetSceneByPath(levelPath));
            currentLevelController.startLevel();
        }

        public virtual void onLevelInstanciated(BaseLevelController levelController)
        {
            currentLevelController = levelController;
        }

        public abstract void OnLevelCompleted(bool levelWon);
    }
}
