using UnityEngine;

public class Heal : MagicSpell
{
	[SerializeField] private float healValue;
	public override void Activate()
	{
		base.Activate();
	}

	public override void Effect()
	{
		base.Effect();

		//target.GetComponent<PlayerHealthController>().Heal(healValue);
	}

}
