using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace Lean.Resources
{
	// Token: 0x02000013 RID: 19
	public class api
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x00015C38 File Offset: 0x00013E38
		public api(string name, string ownerid, string secret, string version)
		{
			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
			{
				api.error(i.a("", 61526));
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00015CD8 File Offset: 0x00013ED8
		public void init()
		{
			this.b = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 62207)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 58176)));
			nameValueCollection[i.a("", 59209)] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection[i.a("", 58150)] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection[i.a("", 62198)] = encryption.encrypt(this.b, this.secret, text);
			nameValueCollection[i.a("", 58770)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 59796)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 58459)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			if (text2 == i.a("", 62706))
			{
				MessageBox.Show(i.a("", 61609), i.a("", 61255), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Application.Exit();
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			if (response_structure.success)
			{
				this.b(response_structure.appinfo);
				this.a = response_structure.sessionid;
				this.c = true;
			}
			else if (response_structure.message == i.a("", 57723))
			{
				this.app_data.downloadLink = response_structure.download;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00015EDC File Offset: 0x000140DC
		public static bool IsDebugRelease
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00015EEC File Offset: 0x000140EC
		public void Checkinit()
		{
			DateTime t = default(DateTime).AddYears(2021).AddMonths(6).AddDays(11.3519907407407);
			if (DateTime.Now > t)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (!this.c)
			{
				if (api.IsDebugRelease)
				{
					api.error(i.a("", 60566));
				}
				else
				{
					api.error(i.a("", 60566));
				}
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00015F80 File Offset: 0x00014180
		public void register(string username, string pass, string key)
		{
			DateTime d = default(DateTime).AddYears(2021).AddMonths(6).AddDays(11.129375);
			if ((DateTime.Now - d).TotalDays <= 0.0)
			{
			}
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 59599)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 63456)));
			nameValueCollection[i.a("", 60796)] = encryption.encrypt(username, this.b, text);
			nameValueCollection[i.a("", 63473)] = encryption.encrypt(pass, this.b, text);
			nameValueCollection[i.a("", 57468)] = encryption.encrypt(key, this.b, text);
			nameValueCollection[i.a("", 63009)] = encryption.encrypt(value, this.b, text);
			nameValueCollection[i.a("", 63441)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 61777)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 59361)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 60381)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			if (response_structure.success)
			{
				this.c(response_structure.info);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00016198 File Offset: 0x00014398
		public void login(string username, string pass)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 60805)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 59396)));
			nameValueCollection[i.a("", 63598)] = encryption.encrypt(username, this.b, text);
			nameValueCollection[i.a("", 63152)] = encryption.encrypt(pass, this.b, text);
			nameValueCollection[i.a("", 58799)] = encryption.encrypt(value, this.b, text);
			nameValueCollection[i.a("", 60105)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 57902)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 59501)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 59192)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			if (response_structure.success)
			{
				this.c(response_structure.info);
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0001633C File Offset: 0x0001453C
		public void upgrade(string username, string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 62365)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 63040)));
			nameValueCollection[i.a("", 63740)] = encryption.encrypt(username, this.b, text);
			nameValueCollection[i.a("", 63244)] = encryption.encrypt(key, this.b, text);
			nameValueCollection[i.a("", 58344)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 59624)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 61080)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 59623)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			response_structure.success = false;
			this.d(response_structure);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000164B0 File Offset: 0x000146B0
		public void license(string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 62492)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 60850)));
			nameValueCollection[i.a("", 59113)] = encryption.encrypt(key, this.b, text);
			nameValueCollection[i.a("", 60982)] = encryption.encrypt(value, this.b, text);
			nameValueCollection[i.a("", 57867)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 59322)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 58191)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 62607)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			if (response_structure.success)
			{
				this.c(response_structure.info);
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00016630 File Offset: 0x00014830
		public void check()
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 63058)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 62175)));
			nameValueCollection[i.a("", 58982)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 60070)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 58594)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 59202)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00016744 File Offset: 0x00014944
		public void setvar(string var, string data)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 61073)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 58167)));
			nameValueCollection[i.a("", 57849)] = encryption.encrypt(var, this.b, text);
			nameValueCollection[i.a("", 63643)] = encryption.encrypt(data, this.b, text);
			nameValueCollection[i.a("", 58766)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 61046)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 61987)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 57476)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0001689C File Offset: 0x00014A9C
		public string getvar(string var)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 59944)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 59665)));
			nameValueCollection[i.a("", 63233)] = encryption.encrypt(var, this.b, text);
			nameValueCollection[i.a("", 61087)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 61892)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 61657)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 61038)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			string result;
			if (response_structure.success)
			{
				result = response_structure.response;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000169EC File Offset: 0x00014BEC
		public void ban()
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 58915)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 61499)));
			nameValueCollection[i.a("", 60035)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 61748)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 57980)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 57997)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00016B00 File Offset: 0x00014D00
		public string var(string varid)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 58726)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 58949)));
			nameValueCollection[i.a("", 57399)] = encryption.encrypt(varid, this.b, text);
			nameValueCollection[i.a("", 63327)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 58603)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 62114)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 61620)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			string result;
			if (response_structure.success)
			{
				result = response_structure.message;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00016C64 File Offset: 0x00014E64
		public List<api.msg> chatget(string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 59813)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 59791)));
			nameValueCollection[i.a("", 61894)] = encryption.encrypt(channelname, this.b, text);
			nameValueCollection[i.a("", 59541)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 58614)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 60476)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 58941)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			List<api.msg> result;
			if (response_structure.success)
			{
				result = response_structure.messages;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00016DB4 File Offset: 0x00014FB4
		public bool chatsend(string msg, string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 59068)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 59758)));
			nameValueCollection[i.a("", 59547)] = encryption.encrypt(msg, this.b, text);
			nameValueCollection[i.a("", 62002)] = encryption.encrypt(channelname, this.b, text);
			nameValueCollection[i.a("", 63312)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 60753)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 63493)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 61209)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			return response_structure.success;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00016F20 File Offset: 0x00015120
		public bool checkblack()
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 63503)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 60244)));
			nameValueCollection[i.a("", 63012)] = encryption.encrypt(value, this.b, text);
			nameValueCollection[i.a("", 57653)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 60636)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 62143)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 62641)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			return response_structure.success;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0001707C File Offset: 0x0001527C
		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 60932)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 60358)));
			nameValueCollection[i.a("", 59466)] = encryption.encrypt(webid, this.b, text);
			nameValueCollection[i.a("", 58697)] = encryption.encrypt(param, this.b, text);
			nameValueCollection[i.a("", 62839)] = encryption.encrypt(body, this.b, text);
			nameValueCollection[i.a("", 58982)] = encryption.encrypt(conttype, this.b, text);
			nameValueCollection[i.a("", 59836)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 58379)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 60202)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 61727)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			string result;
			if (response_structure.success)
			{
				result = response_structure.response;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00017230 File Offset: 0x00015430
		public byte[] download(string fileid)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 62344)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 61383)));
			nameValueCollection[i.a("", 60718)] = encryption.encrypt(fileid, this.b, text);
			nameValueCollection[i.a("", 63628)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 62291)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 59075)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 63295)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			byte[] result;
			if (response_structure.success)
			{
				result = encryption.str_to_byte_arr(response_structure.contents);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00017384 File Offset: 0x00015584
		public void log(string message)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 60406)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 60299)));
			nameValueCollection[i.a("", 57526)] = encryption.encrypt(Environment.UserName, this.b, text);
			nameValueCollection[i.a("", 59480)] = encryption.encrypt(message, this.b, text);
			nameValueCollection[i.a("", 61030)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 58308)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 60328)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 58375)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			api.a(nameValueCollection2);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000174C0 File Offset: 0x000156C0
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace(i.a("", 60508), "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000023D6 File Offset: 0x000005D6
		public static void error(string message)
		{
			MessageBox.Show(message, i.a("", 57934), MessageBoxButtons.OK);
			Environment.Exit(0);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00017540 File Offset: 0x00015740
		private static string a(NameValueCollection a)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues(i.a("", 63674), a);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				HttpStatusCode httpStatusCode = statusCode;
				if (httpStatusCode != (HttpStatusCode)429)
				{
					api.error(i.a("", 62193));
					Environment.Exit(0);
					result = "";
				}
				else
				{
					api.error(i.a("", 60674));
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00017608 File Offset: 0x00015808
		private void b(api.app_data_structure a)
		{
			this.app_data.numUsers = a.numUsers;
			this.app_data.numOnlineUsers = a.numOnlineUsers;
			this.app_data.numKeys = a.numKeys;
			this.app_data.version = a.version;
			this.app_data.customerPanelLink = a.customerPanelLink;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0001766C File Offset: 0x0001586C
		private void c(api.user_data_structure a)
		{
			this.user_data.username = a.username;
			this.user_data.ip = a.ip;
			this.user_data.hwid = a.hwid;
			this.user_data.createdate = a.createdate;
			this.user_data.lastlogin = a.lastlogin;
			this.user_data.subscriptions = a.subscriptions;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000176E0 File Offset: 0x000158E0
		public string expirydaysleft()
		{
			this.Checkinit();
			DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			TimeSpan timeSpan = d - DateTime.Now;
			return Convert.ToString(timeSpan.Days.ToString() + i.a("", 61663) + timeSpan.Hours.ToString() + i.a("", 59311));
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000023F5 File Offset: 0x000005F5
		private void d(api.response_structure a)
		{
			this.response.success = a.success;
			this.response.message = a.message;
		}

		// Token: 0x04000091 RID: 145
		public string name;

		// Token: 0x04000092 RID: 146
		public string ownerid;

		// Token: 0x04000093 RID: 147
		public string secret;

		// Token: 0x04000094 RID: 148
		public string version;

		// Token: 0x04000095 RID: 149
		private string a;

		// Token: 0x04000096 RID: 150
		private string b;

		// Token: 0x04000097 RID: 151
		private bool c;

		// Token: 0x04000098 RID: 152
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x04000099 RID: 153
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x0400009A RID: 154
		public api.response_class response = new api.response_class();

		// Token: 0x0400009B RID: 155
		private json_wrapper d = new json_wrapper(new api.response_structure());

		// Token: 0x02000014 RID: 20
		[DataContract]
		private class response_structure
		{
			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000F0 RID: 240 RVA: 0x00002419 File Offset: 0x00000619
			// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002421 File Offset: 0x00000621
			[DataMember]
			public bool success { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000242A File Offset: 0x0000062A
			// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002432 File Offset: 0x00000632
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000243B File Offset: 0x0000063B
			// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002443 File Offset: 0x00000643
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000244C File Offset: 0x0000064C
			// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002454 File Offset: 0x00000654
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000245D File Offset: 0x0000065D
			// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002465 File Offset: 0x00000665
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000FA RID: 250 RVA: 0x0000246E File Offset: 0x0000066E
			// (set) Token: 0x060000FB RID: 251 RVA: 0x00002476 File Offset: 0x00000676
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000FC RID: 252 RVA: 0x0000247F File Offset: 0x0000067F
			// (set) Token: 0x060000FD RID: 253 RVA: 0x00002487 File Offset: 0x00000687
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000FE RID: 254 RVA: 0x00002490 File Offset: 0x00000690
			// (set) Token: 0x060000FF RID: 255 RVA: 0x00002498 File Offset: 0x00000698
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000100 RID: 256 RVA: 0x000024A1 File Offset: 0x000006A1
			// (set) Token: 0x06000101 RID: 257 RVA: 0x000024A9 File Offset: 0x000006A9
			[DataMember]
			public List<api.msg> messages { get; set; }

			// Token: 0x0400009C RID: 156
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private bool a;

			// Token: 0x0400009D RID: 157
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string b;

			// Token: 0x0400009E RID: 158
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			// Token: 0x0400009F RID: 159
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string d;

			// Token: 0x040000A0 RID: 160
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string e;

			// Token: 0x040000A1 RID: 161
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string f;

			// Token: 0x040000A2 RID: 162
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private api.user_data_structure g;

			// Token: 0x040000A3 RID: 163
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private api.app_data_structure h;

			// Token: 0x040000A4 RID: 164
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private List<api.msg> i;
		}

		// Token: 0x02000015 RID: 21
		public class msg
		{
			// Token: 0x17000026 RID: 38
			// (get) Token: 0x06000103 RID: 259 RVA: 0x000024B2 File Offset: 0x000006B2
			// (set) Token: 0x06000104 RID: 260 RVA: 0x0001775C File Offset: 0x0001595C
			public string message
			{
				[CompilerGenerated]
				get
				{
					return this.a;
				}
				[CompilerGenerated]
				set
				{
					DateTime t = default(DateTime).AddYears(2021).AddMonths(6).AddDays(11.2816087962963);
					if (!(DateTime.Now > t))
					{
					}
					this.a = value;
				}
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x06000105 RID: 261 RVA: 0x000177B4 File Offset: 0x000159B4
			// (set) Token: 0x06000106 RID: 262 RVA: 0x000024BA File Offset: 0x000006BA
			public string author
			{
				[CompilerGenerated]
				get
				{
					DateTime t = default(DateTime).AddYears(2021).AddMonths(6).AddDays(11.5538773148148);
					if (!(t < DateTime.Now))
					{
					}
					return this.b;
				}
				[CompilerGenerated]
				set
				{
					this.b = value;
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x06000107 RID: 263 RVA: 0x000024C3 File Offset: 0x000006C3
			// (set) Token: 0x06000108 RID: 264 RVA: 0x000024CB File Offset: 0x000006CB
			public string timestamp { get; set; }

			// Token: 0x040000A5 RID: 165
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			// Token: 0x040000A6 RID: 166
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string b;

			// Token: 0x040000A7 RID: 167
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string c;
		}

		// Token: 0x02000016 RID: 22
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000029 RID: 41
			// (get) Token: 0x0600010A RID: 266 RVA: 0x000024D4 File Offset: 0x000006D4
			// (set) Token: 0x0600010B RID: 267 RVA: 0x000024DC File Offset: 0x000006DC
			[DataMember]
			public string username { get; set; }

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x0600010C RID: 268 RVA: 0x0001780C File Offset: 0x00015A0C
			// (set) Token: 0x0600010D RID: 269 RVA: 0x000024E5 File Offset: 0x000006E5
			[DataMember]
			public string ip
			{
				[CompilerGenerated]
				get
				{
					DateTime t = new DateTime(2022, 7, 12, 4, 28, 38);
					if (!(t < DateTime.Now))
					{
					}
					return this.b;
				}
				[CompilerGenerated]
				set
				{
					this.b = value;
				}
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x0600010E RID: 270 RVA: 0x000024EE File Offset: 0x000006EE
			// (set) Token: 0x0600010F RID: 271 RVA: 0x000024F6 File Offset: 0x000006F6
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x06000110 RID: 272 RVA: 0x000024FF File Offset: 0x000006FF
			// (set) Token: 0x06000111 RID: 273 RVA: 0x00002507 File Offset: 0x00000707
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x06000112 RID: 274 RVA: 0x00002510 File Offset: 0x00000710
			// (set) Token: 0x06000113 RID: 275 RVA: 0x00002518 File Offset: 0x00000718
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000114 RID: 276 RVA: 0x00002521 File Offset: 0x00000721
			// (set) Token: 0x06000115 RID: 277 RVA: 0x00002529 File Offset: 0x00000729
			[DataMember]
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x040000A8 RID: 168
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string a;

			// Token: 0x040000A9 RID: 169
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			// Token: 0x040000AA RID: 170
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			// Token: 0x040000AB RID: 171
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string d;

			// Token: 0x040000AC RID: 172
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string e;

			// Token: 0x040000AD RID: 173
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private List<api.Data> f;
		}

		// Token: 0x02000017 RID: 23
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x1700002F RID: 47
			// (get) Token: 0x06000117 RID: 279 RVA: 0x00002532 File Offset: 0x00000732
			// (set) Token: 0x06000118 RID: 280 RVA: 0x0000253A File Offset: 0x0000073A
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x06000119 RID: 281 RVA: 0x00002543 File Offset: 0x00000743
			// (set) Token: 0x0600011A RID: 282 RVA: 0x00017848 File Offset: 0x00015A48
			[DataMember]
			public string numOnlineUsers
			{
				[CompilerGenerated]
				get
				{
					return this.b;
				}
				[CompilerGenerated]
				set
				{
					DateTime d = new DateTime(2022, 7, 11, 22, 59, 18);
					if ((d - DateTime.Now).TotalDays < 0.0)
					{
						throw new Exception();
					}
					this.b = value;
				}
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x0600011B RID: 283 RVA: 0x00017898 File Offset: 0x00015A98
			// (set) Token: 0x0600011C RID: 284 RVA: 0x0000254B File Offset: 0x0000074B
			[DataMember]
			public string numKeys
			{
				[CompilerGenerated]
				get
				{
					DateTime t = new DateTime(2022, 7, 12);
					if (t < DateTime.Now)
					{
						throw new ArgumentOutOfRangeException();
					}
					return this.c;
				}
				[CompilerGenerated]
				set
				{
					this.c = value;
				}
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x0600011D RID: 285 RVA: 0x00002554 File Offset: 0x00000754
			// (set) Token: 0x0600011E RID: 286 RVA: 0x0000255C File Offset: 0x0000075C
			[DataMember]
			public string version { get; set; }

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x0600011F RID: 287 RVA: 0x00002565 File Offset: 0x00000765
			// (set) Token: 0x06000120 RID: 288 RVA: 0x0000256D File Offset: 0x0000076D
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x06000121 RID: 289 RVA: 0x00002576 File Offset: 0x00000776
			// (set) Token: 0x06000122 RID: 290 RVA: 0x0000257E File Offset: 0x0000077E
			[DataMember]
			public string downloadLink { get; set; }

			// Token: 0x040000AE RID: 174
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			// Token: 0x040000AF RID: 175
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string b;

			// Token: 0x040000B0 RID: 176
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			// Token: 0x040000B1 RID: 177
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string d;

			// Token: 0x040000B2 RID: 178
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string e;

			// Token: 0x040000B3 RID: 179
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string f;
		}

		// Token: 0x02000018 RID: 24
		public class app_data_class
		{
			// Token: 0x17000035 RID: 53
			// (get) Token: 0x06000124 RID: 292 RVA: 0x00002587 File Offset: 0x00000787
			// (set) Token: 0x06000125 RID: 293 RVA: 0x0000258F File Offset: 0x0000078F
			public string numUsers { get; set; }

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x06000126 RID: 294 RVA: 0x00002598 File Offset: 0x00000798
			// (set) Token: 0x06000127 RID: 295 RVA: 0x000025A0 File Offset: 0x000007A0
			public string numOnlineUsers { get; set; }

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x06000128 RID: 296 RVA: 0x000025A9 File Offset: 0x000007A9
			// (set) Token: 0x06000129 RID: 297 RVA: 0x000025B1 File Offset: 0x000007B1
			public string numKeys { get; set; }

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x0600012A RID: 298 RVA: 0x000025BA File Offset: 0x000007BA
			// (set) Token: 0x0600012B RID: 299 RVA: 0x000025C2 File Offset: 0x000007C2
			public string version { get; set; }

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x0600012C RID: 300 RVA: 0x000025CB File Offset: 0x000007CB
			// (set) Token: 0x0600012D RID: 301 RVA: 0x000025D3 File Offset: 0x000007D3
			public string customerPanelLink { get; set; }

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x0600012E RID: 302 RVA: 0x000025DC File Offset: 0x000007DC
			// (set) Token: 0x0600012F RID: 303 RVA: 0x000025E4 File Offset: 0x000007E4
			public string downloadLink { get; set; }

			// Token: 0x040000B4 RID: 180
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string a;

			// Token: 0x040000B5 RID: 181
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			// Token: 0x040000B6 RID: 182
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string c;

			// Token: 0x040000B7 RID: 183
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string d;

			// Token: 0x040000B8 RID: 184
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string e;

			// Token: 0x040000B9 RID: 185
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string f;
		}

		// Token: 0x02000019 RID: 25
		public class user_data_class
		{
			// Token: 0x1700003B RID: 59
			// (get) Token: 0x06000131 RID: 305 RVA: 0x000025ED File Offset: 0x000007ED
			// (set) Token: 0x06000132 RID: 306 RVA: 0x000025F5 File Offset: 0x000007F5
			public string username { get; set; }

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x06000133 RID: 307 RVA: 0x000025FE File Offset: 0x000007FE
			// (set) Token: 0x06000134 RID: 308 RVA: 0x00002606 File Offset: 0x00000806
			public string ip { get; set; }

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x06000135 RID: 309 RVA: 0x0000260F File Offset: 0x0000080F
			// (set) Token: 0x06000136 RID: 310 RVA: 0x00002617 File Offset: 0x00000817
			public string hwid { get; set; }

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x06000137 RID: 311 RVA: 0x00002620 File Offset: 0x00000820
			// (set) Token: 0x06000138 RID: 312 RVA: 0x00002628 File Offset: 0x00000828
			public string createdate { get; set; }

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x06000139 RID: 313 RVA: 0x00002631 File Offset: 0x00000831
			// (set) Token: 0x0600013A RID: 314 RVA: 0x00002639 File Offset: 0x00000839
			public string lastlogin { get; set; }

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x0600013B RID: 315 RVA: 0x00002642 File Offset: 0x00000842
			// (set) Token: 0x0600013C RID: 316 RVA: 0x0000264A File Offset: 0x0000084A
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x040000BA RID: 186
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			// Token: 0x040000BB RID: 187
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			// Token: 0x040000BC RID: 188
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string c;

			// Token: 0x040000BD RID: 189
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string d;

			// Token: 0x040000BE RID: 190
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string e;

			// Token: 0x040000BF RID: 191
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private List<api.Data> f;
		}

		// Token: 0x0200001A RID: 26
		public class Data
		{
			// Token: 0x17000041 RID: 65
			// (get) Token: 0x0600013E RID: 318 RVA: 0x00002653 File Offset: 0x00000853
			// (set) Token: 0x0600013F RID: 319 RVA: 0x0000265B File Offset: 0x0000085B
			public string subscription { get; set; }

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x06000140 RID: 320 RVA: 0x00002664 File Offset: 0x00000864
			// (set) Token: 0x06000141 RID: 321 RVA: 0x0000266C File Offset: 0x0000086C
			public string expiry { get; set; }

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x06000142 RID: 322 RVA: 0x00002675 File Offset: 0x00000875
			// (set) Token: 0x06000143 RID: 323 RVA: 0x0000267D File Offset: 0x0000087D
			public string timeleft { get; set; }

			// Token: 0x040000C0 RID: 192
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string a;

			// Token: 0x040000C1 RID: 193
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string b;

			// Token: 0x040000C2 RID: 194
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string c;
		}

		// Token: 0x0200001B RID: 27
		public class response_class
		{
			// Token: 0x17000044 RID: 68
			// (get) Token: 0x06000145 RID: 325 RVA: 0x00002686 File Offset: 0x00000886
			// (set) Token: 0x06000146 RID: 326 RVA: 0x0000268E File Offset: 0x0000088E
			public bool success { get; set; }

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x06000147 RID: 327 RVA: 0x00002697 File Offset: 0x00000897
			// (set) Token: 0x06000148 RID: 328 RVA: 0x0000269F File Offset: 0x0000089F
			public string message { get; set; }

			// Token: 0x040000C3 RID: 195
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private bool a;

			// Token: 0x040000C4 RID: 196
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;
		}
	}
}
