/*
 ###########################################################
 ### Warning: this file has been generated automatically ###
 ###                    DO NOT MODIFY                    ###
 ###########################################################
*/

using System;
using Bitcraft.StateMachine;

partial class BitcraftTestGenerateColorState : BitcraftTestStateBase
{
    public BitcraftTestGenerateColorState()
        : base(BitcraftTestStateTokens.GenerateColor)
    {
    }

    protected override void OnInitialized()
    {
        PreInitialized();

        base.OnInitialized();
        RegisterActionHandler(BitcraftTestActionTokens.Next, OnBitcraftTestNextAction);

        PostInitialized();
    }

    partial void PreInitialized();
    partial void PostInitialized();

    /*
    private void OnBitcraftTestNextAction(object data, Action<StateToken> callback)
    {
        callback(BitcraftTestStateTokens.ValidateColor);
    }
    */
}
