using Newtonsoft.Json;
using System.Collections.Generic;

namespace QnaMakerApi.Responses {

	public partial class DownloadKnowledgeBaseResponse {
		public string BlobUrl { get; set; }

		[JsonProperty("qnaDocuments")]
		public List<QnaDocument> QnaDocuments { get; set; }

		public DownloadKnowledgeBaseResponse() {
			QnaDocuments = new List<QnaDocument>();
		}

		public static DownloadKnowledgeBaseResponse FromJson(string json) => JsonConvert.DeserializeObject<DownloadKnowledgeBaseResponse>(json);
	}

	public partial class QnaDocument {
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("answer")]
		public string Answer { get; set; }

		[JsonProperty("source")]
		public string Source { get; set; }

		[JsonProperty("questions")]
		public List<string> Questions { get; set; }

		[JsonProperty("metadata")]
		public List<object> Metadata { get; set; }
	}

}