/*
 ###########################################################
 ### Warning: this file has been generated automatically ###
 ###                    DO NOT MODIFY                    ###
 ###########################################################
*/

using System;
using Bitcraft.StateMachine;

public static class BitcraftTestStateTokens
{
    public static readonly StateToken GenerateColor = new StateToken("GenerateColor");
    public static readonly StateToken ValidateColor = new StateToken("ValidateColor");
    public static readonly StateToken DisplayColor = new StateToken("DisplayColor");

    public static readonly StateToken[] Items = 
    {
        GenerateColor,
        ValidateColor,
        DisplayColor
    };
}
