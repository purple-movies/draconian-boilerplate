using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.draconianmarshmallows.boilerplate.controllers
{
    public abstract class BaseUIController : DraconianBehaviour
    {
        public abstract void OnLevelStarted(BaseLevelController levelController);
    }
}
