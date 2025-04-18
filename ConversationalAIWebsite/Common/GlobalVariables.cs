﻿namespace ConversationalAIWebsite.Common
{
    public class GlobalVariables
    {
        public enum FinishReason
        {
            Stop,
            Length,
            ToolCalls,
            ContentFilter,
            Error
        }

        public enum Role
        {
            User,
            Assistant,
            System,
            Tool
        }

        public enum ResponseFormat
        {
            Json,
            Text
        }
    }
}
