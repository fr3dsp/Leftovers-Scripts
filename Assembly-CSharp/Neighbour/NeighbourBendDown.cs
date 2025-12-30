using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Leftovers.Neighbour
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000016")]
	public class NeighbourBendDown : MonoBehaviour
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x741CF0", Offset = "0x7410F0", VA = "0x180741CF0")]
		private void Start()
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x741F50", Offset = "0x741350", VA = "0x180741F50")]
		private void Update()
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x741BF0", Offset = "0x740FF0", VA = "0x180741BF0")]
		public void StartBendDown()
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x741C70", Offset = "0x741070", VA = "0x180741C70")]
		public void StartStraigten()
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x741A90", Offset = "0x740E90", VA = "0x180741A90")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA5990", Offset = "0xA4D90")]
		private IEnumerator BendDown()
		{
			return null;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x741D80", Offset = "0x741180", VA = "0x180741D80")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA59E0", Offset = "0xA4DE0")]
		private IEnumerator Straighten()
		{
			return null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x741DF0", Offset = "0x7411F0", VA = "0x180741DF0")]
		private void UpdateUpperBody()
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x741B30", Offset = "0x740F30", VA = "0x180741B30")]
		public void MoveFace(float duration)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x741B00", Offset = "0x740F00", VA = "0x180741B00")]
		public void MoveFaceBack(float duration)
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x741B60", Offset = "0x740F60", VA = "0x180741B60")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA5A30", Offset = "0xA4E30")]
		private IEnumerator MovingFace(float duration, float amount)
		{
			return null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x742180", Offset = "0x741580", VA = "0x180742180")]
		public NeighbourBendDown()
		{
		}

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA58A0", Offset = "0xA4CA0")]
		[SerializeField]
		private bool toBendDown;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float bendDownDuration;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float straightenDuration;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float offsetDistance;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA58F0", Offset = "0xA4CF0")]
		[SerializeField]
		private Transform face;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform offsetReference;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5940", Offset = "0xA4D40")]
		[SerializeField]
		private Transform upperBodyBottom;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform upperBodyTop;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform upperBody;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 originalPosition;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 offsetPosition;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x68")]
		private Transform neighbourHeadPosition;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 facePosition;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x7C")]
		private float offsetAmount;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x80")]
		private float timer;

		// Token: 0x0200002A RID: 42
		[Token(Token = "0x2000039")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <BendDown>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <BendDown>d__19(int <>1__state)
			{
			}

			// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060000EE RID: 238 RVA: 0x000021F0 File Offset: 0x000003F0
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x748480", Offset = "0x747880", VA = "0x180748480", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000EF RID: 239 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000029")]
			private object Current
			{
				[Token(Token = "0x600014C")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x748790", Offset = "0x747B90", VA = "0x180748790", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000F1 RID: 241 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700002A")]
			private object Current
			{
				[Token(Token = "0x600014E")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040000F2 RID: 242
			[Token(Token = "0x4000174")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040000F3 RID: 243
			[Token(Token = "0x4000175")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040000F4 RID: 244
			[Token(Token = "0x4000176")]
			[FieldOffset(Offset = "0x20")]
			public NeighbourBendDown <>4__this;

			// Token: 0x040000F5 RID: 245
			[Token(Token = "0x4000177")]
			[FieldOffset(Offset = "0x28")]
			private Vector3 <endPosition>5__2;
		}

		// Token: 0x0200002B RID: 43
		[Token(Token = "0x200003A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <Straighten>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <Straighten>d__20(int <>1__state)
			{
			}

			// Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060000F4 RID: 244 RVA: 0x00002208 File Offset: 0x00000408
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x74BC80", Offset = "0x74B080", VA = "0x18074BC80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700002B")]
			private object Current
			{
				[Token(Token = "0x6000152")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x74BE30", Offset = "0x74B230", VA = "0x18074BE30", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060000F7 RID: 247 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700002C")]
			private object Current
			{
				[Token(Token = "0x6000154")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040000F6 RID: 246
			[Token(Token = "0x4000178")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040000F7 RID: 247
			[Token(Token = "0x4000179")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040000F8 RID: 248
			[Token(Token = "0x400017A")]
			[FieldOffset(Offset = "0x20")]
			public NeighbourBendDown <>4__this;

			// Token: 0x040000F9 RID: 249
			[Token(Token = "0x400017B")]
			[FieldOffset(Offset = "0x28")]
			private Vector3 <startPosition>5__2;
		}

		// Token: 0x0200002C RID: 44
		[Token(Token = "0x200003B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <MovingFace>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <MovingFace>d__24(int <>1__state)
			{
			}

			// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060000FA RID: 250 RVA: 0x00002220 File Offset: 0x00000420
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x74A320", Offset = "0x749720", VA = "0x18074A320", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060000FB RID: 251 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700002D")]
			private object Current
			{
				[Token(Token = "0x6000158")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x74A400", Offset = "0x749800", VA = "0x18074A400", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060000FD RID: 253 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700002E")]
			private object Current
			{
				[Token(Token = "0x600015A")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040000FA RID: 250
			[Token(Token = "0x400017C")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040000FB RID: 251
			[Token(Token = "0x400017D")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040000FC RID: 252
			[Token(Token = "0x400017E")]
			[FieldOffset(Offset = "0x20")]
			public NeighbourBendDown <>4__this;

			// Token: 0x040000FD RID: 253
			[Token(Token = "0x400017F")]
			[FieldOffset(Offset = "0x28")]
			public float amount;

			// Token: 0x040000FE RID: 254
			[Token(Token = "0x4000180")]
			[FieldOffset(Offset = "0x2C")]
			public float duration;

			// Token: 0x040000FF RID: 255
			[Token(Token = "0x4000181")]
			[FieldOffset(Offset = "0x30")]
			private float <originalFaceDistance>5__2;

			// Token: 0x04000100 RID: 256
			[Token(Token = "0x4000182")]
			[FieldOffset(Offset = "0x34")]
			private float <timer>5__3;
		}
	}
}
