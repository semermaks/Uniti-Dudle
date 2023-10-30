using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBroken : Platform
{
	private void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			gameObject.SetActive(false);
		}
	}
}
