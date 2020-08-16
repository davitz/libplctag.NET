﻿namespace libplctag.DataTypes
{
    public class SintMarshaller : Marshaller<sbyte>
    {

        override public int? ElementSize => 1;

        override public sbyte Decode(Tag tag, int offset, out int elementSize)
        {
            elementSize = ElementSize.Value;
            return tag.GetInt8(offset * ElementSize.Value);
        }

        override public void Encode(Tag tag, int offset, out int elementSize, sbyte value)
        {
            elementSize = ElementSize.Value;
            tag.SetInt8(offset, value);
        }

    }
}
