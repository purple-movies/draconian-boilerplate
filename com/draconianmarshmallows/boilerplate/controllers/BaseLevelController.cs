using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.draconianmarshmallows.boilerplate.controllers
{
    public abstract class BaseLevelController : MonoBehaviour
    {
        protected virtual void Start()
        {
            BaseMasterController.instance.onLevelStarted(this);
        }
    }
}
