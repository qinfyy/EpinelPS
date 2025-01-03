﻿using EpinelPS.Utils;

namespace EpinelPS.LobbyServer.Character
{
    [PacketPath("/character/attractive/get")]
    public class GetCharacterAttractiveList : LobbyMsgHandler
    {
        protected override async Task HandleAsync()
        {
            var req = await ReadData<ReqGetAttractiveList>();

            var response = new ResGetAttractiveList();
            response.CounselAvailableCount = 0; // TODO

            // TODO: Validate response from real server and pull info from user info
            await WriteDataAsync(response);
        }
    }
}
