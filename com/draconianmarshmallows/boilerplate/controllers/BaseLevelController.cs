using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.draconianmarshmallows.boilerplate.controllers
{
    public abstract class BaseLevelController : MonoBehaviour
    {
        protected bool resetting;

        protected virtual void Start()
        {
            BaseMasterController.instance.onLevelInstanciated(this);
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
