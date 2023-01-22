using Mono.Cecil;
using Mono.Cecil.Cil;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace NexusLabs.BoRAT.Server
{
    public class Common
    {
        // Change this
        public static bool pipedreamEnabled = false;
        public static string pipedreamURL = "https://eonvuonqbllwqpu.m.pipedream.net";
        public static string encryptionKey = "B0R@t2!02@2^2%2#";

        public static string Encrypt(string clearText)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Rijndael encryptor = Rijndael.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey,
                    new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }

                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }

            return clearText;
        }

        public static string Decrypt(string cipherText)
        {
            try
            {
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                using (Rijndael encryptor = Rijndael.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey,
                        new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }

                        cipherText = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }

                return cipherText;
            }
            catch (Exception)
            {
                //plain text?
                return cipherText;
            }
        }

        public static void ReplaceString(string old, string replacement, AssemblyDefinition asm)
        {
            foreach (ModuleDefinition mod in asm.Modules)
                foreach (TypeDefinition td in mod.Types)
                    IterateType(td, old, replacement);
        }

        public static void IterateType(TypeDefinition td, string old, string replacement)
        {
            foreach (TypeDefinition ntd in td.NestedTypes) IterateType(ntd, old, replacement);

            foreach (MethodDefinition md in td.Methods)
                if (md.HasBody)
                    for (int i = 0; i < md.Body.Instructions.Count - 1; i++)
                    {
                        Instruction inst = md.Body.Instructions[i];
                        if (inst.OpCode == OpCodes.Ldstr)
                            if (inst.Operand.ToString().Equals(old))
                                inst.Operand = replacement;
                    }
        }

        // SOURCE : https://stackoverflow.com/questions/1242266/converting-bytes-to-gb-in-c
        public static string FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024) dblSByte = bytes / 1024.0;

            return string.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }
    }
}
