using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Leftovers.UI
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x200000D")]
	public class LeftoverCounter : MonoBehaviour
	{
		// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x741800", Offset = "0x740C00", VA = "0x180741800")]
		public void SetCounter(string text)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x741770", Offset = "0x740B70", VA = "0x180741770")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA5430", Offset = "0xA4830")]
		private IEnumerator FlashText(Color startColor, Color endColor)
		{
			return null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x7419D0", Offset = "0x740DD0", VA = "0x1807419D0")]
		public LeftoverCounter()
		{
		}

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5070", Offset = "0xA4470")]
		[SerializeField]
		private Color originalColor;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color flashColor;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color endColor;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float originalSize;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float flashSize;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float flashDuration;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float returnDuration;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string endCounter;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string startCounter;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA50C0", Offset = "0xA44C0")]
		[SerializeField]
		private TMP_Text textCounter;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x70")]
		private Coroutine flashCoroutine;

		// Token: 0x02000016 RID: 22
		[Token(Token = "0x200002E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <FlashText>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <FlashText>d__12(int <>1__state)
			{
			}

			// Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06000066 RID: 102 RVA: 0x00002100 File Offset: 0x00000300
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x749D90", Offset = "0x749190", VA = "0x180749D90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000067 RID: 103 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000017")]
			private object Current
			{
				[Token(Token = "0x6000114")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x749FC0", Offset = "0x7493C0", VA = "0x180749FC0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000069 RID: 105 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000018")]
			private object Current
			{
				[Token(Token = "0x6000116")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04000057 RID: 87
			[Token(Token = "0x4000143")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000058 RID: 88
			[Token(Token = "0x4000144")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04000059 RID: 89
			[Token(Token = "0x4000145")]
			[FieldOffset(Offset = "0x20")]
			public LeftoverCounter <>4__this;

			// Token: 0x0400005A RID: 90
			[Token(Token = "0x4000146")]
			[FieldOffset(Offset = "0x28")]
			public Color startColor;

			// Token: 0x0400005B RID: 91
			[Token(Token = "0x4000147")]
			[FieldOffset(Offset = "0x38")]
			public Color endColor;

			// Token: 0x0400005C RID: 92
			[Token(Token = "0x4000148")]
			[FieldOffset(Offset = "0x48")]
			private float <timer>5__2;
		}
	}
}
