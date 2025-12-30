using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Leftovers.Utilities
{
	public class AudioUtility : MonoBehaviour
	{
		public void StartFadeIn(float duration)
		{
            if (audioSource == null)
                return;

            audioSource.volume = 0f;
            audioSource.Play();
            StartCoroutine(FadeIn(duration));
        }

		private IEnumerator FadeIn(float duration)
		{
            return new FadeIn_d__3(0)
            {
                __this = this,
                duration = duration
            };
        }

		public void StartFadeOut(float duration)
		{
            if (audioSource == null)
                return;

            audioSource.volume = volume;
            StartCoroutine(FadeOut(duration));
        }

		private IEnumerator FadeOut(float duration)
		{
            return new FadeOut_d__5(0)
            {
                __this = this,
                duration = duration
            };
        }

		public void PlayIfNotPlaying()
		{
		}

		public AudioUtility()
		{
            public float volume = 1.0f;
            public AudioSource audioSource;

            public Leftovers_Utilities_AudioUtility()
            {
                volume = 1.0f;
            }
		}

		[SerializeField]
		private AudioSource audioSource;

		[SerializeField]
		private float volume;

		private sealed class <FadeIn>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			public <FadeIn>d__3(int <>1__state)
			{
			}

			private void Dispose()
			{
			}

			private bool MoveNext()
			{
				if (__state == 0)
				{
					_timer = 0f;
					__state = -1;
				}

				if (_timer < duration)
				{
					_timer += Time.deltaTime;
					if (__this.audioSource != null)
					{
						__this.audioSource.volume = Mathf.Lerp(0f, __this.volume, _timer / duration);
					}
					__current = null;
					__state = 1;
					return true;
				}

				if (__this.audioSource != null)
				{
					__this.audioSource.volume = __this.volume;
				}

				return false;
			}

			private object Current
			{
				get
				{
					return null;
				}
			}

			private void Reset()
			{
			}

			private object Current
			{
				get
				{
					return null;
				}
			}

			private int <>1__state;

			private object <>2__current;

			public AudioUtility <>4__this;

			public float duration;

			private float <timer>5__2;
		}

		private sealed class <FadeOut>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			public <FadeOut>d__5(int <>1__state)
			{
			}

			private void Dispose()
			{
			}

			private bool MoveNext()
			{
				if (__state == 0)
				{
					_timer = 0f;
					__state = -1;
				}

				if (_timer < duration)
				{
					_timer += Time.deltaTime;
					if (__this.audioSource != null)
					{
						__this.audioSource.volume = Mathf.Lerp(__this.volume, 0f, _timer / duration);
					}
					__current = null;
					__state = 1;
					return true;
				}

				if (__this.audioSource != null)
				{
					__this.audioSource.volume = 0f;
					__this.audioSource.Stop();
				}

				return false;
			}

			private object Current
			{
				get
				{
					return null;
				}
			}

			private void Reset()
			{
			}

			private object Current
			{
				get
				{
					return null;
				}
			}

			private int <>1__state;

			private object <>2__current;

			public AudioUtility <>4__this;

			public float duration;

			private float <timer>5__2;
		}
	}
}
