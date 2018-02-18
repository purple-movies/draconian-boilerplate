using com.draconianmarshmallows.boilerplate;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonController : DraconianBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private EventTrigger eventTrigger;


    protected override void Start()
    {
        base.Start();


    }
}
