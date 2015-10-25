using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5eCharGen
{
    public class Notation
    {
        List<NotationValue> values = new List<NotationValue>();

        public Notation(string notation)
        {
            notation = notation.Replace(" ", string.Empty).ToUpper();
            values = Parse(notation, notation.Length - 1, 0);
        }

        public static char[] operators = { '+', '-', '/', '*', '^' };

        private static List<NotationValue> Parse(string notation, int start, int end)
        {
            List<NotationValue> values = new List<NotationValue>();

            int i = start;
            while (i >= end)
            {
                int i2 = i;
                while (i2 > end && !operators.Contains(notation[i2]))
                    i2--;
                values.Add(new NotationValue(notation, i2, i));
                i = i2 - 1;
            }

            values.Reverse();
            return values;
        }
    }

    public struct NotationValue
    {
        public int value;
        public Op op;
        public NotationType type;

        public NotationValue(int value, NotationType type, Op op)
        {
            this.value = value;
            this.op = op;
            this.type = type;
        }

        public NotationValue(string notation, int index, int end)
        {
            value = 1;
            op = Op.Add;
            type = NotationType.Value;

            switch (notation[index])
            {
                case '+': { index++; break; }
                case '-': { op = Op.Sub; index++; break; }
                case '*': { op = Op.Mul; index++; break; }
                case '/': { op = Op.Div; index++; break; }
                case '^': { op = Op.Mod; index++; break; }
            }

            if (index <= end && char.IsDigit(notation[index]))
            {
                int i = index + 1;
                while (i <= end && char.IsDigit(notation[i])) i++;
                value = int.Parse(notation.Substring(index, i - index));
                index = i;
            }

            if (index <= end && char.IsLetter(notation[index]))
            {
                Enum.TryParse<NotationType>(notation.Substring(index, end - index + 1), out type);
            }
        }
    }

    public enum NotationType
    {
        Value,
        D3,
        D4,
        D6,
        D8,
        D10,
        D12,
        D20,
        STR,
        CON,
        DEX,
        INT,
        WIS,
        CHA,
        PROF,
    }

    public enum Op : byte
    {
        Add,
        Sub,
        Mul,
        Div,
        Mod
    }

    //public class NotationValueListSerializer : JsonConverter
    //{
    //    public override bool CanConvert(Type objectType)
    //    {
    //        return typeof(string) == objectType;
    //    }

    //    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    //    {

    //    }

    //    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    //    {
    //    }
    //}
}
