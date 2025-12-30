using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Leftovers.Neighbour
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x200001E")]
	public class NeighbourLineRenderers : MonoBehaviour
	{
		// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x743620", Offset = "0x742A20", VA = "0x180743620")]
		private void Start()
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x743650", Offset = "0x742A50", VA = "0x180743650")]
		private void Update()
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1E0E10", Offset = "0x1E0210", VA = "0x1801E0E10")]
		public NeighbourLineRenderers()
		{
		}

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5B80", Offset = "0xA4F80")]
		[SerializeField]
		private LineRenderer upperToFaceLine;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5BD0", Offset = "0xA4FD0")]
		[SerializeField]
		private Transform upperTop;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform faceBottom;
	}
}
