using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MagicSpell
{
	[SerializeField] private float damage;

	public override void Activate()
	{
		PlayAnimation();
		SpawnParticle();
	}

	public override void PlayAnimation()
	{
		base.PlayAnimation();

		Debug.Log("Attack animation played");
	}

	public override void Effect()
	{
		base.Effect();

		//target.GetComponent<EnemyController>().ReduceHealth(damage);
	}
}
