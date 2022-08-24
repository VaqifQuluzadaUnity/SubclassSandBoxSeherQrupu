using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicSpell : MonoBehaviour
{
  [SerializeField] private string animationClipString;

  [SerializeField] private AudioClip spellSFX;

  [SerializeField] private GameObject spellVFXPrefab;

  [SerializeField] private AudioSource spellSFXSource;

  public bool isEnemyTarget;

  private Animator characterAnimator;

  public Transform target;

  public virtual void Activate()
	{
    SpawnParticle();

    PlayAnimation();

    Effect();
	}

  public virtual void SpawnParticle()
	{
    GameObject particleInstance = Instantiate(spellVFXPrefab,target);

    particleInstance.GetComponent<ParticleSystem>().Play();
	}

  public virtual void PlaySound()
	{
    spellSFXSource.clip = spellSFX;

    spellSFXSource.Play();
	}

  public virtual void PlayAnimation()
	{
    characterAnimator.Play(animationClipString);
	}

  public virtual void Effect()
	{
    Debug.Log(animationClipString + " applied");
	}
  
  public void SetupSpell(Animator _characterAnimator, Transform _targetTransform)
	{
    characterAnimator = _characterAnimator;

    target = _targetTransform;
	}
}
