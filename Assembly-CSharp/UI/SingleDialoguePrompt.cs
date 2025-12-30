using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.UI
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000010")]
	public class SingleDialoguePrompt : MonoBehaviour
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x7477B0", Offset = "0x746BB0", VA = "0x1807477B0")]
		public void ShowDialogue()
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x747740", Offset = "0x746B40", VA = "0x180747740")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA5480", Offset = "0xA4880")]
		private IEnumerator ListenToPrompt()
		{
			return null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x747940", Offset = "0x746D40", VA = "0x180747940")]
		public SingleDialoguePrompt()
		{
		}

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5070", Offset = "0xA4470")]
		[SerializeField]
		private string message;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float delayMessage;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5180", Offset = "0xA4580")]
		[SerializeField]
		private UnityEvent onStartDialogue;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent onCloseDialogue;

		// Token: 0x0200001A RID: 26
		[Token(Token = "0x200002F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <ListenToPrompt>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <ListenToPrompt>d__5(int <>1__state)
			{
			}

			// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06000073 RID: 115 RVA: 0x00002118 File Offset: 0x00000318
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x74A000", Offset = "0x749400", VA = "0x18074A000", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000074 RID: 116 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000019")]
			private object Current
			{
				[Token(Token = "0x600011A")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x74A2E0", Offset = "0x7496E0", VA = "0x18074A2E0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000076 RID: 118 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700001A")]
			private object Current
			{
				[Token(Token = "0x600011C")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04000065 RID: 101
			[Token(Token = "0x4000149")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000066 RID: 102
			[Token(Token = "0x400014A")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04000067 RID: 103
			[Token(Token = "0x400014B")]
			[FieldOffset(Offset = "0x20")]
			public SingleDialoguePrompt <>4__this;
		}
	}
}
