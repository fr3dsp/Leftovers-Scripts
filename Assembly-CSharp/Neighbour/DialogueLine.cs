using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Neighbour
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x200001B")]
	[Serializable]
	public struct DialogueLine
	{
		// Token: 0x04000110 RID: 272
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "TextAreaAttribute", RVA = "0xA5A80", Offset = "0xA4E80")]
		public string message;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x8")]
		public string animationBody;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x10")]
		public string animationFace;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x18")]
		public float delay;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x1C")]
		public float durationMessage;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x20")]
		public float durationLine;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x28")]
		public AudioClip sfx;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent onLineEnd;
	}
}
