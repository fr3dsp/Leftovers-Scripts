using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Player
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000012")]
	public class PlayerController : MonoBehaviour
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public static PlayerController Instance
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x7474D0", Offset = "0x7468D0", VA = "0x1807474D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x747530", Offset = "0x746930", VA = "0x180747530")]
			set
			{
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x745700", Offset = "0x744B00", VA = "0x180745700")]
		private void Awake()
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x745F80", Offset = "0x745380", VA = "0x180745F80")]
		private void Start()
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x745950", Offset = "0x744D50", VA = "0x180745950")]
		private void OnDestroy()
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x7461F0", Offset = "0x7455F0", VA = "0x1807461F0")]
		private void Update()
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x745C50", Offset = "0x745050", VA = "0x180745C50")]
		public void ResetRotationValues()
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x745930", Offset = "0x744D30", VA = "0x180745930")]
		private float GetLimitedRotationX(float rotation)
		{
			return 0f;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x745770", Offset = "0x744B70", VA = "0x180745770")]
		private void CheckPrompt()
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x745DC0", Offset = "0x7451C0", VA = "0x180745DC0")]
		public void ShowFood()
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x745A80", Offset = "0x744E80", VA = "0x180745A80")]
		public void PutAwayFood()
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x745B00", Offset = "0x744F00", VA = "0x180745B00")]
		public void RemoveFood()
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x745DB0", Offset = "0x7451B0", VA = "0x180745DB0")]
		public void SetLookAt(Transform lookAtTransform)
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x745EB0", Offset = "0x7452B0", VA = "0x180745EB0")]
		public void StartZoomIn(float duration)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x745EE0", Offset = "0x7452E0", VA = "0x180745EE0")]
		public void StartZoomOut(float duration)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x24B0D0", Offset = "0x24A4D0", VA = "0x18024B0D0")]
		public void StartHandlingKeyboardInput()
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x7460B0", Offset = "0x7454B0", VA = "0x1807460B0")]
		public void StopHandlingKeyboardInput()
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x745DE0", Offset = "0x7451E0", VA = "0x180745DE0")]
		public void StartHandlingMouseInput()
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x7460C0", Offset = "0x7454C0", VA = "0x1807460C0")]
		public void StopHandlingMouseInput()
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x745DF0", Offset = "0x7451F0", VA = "0x180745DF0")]
		public void StartListeningToPrompt(UnityAction nodListener, UnityAction shakeListener, UnityAction showFoodListener)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x7460D0", Offset = "0x7454D0", VA = "0x1807460D0")]
		public void StopListeningToPrompt(UnityAction nodListener, UnityAction shakeListener, UnityAction showFoodListener)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x745890", Offset = "0x744C90", VA = "0x180745890")]
		public void CopyCameraTransform(Transform copier)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x7459B0", Offset = "0x744DB0", VA = "0x1807459B0")]
		public void PauseGame()
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x745D50", Offset = "0x745150", VA = "0x180745D50")]
		public void ResumeGame()
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x745760", Offset = "0x744B60", VA = "0x180745760")]
		public void CanOpenEscapeMenu()
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x745A10", Offset = "0x744E10", VA = "0x180745A10")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA57F0", Offset = "0xA4BF0")]
		private IEnumerator PlayFootsteps()
		{
			return null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x7472F0", Offset = "0x7466F0", VA = "0x1807472F0")]
		public PlayerController()
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x7461E0", Offset = "0x7455E0", VA = "0x1807461E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private void <Update>b__64_1()
		{
		}

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int HashBoolShowFood;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x8")]
		private static PlayerController instance;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x10")]
		public static float MouseSensitivity;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x400004D")]
		private const float PlatformSensitivity = 1f;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5070", Offset = "0xA4470")]
		[SerializeField]
		private bool handleKeyboardInput;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool handleMouseInput;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA56B0", Offset = "0xA4AB0")]
		[SerializeField]
		private float moveSpeed;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float gravity;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float groundCheckRadius;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask groundCheckLayerMask;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float footstepsInterval;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioSource footstepsAudioSource;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AudioClip footstepsAudioClip;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5700", Offset = "0xA4B00")]
		[SerializeField]
		private float cameraSpeed;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Vector2 cameraRotationXLimits;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA5750", Offset = "0xA4B50")]
		[SerializeField]
		private float lookAtSpeed;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float neighbourLookAtOffsetHeight;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float neighbourLookAtOffsetDistance;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float zoomOriginal;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float zoomIn;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA57A0", Offset = "0xA4BA0")]
		[SerializeField]
		private float promptLookSpeed;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Vector2 promptRotationXLimits;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Vector2 promptRotationYLimits;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Vector2 noddingThreshold;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector2 shakingThreshold;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xA50C0", Offset = "0xA44C0")]
		[SerializeField]
		private CharacterController characterController;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Camera controlledCamera;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Transform cameraContainer;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Animator animator;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Transform neighbourLookAt;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject promptIndicator;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject pauseMenu;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Transform[] shortcutTeleportations;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0xC8")]
		private bool listenPrompt;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0xD0")]
		private Transform lookAt;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0xD8")]
		private float promptRotationX;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0xDC")]
		private float promptRotationY;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0xE0")]
		private int checkShake;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0xE4")]
		private int checkNod;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0xE8")]
		private int numberOfShakes;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0xEC")]
		private int numberOfNods;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0xF0")]
		private UnityEvent OnNod;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0xF8")]
		private UnityEvent OnShake;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x100")]
		private UnityEvent OnShowFood;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x108")]
		private Vector3 fallingVelocity;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x114")]
		private float rotationX;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x118")]
		private float rotationY;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x11C")]
		private PlayerController.ZoomPhase zoomPhase;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x120")]
		private float zoomDuration;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x124")]
		private float zoomTimer;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x128")]
		private float zoomStartAmount;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x12C")]
		private float zoomAmount;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x130")]
		private bool paused;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x131")]
		private bool pausedMouse;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x132")]
		private bool pausedKeyboard;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x133")]
		private bool canOpenEscape;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x138")]
		private Coroutine footstepsCoroutine;

		// Token: 0x02000023 RID: 35
		[Token(Token = "0x2000036")]
		private enum ZoomPhase
		{
			// Token: 0x040000CE RID: 206
			[Token(Token = "0x400016C")]
			None,
			// Token: 0x040000CF RID: 207
			[Token(Token = "0x400016D")]
			In,
			// Token: 0x040000D0 RID: 208
			[Token(Token = "0x400016E")]
			Out
		}

		// Token: 0x02000024 RID: 36
		[Token(Token = "0x2000037")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <>c__DisplayClass64_0
		{
			// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x1E0CC0", Offset = "0x1E00C0", VA = "0x1801E0CC0")]
			public <>c__DisplayClass64_0()
			{
			}

			// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x74C840", Offset = "0x74BC40", VA = "0x18074C840")]
			internal void <Update>b__0()
			{
			}

			// Token: 0x040000D1 RID: 209
			[Token(Token = "0x400016F")]
			[FieldOffset(Offset = "0x10")]
			public int captured;

			// Token: 0x040000D2 RID: 210
			[Token(Token = "0x4000170")]
			[FieldOffset(Offset = "0x18")]
			public PlayerController <>4__this;
		}

		// Token: 0x02000025 RID: 37
		[Token(Token = "0x2000038")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C9F0", Offset = "0x8BDF0")]
		private sealed class <PlayFootsteps>d__84 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x376000", Offset = "0x375400", VA = "0x180376000")]
			[DebuggerHidden]
			public <PlayFootsteps>d__84(int <>1__state)
			{
			}

			// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x18BEE0", Offset = "0x18B2E0", VA = "0x18018BEE0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060000D5 RID: 213 RVA: 0x000021D8 File Offset: 0x000003D8
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x74A440", Offset = "0x749840", VA = "0x18074A440", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000D6 RID: 214 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000027")]
			private object Current
			{
				[Token(Token = "0x6000146")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x74A500", Offset = "0x749900", VA = "0x18074A500", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000D8 RID: 216 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000028")]
			private object Current
			{
				[Token(Token = "0x6000148")]
				[Address(RVA = "0x1BC550", Offset = "0x1BB950", VA = "0x1801BC550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040000D3 RID: 211
			[Token(Token = "0x4000171")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040000D4 RID: 212
			[Token(Token = "0x4000172")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040000D5 RID: 213
			[Token(Token = "0x4000173")]
			[FieldOffset(Offset = "0x20")]
			public PlayerController <>4__this;
		}
	}
}
