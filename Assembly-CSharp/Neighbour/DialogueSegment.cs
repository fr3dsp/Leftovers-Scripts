using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Neighbour
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x200001C")]
	[Serializable]
	public struct DialogueSegment
	{
		// Token: 0x04000118 RID: 280
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x0")]
		public string name;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x8")]
		public List<DialogueLine> lines;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x10")]
		public float delay;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x18")]
		public string animationBody;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x20")]
		public string animationFace;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x28")]
		public AudioClip sfx;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x30")]
		public DialogueSegmentType type;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x34")]
		public int indexType;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent onSegmentStart;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onSegmentEnd;
	}
}
