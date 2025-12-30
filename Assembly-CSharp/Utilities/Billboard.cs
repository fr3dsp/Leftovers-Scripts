using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Leftovers.Utilities
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000005")]
	public class Billboard : MonoBehaviour
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x73E100", Offset = "0x73D500", VA = "0x18073E100")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x73E230", Offset = "0x73D630", VA = "0x18073E230")]
		public Billboard()
		{
		}

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool onlyXZ;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool overTime;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float overTimeSpeed;
	}
}
