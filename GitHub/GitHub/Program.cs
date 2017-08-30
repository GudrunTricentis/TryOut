using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Octokit;

namespace GitHub
{
    class Program
    {
        static void Main(string[] args) {
            var client = new GitHubClient(new ProductHeaderValue("TryOut_GitHub1"));

            var basicAuth = new Credentials("GudrunTricentis", "GitHub11#");

            client.Credentials = basicAuth;

            IRepositoryBranchesClient branches = client.Repository.Branch;

        }
    }
}
