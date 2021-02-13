﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OperatorMessage.cs" company="SmokeLounge">
//   Copyright © 2013 SmokeLounge.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the OperatorMessage type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SmokeLounge.AOtomation.Messaging.Messages
{
    using SmokeLounge.AOtomation.Messaging.Serialization.MappingAttributes;

    [AoContract((int)PacketType.OperatorMessage)]
    public class OperatorMessage : MessageBody
    {
        #region Public Properties

        public override PacketType PacketType
        {
            get
            {
                return PacketType.OperatorMessage;
            }
        }

        #endregion
    }
}