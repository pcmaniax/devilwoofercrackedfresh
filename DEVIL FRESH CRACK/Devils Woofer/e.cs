using System;
using System.Collections.Specialized;
using System.Net;

// Token: 0x02000012 RID: 18
internal class e
{
	// Token: 0x060000D4 RID: 212 RVA: 0x00015BFC File Offset: 0x00013DFC
	public static byte[] a(string a, NameValueCollection b)
	{
		byte[] result;
		using (WebClient webClient = new WebClient())
		{
			result = webClient.UploadValues(a, b);
		}
		return result;
	}
}
