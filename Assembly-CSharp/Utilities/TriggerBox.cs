using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Utilities
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x2000009")]
	[Attribute(Name = "RequireComponent", RVA = "0xA5250", Offset = "0xA4650")]
	public class TriggerBox : MonoBehaviour
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x7481C0", Offset = "0x7475C0", VA = "0x1807481C0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x7481F0", Offset = "0x7475F0", VA = "0x1807481F0")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x748220", Offset = "0x747620", VA = "0x180748220")]
		public void TriggerIfInContact()
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x748240", Offset = "0x747640", VA = "0x180748240")]
		public TriggerBox()
		{
		}

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5180", Offset = "0xA4580")]
		[SerializeField]
		private UnityEvent onTriggerEnter;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent onTriggerExit;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent ifInContact;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x30")]
		private int inContact;
	}
}
