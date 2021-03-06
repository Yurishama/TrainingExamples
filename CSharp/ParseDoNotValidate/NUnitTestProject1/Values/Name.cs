using System;
using System.Collections.Generic;

namespace ParseNotValidate.Values
{
    public class Name : Value.ValueType<Name>
    {
        private readonly string _value;

        public static Name Value(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            if(value == string.Empty)
            {
                throw new EmptyNameException();
            }

            return new Name(value);
        }

        internal Name(string value) => _value = value;
        public override string ToString() => _value;

        protected override IEnumerable<object> GetAllAttributesToBeUsedForEquality()
        {
            yield return _value;
        }


    }
}