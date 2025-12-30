using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Leftovers.General
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000025")]
	public class Interactor : MonoBehaviour
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000008")]
		public static Interactor Instance
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x7415B0", Offset = "0x7409B0", VA = "0x1807415B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x741610", Offset = "0x740A10", VA = "0x180741610")]
			set
			{
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x740AE0", Offset = "0x73FEE0", VA = "0x180740AE0")]
		private void Awake()
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x741310", Offset = "0x740710", VA = "0x180741310")]
		private void Start()
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x741140", Offset = "0x740540", VA = "0x180741140")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x741380", Offset = "0x740780", VA = "0x180741380")]
		private void Update()
		{
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x740BA0", Offset = "0x73FFA0", VA = "0x180740BA0")]
		private void HandleHoverable(Hoverable hoverable)
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x740D80", Offset = "0x740180", VA = "0x180740D80")]
		private void HandleInteractable()
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x741190", Offset = "0x740590", VA = "0x180741190")]
		private void PlayAnimation(InteractionAnimationType animationType)
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x740B40", Offset = "0x73FF40", VA = "0x180740B40")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA5F30", Offset = "0xA5330")]
		private IEnumerator FinishAnimation(float duration)
		{
			return null;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x741100", Offset = "0x740500", VA = "0x180741100")]
		public void LockInteraction()
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x741370", Offset = "0x740770", VA = "0x180741370")]
		public void UnlockInteraction()
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x741570", Offset = "0x740970", VA = "0x180741570")]
		public Interactor()
		{
		}

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int HashTriggerKnock;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x8")]
		private static Interactor instance;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5070", Offset = "0xA4470")]
		[SerializeField]
		private float raycastDistance;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private LayerMask raycastMask;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA50C0", Offset = "0xA44C0")]
		[SerializeField]
		private Animator animator;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Camera cameraRaycast;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject cursor;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 screenCenter;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x44")]
		private RaycastHit hitInfo;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x70")]
		private bool lockedInteraction;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x78")]
		private Hoverable currentDetectedObject;

		// Token: 0x02000043 RID: 67
		[Token(Token = "0x2000043")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <FinishAnimation>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600017B RID: 379 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <FinishAnimation>d__21(int <>1__state)
			{
			}

			// Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600017D RID: 381 RVA: 0x000022F8 File Offset: 0x000004F8
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x749C60", Offset = "0x749060", VA = "0x180749C60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x0600017E RID: 382 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000039")]
			private object Current
			{
				[Token(Token = "0x600017E")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600017F RID: 383 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x749D50", Offset = "0x749150", VA = "0x180749D50", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x06000180 RID: 384 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700003A")]
			private object Current
			{
				[Token(Token = "0x6000180")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04000198 RID: 408
			[Token(Token = "0x4000198")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000199 RID: 409
			[Token(Token = "0x4000199")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400019A RID: 410
			[Token(Token = "0x400019A")]
			[FieldOffset(Offset = "0x20")]
			public float duration;
		}
	}
}
