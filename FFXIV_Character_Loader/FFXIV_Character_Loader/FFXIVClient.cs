using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFXIV_Character_Loader
{
    public class FFXIVClient
    {
        static HttpClient Client;
        static string CharacterName;
        static string ServerWorld;
        static long CharacterId;
        public static List<String> AvatarPictures;
        public static List<Result> CharacterSearchResults;
        public static Result SelectedResult;

        static FFXIVClient()
        {
            Client = new HttpClient();
            CharacterName = string.Empty;
            ServerWorld = string.Empty;
            CharacterId = 0;
            AvatarPictures = new List<String>();
            CharacterSearchResults = new List<Result>();
            SelectedResult = null;
        }

        public static string MakeRequest(string url)
        {
            using (HttpResponseMessage response = Client.GetAsync(url).Result)
            using (HttpContent content = response.Content)
            {
                return content.ReadAsStringAsync().Result;
            }
        }

        internal static void SetCharacterInfo(Result result)
        {
            SelectedResult = result;
            CharacterId = result.Id;
        }

        public static void SearchCharacterName(string characterName, string serverWorld)
        {
            CharacterName = characterName;
            ServerWorld = serverWorld;
            
            GetCharacterAvatars(CharacterName, ServerWorld);
        }

        internal static CharacterData GetCharacterData()
        {
            string url = $"https://xivapi.com/character/{CharacterId}";
            return  JsonConvert.DeserializeObject<CharacterData>(MakeRequest(url));
        }

        public static void GetCharacterAvatars(string characterName, string serverWorld)
        {
            string url = $"https://xivapi.com/character/search?name={characterName}&server={serverWorld}";
            CharacterSearchResult characterSearchResults = JsonConvert.DeserializeObject<CharacterSearchResult>(MakeRequest(url));

            foreach (Result result in characterSearchResults.Results)
                CharacterSearchResults.Add(result);
        }
    }
}
