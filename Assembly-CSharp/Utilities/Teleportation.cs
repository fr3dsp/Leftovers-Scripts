using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Leftovers.Utilities
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000007")]
	public class Teleportation : MonoBehaviour
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x747A10", Offset = "0x746E10", VA = "0x180747A10")]
		public void Teleport()
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1E0E10", Offset = "0x1E0210", VA = "0x1801E0E10")]
		public Teleportation()
		{
		}

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5070", Offset = "0xA4470")]
		[SerializeField]
		private TransitionType type;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA50C0", Offset = "0xA44C0")]
		[SerializeField]
		private Transform teleportationPoint;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip startTeleportSound;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip finishTeleportSound;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AudioSource audioSource;

		// Token: 0x0200000A RID: 10
		[Token(Token = "0x2000028")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x1E0CC0", Offset = "0x1E00C0", VA = "0x1801E0CC0")]
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x74C200", Offset = "0x74B600", VA = "0x18074C200")]
			internal void <Teleport>b__0()
			{
			}

			// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x74C4A0", Offset = "0x74B8A0", VA = "0x18074C4A0")]
			internal void <Teleport>b__1()
			{
			}

			// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x74C670", Offset = "0x74BA70", VA = "0x18074C670")]
			internal void <Teleport>b__2()
			{
			}

			// Token: 0x0400001A RID: 26
			[Token(Token = "0x400012B")]
			[FieldOffset(Offset = "0x10")]
			public GameObject player;

			// Token: 0x0400001B RID: 27
			[Token(Token = "0x400012C")]
			[FieldOffset(Offset = "0x18")]
			public Teleportation <>4__this;
		}
	}
}
