using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventManager
{
    public static event Action updateUi;//ˢ��ui
    public static void UpdateUi()
    {
        updateUi?.Invoke();
    }

}
