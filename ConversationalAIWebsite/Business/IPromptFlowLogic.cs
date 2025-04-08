﻿using ConversationalAIWebsite.API;
using ConversationalAIWebsite.DAL.Models;

namespace ConversationalAIWebsite.Business
{
    public interface IPromptFlowLogic
    {
        Task<BackendResponse<UserData?>> GetUser(string username);
        Task<BackendResponse<bool>> MarkUserAsPaying(string username, string customerId);
        Task<BackendResponse<bool>> MarkUserAsNonPaying(string username);
        Task<BackendResponse<bool>> SaveNewUser(string username);
        Task<BackendResponse<bool>> UpsertUserSQLData(FrontEndRequest request);
        Task<BackendResponse<string?>> GetSQLDataHelp(FrontEndRequest request);
        BackendResponse<string?> GetSQLData(string username);
        Task<BackendResponse<string?>> ConvertQueryToSQL(FrontEndRequest request);
        Task<BackendResponse<string>> GenerateAndStoreApiKey(string username);
    }
}

