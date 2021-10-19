using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForPress : CustomYieldInstruction
{
    public override bool keepWaiting => !Input.anyKey; 
}