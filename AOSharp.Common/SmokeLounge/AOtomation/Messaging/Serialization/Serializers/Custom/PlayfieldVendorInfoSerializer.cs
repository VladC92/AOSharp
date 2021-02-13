﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlayfieldVendorInfoSerializer.cs" company="SmokeLounge">
//   Copyright © 2013 SmokeLounge.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the PlayfieldVendorInfoSerializer type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using AOSharp.Common.GameData;

namespace SmokeLounge.AOtomation.Messaging.Serialization.Serializers.Custom
{
    using System;
    using System.Linq.Expressions;

    using SmokeLounge.AOtomation.Messaging.GameData;

    // TODO: Investigate whether this can be implemented using a CanBeNullAttribute
    public class PlayfieldVendorInfoSerializer : ISerializer
    {
        #region Fields

        private readonly Type type;

        #endregion

        #region Constructors and Destructors

        public PlayfieldVendorInfoSerializer()
        {
            this.type = typeof(PlayfieldVendorInfo);
        }

        #endregion

        #region Public Properties

        public Type Type
        {
            get
            {
                return this.type;
            }
        }

        #endregion

        #region Public Methods and Operators

        public object Deserialize(
            StreamReader streamReader, 
            SerializationContext serializationContext, 
            PropertyMetaData propertyMetaData = null)
        {
            var identityType = (IdentityType)streamReader.ReadInt32();
            if (identityType != IdentityType.VendingMachine)
            {
                streamReader.Position = streamReader.Position - 4;
                return null;
            }

            var playfieldVendorInfo = new PlayfieldVendorInfo
                                          {
                                              Unknown1 =
                                                  new Identity
                                                      {
                                                          Type = identityType, 
                                                          Instance = streamReader.ReadInt32()
                                                      }, 
                                              Unknown2 = streamReader.ReadInt32(), 
                                              VendorCount = streamReader.ReadInt32(), 
                                              FirstVendorId = streamReader.ReadInt32()
                                          };
            return playfieldVendorInfo;
        }

        public Expression DeserializerExpression(
            ParameterExpression streamReaderExpression, 
            ParameterExpression serializationContextExpression, 
            Expression assignmentTargetExpression, 
            PropertyMetaData propertyMetaData)
        {
            var deserializerMethodInfo =
                ReflectionHelper
                    .GetMethodInfo
                    <PlayfieldVendorInfoSerializer, Func<StreamReader, SerializationContext, PropertyMetaData, object>>(
                        o => o.Deserialize);
            var serializerExp = Expression.New(this.GetType());
            var callExp = Expression.Call(
                serializerExp, 
                deserializerMethodInfo, 
                new Expression[]
                    {
                        streamReaderExpression, serializationContextExpression, 
                        Expression.Constant(propertyMetaData, typeof(PropertyMetaData))
                    });

            var assignmentExp = Expression.Assign(
                assignmentTargetExpression, Expression.TypeAs(callExp, assignmentTargetExpression.Type));
            return assignmentExp;
        }

        public void Serialize(
            StreamWriter streamWriter, 
            SerializationContext serializationContext, 
            object value, 
            PropertyMetaData propertyMetaData = null)
        {
            if (value == null)
            {
                return;
            }

            var playfieldVendorInfo = (PlayfieldVendorInfo)value;
            streamWriter.WriteInt32((int)playfieldVendorInfo.Unknown1.Type);
            streamWriter.WriteInt32(playfieldVendorInfo.Unknown1.Instance);
            streamWriter.WriteInt32(playfieldVendorInfo.Unknown2);
            streamWriter.WriteInt32(playfieldVendorInfo.VendorCount);
            streamWriter.WriteInt32(playfieldVendorInfo.FirstVendorId);
        }

        public Expression SerializerExpression(
            ParameterExpression streamWriterExpression, 
            ParameterExpression serializationContextExpression, 
            Expression valueExpression, 
            PropertyMetaData propertyMetaData)
        {
            var serializerMethodInfo =
                ReflectionHelper
                    .GetMethodInfo
                    <PlayfieldVendorInfoSerializer, Action<StreamWriter, SerializationContext, object, PropertyMetaData>>(o => o.Serialize);
            var serializerExp = Expression.New(this.GetType());
            var callExp = Expression.Call(
                serializerExp, 
                serializerMethodInfo, 
                new[]
                    {
                        streamWriterExpression, serializationContextExpression, valueExpression, 
                        Expression.Constant(propertyMetaData, typeof(PropertyMetaData))
                    });
            return callExp;
        }

        #endregion
    }
}