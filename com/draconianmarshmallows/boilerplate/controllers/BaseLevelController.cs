using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.draconianmarshmallows.boilerplate.controllers
{
    public abstract class BaseLevelController : DraconianBehaviour
    {
        [SerializeField] private BasePlayerController player;

        protected BaseMasterController masterController;
        protected bool resetting;

        public BasePlayerController Player { get { return player; } }

        protected override void Start()
        {
            masterController = BaseMasterController.instance;
            masterController.onLevelInstanciated(this);
        }

        public virtual void startLevel()
        {
            reset();
        }

        protected virtual void reset()
        {
            resetting = true;
        }

        protected void endResetting()
        {
            resetting = false;
        }
    }
}
