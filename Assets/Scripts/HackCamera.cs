using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackCamera : MonoBehaviour
{
	public Transform target1;
	public Transform target2;
	public Transform target3;
	public Vector3 offset;
	[Range(1, 10)]
	public float smoothFactor;
	public bool ishack4and5;

	private void FixedUpdate()
	{
		Follow();
	}

	void Follow()
	{ 
		if(ishack4and5)
        {
			Vector3 targetPosition = target1.position + offset;
			Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor * Time.fixedDeltaTime);
			transform.position = smoothPosition;
		}
		else
        {
			if (target1.gameObject.active)
			{
				Vector3 targetPosition = target1.position + offset;
				Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor * Time.fixedDeltaTime);
				transform.position = smoothPosition;
			}
			else if (target2.gameObject.active)
			{
				Vector3 targetPosition = target2.position + offset;
				Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor * Time.fixedDeltaTime);
				transform.position = smoothPosition;
			}
			else if (target3.gameObject.active)
			{
				Vector3 targetPosition = target3.position + offset;
				Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor * Time.fixedDeltaTime);
				transform.position = smoothPosition;
			}
		}
		
	}

	public void Shake(float duration, float magnitude)
	{
		StartCoroutine(DoShake(duration, magnitude));
	}

	private IEnumerator DoShake(float duration, float magnitude)
	{
		var pos = transform.localPosition;

		var elapsed = 0f;

		while (elapsed < duration)
		{
			var x = pos.x + Random.Range(-1f, 1f) * magnitude;
			var y = pos.y + Random.Range(-1f, 1f) * magnitude;

			transform.localPosition = new Vector3(x, y, pos.z);

			elapsed += Time.deltaTime;

			yield return null;
		}

		transform.localPosition = pos;
	}
}

