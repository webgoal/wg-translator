using System.Net;
using System.Runtime.Serialization;

namespace Milkshake.Integration.Google.Translate
{
	///
	/// Defines a response from the Google AJAX Translate API.
	///
	[DataContract]
	public class TranslationResponse
	{
		///
		/// Initializes a new instance of the  class.
		///
		public TranslationResponse()
		{
			this.ResponseStatus = HttpStatusCode.OK;
		}

		///
		/// Gets or sets the translated text.
		///
		/// The translated text.
		[DataMember(Name = "translatedText", Order = 0)]
		public string TranslatedText { get; set; }

		///
		/// Gets or sets the response details.
		///
		/// The response details.
		[DataMember(Name = "responseDetails", Order = 1)]
		public object ResponseDetails { get; set; }

		///
		/// Gets or sets the response status.
		///
		/// The response status.
		[DataMember(Name = "responseStatus", Order = 2)]
		public HttpStatusCode ResponseStatus { get; set; }
	}
}