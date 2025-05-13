using UnityEngine;
using System;

public static class EventChannels
{
    public static Action<string> OnButtonPressed;

    public static void AbrirPorta(string doorID)
    {
        OnButtonPressed?.Invoke(doorID);
    }
}
