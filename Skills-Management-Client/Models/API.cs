using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

class API {
	async static public Task<string> getSkills() {
		string url = "localhost/api/skillsapi";
		using (var client = new HttpClient()) {
			HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);
			if (response.IsSuccessStatusCode) {
				var jsonResponse = response.Content.ReadAsStringAsync().Result;
				return jsonResponse;
				
			}
			else {
				return null;
			}
		}
	}
}