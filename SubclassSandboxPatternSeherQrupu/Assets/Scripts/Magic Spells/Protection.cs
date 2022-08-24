using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protection : MagicSpell
{
	public override void Activate()
	{
		SpawnParticle();
	}
}
