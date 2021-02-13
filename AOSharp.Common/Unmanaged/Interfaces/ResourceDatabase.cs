﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOSharp.Common.GameData;
using AOSharp.Common.Unmanaged.DbObjects;
using AOSharp.Common.Unmanaged.Imports;
using AOSharp.Common.Unmanaged.Imports.DatabaseController;

namespace AOSharp.Common.Unmanaged.Interfaces
{
    public class ResourceDatabase
    {
        public static IntPtr GetDbObject(Identity identity)
        {
            IntPtr pDatabaseHandler = N3DatabaseHandler_t.Get();
            IntPtr pResourceDatabase = N3DatabaseHandler_t.GetResourceDatabase(pDatabaseHandler);

            return ResourceDatabase_t.GetDbObject(pResourceDatabase, ref identity);
        }

        public static T GetDbObject<T>(Identity identity) where T : DbObject
        {
            IntPtr pDatabaseHandler = N3DatabaseHandler_t.Get();
            IntPtr pResourceDatabase = N3DatabaseHandler_t.GetResourceDatabase(pDatabaseHandler);


            if (typeof(T) == typeof(PlayfieldDistrictInfo))
            {
                return (T)(object) new PlayfieldDistrictInfo(GetDbObject(identity));
            }
                return (T)(object) new PlayfieldDistrictInfo(ResourceDatabase_t.GetDbObject(pResourceDatabase, ref identity));

            if (typeof(T) == typeof(LandControlMap))
                return (T) (object) new LandControlMap(ResourceDatabase_t.GetDbObject(pResourceDatabase, ref identity));

            if (typeof(T) == typeof(RDBPlayfield))
                return (T) (object) new RDBPlayfield(ResourceDatabase_t.GetDbObject(pResourceDatabase, ref identity));

            throw new ArgumentException();
        }

        public static void PutDbBlob(Identity identity, byte[] blobData)
        {
            IntPtr pDatabaseHandler = N3DatabaseHandler_t.Get();
            IntPtr pResourceDatabase = N3DatabaseHandler_t.GetResourceDatabase(pDatabaseHandler);

            ResourceDatabase_t.PutDbBlob(pResourceDatabase, ref identity, blobData, blobData.Length);
        }

        public static void PutDbObject(IntPtr pDbObject)
        {
            IntPtr pDatabaseHandler = N3DatabaseHandler_t.Get();
            IntPtr pResourceDatabase = N3DatabaseHandler_t.GetResourceDatabase(pDatabaseHandler);

            ResourceDatabase_t.PutDbObject(pResourceDatabase, pDbObject);
        }
    }
}