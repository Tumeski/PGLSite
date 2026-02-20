using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Oqtane.Modules.ClubMembers.Models;
using Oqtane.Services;

namespace Oqtane.Modules.ClubMembers.Services
{
    public class ClubMemberService : IClubMemberService, IClientService
    {
        private readonly HttpClient _http;

        public ClubMemberService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<ClubMember>> GetClubMembersAsync(int moduleId)
        {
            return await _http.GetFromJsonAsync<List<ClubMember>>($"api/ClubMember?moduleid={moduleId}");
        }

        public async Task<ClubMember> GetClubMemberAsync(int clubMemberId)
        {
            return await _http.GetFromJsonAsync<ClubMember>($"api/ClubMember/{clubMemberId}");
        }

        public async Task<ClubMember> AddClubMemberAsync(ClubMember clubMember)
        {
            var response = await _http.PostAsJsonAsync("api/ClubMember", clubMember);
            return await response.Content.ReadFromJsonAsync<ClubMember>();
        }

        public async Task<ClubMember> UpdateClubMemberAsync(ClubMember clubMember)
        {
            var response = await _http.PutAsJsonAsync($"api/ClubMember/{clubMember.ClubMemberId}", clubMember);
            return await response.Content.ReadFromJsonAsync<ClubMember>();
        }

        public async Task DeleteClubMemberAsync(int clubMemberId)
        {
            await _http.DeleteAsync($"api/ClubMember/{clubMemberId}");
        }
    }
}
