/*
 ###########################################################
 ### Warning: this file has been generated automatically ###
 ###                    DO NOT MODIFY                    ###
 ###########################################################
*/

using System;
using Bitcraft.StateMachine;

partial class BitcraftTestStateMachine : StateManager
{
    public BitcraftTestStateMachine()
        : this(null)
    {
    }

    public BitcraftTestStateMachine(object context)
        : base(context)
    {
        PreHandlersRegistration();

        RegisterState(new BitcraftTestGenerateColorState());
        RegisterState(new BitcraftTestValidateColorState());
        RegisterState(new BitcraftTestDisplayColorState());

        PostHandlersRegistration();

        SetInitialState(BitcraftTestStateTokens.GenerateColor);
    }

    partial void PreHandlersRegistration();
    partial void PostHandlersRegistration();
}
