using System;
using System.Windows.Forms;
using Lean.Forms;

// Token: 0x0200001E RID: 30
internal static class f
{
	// Token: 0x06000156 RID: 342 RVA: 0x00017CA8 File Offset: 0x00015EA8
	[STAThread]
	private static void Main()
	{
		DateTime t = new DateTime(2022, 7, 12, 18, 46, 42);
		if (!(DateTime.Now > t))
		{
		}
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new Login());
	}
}
