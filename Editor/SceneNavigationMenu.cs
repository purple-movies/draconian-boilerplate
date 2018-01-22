using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

//[InitializeOnLoad]
//public static class SceneNavigationMenu
//{
//    private const string SCENE_DIRECTORY_PATH = "Assets/DraconianMarshmallows/Boilerplate/Example/Scenes/";
//    private const string SCENE_NAVIGATION_MENU = "Scene Navigation/";

//    // This is the name of the canvas-object. 
//    // Turned off while navigating to levels for testing. 
//    private const string START_MENU_NAME = "CanvasStartMenu";

//    static SceneNavigationMenu()
//    {
//        Debug.Log("menu started !!!");
//        Debug.Log("recompiled !!!");
//    }

//    [MenuItem(SCENE_NAVIGATION_MENU + "Base Scene")] public static void loadBaseScene()
//    {
//        EditorSceneManager.OpenScene(SCENE_DIRECTORY_PATH + "Persistant.unity");
//    }

//    [MenuItem(SCENE_NAVIGATION_MENU + "1 Level1")] public static void loadLevel1()
//    {
//        // Turned off while navigating to levels for testing. 
//        GameObject.Find(START_MENU_NAME).SetActive(false);

//        EditorSceneManager.OpenScene(SCENE_DIRECTORY_PATH + "Levels/Level1.unity", 
//            OpenSceneMode.Additive);
//    }
//}
