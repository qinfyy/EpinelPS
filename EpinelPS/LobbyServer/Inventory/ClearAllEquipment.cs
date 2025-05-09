﻿using EpinelPS.Database;
using EpinelPS.Utils;

namespace EpinelPS.LobbyServer.Inventory
{
    [PacketPath("/inventory/allclearequipment")]
    public class ClearAllEquipment : LobbyMsgHandler
    {
        protected override async Task HandleAsync()
        {
            var req = await ReadData<ReqAllClearEquipment>();
            var user = GetUser();

            var response = new ResAllClearEquipment();
            response.Csn = req.Csn;

            foreach (var item in user.Items.ToArray())
            {
                if (item.Csn == req.Csn)
                {
                    // update character id
                    item.Csn = 0;

                    response.Items.Add(NetUtils.ToNet(item));
                }
            }

            JsonDb.Save();

            await WriteDataAsync(response);
        }
    }
}
