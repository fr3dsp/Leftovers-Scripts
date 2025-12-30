using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Leftovers.Neighbour;
using Leftovers.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.General
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x2000021")]
	public class GameState : MonoBehaviour
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public static GameState Instance
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x740250", Offset = "0x73F650", VA = "0x180740250")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x740300", Offset = "0x73F700", VA = "0x180740300")]
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00002298 File Offset: 0x00000498
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		public int NumberOfLeftOvers
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x7402B0", Offset = "0x73F6B0", VA = "0x1807402B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x740460", Offset = "0x73F860", VA = "0x180740460")]
			set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		public bool HasExtraLeftOver
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x7402D0", Offset = "0x73F6D0", VA = "0x1807402D0")]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600014F RID: 335 RVA: 0x000022B0 File Offset: 0x000004B0
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		public bool CanShowLeftovers
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x631C00", Offset = "0x631000", VA = "0x180631C00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x7402C0", Offset = "0x73F6C0", VA = "0x1807402C0")]
			set
			{
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x73F920", Offset = "0x73ED20", VA = "0x18073F920")]
		private void Awake()
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x73FDB0", Offset = "0x73F1B0", VA = "0x18073FDB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x73FE00", Offset = "0x73F200", VA = "0x18073FE00")]
		public void ResetGame()
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x740080", Offset = "0x73F480", VA = "0x180740080")]
		private void Update()
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x73FD60", Offset = "0x73F160", VA = "0x18073FD60")]
		[Attribute(Name = "ContextMenu", RVA = "0xA5E00", Offset = "0xA5200")]
		public void EditorDecreaseNumberOfLeftovers()
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x73FCD0", Offset = "0x73F0D0", VA = "0x18073FCD0")]
		public void DecreaseNumberOfLeftovers(int number)
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x73FA50", Offset = "0x73EE50", VA = "0x18073FA50")]
		[Attribute(Name = "ContextMenu", RVA = "0xA5E30", Offset = "0xA5230")]
		public void Cry()
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x73FCF0", Offset = "0x73F0F0", VA = "0x18073FCF0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA5E60", Offset = "0xA5260")]
		private IEnumerator DelayCry()
		{
			return null;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x73FD70", Offset = "0x73F170", VA = "0x18073FD70")]
		[Attribute(Name = "ContextMenu", RVA = "0xA5EB0", Offset = "0xA52B0")]
		public void ForceMistressThreshold()
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x740060", Offset = "0x73F460", VA = "0x180740060")]
		public void RestartOldManConversation()
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x740040", Offset = "0x73F440", VA = "0x180740040")]
		public void RestartMistressChase()
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x73FD90", Offset = "0x73F190", VA = "0x18073FD90")]
		public void FoundCannedFood()
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x7400F0", Offset = "0x73F4F0", VA = "0x1807400F0")]
		public GameState()
		{
		}

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x0")]
		private static GameState instance;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5070", Offset = "0xA4470")]
		[SerializeField]
		private int startingNumberOfLeftovers;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int startingNumberOfChances;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int mistressThreshold;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int[] chancesOpeningSegmentIndices;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float cryDuration;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AudioSource cryAudioSource;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AudioClip cryAudioClip;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA50C0", Offset = "0xA44C0")]
		[SerializeField]
		private NeighbourDialoguePlayer mumDialoguePlayer;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Teleportation mumTeleportation;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject bully;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5D60", Offset = "0xA5160")]
		[SerializeField]
		private UnityEvent onRestartOldMan;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5DB0", Offset = "0xA51B0")]
		[SerializeField]
		private UnityEvent onRestartMistressChase;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5180", Offset = "0xA4580")]
		[SerializeField]
		private GameState.StringEvent onNumberOfLeftOversChanged;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UnityEvent onMistressThresholdReached;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UnityEvent onReceivedExtraLeftover;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UnityEvent onGaveAwayExtraLeftover;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UnityEvent onFoundCannedFood;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x98")]
		private int numberOfLeftovers;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x9C")]
		private int numberOfChances;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0xA0")]
		private bool canShowLeftovers;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0xA1")]
		private bool hasExtraLeftover;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0xA8")]
		private List<NeighbourState> neighbourStates;

		// Token: 0x0200003C RID: 60
		[Token(Token = "0x2000040")]
		[Serializable]
		private class StringEvent : UnityEvent<string>
		{
			// Token: 0x0600015E RID: 350 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x7479D0", Offset = "0x746DD0", VA = "0x1807479D0")]
			public StringEvent()
			{
			}
		}

		// Token: 0x0200003D RID: 61
		[Token(Token = "0x2000041")]
		[Serializable]
		private class IntEvent : UnityEvent<int>
		{
			// Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x7407A0", Offset = "0x73FBA0", VA = "0x1807407A0")]
			public IntEvent()
			{
			}
		}

		// Token: 0x0200003E RID: 62
		[Token(Token = "0x2000042")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <DelayCry>d__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000160 RID: 352 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <DelayCry>d__43(int <>1__state)
			{
			}

			// Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06000162 RID: 354 RVA: 0x000022C8 File Offset: 0x000004C8
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x748A10", Offset = "0x747E10", VA = "0x180748A10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x06000163 RID: 355 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000037")]
			private object Current
			{
				[Token(Token = "0x6000178")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000164 RID: 356 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x748D20", Offset = "0x748120", VA = "0x180748D20", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x06000165 RID: 357 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000038")]
			private object Current
			{
				[Token(Token = "0x600017A")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400017F RID: 383
			[Token(Token = "0x4000195")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000180 RID: 384
			[Token(Token = "0x4000196")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04000181 RID: 385
			[Token(Token = "0x4000197")]
			[FieldOffset(Offset = "0x20")]
			public GameState <>4__this;
		}
	}
}
