/*
 ###########################################################
 ### Warning: this file has been generated automatically ###
 ###                    DO NOT MODIFY                    ###
 ###########################################################
*/

using System;
using Bitcraft.StateMachine;

partial class BitcraftTestValidateColorState : BitcraftTestStateBase
{
    public BitcraftTestValidateColorState()
        : base(BitcraftTestStateTokens.ValidateColor)
    {
    }

    protected override void OnInitialized()
    {
        PreInitialized();

        base.OnInitialized();
        RegisterActionHandler(BitcraftTestActionTokens.Next, OnBitcraftTestNextAction);
        RegisterActionHandler(BitcraftTestActionTokens.Invalid, OnBitcraftTestInvalidAction);

        PostInitialized();
    }

    partial void PreInitialized();
    partial void PostInitialized();

    /*
    private void OnBitcraftTestNextAction(object data, Action<StateToken> callback)
    {
        callback(BitcraftTestStateTokens.DisplayColor);
    }
    */

    /*
    private void OnBitcraftTestInvalidAction(object data, Action<StateToken> callback)
    {
        callback(BitcraftTestStateTokens.GenerateColor);
    }
    */
}
