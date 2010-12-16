using System.Runtime.Serialization;
using Milkshake.Integration.Google.Translate;

namespace Milkshake.Integration.Google
{
	///
	/// Defines a response from one of Google's AJAX APIs.
	///
	/// The type of object, being returned.
	[DataContract]
	public class GoogleAjaxResponse
	{
		///
		/// Gets or sets the response data.
		///
		///
		/// The responseData from Google AJAX API Call
		///
		/// The response data.
		[DataMember(Name = "responseData", Order = 0)]
		public TranslationResponse ResponseData { get; set; }
	}
}