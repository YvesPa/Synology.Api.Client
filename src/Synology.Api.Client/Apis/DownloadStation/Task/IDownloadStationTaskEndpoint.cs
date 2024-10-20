﻿using Synology.Api.Client.Apis.DownloadStation.Task.Models;
using Synology.Api.Client.Shared.Models;
using System.Threading.Tasks;

namespace Synology.Api.Client.Apis.DownloadStation.Task
{
    public interface IDownloadStationTaskEndpoint
    {
        Task<DownloadStationTaskListResponse> ListAsync();

        Task<DownloadStationTask> GetInfoAsync(string id);

        Task<DownloadStationTaskCreateResponse> CreateAsync(DownloadStationTaskCreateRequest request);

        Task<DownloadStationTaskDeleteResponse> DeleteAsync(DownloadStationTaskDeleteRequest data);

        Task<BaseApiResponse> PauseAsync(params string[] data);

        Task<DownloadStationTaskResumeResponse> ResumeAsync(params string[] ids);
    }
}
