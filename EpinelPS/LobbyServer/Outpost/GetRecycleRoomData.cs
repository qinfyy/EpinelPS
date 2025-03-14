﻿using EpinelPS.Utils;

namespace EpinelPS.LobbyServer.Outpost
{
    [PacketPath("/outpost/recycleroom/get")]
    public class GetRecycleRoomData : LobbyMsgHandler
    {
        protected override async Task HandleAsync()
        {
            var req = await ReadData<ReqGetRecycleRoomData>();

            // TODO: save these things
            var response = new ResGetRecycleRoomData();

            await WriteDataAsync(response);
        }
    }
}
