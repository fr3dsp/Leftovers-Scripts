using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Leftovers.UI
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x200000E")]
	public class PauseMenu : MonoBehaviour
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x7456C0", Offset = "0x744AC0", VA = "0x1807456C0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1E0E10", Offset = "0x1E0210", VA = "0x1801E0E10")]
		public PauseMenu()
		{
		}

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject pageMain;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject pageSettings;
	}
}
