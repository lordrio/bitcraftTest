using System;
using UnityEngine;
using Bitcraft.StateMachine;
using System.Collections.Generic;

public partial class BitcraftTestGenerateColorState : BitcraftTestStateBase
{
    private void OnBitcraftTestNextAction(object data, Action<StateToken> callback)
    {
        var col = (Color)data;
        GetContext<ColorGenData> ().previousColor = GetContext<ColorGenData> ().currentColor;
        GetContext<ColorGenData> ().currentColor = col;

        callback(BitcraftTestStateTokens.ValidateColor);
    }
}