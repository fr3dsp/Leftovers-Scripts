using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.General
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x2000022")]
	public class Hoverable : MonoBehaviour
	{
		// Token: 0x06000166 RID: 358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x740500", Offset = "0x73F900", VA = "0x180740500")]
		public void StartHover()
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x7405E0", Offset = "0x73F9E0", VA = "0x1807405E0")]
		public void StopHover()
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x7406E0", Offset = "0x73FAE0", VA = "0x1807406E0")]
		public Hoverable()
		{
		}

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string tooltip;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent onStartHover;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent onStopHover;
	}
}
