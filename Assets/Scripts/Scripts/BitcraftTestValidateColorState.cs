using System;
using Bitcraft.StateMachine;

partial class BitcraftTestValidateColorState : BitcraftTestStateBase
{
    protected override void OnEnter(StateEnterEventArgs e)
    {
        base.OnEnter(e);

        var r = GetContext<ColorGenData> ();
        r.root.PerformColorCheck (r);
    }

    private void OnBitcraftTestNextAction(object data, Action<StateToken> callback)
    {
        callback(BitcraftTestStateTokens.DisplayColor);
    }

    private void OnBitcraftTestInvalidAction(object data, Action<StateToken> callback)
    {
        callback(BitcraftTestStateTokens.GenerateColor);
    }
}
