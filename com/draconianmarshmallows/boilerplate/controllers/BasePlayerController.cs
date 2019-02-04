using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.draconianmarshmallows.boilerplate.controllers
{
    public class BasePlayerController : DraconianBehaviour
    {
        public static BasePlayerController Instance{ get; private set; }

        protected override void Start()
        {
            base.Start();
            if (Instance) Destroy(gameObject);
            Instance = this;
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            Instance = null;
        }
    }
}
