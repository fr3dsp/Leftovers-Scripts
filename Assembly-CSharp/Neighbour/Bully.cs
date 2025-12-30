using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Leftovers.Neighbour
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000013")]
	public class Bully : MonoBehaviour
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x73E250", Offset = "0x73D650", VA = "0x18073E250")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x73E310", Offset = "0x73D710", VA = "0x18073E310")]
		private void Update()
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x73E4B0", Offset = "0x73D8B0", VA = "0x18073E4B0")]
		public Bully()
		{
		}

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5070", Offset = "0xA4470")]
		[SerializeField]
		private float pushForce;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float decaySpeed;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 direction;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x30")]
		private CharacterController playerController;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x38")]
		private float currentForce;
	}
}
