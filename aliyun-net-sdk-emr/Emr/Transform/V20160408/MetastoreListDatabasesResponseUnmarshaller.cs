/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class MetastoreListDatabasesResponseUnmarshaller
    {
        public static MetastoreListDatabasesResponse Unmarshall(UnmarshallerContext context)
        {
			MetastoreListDatabasesResponse metastoreListDatabasesResponse = new MetastoreListDatabasesResponse();

			metastoreListDatabasesResponse.HttpResponse = context.HttpResponse;
			metastoreListDatabasesResponse.RequestId = context.StringValue("MetastoreListDatabases.RequestId");
			metastoreListDatabasesResponse.Description = context.StringValue("MetastoreListDatabases.Description");
			metastoreListDatabasesResponse.TotalCount = context.IntegerValue("MetastoreListDatabases.TotalCount");
			metastoreListDatabasesResponse.PageNumber = context.IntegerValue("MetastoreListDatabases.PageNumber");
			metastoreListDatabasesResponse.PageSize = context.IntegerValue("MetastoreListDatabases.PageSize");

			List<string> metastoreListDatabasesResponse_dbNames = new List<string>();
			for (int i = 0; i < context.Length("MetastoreListDatabases.DbNames.Length"); i++) {
				metastoreListDatabasesResponse_dbNames.Add(context.StringValue("MetastoreListDatabases.DbNames["+ i +"]"));
			}
			metastoreListDatabasesResponse.DbNames = metastoreListDatabasesResponse_dbNames;

			List<MetastoreListDatabasesResponse.MetastoreListDatabases_Database> metastoreListDatabasesResponse_databaseList = new List<MetastoreListDatabasesResponse.MetastoreListDatabases_Database>();
			for (int i = 0; i < context.Length("MetastoreListDatabases.DatabaseList.Length"); i++) {
				MetastoreListDatabasesResponse.MetastoreListDatabases_Database database = new MetastoreListDatabasesResponse.MetastoreListDatabases_Database();
				database.Id = context.StringValue("MetastoreListDatabases.DatabaseList["+ i +"].Id");
				database.ClusterBizId = context.StringValue("MetastoreListDatabases.DatabaseList["+ i +"].ClusterBizId");
				database.ClusterName = context.StringValue("MetastoreListDatabases.DatabaseList["+ i +"].ClusterName");
				database.DatabaseName = context.StringValue("MetastoreListDatabases.DatabaseList["+ i +"].DatabaseName");
				database.DatabaseType = context.StringValue("MetastoreListDatabases.DatabaseList["+ i +"].DatabaseType");
				database.Owner = context.StringValue("MetastoreListDatabases.DatabaseList["+ i +"].Owner");
				database.OwnerType = context.StringValue("MetastoreListDatabases.DatabaseList["+ i +"].OwnerType");
				database.Location = context.StringValue("MetastoreListDatabases.DatabaseList["+ i +"].Location");
				database.Status = context.StringValue("MetastoreListDatabases.DatabaseList["+ i +"].Status");
				database.DatabaseParameters = context.StringValue("MetastoreListDatabases.DatabaseList["+ i +"].DatabaseParameters");
				database.GmtCreate = context.LongValue("MetastoreListDatabases.DatabaseList["+ i +"].GmtCreate");
				database.GmtModified = context.LongValue("MetastoreListDatabases.DatabaseList["+ i +"].GmtModified");
				database.LocationType = context.StringValue("MetastoreListDatabases.DatabaseList["+ i +"].LocationType");
				database.DatabaseComment = context.StringValue("MetastoreListDatabases.DatabaseList["+ i +"].DatabaseComment");

				metastoreListDatabasesResponse_databaseList.Add(database);
			}
			metastoreListDatabasesResponse.DatabaseList = metastoreListDatabasesResponse_databaseList;
        
			return metastoreListDatabasesResponse;
        }
    }
}
