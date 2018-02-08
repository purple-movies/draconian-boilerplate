using com.draconianmarshmallows.boilerplate.controllers;
using UnityEngine;

namespace com.draconianmarshmallows.boilerplate.example
{
    public class ExampleMasterController : BaseMasterController
    {
        override protected void Awake()
        {
            base.Awake();
        }

        public override void OnLevelCompleted(bool levelWon)
        {
            if (levelWon) Debug.Log("won level !!!!");
            else Debug.Log("level failed !");
        }
    }
}
