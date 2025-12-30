using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Leftovers.UI
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x200000F")]
	public class SettingsMenu : MonoBehaviour
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x747690", Offset = "0x746A90", VA = "0x180747690")]
		private void OnEnable()
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1E0E10", Offset = "0x1E0210", VA = "0x1801E0E10")]
		public SettingsMenu()
		{
		}

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Slider sliderVolume;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Slider sliderMouseSensitivity;
	}
}
