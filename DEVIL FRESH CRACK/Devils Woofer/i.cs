using System;
using System.IO;
using System.Reflection;

// Token: 0x02000021 RID: 33
internal sealed class i
{
	// Token: 0x06000161 RID: 353 RVA: 0x00018240 File Offset: 0x00016440
	public static string a(string a, int b)
	{
		DateTime t = default(DateTime).AddYears(2021).AddMonths(6).AddDays(11.4390509259259);
		if (!(t < DateTime.Now))
		{
		}
		return i.b.b.c(a, b);
	}

	// Token: 0x06000162 RID: 354 RVA: 0x0001829C File Offset: 0x0001649C
	public static string b()
	{
		char[] array = "ÏßÔÐ".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] ^= '\u009a';
		}
		return new string(array);
	}

	// Token: 0x02000022 RID: 34
	// (Invoke) Token: 0x06000165 RID: 357
	private delegate string a();

	// Token: 0x02000023 RID: 35
	private sealed class b
	{
		// Token: 0x06000169 RID: 361 RVA: 0x000182F4 File Offset: 0x000164F4
		private b()
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(i.b.a());
			if (manifestResourceStream != null)
			{
				this.c = new byte[16];
				manifestResourceStream.Read(this.c, 0, this.c.Length);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00018360 File Offset: 0x00016560
		public string c(string a, int b)
		{
			int num = a.Length;
			char[] array = a.ToCharArray();
			while (--num >= 0)
			{
				array[num] = (char)((int)array[num] ^ ((int)this.c[b & 15] | b));
			}
			return new string(array);
		}

		// Token: 0x040000CE RID: 206
		private static readonly i.a a = new i.a(i.b);

		// Token: 0x040000CF RID: 207
		public static readonly i.b b = new i.b();

		// Token: 0x040000D0 RID: 208
		private byte[] c;
	}
}
