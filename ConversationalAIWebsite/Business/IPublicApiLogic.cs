﻿using ConversationalAIWebsite.API;
using ConversationalAIWebsite.ClientApp.src.components;

namespace ConversationalAIWebsite.Business
{
    public interface IPublicApiLogic
    {
        Task<BackendResponse<int>> GetRemainingFreeRequests(string apiKey);
        Task<BackendResponse<bool>> UpsertUserSQLData(ApiRequest request, string apiKey);
        Task<BackendResponse<string?>> GetSQLData(string apiKey);
        Task<BackendResponse<string?>> ConvertQueryToSQL(ApiRequest request, string apiKey);
    }
}
