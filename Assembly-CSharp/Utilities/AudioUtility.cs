using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Leftovers.Utilities
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class AudioUtility : MonoBehaviour
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x73DF90", Offset = "0x73D390", VA = "0x18073DF90")]
		public void StartFadeIn(float duration)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x73DE90", Offset = "0x73D290", VA = "0x18073DE90")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA4FD0", Offset = "0xA43D0")]
		private IEnumerator FadeIn(float duration)
		{
			return null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x73E050", Offset = "0x73D450", VA = "0x18073E050")]
		public void StartFadeOut(float duration)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x73DF10", Offset = "0x73D310", VA = "0x18073DF10")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA5020", Offset = "0xA4420")]
		private IEnumerator FadeOut(float duration)
		{
			return null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0")]
		public void PlayIfNotPlaying()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x73E0F0", Offset = "0x73D4F0", VA = "0x18073E0F0")]
		public AudioUtility()
		{
		}

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource audioSource;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float volume;

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x2000026")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <FadeIn>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <FadeIn>d__3(int <>1__state)
			{
			}

			// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600001A RID: 26 RVA: 0x00002058 File Offset: 0x00000258
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x749300", Offset = "0x748700", VA = "0x180749300", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000001 RID: 1
			// (get) Token: 0x0600001B RID: 27 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000009")]
			private object Current
			{
				[Token(Token = "0x60000E6")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x749400", Offset = "0x748800", VA = "0x180749400", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x0600001D RID: 29 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700000A")]
			private object Current
			{
				[Token(Token = "0x60000E8")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04000004 RID: 4
			[Token(Token = "0x4000121")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000005 RID: 5
			[Token(Token = "0x4000122")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04000006 RID: 6
			[Token(Token = "0x4000123")]
			[FieldOffset(Offset = "0x20")]
			public AudioUtility <>4__this;

			// Token: 0x04000007 RID: 7
			[Token(Token = "0x4000124")]
			[FieldOffset(Offset = "0x28")]
			public float duration;

			// Token: 0x04000008 RID: 8
			[Token(Token = "0x4000125")]
			[FieldOffset(Offset = "0x2C")]
			private float <timer>5__2;
		}

		// Token: 0x02000006 RID: 6
		[Token(Token = "0x2000027")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <FadeOut>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <FadeOut>d__5(int <>1__state)
			{
			}

			// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06000020 RID: 32 RVA: 0x00002070 File Offset: 0x00000270
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x749440", Offset = "0x748840", VA = "0x180749440", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000021 RID: 33 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700000B")]
			private object Current
			{
				[Token(Token = "0x60000EC")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x749550", Offset = "0x748950", VA = "0x180749550", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x06000023 RID: 35 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700000C")]
			private object Current
			{
				[Token(Token = "0x60000EE")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04000009 RID: 9
			[Token(Token = "0x4000126")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400000A RID: 10
			[Token(Token = "0x4000127")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400000B RID: 11
			[Token(Token = "0x4000128")]
			[FieldOffset(Offset = "0x20")]
			public AudioUtility <>4__this;

			// Token: 0x0400000C RID: 12
			[Token(Token = "0x4000129")]
			[FieldOffset(Offset = "0x28")]
			public float duration;

			// Token: 0x0400000D RID: 13
			[Token(Token = "0x400012A")]
			[FieldOffset(Offset = "0x2C")]
			private float <timer>5__2;
		}
	}
}
