using System.ComponentModel;

namespace Chapter05.Enums
{
	public enum Wood
	{
		[Description("INDIAN ROSEWOOD")]
		INDIAN_ROSEWOOD,
		[Description("BRAZILIAN ROSEWOOD")]
		BRAZILIAN_ROSEWOOD,
		MAHOGANY,
		MAPLE,
		COCOBOLO,
		CEDAR,
		ADIRONDACK,
		ALDER,
		STIKA
	}
}