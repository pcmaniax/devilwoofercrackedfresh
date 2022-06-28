using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace LeanDevelopment.Properties
{
	// Token: 0x02000006 RID: 6
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002D6C File Offset: 0x00000F6C
		public static Settings Default
		{
			get
			{
				return Settings.a;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002D80 File Offset: 0x00000F80
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002DFC File Offset: 0x00000FFC
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string username
		{
			get
			{
				DateTime d = default(DateTime).AddYears(2021).AddMonths(6).AddDays(11.5646990740741);
				if ((d - DateTime.Now).TotalDays < 0.0)
				{
					throw new Exception();
				}
				return (string)this[i.a("", 62628)];
			}
			set
			{
				DateTime d = new DateTime(2022, 7, 12, 10, 43, 9);
				if ((d - DateTime.Now).TotalDays >= 0.0)
				{
				}
				this[i.a("", 62127)] = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002E54 File Offset: 0x00001054
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002156 File Offset: 0x00000356
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string password
		{
			get
			{
				return (string)this[i.a("", 61515)];
			}
			set
			{
				this[i.a("", 62713)] = value;
			}
		}

		// Token: 0x0400000B RID: 11
		private static Settings a;
	}
}
