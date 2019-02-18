using UnityEngine;

namespace com.draconianmarshmallows.boilerplate
{
    public class DraconianBehaviour : MonoBehaviour
    {
        public virtual void OnTriggerEnter2D(Collider2D other) { }

        protected virtual void Awake() { }
        protected virtual void Start() { }
        protected virtual void OnDestroy() { }
        protected virtual void OnCollisionEnter2D(Collision2D collision) { }
        protected virtual void OnTriggerEnter(Collider other) { }
    }
}
