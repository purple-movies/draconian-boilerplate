using com.draconianmarshmallows.boilerplate;
using com.draconianmarshmallows.boilerplate.managers;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(EventTrigger))]
public class ButtonController : DraconianBehaviour, IUpdateable
{
    public Action onButtonHeld;
    
    private bool pointerDown = false;

    protected override void Start()
    {
        base.Start();
        UpdateManager.Instance.AddUpdateable(this);
    }

    public void OnUpdate()
    {
        if (pointerDown) onButtonHeld();
    }

    public void OnPointerDown()
    {
        pointerDown = true;
    }

    public void OnPointerUp()
    {
        pointerDown = false;
    }
}
