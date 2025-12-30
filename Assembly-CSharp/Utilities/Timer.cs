using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Utilities
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x2000008")]
	public class Timer : MonoBehaviour
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x748030", Offset = "0x747430", VA = "0x180748030")]
		[Attribute(Name = "ContextMenu", RVA = "0xA51D0", Offset = "0xA45D0")]
		public void StartTimer()
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x7480B0", Offset = "0x7474B0", VA = "0x1807480B0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA5200", Offset = "0xA4600")]
		private IEnumerator UpdateTimer()
		{
			return null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x748120", Offset = "0x747520", VA = "0x180748120")]
		public Timer()
		{
		}

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5110", Offset = "0xA4510")]
		[Attribute(Name = "RangeAttribute", RVA = "0xA5110", Offset = "0xA4510")]
		[SerializeField]
		private float duration;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5180", Offset = "0xA4580")]
		[SerializeField]
		private UnityEvent onTimerStart;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent onTimerEnd;

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x2000029")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <UpdateTimer>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <UpdateTimer>d__4(int <>1__state)
			{
			}

			// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06000031 RID: 49 RVA: 0x00002088 File Offset: 0x00000288
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x74CA00", Offset = "0x74BE00", VA = "0x18074CA00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x06000032 RID: 50 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700000D")]
			private object Current
			{
				[Token(Token = "0x60000F6")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x74CAC0", Offset = "0x74BEC0", VA = "0x18074CAC0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000034 RID: 52 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700000E")]
			private object Current
			{
				[Token(Token = "0x60000F8")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400001F RID: 31
			[Token(Token = "0x400012D")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000020 RID: 32
			[Token(Token = "0x400012E")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04000021 RID: 33
			[Token(Token = "0x400012F")]
			[FieldOffset(Offset = "0x20")]
			public Timer <>4__this;
		}
	}
}
