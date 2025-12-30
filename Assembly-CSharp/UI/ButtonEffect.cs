using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Leftovers.UI
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x200000B")]
	public class ButtonEffect : MonoBehaviour
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x73E4F0", Offset = "0x73D8F0", VA = "0x18073E4F0")]
		private void Awake()
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x73E7B0", Offset = "0x73DBB0", VA = "0x18073E7B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x73E770", Offset = "0x73DB70", VA = "0x18073E770")]
		private void OnDisable()
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x73E950", Offset = "0x73DD50", VA = "0x18073E950")]
		private void OnPointerOverDelegate(PointerEventData eventData)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x73E8A0", Offset = "0x73DCA0", VA = "0x18073E8A0")]
		private void OnPointerOffDelegate(PointerEventData eventData)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x73EA70", Offset = "0x73DE70", VA = "0x18073EA70")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA52F0", Offset = "0xA46F0")]
		private IEnumerator PointerOverCoroutine()
		{
			return null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x73EA00", Offset = "0x73DE00", VA = "0x18073EA00")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA5340", Offset = "0xA4740")]
		private IEnumerator PointerOffCoroutine()
		{
			return null;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x73ED00", Offset = "0x73E100", VA = "0x18073ED00")]
		public ButtonEffect()
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x73EAE0", Offset = "0x73DEE0", VA = "0x18073EAE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private void <Awake>b__8_0(BaseEventData data)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x73EBF0", Offset = "0x73DFF0", VA = "0x18073EBF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private void <Awake>b__8_1(BaseEventData data)
		{
		}

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5070", Offset = "0xA4470")]
		[SerializeField]
		private float hoveredScale;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Color hoveredColor;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float effectDuration;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x30")]
		private TMP_Text textComponent;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x38")]
		private Color originalColor;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x48")]
		private float originalScale;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x4C")]
		private float timer;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine coroutine;

		// Token: 0x02000011 RID: 17
		[Token(Token = "0x200002B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <PointerOverCoroutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <PointerOverCoroutine>d__13(int <>1__state)
			{
			}

			// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600004E RID: 78 RVA: 0x000020B8 File Offset: 0x000002B8
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x74B750", Offset = "0x74AB50", VA = "0x18074B750", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x0600004F RID: 79 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000011")]
			private object Current
			{
				[Token(Token = "0x6000102")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x74BB10", Offset = "0x74AF10", VA = "0x18074BB10", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000051 RID: 81 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000012")]
			private object Current
			{
				[Token(Token = "0x6000104")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400003A RID: 58
			[Token(Token = "0x4000134")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400003B RID: 59
			[Token(Token = "0x4000135")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400003C RID: 60
			[Token(Token = "0x4000136")]
			[FieldOffset(Offset = "0x20")]
			public ButtonEffect <>4__this;

			// Token: 0x0400003D RID: 61
			[Token(Token = "0x4000137")]
			[FieldOffset(Offset = "0x28")]
			private Vector3 <originalScaleVec3>5__2;

			// Token: 0x0400003E RID: 62
			[Token(Token = "0x4000138")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 <hoveredScaleVec3>5__3;
		}

		// Token: 0x02000012 RID: 18
		[Token(Token = "0x200002C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <PointerOffCoroutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <PointerOffCoroutine>d__14(int <>1__state)
			{
			}

			// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06000054 RID: 84 RVA: 0x000020D0 File Offset: 0x000002D0
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x74B350", Offset = "0x74A750", VA = "0x18074B350", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000055 RID: 85 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000013")]
			private object Current
			{
				[Token(Token = "0x6000108")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x74B710", Offset = "0x74AB10", VA = "0x18074B710", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000057 RID: 87 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000014")]
			private object Current
			{
				[Token(Token = "0x600010A")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400003F RID: 63
			[Token(Token = "0x4000139")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000040 RID: 64
			[Token(Token = "0x400013A")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04000041 RID: 65
			[Token(Token = "0x400013B")]
			[FieldOffset(Offset = "0x20")]
			public ButtonEffect <>4__this;

			// Token: 0x04000042 RID: 66
			[Token(Token = "0x400013C")]
			[FieldOffset(Offset = "0x28")]
			private Vector3 <originalScaleVec3>5__2;

			// Token: 0x04000043 RID: 67
			[Token(Token = "0x400013D")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 <hoveredScaleVec3>5__3;
		}
	}
}
