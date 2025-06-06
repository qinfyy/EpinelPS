﻿using EpinelPS.Utils;

namespace EpinelPS.LobbyServer.Campaign
{
    [PacketPath("/campaign/savefield")]
    public class SaveField : LobbyMsgHandler
    {
        protected override async Task HandleAsync()
        {
            var req = await ReadData<ReqSaveCampaignField>();
            var user = GetUser();

            var response = new ResSaveCampaignField();

            if (!user.MapJson.ContainsKey(req.MapId))
            {
                user.MapJson.Add(req.MapId, req.Json);
            }
            else
            {
                user.MapJson[req.MapId] = req.Json;
            }

            await WriteDataAsync(response);
        }
    }
}
