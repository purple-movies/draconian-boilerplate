using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.draconianmarshmallows.boilerplate.managers
{
    public class UpdateManager : DraconianBehaviour
    {
        private static UpdateManager instance;
        public static UpdateManager Instance { get { return instance; } }

        private List<IUpdateable> updateables = new List<IUpdateable>();
        private IUpdateable[] updateableArray;

        protected override void Awake()
        {
            base.Awake();
            if (instance != null) Destroy(gameObject);
            instance = this;
        }

        public void AddUpdateable(IUpdateable updateable)
        {
            updateables.Add(updateable);
            updateableArray = updateables.ToArray();
        }

        public void RemoveUpdateable(IUpdateable updateable)
        {
            updateables.Remove(updateable);
            updateableArray = updateables.ToArray();
        }

        protected virtual void Update()
        {
            if (updateableArray == null) return;

            for (int i = 0; i < updateableArray.Length; i++)
                updateableArray[i].OnUpdate();
        }
    }
}
