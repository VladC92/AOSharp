﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CharInPlayMessage.cs" company="SmokeLounge">
//   Copyright © 2013 SmokeLounge.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the CharInPlayMessage type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SmokeLounge.AOtomation.Messaging.Messages.N3Messages
{
    using SmokeLounge.AOtomation.Messaging.Serialization.MappingAttributes;

    [AoContract((int)N3MessageType.CharInPlay)]
    public class CharInPlayMessage : N3Message
    {
        #region Constructors and Destructors

        public CharInPlayMessage()
        {
            this.N3MessageType = N3MessageType.CharInPlay;
        }

        #endregion
    }
}