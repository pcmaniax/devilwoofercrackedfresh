﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Lean.Resources
{
	// Token: 0x0200001C RID: 28
	public static class encryption
	{
		// Token: 0x0600014A RID: 330 RVA: 0x000178D4 File Offset: 0x00015AD4
		public static string byte_arr_to_str(byte[] ba)
		{
			StringBuilder stringBuilder = new StringBuilder(ba.Length * 2);
			foreach (byte b in ba)
			{
				stringBuilder.AppendFormat(i.a("", 59140), b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00017928 File Offset: 0x00015B28
		public static byte[] str_to_byte_arr(string hex)
		{
			byte[] result;
			try
			{
				int length = hex.Length;
				byte[] array = new byte[length / 2];
				for (int i = 0; i < length; i += 2)
				{
					array[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
				}
				result = array;
			}
			catch
			{
				Thread.Sleep(3500);
				Environment.Exit(0);
				result = null;
			}
			return result;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00017998 File Offset: 0x00015B98
		public static string encrypt_string(string plain_text, byte[] key, byte[] iv)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Key = key;
			aes.IV = iv;
			string result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (ICryptoTransform cryptoTransform = aes.CreateEncryptor())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
					{
						byte[] bytes = Encoding.Default.GetBytes(plain_text);
						cryptoStream.Write(bytes, 0, bytes.Length);
						cryptoStream.FlushFinalBlock();
						byte[] ba = memoryStream.ToArray();
						result = encryption.byte_arr_to_str(ba);
					}
				}
			}
			return result;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00017A54 File Offset: 0x00015C54
		public static string decrypt_string(string cipher_text, byte[] key, byte[] iv)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Key = key;
			aes.IV = iv;
			string @string;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (ICryptoTransform cryptoTransform = aes.CreateDecryptor())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
					{
						byte[] array = encryption.str_to_byte_arr(cipher_text);
						cryptoStream.Write(array, 0, array.Length);
						cryptoStream.FlushFinalBlock();
						byte[] array2 = memoryStream.ToArray();
						@string = Encoding.Default.GetString(array2, 0, array2.Length);
					}
				}
			}
			return @string;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00017B14 File Offset: 0x00015D14
		public static string iv_key()
		{
			return Guid.NewGuid().ToString().Substring(0, Guid.NewGuid().ToString().IndexOf(i.a("", 57742), StringComparison.Ordinal));
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000026A8 File Offset: 0x000008A8
		public static string sha256(string r)
		{
			return encryption.byte_arr_to_str(new SHA256Managed().ComputeHash(Encoding.Default.GetBytes(r)));
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00017B64 File Offset: 0x00015D64
		public static string encrypt(string message, string enc_key, string iv)
		{
			byte[] bytes = Encoding.Default.GetBytes(encryption.sha256(enc_key).Substring(0, 32));
			byte[] bytes2 = Encoding.Default.GetBytes(encryption.sha256(iv).Substring(0, 16));
			return encryption.encrypt_string(message, bytes, bytes2);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00017BB0 File Offset: 0x00015DB0
		public static string decrypt(string message, string enc_key, string iv)
		{
			byte[] bytes = Encoding.Default.GetBytes(encryption.sha256(enc_key).Substring(0, 32));
			byte[] bytes2 = Encoding.Default.GetBytes(encryption.sha256(iv).Substring(0, 16));
			return encryption.decrypt_string(message, bytes, bytes2);
		}
	}
}
