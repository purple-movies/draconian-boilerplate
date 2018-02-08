using com.draconianmarshmallows.boilerplate.controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace com.draconianmarshmallows.boilerplate.example.views
{
    public class StartMenuViewController : MonoBehaviour
    {
        [SerializeField] private Button startButton;

        private void Start()
        {
            startButton.onClick.AddListener(onClickStart);
        }

        private void onClickStart()
        {
            BaseMasterController.instance.StartGame();
        }
    }
}
