using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Neighbour
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000020")]
	public class NeighbourState : MonoBehaviour
	{
		// Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0")]
		private void Update()
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x7451A0", Offset = "0x7445A0", VA = "0x1807451A0")]
		public void StartInteract()
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x743700", Offset = "0x742B00", VA = "0x180743700")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA5C90", Offset = "0xA5090")]
		private IEnumerator CheckAvailability()
		{
			return null;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x744B60", Offset = "0x743F60", VA = "0x180744B60")]
		public void ResetState()
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x745010", Offset = "0x744410", VA = "0x180745010")]
		public void SpokenTo()
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x743770", Offset = "0x742B70", VA = "0x180743770")]
		public void Complete()
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x7446F0", Offset = "0x743AF0", VA = "0x1807446F0")]
		public void PrepareConversation()
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x7450A0", Offset = "0x7444A0", VA = "0x1807450A0")]
		public void StartConversation()
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x743B80", Offset = "0x742F80", VA = "0x180743B80")]
		public void GoToSegment(int index)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x744680", Offset = "0x743A80", VA = "0x180744680")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA5CE0", Offset = "0xA50E0")]
		private IEnumerator PlaySegment()
		{
			return null;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x744480", Offset = "0x743880", VA = "0x180744480")]
		private void PlayBodyAnimation(string animation)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x744520", Offset = "0x743920", VA = "0x180744520")]
		private void PlayFaceAnimation(string animation)
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x7445C0", Offset = "0x7439C0", VA = "0x1807445C0")]
		private void PlayNeighbourSfx(AudioClip clip)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x7439E0", Offset = "0x742DE0", VA = "0x1807439E0")]
		public void GoToPrompt(int index)
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x743D60", Offset = "0x743160", VA = "0x180743D60")]
		private void OnNod()
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x743FC0", Offset = "0x7433C0", VA = "0x180743FC0")]
		private void OnShake()
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x744220", Offset = "0x743620", VA = "0x180744220")]
		private void OnShowFood()
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x745300", Offset = "0x744700", VA = "0x180745300")]
		public void TakeFoodFromPlayer()
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x743C50", Offset = "0x743050", VA = "0x180743C50")]
		public void MakePlayerPutAwayFood()
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x7437F0", Offset = "0x742BF0", VA = "0x1807437F0")]
		public void EndConversation()
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x744E20", Offset = "0x744220", VA = "0x180744E20")]
		public void SetDoorOpenedState(bool state)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x744F10", Offset = "0x744310", VA = "0x180744F10")]
		public void SetNeighbourForwardState(bool state)
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x6E6590", Offset = "0x6E5990", VA = "0x1806E6590")]
		public void SetAvailability(bool state)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x745000", Offset = "0x744400", VA = "0x180745000")]
		public void SetOpeningSegmentIndex(int index)
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x745000", Offset = "0x744400", VA = "0x180745000")]
		public void SetSubsequentSegmentIndex(int index)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x744810", Offset = "0x743C10", VA = "0x180744810")]
		[Attribute(Name = "ContextMenu", RVA = "0xA5D30", Offset = "0xA5130")]
		private void ResetAnimation()
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x7454D0", Offset = "0x7448D0", VA = "0x1807454D0")]
		public NeighbourState()
		{
		}

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int HashBoolPartial;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int HashBoolFull;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int HashBoolAlways;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int HashBoolOpened;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int HashBoolForward;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x18")]
		private static NeighbourState DebuggedNeighbour;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5C20", Offset = "0xA5020")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xA5C20", Offset = "0xA5020")]
		[SerializeField]
		private KeyCode debugKeyCode;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5070", Offset = "0xA4470")]
		[SerializeField]
		private NeighbourAnimatorControllers animatorControllers;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private NeighbourDoorAnimationType doorAnimationType;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool isAvailable;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float availabilityDelay;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string unavailableMessage;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float unavailableMessageDuration;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA50C0", Offset = "0xA44C0")]
		[SerializeField]
		private Animator animatorDoor;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Animator animatorNeighbour;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Animator animatorNeighbourFace;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AudioSource audioSourceNeighbour;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform lookAtFace;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5180", Offset = "0xA4580")]
		[SerializeField]
		private UnityEvent onReset;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UnityEvent onUnavailable;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UnityEvent onSpokenTo;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UnityEvent onCompleted;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UnityEvent onEndConversation;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5A90", Offset = "0xA4E90")]
		[SerializeField]
		private List<DialogueSegment> segments;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<DialoguePrompt> prompts;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private int indexOpeningSegment;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private int indexSubsequentSegment;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0xB0")]
		private bool spokenTo;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0xB4")]
		private int currentSegment;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0xB8")]
		private int currentPrompt;

		// Token: 0x02000039 RID: 57
		[Token(Token = "0x200003E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <CheckAvailability>d__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <CheckAvailability>d__32(int <>1__state)
			{
			}

			// Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600013F RID: 319 RVA: 0x00002268 File Offset: 0x00000468
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x7487D0", Offset = "0x747BD0", VA = "0x1807487D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x06000140 RID: 320 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000033")]
			private object Current
			{
				[Token(Token = "0x600016A")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x7489D0", Offset = "0x747DD0", VA = "0x1807489D0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000142 RID: 322 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000034")]
			private object Current
			{
				[Token(Token = "0x600016C")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400015F RID: 351
			[Token(Token = "0x400018C")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000160 RID: 352
			[Token(Token = "0x400018D")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04000161 RID: 353
			[Token(Token = "0x400018E")]
			[FieldOffset(Offset = "0x20")]
			public NeighbourState <>4__this;
		}

		// Token: 0x0200003A RID: 58
		[Token(Token = "0x200003F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <PlaySegment>d__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <PlaySegment>d__39(int <>1__state)
			{
			}

			// Token: 0x06000144 RID: 324 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06000145 RID: 325 RVA: 0x00002280 File Offset: 0x00000480
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x74ABE0", Offset = "0x749FE0", VA = "0x18074ABE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x06000146 RID: 326 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000035")]
			private object Current
			{
				[Token(Token = "0x6000170")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x74B310", Offset = "0x74A710", VA = "0x18074B310", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x06000148 RID: 328 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000036")]
			private object Current
			{
				[Token(Token = "0x6000172")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04000162 RID: 354
			[Token(Token = "0x400018F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000163 RID: 355
			[Token(Token = "0x4000190")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04000164 RID: 356
			[Token(Token = "0x4000191")]
			[FieldOffset(Offset = "0x20")]
			public NeighbourState <>4__this;

			// Token: 0x04000165 RID: 357
			[Token(Token = "0x4000192")]
			[FieldOffset(Offset = "0x28")]
			private DialogueSegment <segment>5__2;

			// Token: 0x04000166 RID: 358
			[Token(Token = "0x4000193")]
			[FieldOffset(Offset = "0x70")]
			private int <indexLine>5__3;

			// Token: 0x04000167 RID: 359
			[Token(Token = "0x4000194")]
			[FieldOffset(Offset = "0x78")]
			private DialogueLine <line>5__4;
		}
	}
}
