using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Docs.Projects;

namespace Volo.Docs.Documents
{
    public interface IDocumentAppService : IApplicationService
    {
        Task<DocumentWithDetailsDto> GetByNameAsync(string projectShortName, string documentName, string version,
            bool normalize);

        Task<NavigationWithDetailsDto> GetNavigationDocumentAsync(string projectShortName, string version,
            bool normalize);

        Task<List<VersionInfoDto>> GetVersions(string projectShortName, string defaultDocumentName, string documentStoreType, string documentName);

        Task<DocumentWithDetailsDto> GetDocument(ProjectDto projectDto, string documentName, string version, bool normalize);
    }
}