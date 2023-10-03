using System;
using System.Collections.Generic;
using System.Text;

namespace Grammophone.Formulae
{
	/// <summary>
	/// Interface for the definition of a formula.
	/// </summary>
	public interface IFormulaDefinition
	{
		/// <summary>
		/// The datatype of the 
		/// </summary>
		public Type DataType { get; }

		/// <summary>
		/// The unique identifier where the evaluation of the formula is assigned.
		/// </summary>
		public string Identifier { get; }

		/// <summary>
		/// The expression of the formula. Does not include the assignment to the <see cref="Identifier"/>.
		/// </summary>
		public string Expression { get; }

		/// <summary>
		/// Get a unique formula ID as a string.
		/// </summary>
		public string GetFormulaID();
	}
}
