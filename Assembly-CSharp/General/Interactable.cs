using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.General
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000024")]
	public class Interactable : Hoverable
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x17000007")]
		public InteractionAnimationType AnimationType
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x253F50", Offset = "0x253350", VA = "0x180253F50")]
			get
			{
				return InteractionAnimationType.None;
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x7407E0", Offset = "0x73FBE0", VA = "0x1807407E0")]
		public void StartInteract()
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x7408E0", Offset = "0x73FCE0", VA = "0x1807408E0")]
		public void StopInteract()
		{
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x7409B0", Offset = "0x73FDB0", VA = "0x1807409B0")]
		public Interactable()
		{
		}

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent onStartInteract;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent onStopInteract;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5070", Offset = "0xA4470")]
		[SerializeField]
		private InteractionAnimationType animationType;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xA5EE0", Offset = "0xA52E0")]
		[SerializeField]
		private bool lockInteraction;
	}
}
