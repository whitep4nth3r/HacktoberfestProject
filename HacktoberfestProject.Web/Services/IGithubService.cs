﻿using System.Collections.Generic;
using System.Threading.Tasks;

using HacktoberfestProject.Web.Models.DTOs;
using HacktoberfestProject.Web.Models.Helpers;

namespace HacktoberfestProject.Web.Services
{
	public interface IGithubService
	{
		Task<List<PullRequest>> GetPullRequestsForRepo(string owner, string name);
		Task<List<Repository>> GetRepos(string owner);
		Task<ServiceResponse<IEnumerable<string>>> SearchOwners(string owner, int limit);
	}
}
