using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Neighbour
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x200001D")]
	public class NeighbourDialoguePlayer : MonoBehaviour
	{
		// Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x743400", Offset = "0x742800", VA = "0x180743400")]
		private void Start()
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x743210", Offset = "0x742610", VA = "0x180743210")]
		public void StartInteract()
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x743180", Offset = "0x742580", VA = "0x180743180")]
		public void ResetState()
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x742210", Offset = "0x741610", VA = "0x180742210")]
		public void Complete()
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x743200", Offset = "0x742600", VA = "0x180743200")]
		public void StartConversation()
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x742750", Offset = "0x741B50", VA = "0x180742750")]
		public void GoToSegment(int index)
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x743110", Offset = "0x742510", VA = "0x180743110")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA5AE0", Offset = "0xA4EE0")]
		private IEnumerator PlaySegment()
		{
			return null;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x742F10", Offset = "0x742310", VA = "0x180742F10")]
		private void PlayBodyAnimation(string animation)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x742FB0", Offset = "0x7423B0", VA = "0x180742FB0")]
		private void PlayFaceAnimation(string animation)
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x743050", Offset = "0x742450", VA = "0x180743050")]
		private void PlayNeighbourSfx(AudioClip clip)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x7425B0", Offset = "0x7419B0", VA = "0x1807425B0")]
		public void GoToPrompt(int index)
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x742820", Offset = "0x741C20", VA = "0x180742820")]
		private void OnNod()
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x742A70", Offset = "0x741E70", VA = "0x180742A70")]
		private void OnShake()
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x742CC0", Offset = "0x7420C0", VA = "0x180742CC0")]
		private void OnShowFood()
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x743410", Offset = "0x742810", VA = "0x180743410")]
		public void TakeFoodFromPlayer()
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x742300", Offset = "0x741700", VA = "0x180742300")]
		public void EndConversation()
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x3A5EE0", Offset = "0x3A52E0", VA = "0x1803A5EE0")]
		public void SetOpeningSegmentIndex(int index)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x742290", Offset = "0x741690", VA = "0x180742290")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA5B30", Offset = "0xA4F30")]
		private IEnumerator DelayLookAt()
		{
			return null;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x7434C0", Offset = "0x7428C0", VA = "0x1807434C0")]
		public NeighbourDialoguePlayer()
		{
		}

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5070", Offset = "0xA4470")]
		[SerializeField]
		private float lookAtDelay;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA50C0", Offset = "0xA44C0")]
		[SerializeField]
		private Animator animatorNeighbour;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator animatorNeighbourFace;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioSource audioSourceNeighbour;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform lookAtFace;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5180", Offset = "0xA4580")]
		[SerializeField]
		private UnityEvent onReset;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UnityEvent onCompleted;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UnityEvent onEndConversation;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5A90", Offset = "0xA4E90")]
		[SerializeField]
		private List<DialogueSegment> segments;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<DialoguePrompt> prompts;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int indexOpeningSegment;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x6C")]
		private int originalOpeningSegment;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x70")]
		private int currentSegment;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x74")]
		private int currentPrompt;

		// Token: 0x02000034 RID: 52
		[Token(Token = "0x200003C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <PlaySegment>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <PlaySegment>d__20(int <>1__state)
			{
			}

			// Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06000114 RID: 276 RVA: 0x00002238 File Offset: 0x00000438
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x74A540", Offset = "0x749940", VA = "0x18074A540", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x06000115 RID: 277 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700002F")]
			private object Current
			{
				[Token(Token = "0x600015E")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x74ABA0", Offset = "0x749FA0", VA = "0x18074ABA0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x06000117 RID: 279 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000030")]
			private object Current
			{
				[Token(Token = "0x6000160")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04000130 RID: 304
			[Token(Token = "0x4000183")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000131 RID: 305
			[Token(Token = "0x4000184")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04000132 RID: 306
			[Token(Token = "0x4000185")]
			[FieldOffset(Offset = "0x20")]
			public NeighbourDialoguePlayer <>4__this;

			// Token: 0x04000133 RID: 307
			[Token(Token = "0x4000186")]
			[FieldOffset(Offset = "0x28")]
			private DialogueSegment <segment>5__2;

			// Token: 0x04000134 RID: 308
			[Token(Token = "0x4000187")]
			[FieldOffset(Offset = "0x70")]
			private int <indexLine>5__3;

			// Token: 0x04000135 RID: 309
			[Token(Token = "0x4000188")]
			[FieldOffset(Offset = "0x78")]
			private DialogueLine <line>5__4;
		}

		// Token: 0x02000035 RID: 53
		[Token(Token = "0x200003D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <DelayLookAt>d__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <DelayLookAt>d__31(int <>1__state)
			{
			}

			// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600011A RID: 282 RVA: 0x00002250 File Offset: 0x00000450
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x748D60", Offset = "0x748160", VA = "0x180748D60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x0600011B RID: 283 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000031")]
			private object Current
			{
				[Token(Token = "0x6000164")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x748E20", Offset = "0x748220", VA = "0x180748E20", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x0600011D RID: 285 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000032")]
			private object Current
			{
				[Token(Token = "0x6000166")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04000136 RID: 310
			[Token(Token = "0x4000189")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000137 RID: 311
			[Token(Token = "0x400018A")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04000138 RID: 312
			[Token(Token = "0x400018B")]
			[FieldOffset(Offset = "0x20")]
			public NeighbourDialoguePlayer <>4__this;
		}
	}
}
