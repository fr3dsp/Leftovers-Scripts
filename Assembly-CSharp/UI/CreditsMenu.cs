using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Leftovers.UI
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x200000C")]
	public class CreditsMenu : MonoBehaviour
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x73EDD0", Offset = "0x73E1D0", VA = "0x18073EDD0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x73ED60", Offset = "0x73E160", VA = "0x18073ED60")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA53E0", Offset = "0xA47E0")]
		private IEnumerator DelayMessage()
		{
			return null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x73EE40", Offset = "0x73E240", VA = "0x18073EE40")]
		public CreditsMenu()
		{
		}

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5070", Offset = "0xA4470")]
		[SerializeField]
		private float delay;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float fadeDuration;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5390", Offset = "0xA4790")]
		[SerializeField]
		private TMP_Text textComponent;

		// Token: 0x02000014 RID: 20
		[Token(Token = "0x200002D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <DelayMessage>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <DelayMessage>d__4(int <>1__state)
			{
			}

			// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600005D RID: 93 RVA: 0x000020E8 File Offset: 0x000002E8
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x748E60", Offset = "0x748260", VA = "0x180748E60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x0600005E RID: 94 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000015")]
			private object Current
			{
				[Token(Token = "0x600010E")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x749040", Offset = "0x748440", VA = "0x180749040", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000060 RID: 96 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000016")]
			private object Current
			{
				[Token(Token = "0x6000110")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04000047 RID: 71
			[Token(Token = "0x400013E")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000048 RID: 72
			[Token(Token = "0x400013F")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04000049 RID: 73
			[Token(Token = "0x4000140")]
			[FieldOffset(Offset = "0x20")]
			public CreditsMenu <>4__this;

			// Token: 0x0400004A RID: 74
			[Token(Token = "0x4000141")]
			[FieldOffset(Offset = "0x28")]
			private float <timer>5__2;

			// Token: 0x0400004B RID: 75
			[Token(Token = "0x4000142")]
			[FieldOffset(Offset = "0x2C")]
			private Color <textColor>5__3;
		}
	}
}
