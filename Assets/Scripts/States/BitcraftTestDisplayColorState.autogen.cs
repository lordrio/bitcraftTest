/*
 ###########################################################
 ### Warning: this file has been generated automatically ###
 ###                    DO NOT MODIFY                    ###
 ###########################################################
*/

using System;
using Bitcraft.StateMachine;

partial class BitcraftTestDisplayColorState : BitcraftTestStateBase
{
    public BitcraftTestDisplayColorState()
        : base(BitcraftTestStateTokens.DisplayColor)
    {
    }

    protected override void OnInitialized()
    {
        PreInitialized();

        base.OnInitialized();
        RegisterActionHandler(BitcraftTestActionTokens.GenerateColor, OnBitcraftTestGenerateColorAction);

        PostInitialized();
    }

    partial void PreInitialized();
    partial void PostInitialized();

    /*
    private void OnBitcraftTestGenerateColorAction(object data, Action<StateToken> callback)
    {
        callback(BitcraftTestStateTokens.GenerateColor);
    }
    */
}
