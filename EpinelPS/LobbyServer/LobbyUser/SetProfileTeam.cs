﻿using EpinelPS.Database;
using EpinelPS.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpinelPS.LobbyServer.LobbyUser
{
    [PacketPath("/user/setprofileteam")]
    public class SetProfileTeam : LobbyMsgHandler
    {
        protected override async Task HandleAsync()
        {
            var req = await ReadData<ReqSetProfileTeam>();
            var user = GetUser();
            user.RepresentationTeamData = new NetWholeUserTeamData();
            user.RepresentationTeamData.TeamNumber = req.Team.TeamNumber;
            foreach (var item in req.Team.Slots)
            {
                var character = user.GetCharacterBySerialNumber(item.Value);
                if (character != null)
                {
                    user.RepresentationTeamData.Slots.Add(new NetWholeTeamSlot() { Csn = item.Value, Slot = item.Slot, CostumeId = character.CostumeId, Level = character.Level, Tid = character.Tid });
                }
            }

            JsonDb.Save();
            var response = new ResSetProfileTeam();

            await WriteDataAsync(response);
        }
    }
}
