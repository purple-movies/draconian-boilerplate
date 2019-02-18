using com.draconianmarshmallows.boilerplate;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateToParent : MonoBehaviour
{
    public DraconianBehaviour parentDelegate;

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (parentDelegate != null) parentDelegate.OnTriggerEnter2D(collision);
    }
}
