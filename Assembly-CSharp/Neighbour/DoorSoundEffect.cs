using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Leftovers.Neighbour
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000014")]
	public class DoorSoundEffect : MonoBehaviour
	{
		// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x73EE90", Offset = "0x73E290", VA = "0x18073EE90")]
		public void PlayDoorOpen()
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x73EE60", Offset = "0x73E260", VA = "0x18073EE60")]
		public void PlayDoorClose()
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x73EEC0", Offset = "0x73E2C0", VA = "0x18073EEC0")]
		public void PlayGrunt()
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1E0E10", Offset = "0x1E0210", VA = "0x1801E0E10")]
		public DoorSoundEffect()
		{
		}

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource audioSource;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip sfxDoorOpen;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip sfxDoorClose;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip sfxGrunt;
	}
}
