using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bitcraft.StateMachine;

public partial class BitcraftTestStateBase : StateBase
{
    protected BitcraftTestStateBase(StateToken token)
        : base(token)
    {
    }
}