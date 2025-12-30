using System;
using Il2CppDummyDll;

namespace Leftovers.Neighbour
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x200001A")]
	[Serializable]
	public class DialoguePrompt
	{
		// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1E0CC0", Offset = "0x1E00C0", VA = "0x1801E0CC0")]
		public DialoguePrompt()
		{
		}

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x18")]
		public DialoguePromptOption optionNod;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x20")]
		public DialoguePromptOption optionShake;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x28")]
		public DialoguePromptOption optionShowFood;
	}
}
