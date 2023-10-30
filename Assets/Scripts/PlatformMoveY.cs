using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveY : Platform
{
	public override void Move()
	{
		if (isRightDiorection)
		{
			transform.Translate(Vector2.down * speed * Time.deltaTime);
		}
		else if (!isRightDiorection)
		{
			transform.Translate(Vector2.up * speed * Time.deltaTime);
		}
		if (transform.position.y > startY + 3 || transform.position.y < startY - 3)
		{
			isRightDiorection = !isRightDiorection;
		}
	}
}
