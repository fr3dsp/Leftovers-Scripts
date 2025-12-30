using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Utilities
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public class AnimationCallback : MonoBehaviour
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x73DD90", Offset = "0x73D190", VA = "0x18073DD90")]
		public void InvokeAnimationEvent(int index)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x73DE10", Offset = "0x73D210", VA = "0x18073DE10")]
		public AnimationCallback()
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<UnityEvent> onAnimationEvent;
	}
}
