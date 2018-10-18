using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil;

namespace Void_server.Libs
{
    public class Renamer
    {
        public AssemblyDefinition AsmDef { get; set; }

        private int Length { get; set; }

        public Renamer(AssemblyDefinition def) : this(def, 20)
        {
        }

        public Renamer(AssemblyDefinition def, int length)
        {
            AsmDef = def;
            Length = length;
            typeOverloader = new MemberOverloader(Length, true);
            methodOverloaders = new Dictionary<TypeDefinition, MemberOverloader>();
            fieldOverloaders = new Dictionary<TypeDefinition, MemberOverloader>();
            eventOverloaders = new Dictionary<TypeDefinition, MemberOverloader>();
        }

        public bool Perform()
        {
            bool result;
            try
            {
                foreach (TypeDefinition typeDef in AsmDef.Modules.SelectMany((ModuleDefinition module) => module.Types))
                {
                    RenameInType(typeDef);
                }
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        private void RenameInType(TypeDefinition typeDef)
        {
            if (typeDef.Namespace.Contains("NetSerializer") || typeDef.Namespace.Contains("Registry") || typeDef.HasInterfaces)
            {
                return;
            }
            typeOverloader.GiveName(typeDef);
            typeDef.Namespace = string.Empty;
            MemberOverloader methodOverloader = GetMethodOverloader(typeDef);
            MemberOverloader fieldOverloader = GetFieldOverloader(typeDef);
            MemberOverloader eventOverloader = GetEventOverloader(typeDef);
            if (typeDef.HasNestedTypes)
            {
                foreach (TypeDefinition typeDef2 in typeDef.NestedTypes)
                {
                    RenameInType(typeDef2);
                }
            }
            if (typeDef.HasMethods)
            {
                foreach (MethodDefinition member in from methodDef in typeDef.Methods
                                                    where !methodDef.IsConstructor && !methodDef.HasCustomAttributes && !methodDef.IsAbstract && !methodDef.IsVirtual
                                                    select methodDef)
                {
                    methodOverloader.GiveName(member);
                }
            }
            if (typeDef.HasFields)
            {
                foreach (FieldDefinition member2 in typeDef.Fields)
                {
                    fieldOverloader.GiveName(member2);
                }
            }
            if (typeDef.HasEvents)
            {
                foreach (EventDefinition member3 in typeDef.Events)
                {
                    eventOverloader.GiveName(member3);
                }
            }
        }

        private MemberOverloader GetMethodOverloader(TypeDefinition typeDef)
        {
            return GetOverloader(methodOverloaders, typeDef);
        }

        private MemberOverloader GetFieldOverloader(TypeDefinition typeDef)
        {
            return GetOverloader(fieldOverloaders, typeDef);
        }

        private MemberOverloader GetEventOverloader(TypeDefinition typeDef)
        {
            return GetOverloader(eventOverloaders, typeDef);
        }

        private MemberOverloader GetOverloader(Dictionary<TypeDefinition, MemberOverloader> overloaderDictionary, TypeDefinition targetTypeDef)
        {
            MemberOverloader memberOverloader;
            if (!overloaderDictionary.TryGetValue(targetTypeDef, out memberOverloader))
            {
                memberOverloader = new MemberOverloader(Length, true);
                overloaderDictionary.Add(targetTypeDef, memberOverloader);
            }
            return memberOverloader;
        }

        private MemberOverloader typeOverloader;
        private Dictionary<TypeDefinition, MemberOverloader> methodOverloaders;
        private Dictionary<TypeDefinition, MemberOverloader> fieldOverloaders;
        private Dictionary<TypeDefinition, MemberOverloader> eventOverloaders;

        private class MemberOverloader
        {
            private bool DoRandom { get; set; }

            private int StartingLength { get; set; }

            public MemberOverloader(int startingLength, bool doRandom = true) : this(startingLength, doRandom, "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray())
            {
            }

            private MemberOverloader(int startingLength, bool doRandom, char[] chars)
            {
                charMap = chars;
                DoRandom = doRandom;
                StartingLength = startingLength;
                indices = new int[startingLength];
            }

            public void GiveName(MemberReference member)
            {
                string currentName = GetCurrentName();
                string key = member.ToString();
                member.Name = currentName;
                while (renamedMembers.ContainsValue(member.ToString()))
                {
                    member.Name = GetCurrentName();
                }
                renamedMembers.Add(key, member.ToString());
            }

            private string GetCurrentName()
            {
                if (!DoRandom)
                {
                    return GetOverloadedName();
                }
                return GetRandomName();
            }

            private string GetRandomName()
            {
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < StartingLength; i++)
                {
                    stringBuilder.Append((char)new Random(Guid.NewGuid().GetHashCode()).Next(int.MinValue, int.MaxValue));
                }
                return stringBuilder.ToString();
            }

            private string GetOverloadedName()
            {
                IncrementIndices();
                char[] array = new char[indices.Length];
                for (int i = 0; i < indices.Length; i++)
                {
                    array[i] = charMap[indices[i]];
                }
                return new string(array);
            }

            private void IncrementIndices()
            {
                for (int i = indices.Length - 1; i >= 0; i--)
                {
                    indices[i]++;
                    if (indices[i] < charMap.Length)
                    {
                        break;
                    }
                    if (i == 0)
                    {
                        Array.Resize<int>(ref indices, indices.Length + 1);
                    }
                    indices[i] = 0;
                }
            }

            private Dictionary<string, string> renamedMembers = new Dictionary<string, string>();
            private readonly char[] charMap;
            private int[] indices;
        }
    }
}
