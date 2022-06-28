using System;
using System.Linq;
using Microsoft.Win32;

// Token: 0x02000007 RID: 7
internal class d
{
	// Token: 0x0600002E RID: 46 RVA: 0x00002EDC File Offset: 0x000010DC
	public static string a(int a)
	{
		return new string(Enumerable.Repeat<string>(i.a("", 63492), a).Select(new Func<string, char>(global::d.<>c.<>9.a)).ToArray<char>());
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002F30 File Offset: 0x00001130
	public void b()
	{
		this.a = global::d.a(20);
		for (int i = 0; i < this.c.Length; i++)
		{
			this.c(i);
		}
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002F68 File Offset: 0x00001168
	private void c(int a)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(this.c[a], true);
		if (registryKey != null)
		{
			int num = 0;
			while (num < this.d.GetLength(1) && !(this.d[a, num] == i.a("", 57450)))
			{
				registryKey.SetValue(this.d[a, num], this.a);
				this.a = global::d.a(20);
				num++;
			}
			registryKey.Close();
		}
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002FF8 File Offset: 0x000011F8
	public string[] d()
	{
		return this.c;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00003010 File Offset: 0x00001210
	public string[,] e()
	{
		DateTime t = new DateTime(2022, 7, 12, 9, 11, 30);
		if (DateTime.Now > t)
		{
			throw new Exception();
		}
		return this.d;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00003054 File Offset: 0x00001254
	public d()
	{
		string[,] array = new string[7, 7];
		array[0, 0] = i.a("", 63710);
		array[0, 1] = i.a("", 59018);
		array[0, 2] = i.a("", 59619);
		array[0, 3] = i.a("", 62124);
		array[0, 4] = i.a("", 61648);
		array[0, 5] = i.a("", 61963);
		array[0, 6] = i.a("", 57872);
		array[1, 0] = i.a("", 59934);
		array[1, 1] = i.a("", 59018);
		array[1, 2] = i.a("", 58356);
		array[1, 3] = i.a("", 61184);
		array[1, 4] = i.a("", 61184);
		array[1, 5] = i.a("", 61184);
		array[1, 6] = i.a("", 61184);
		array[2, 0] = i.a("", 62611);
		array[2, 1] = i.a("", 59201);
		array[2, 2] = i.a("", 58731);
		array[2, 3] = i.a("", 62173);
		array[2, 4] = i.a("", 62124);
		array[2, 5] = i.a("", 61634);
		array[2, 6] = i.a("", 61184);
		array[3, 0] = i.a("", 62173);
		array[3, 1] = i.a("", 62015);
		array[3, 2] = i.a("", 63556);
		array[3, 3] = i.a("", 61184);
		array[3, 4] = i.a("", 61184);
		array[3, 5] = i.a("", 61184);
		array[3, 6] = i.a("", 61184);
		array[4, 0] = i.a("", 62231);
		array[4, 1] = i.a("", 61184);
		array[4, 2] = i.a("", 61184);
		array[4, 3] = i.a("", 61184);
		array[4, 4] = i.a("", 61184);
		array[4, 5] = i.a("", 61184);
		array[4, 6] = i.a("", 61184);
		array[5, 0] = i.a("", 58202);
		array[5, 1] = i.a("", 57353);
		array[5, 2] = i.a("", 61184);
		array[5, 3] = i.a("", 61184);
		array[5, 4] = i.a("", 61184);
		array[5, 5] = i.a("", 61184);
		array[5, 6] = i.a("", 61184);
		array[6, 0] = i.a("", 59697);
		array[6, 1] = i.a("", 58202);
		array[6, 2] = i.a("", 62081);
		array[6, 3] = i.a("", 61184);
		array[6, 4] = i.a("", 61184);
		array[6, 5] = i.a("", 61184);
		array[6, 6] = i.a("", 61184);
		this.d = array;
		base..ctor();
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00003568 File Offset: 0x00001768
	// Note: this type is marked as 'beforefieldinit'.
	static d()
	{
		DateTime d = new DateTime(2022, 7, 12, 18, 7, 10);
		if ((d - DateTime.Now).TotalDays >= 0.0)
		{
		}
		global::d.b = new Random();
	}

	// Token: 0x0400000C RID: 12
	private string a;

	// Token: 0x0400000D RID: 13
	private static Random b;

	// Token: 0x0400000E RID: 14
	private string[] c = new string[]
	{
		i.a("", 61739),
		i.a("", 61839),
		i.a("", 62812),
		i.a("", 62760),
		i.a("", 57462),
		i.a("", 60516),
		i.a("", 63416)
	};

	// Token: 0x0400000F RID: 15
	private string[,] d;
}
