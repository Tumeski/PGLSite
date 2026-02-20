using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Oqtane.Controllers;
using Oqtane.Modules.ClubMembers.Models;
using Oqtane.Modules.ClubMembers.Repository;
using Oqtane.Shared;
using System.Collections.Generic;
using Oqtane.Infrastructure;
using Oqtane.Enums;

namespace Oqtane.Modules.ClubMembers.Controllers
{
    [Route(ControllerRoutes.ApiRoute)]
    public class ClubMemberController : ModuleControllerBase
    {
        private readonly IClubMemberRepository _clubMembers;

        public ClubMemberController(IClubMemberRepository clubMembers, ILogManager logger, Microsoft.AspNetCore.Http.IHttpContextAccessor accessor) : base(logger, accessor)
        {
            _clubMembers = clubMembers;
        }

        // GET api/<controller>?moduleid=1
        [HttpGet]
        public IEnumerable<ClubMember> Get(int moduleid)
        {
            return _clubMembers.GetClubMembers(moduleid);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ClubMember GetById(int id)
        {
            return _clubMembers.GetClubMember(id);
        }

        // POST api/<controller>
        [HttpPost]
        [Authorize(Roles = RoleNames.Registered)]
        public ClubMember Post([FromBody] ClubMember clubMember)
        {
            clubMember = _clubMembers.AddClubMember(clubMember);
            _logger.Log(LogLevel.Information, this, LogFunction.Create, "ClubMember Added {ClubMember}", clubMember);
            return clubMember;
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        [Authorize(Roles = RoleNames.Registered)]
        public ClubMember Put(int id, [FromBody] ClubMember clubMember)
        {
            clubMember = _clubMembers.UpdateClubMember(clubMember);
            _logger.Log(LogLevel.Information, this, LogFunction.Update, "ClubMember Updated {ClubMember}", clubMember);
            return clubMember;
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        [Authorize(Roles = RoleNames.Registered)]
        public void Delete(int id)
        {
            _clubMembers.DeleteClubMember(id);
            _logger.Log(LogLevel.Information, this, LogFunction.Delete, "ClubMember Deleted {ClubMemberId}", id);
        }
    }
}
