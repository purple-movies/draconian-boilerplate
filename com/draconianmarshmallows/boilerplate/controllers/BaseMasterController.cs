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
        [Tooltip("Set the root of this to your \"Assets\" directory E.G. \"Assets/Scenes/Levels/\".")]
        [SerializeField] private string levelsDirectoryPath;
        [Tooltip("Remember to add the FULL file name with \".unity\" file extension.")]
        [SerializeField] private string[] levelSceneNames;

        [Header("UI Hooks")]
        [SerializeField] private BaseUIController uiController;
        [SerializeField] private GameObject startMenu;

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
            catch (ArgumentException exception)
            {
                Debug.LogWarning("Couldn't unload previous level: " + exception);
            }
            #endif

            StartCoroutine(loadLevel(levelPath));
        }

        private IEnumerator loadLevel(string levelPath)
        {
            var result = SceneManager.LoadSceneAsync(levelPath, LoadSceneMode.Additive);
            while ( ! result.isDone) yield return new WaitForEndOfFrame();

            SceneManager.SetActiveScene(SceneManager.GetSceneByPath(levelPath));
            currentLevelController.startLevel();
            uiController.OnLevelStarted(currentLevelController);
        }

        public virtual void onLevelInstanciated(BaseLevelController levelController)
        {
            currentLevelController = levelController;
        }

        public abstract void OnLevelCompleted(bool levelWon);
    }
}
