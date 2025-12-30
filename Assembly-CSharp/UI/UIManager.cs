using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Leftovers.UI
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x2000011")]
	public class UIManager : MonoBehaviour
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public static UIManager Instance
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x74D570", Offset = "0x74C970", VA = "0x18074D570")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x74D5D0", Offset = "0x74C9D0", VA = "0x18074D5D0")]
			set
			{
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x74CB00", Offset = "0x74BF00", VA = "0x18074CB00")]
		private void Awake()
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x74D190", Offset = "0x74C590", VA = "0x18074D190")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x74D320", Offset = "0x74C720", VA = "0x18074D320")]
		public void SetMessage(string message, float duration = -1f)
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x74D3D0", Offset = "0x74C7D0", VA = "0x18074D3D0")]
		public void SetMessage(string message)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x74CC40", Offset = "0x74C040", VA = "0x18074CC40")]
		public void ClearMessage(float delay)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x74D270", Offset = "0x74C670", VA = "0x18074D270")]
		public void SetInnerMessage(string message, float duration = -1f)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x74D200", Offset = "0x74C600", VA = "0x18074D200")]
		public void SetInnerMessage(string message)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x74CB60", Offset = "0x74BF60", VA = "0x18074CB60")]
		public void ClearInnerMessage(float delay)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x74D1E0", Offset = "0x74C5E0", VA = "0x18074D1E0")]
		public void SetDialogueClickPromptVisibility(bool visibility)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x74D440", Offset = "0x74C840", VA = "0x18074D440")]
		public void SetTooltip(string message)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x74CF10", Offset = "0x74C310", VA = "0x18074CF10")]
		public void FadeIn(UnityAction callback)
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x74CF40", Offset = "0x74C340", VA = "0x18074CF40")]
		public void FadeIn()
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x74CFA0", Offset = "0x74C3A0", VA = "0x18074CFA0")]
		public void FadeOut(UnityAction callback)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x74CF70", Offset = "0x74C370", VA = "0x18074CF70")]
		public void FadeOut()
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x74CE60", Offset = "0x74C260", VA = "0x18074CE60")]
		public void FadeInAndOut(UnityAction callbackIn, UnityAction callbackOut)
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x74D070", Offset = "0x74C470", VA = "0x18074D070")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA54D0", Offset = "0xA48D0")]
		private IEnumerator FadingIn(UnityAction callback)
		{
			return null;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x74D100", Offset = "0x74C500", VA = "0x18074D100")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA5520", Offset = "0xA4920")]
		private IEnumerator FadingOut(UnityAction callback)
		{
			return null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x74CFD0", Offset = "0x74C3D0", VA = "0x18074CFD0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA5570", Offset = "0xA4970")]
		private IEnumerator FadingInAndOut(UnityAction callbackIn, UnityAction callbackOut)
		{
			return null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x74D470", Offset = "0x74C870", VA = "0x18074D470")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA55C0", Offset = "0xA49C0")]
		private IEnumerator ShowAndClearMessage(TMP_Text textComponent, string message, float duration)
		{
			return null;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x74CDC0", Offset = "0x74C1C0", VA = "0x18074CDC0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA5610", Offset = "0xA4A10")]
		private IEnumerator DelayedClearMessage(TMP_Text textComponent, float delay)
		{
			return null;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x74CD20", Offset = "0x74C120", VA = "0x18074CD20")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA5660", Offset = "0xA4A60")]
		private IEnumerator DelayedClearInnerMessage(TMP_Text textComponent, float delay)
		{
			return null;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x74D510", Offset = "0x74C910", VA = "0x18074D510")]
		public UIManager()
		{
		}

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x0")]
		private static UIManager instance;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5070", Offset = "0xA4470")]
		[SerializeField]
		private float fadeInDuration;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float fadeOutDuration;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float fadeInAndOutDelay;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Color originalColor;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Color fadedColor;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA50C0", Offset = "0xA44C0")]
		[SerializeField]
		private TMP_Text messageText;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TMP_Text innerMessageText;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TMP_Text tooltipText;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image transitionImage;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject dialogueClickPrompt;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x70")]
		private Coroutine clearMessageCoroutine;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x78")]
		private Coroutine clearInnerMessageCoroutine;

		// Token: 0x0200001C RID: 28
		[Token(Token = "0x2000030")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <FadingIn>d__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <FadingIn>d__31(int <>1__state)
			{
			}

			// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06000092 RID: 146 RVA: 0x00002130 File Offset: 0x00000330
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x7498C0", Offset = "0x748CC0", VA = "0x1807498C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000093 RID: 147 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700001B")]
			private object Current
			{
				[Token(Token = "0x6000120")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x749A50", Offset = "0x748E50", VA = "0x180749A50", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000095 RID: 149 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700001C")]
			private object Current
			{
				[Token(Token = "0x6000122")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04000075 RID: 117
			[Token(Token = "0x400014C")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000076 RID: 118
			[Token(Token = "0x400014D")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04000077 RID: 119
			[Token(Token = "0x400014E")]
			[FieldOffset(Offset = "0x20")]
			public UIManager <>4__this;

			// Token: 0x04000078 RID: 120
			[Token(Token = "0x400014F")]
			[FieldOffset(Offset = "0x28")]
			public UnityAction callback;

			// Token: 0x04000079 RID: 121
			[Token(Token = "0x4000150")]
			[FieldOffset(Offset = "0x30")]
			private float <timer>5__2;
		}

		// Token: 0x0200001D RID: 29
		[Token(Token = "0x2000031")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <FadingOut>d__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <FadingOut>d__32(int <>1__state)
			{
			}

			// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06000098 RID: 152 RVA: 0x00002148 File Offset: 0x00000348
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x749A90", Offset = "0x748E90", VA = "0x180749A90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000099 RID: 153 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700001D")]
			private object Current
			{
				[Token(Token = "0x6000126")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x749C20", Offset = "0x749020", VA = "0x180749C20", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x0600009B RID: 155 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700001E")]
			private object Current
			{
				[Token(Token = "0x6000128")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400007A RID: 122
			[Token(Token = "0x4000151")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400007B RID: 123
			[Token(Token = "0x4000152")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400007C RID: 124
			[Token(Token = "0x4000153")]
			[FieldOffset(Offset = "0x20")]
			public UIManager <>4__this;

			// Token: 0x0400007D RID: 125
			[Token(Token = "0x4000154")]
			[FieldOffset(Offset = "0x28")]
			public UnityAction callback;

			// Token: 0x0400007E RID: 126
			[Token(Token = "0x4000155")]
			[FieldOffset(Offset = "0x30")]
			private float <timer>5__2;
		}

		// Token: 0x0200001E RID: 30
		[Token(Token = "0x2000032")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <FadingInAndOut>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <FadingInAndOut>d__33(int <>1__state)
			{
			}

			// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600009E RID: 158 RVA: 0x00002160 File Offset: 0x00000360
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x749590", Offset = "0x748990", VA = "0x180749590", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600009F RID: 159 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700001F")]
			private object Current
			{
				[Token(Token = "0x600012C")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x749880", Offset = "0x748C80", VA = "0x180749880", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000020")]
			private object Current
			{
				[Token(Token = "0x600012E")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400007F RID: 127
			[Token(Token = "0x4000156")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000080 RID: 128
			[Token(Token = "0x4000157")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04000081 RID: 129
			[Token(Token = "0x4000158")]
			[FieldOffset(Offset = "0x20")]
			public UIManager <>4__this;

			// Token: 0x04000082 RID: 130
			[Token(Token = "0x4000159")]
			[FieldOffset(Offset = "0x28")]
			public UnityAction callbackIn;

			// Token: 0x04000083 RID: 131
			[Token(Token = "0x400015A")]
			[FieldOffset(Offset = "0x30")]
			public UnityAction callbackOut;

			// Token: 0x04000084 RID: 132
			[Token(Token = "0x400015B")]
			[FieldOffset(Offset = "0x38")]
			private float <timer>5__2;
		}

		// Token: 0x0200001F RID: 31
		[Token(Token = "0x2000033")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <ShowAndClearMessage>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <ShowAndClearMessage>d__34(int <>1__state)
			{
			}

			// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060000A4 RID: 164 RVA: 0x00002178 File Offset: 0x00000378
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x74BB50", Offset = "0x74AF50", VA = "0x18074BB50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000021")]
			private object Current
			{
				[Token(Token = "0x6000132")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x74BC40", Offset = "0x74B040", VA = "0x18074BC40", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060000A7 RID: 167 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000022")]
			private object Current
			{
				[Token(Token = "0x6000134")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04000085 RID: 133
			[Token(Token = "0x400015C")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000086 RID: 134
			[Token(Token = "0x400015D")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04000087 RID: 135
			[Token(Token = "0x400015E")]
			[FieldOffset(Offset = "0x20")]
			public TMP_Text textComponent;

			// Token: 0x04000088 RID: 136
			[Token(Token = "0x400015F")]
			[FieldOffset(Offset = "0x28")]
			public string message;

			// Token: 0x04000089 RID: 137
			[Token(Token = "0x4000160")]
			[FieldOffset(Offset = "0x30")]
			public float duration;
		}

		// Token: 0x02000020 RID: 32
		[Token(Token = "0x2000034")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <DelayedClearMessage>d__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <DelayedClearMessage>d__35(int <>1__state)
			{
			}

			// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060000AA RID: 170 RVA: 0x00002190 File Offset: 0x00000390
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x7491C0", Offset = "0x7485C0", VA = "0x1807491C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060000AB RID: 171 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000023")]
			private object Current
			{
				[Token(Token = "0x6000138")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x7492C0", Offset = "0x7486C0", VA = "0x1807492C0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000AD RID: 173 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000024")]
			private object Current
			{
				[Token(Token = "0x600013A")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400008A RID: 138
			[Token(Token = "0x4000161")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400008B RID: 139
			[Token(Token = "0x4000162")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400008C RID: 140
			[Token(Token = "0x4000163")]
			[FieldOffset(Offset = "0x20")]
			public float delay;

			// Token: 0x0400008D RID: 141
			[Token(Token = "0x4000164")]
			[FieldOffset(Offset = "0x28")]
			public TMP_Text textComponent;

			// Token: 0x0400008E RID: 142
			[Token(Token = "0x4000165")]
			[FieldOffset(Offset = "0x30")]
			public UIManager <>4__this;
		}

		// Token: 0x02000021 RID: 33
		[Token(Token = "0x2000035")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <DelayedClearInnerMessage>d__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <DelayedClearInnerMessage>d__36(int <>1__state)
			{
			}

			// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060000B0 RID: 176 RVA: 0x000021A8 File Offset: 0x000003A8
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x749080", Offset = "0x748480", VA = "0x180749080", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000B1 RID: 177 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000025")]
			private object Current
			{
				[Token(Token = "0x600013E")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x749180", Offset = "0x748580", VA = "0x180749180", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000B3 RID: 179 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000026")]
			private object Current
			{
				[Token(Token = "0x6000140")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400008F RID: 143
			[Token(Token = "0x4000166")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000090 RID: 144
			[Token(Token = "0x4000167")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04000091 RID: 145
			[Token(Token = "0x4000168")]
			[FieldOffset(Offset = "0x20")]
			public float delay;

			// Token: 0x04000092 RID: 146
			[Token(Token = "0x4000169")]
			[FieldOffset(Offset = "0x28")]
			public TMP_Text textComponent;

			// Token: 0x04000093 RID: 147
			[Token(Token = "0x400016A")]
			[FieldOffset(Offset = "0x30")]
			public UIManager <>4__this;
		}
	}
}
