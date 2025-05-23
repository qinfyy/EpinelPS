﻿using EpinelPS.Utils;

namespace EpinelPS.LobbyServer.Shop.InApp
{
    [PacketPath("/inappshop/jupiter/getmarketingdetail")]
    public class GetMarketingDetail : LobbyMsgHandler
    {
        protected override async Task HandleAsync()
        {
            var req = await ReadData<ReqGetJupiterMarketingDetail>();
            var response = new ResGetJupiterMarketingDetail();
            response.MarketingDetail = "{}";

            await WriteDataAsync(response);
        }
    }
}
