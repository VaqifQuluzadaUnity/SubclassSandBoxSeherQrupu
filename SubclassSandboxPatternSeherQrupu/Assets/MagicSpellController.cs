using UnityEngine;
using UnityEngine.UI;

public class MagicSpellController : MonoBehaviour
{
	[SerializeField] private GameObject[] spells;

	[SerializeField] private Button[] spellButtons;

	[SerializeField] private Animator charAnimRef;

	[SerializeField] private Transform charTargetRef;

	[SerializeField] private Transform enemyTargetRef;


	void Start()
	{
		for (int i = 0; i < spells.Length; i++)
		{
			GameObject spellInstance = Instantiate(spells[i],transform);

			MagicSpell instanceSpell = spellInstance.GetComponent<MagicSpell>();

			Transform targetRef;



			if (instanceSpell.isEnemyTarget)
			{
				targetRef = enemyTargetRef;
			}
			else
			{
				targetRef = charTargetRef;
			}

			instanceSpell.SetupSpell(charAnimRef,targetRef);

			spellButtons[i].onClick.AddListener(delegate { OnSpellButtonPressed(instanceSpell); });

		}
	}


	private void OnSpellButtonPressed(MagicSpell spell)
	{
		spell.Activate();
	}

}
