//
// ScaleFactorType2.cs.cs
//
// This file was generated by XMLSpy 2005 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSpy Documentation for further details.
// http://www.altova.com/xmlspy
//


using Altova.Types;

namespace LayerSet
{

	public class ScaleFactorType2 : SchemaDecimal
	{

		public ScaleFactorType2() : base()
		{
		}

		public ScaleFactorType2(string newValue) : base(newValue)
		{
			Validate();
		}

		public ScaleFactorType2(SchemaDecimal newValue) : base(newValue)
		{
			Validate();
		}

		public void Validate()
		{

			if (CompareTo(GetMinInclusive()) < 0)
				throw new System.Exception("Out of range");
		}
		public SchemaDecimal GetMinInclusive()
		{
			return new SchemaDecimal("0");
		}
	}
}
