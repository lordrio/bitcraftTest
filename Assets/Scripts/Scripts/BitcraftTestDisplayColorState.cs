using System;
using Bitcraft.StateMachine;

partial class BitcraftTestDisplayColorState : BitcraftTestStateBase
{
    protected override void OnEnter(StateEnterEventArgs e)
    {
        base.OnEnter(e);

        var r = GetContext<ColorGenData> ();
        r.root.PerformShowColor (r);
    }

    private void OnBitcraftTestGenerateColorAction(object data, Action<StateToken> callback)
    {
        callback(BitcraftTestStateTokens.GenerateColor);
    }
}
