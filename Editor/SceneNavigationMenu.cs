using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using com.draconianmarshmallows.boilerplate.controllers;

public class SceneNavigationMenu : MonoBehaviour
{
    private const string SCENE_DIRECTORY_PATH = "Assets/DraconianMarshmallows/Boilerplate/Example/Scenes/";
    private const string SCENE_NAVIGATION_MENU = "Scene Navigation/";

    private const string START_MENU_NAME = "CanvasStartMenu";

    [MenuItem(SCENE_NAVIGATION_MENU + "Base Scene")] public static void loadBaseScene()
    {
        EditorSceneManager.OpenScene(SCENE_DIRECTORY_PATH + "Persistant.unity");
    }

    [MenuItem(SCENE_NAVIGATION_MENU + "1 Level1")] public static void loadLevel1()
    {
        GameObject.Find(START_MENU_NAME).SetActive(false);

        EditorSceneManager.OpenScene(SCENE_DIRECTORY_PATH + "Levels/Level1.unity", 
            OpenSceneMode.Additive);
    }
}
