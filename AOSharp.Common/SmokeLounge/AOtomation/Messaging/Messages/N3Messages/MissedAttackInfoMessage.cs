﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MissedAttackInfoMessage.cs" company="SmokeLounge">
//   Copyright © 2013 SmokeLounge.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the MissedAttackInfoMessage type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using AOSharp.Common.GameData;

namespace SmokeLounge.AOtomation.Messaging.Messages.N3Messages
{
    using SmokeLounge.AOtomation.Messaging.GameData;
    using SmokeLounge.AOtomation.Messaging.Serialization.MappingAttributes;

    [AoContract((int)N3MessageType.MissedAttackInfo)]
    public class MissedAttackInfoMessage : N3Message
    {
        #region Constructors and Destructors

        public MissedAttackInfoMessage()
        {
            this.N3MessageType = N3MessageType.MissedAttackInfo;
        }

        #endregion

        #region AoMember Properties

        [AoMember(0)]
        public int Unknown1 { get; set; }

        [AoMember(1)]
        public int Unknown2 { get; set; }

        [AoMember(2)]
        public Identity Attacker { get; set; }

        [AoMember(3)]
        public Identity Defender { get; set; }

        [AoMember(4)]
        public int Unknown3 { get; set; }

        #endregion
    }
}