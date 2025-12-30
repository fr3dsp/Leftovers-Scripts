using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Leftovers.Neighbour
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000015")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0xA5840", Offset = "0xA4C40")]
	public class NeighbourAnimatorControllers : ScriptableObject
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x28E460", Offset = "0x28D860", VA = "0x18028E460")]
		public NeighbourAnimatorControllers()
		{
		}

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x18")]
		public RuntimeAnimatorController controllerFullyOpened;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x20")]
		public RuntimeAnimatorController controllerPartiallyOpened;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x28")]
		public RuntimeAnimatorController controllerLegless;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x30")]
		public RuntimeAnimatorController controllerNine;
	}
}
