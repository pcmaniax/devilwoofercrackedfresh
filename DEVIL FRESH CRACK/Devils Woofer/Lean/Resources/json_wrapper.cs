﻿using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Lean.Resources
{
	// Token: 0x0200001D RID: 29
	public class json_wrapper
	{
		// Token: 0x06000152 RID: 338 RVA: 0x000026C4 File Offset: 0x000008C4
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00017BFC File Offset: 0x00015DFC
		public json_wrapper(object obj_to_work_with)
		{
			this.b = obj_to_work_with;
			Type type = this.b.GetType();
			this.a = new DataContractJsonSerializer(type);
			if (!json_wrapper.is_serializable(type))
			{
				throw new Exception(string.Format(i.a("", 58967), this.b));
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00017C5C File Offset: 0x00015E5C
		public object string_to_object(string json)
		{
			byte[] bytes = Encoding.Default.GetBytes(json);
			object result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = this.a.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000026E2 File Offset: 0x000008E2
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x040000C5 RID: 197
		private DataContractJsonSerializer a;

		// Token: 0x040000C6 RID: 198
		private object b;
	}
}
