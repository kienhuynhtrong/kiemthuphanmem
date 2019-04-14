

using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Bank.Business.HandleComponents
{
	/// <summary>
	/// Encrypt Data
	/// </summary>
	public class Encrypt
	{

		/// <summary>
		/// Encrypt( Only have Encrypt)
		/// </summary>
		/// <param name="pInput"></param>
		/// <returns></returns>
		public string Encrypt_UP(string pInput)
		{
			MD5 md5 = new MD5CryptoServiceProvider();

			//compute hash from the bytes of text  
			md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pInput));

			//get hash result after compute it  
			byte[] result = md5.Hash;

			StringBuilder strBuilder = new StringBuilder();
			for (int i = 0; i < result.Length; i++)
			{
				//change it into 2 hexadecimal digits  
				//for each byte  
				strBuilder.Append(result[i].ToString("x2"));
			}

			return strBuilder.ToString();
		}


		/// <summary>
		/// Encrypt (can Decrypt)
		/// </summary>
		/// <param name="strEnCrypt"></param>
		/// <returns></returns>
		public string EncryptByKey(string strEnCrypt)
		{
			try
			{
				byte[] keyArr;
				byte[] EnCryptArr = UTF8Encoding.UTF8.GetBytes(strEnCrypt);
				MD5CryptoServiceProvider MD5Hash = new MD5CryptoServiceProvider();
				keyArr = MD5Hash.ComputeHash(UTF8Encoding.UTF8.GetBytes("SoftwareTesting"));
				TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider();
				tripDes.Key = keyArr;
				tripDes.Mode = CipherMode.ECB;
				tripDes.Padding = PaddingMode.PKCS7;
				ICryptoTransform transform = tripDes.CreateEncryptor();
				byte[] arrResult = transform.TransformFinalBlock(EnCryptArr, 0, EnCryptArr.Length);
				return Convert.ToBase64String(arrResult, 0, arrResult.Length);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Decrypt
		/// </summary>
		/// <param name="strDecypt"></param>
		/// <returns></returns>
		public string Decrypt(string strDecypt)
		{
			try
			{
				byte[] keyArr;
				byte[] DeCryptArr = Convert.FromBase64String(strDecypt);
				MD5CryptoServiceProvider MD5Hash = new MD5CryptoServiceProvider();
				keyArr = MD5Hash.ComputeHash(UTF8Encoding.UTF8.GetBytes("SoftwareTesting"));
				TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider();
				tripDes.Key = keyArr;
				tripDes.Mode = CipherMode.ECB;
				tripDes.Padding = PaddingMode.PKCS7;
				ICryptoTransform transform = tripDes.CreateDecryptor();
				byte[] arrResult = transform.TransformFinalBlock(DeCryptArr, 0, DeCryptArr.Length);
				return UTF8Encoding.UTF8.GetString(arrResult);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Decrypt Image
		/// </summary>
		/// <param name="base64String"></param>
		/// <returns></returns>
		public Image DecryptImage(string base64String)
		{
			byte[] imageBytes = Convert.FromBase64String(base64String);
			MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
			ms.Write(imageBytes, 0, imageBytes.Length);
			Image image = Image.FromStream(ms, true);
			return image;
		}

		/// <summary>
		/// Encript Image
		/// </summary>
		/// <param name="pImage"></param>
		/// <returns></returns>
		public string EncryptImage(Image pImage)
		{

			using (MemoryStream m = new MemoryStream())
			{
				pImage.Save(m, pImage.RawFormat);
				byte[] imageBytes = m.ToArray();
				string base64String = Convert.ToBase64String(imageBytes);
				return base64String;
			}

		}

	}
}
