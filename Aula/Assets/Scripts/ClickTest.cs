using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTest : CustomYieldInstructions
{
    public override bool keepWaiting => !Input.anyKey; 
}
