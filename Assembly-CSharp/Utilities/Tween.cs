using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Utilities
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000A")]
	public class Tween : MonoBehaviour
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x748300", Offset = "0x747700", VA = "0x180748300")]
		public void StartTween()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x748370", Offset = "0x747770", VA = "0x180748370")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA52A0", Offset = "0xA46A0")]
		private IEnumerator Tweening()
		{
			return null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x7483E0", Offset = "0x7477E0", VA = "0x1807483E0")]
		public Tween()
		{
		}

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5110", Offset = "0xA4510")]
		[Attribute(Name = "RangeAttribute", RVA = "0xA5110", Offset = "0xA4510")]
		[SerializeField]
		private float tweenDuration;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool enableOnStart;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x1D")]
		[SerializeField]
		private bool disableOnEnd;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA50C0", Offset = "0xA44C0")]
		[SerializeField]
		private Transform objectToTween;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform positionFrom;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform positionTo;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5180", Offset = "0xA4580")]
		[SerializeField]
		private UnityEvent onTweenStart;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UnityEvent onTweenEnd;

		// Token: 0x0200000F RID: 15
		[Token(Token = "0x200002A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <Tweening>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <Tweening>d__9(int <>1__state)
			{
			}

			// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600003E RID: 62 RVA: 0x000020A0 File Offset: 0x000002A0
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x74BE70", Offset = "0x74B270", VA = "0x18074BE70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600003F RID: 63 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700000F")]
			private object Current
			{
				[Token(Token = "0x60000FC")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x74C1C0", Offset = "0x74B5C0", VA = "0x18074C1C0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000041 RID: 65 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000010")]
			private object Current
			{
				[Token(Token = "0x60000FE")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400002E RID: 46
			[Token(Token = "0x4000130")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400002F RID: 47
			[Token(Token = "0x4000131")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04000030 RID: 48
			[Token(Token = "0x4000132")]
			[FieldOffset(Offset = "0x20")]
			public Tween <>4__this;

			// Token: 0x04000031 RID: 49
			[Token(Token = "0x4000133")]
			[FieldOffset(Offset = "0x28")]
			private float <timer>5__2;
		}
	}
}
