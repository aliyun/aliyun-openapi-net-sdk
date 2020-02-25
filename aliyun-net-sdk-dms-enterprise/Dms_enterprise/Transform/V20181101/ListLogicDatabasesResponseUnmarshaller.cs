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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class ListLogicDatabasesResponseUnmarshaller
    {
        public static ListLogicDatabasesResponse Unmarshall(UnmarshallerContext context)
        {
			ListLogicDatabasesResponse listLogicDatabasesResponse = new ListLogicDatabasesResponse();

			listLogicDatabasesResponse.HttpResponse = context.HttpResponse;
			listLogicDatabasesResponse.RequestId = context.StringValue("ListLogicDatabases.RequestId");
			listLogicDatabasesResponse.Success = context.BooleanValue("ListLogicDatabases.Success");
			listLogicDatabasesResponse.ErrorMessage = context.StringValue("ListLogicDatabases.ErrorMessage");
			listLogicDatabasesResponse.ErrorCode = context.StringValue("ListLogicDatabases.ErrorCode");
			listLogicDatabasesResponse.TotalCount = context.LongValue("ListLogicDatabases.TotalCount");

			List<ListLogicDatabasesResponse.ListLogicDatabases_LogicDatabase> listLogicDatabasesResponse_logicDatabaseList = new List<ListLogicDatabasesResponse.ListLogicDatabases_LogicDatabase>();
			for (int i = 0; i < context.Length("ListLogicDatabases.LogicDatabaseList.Length"); i++) {
				ListLogicDatabasesResponse.ListLogicDatabases_LogicDatabase logicDatabase = new ListLogicDatabasesResponse.ListLogicDatabases_LogicDatabase();
				logicDatabase.Logic = context.BooleanValue("ListLogicDatabases.LogicDatabaseList["+ i +"].Logic");
				logicDatabase.DatabaseId = context.StringValue("ListLogicDatabases.LogicDatabaseList["+ i +"].DatabaseId");
				logicDatabase.EnvType = context.StringValue("ListLogicDatabases.LogicDatabaseList["+ i +"].EnvType");
				logicDatabase.SchemaName = context.StringValue("ListLogicDatabases.LogicDatabaseList["+ i +"].SchemaName");
				logicDatabase.SearchName = context.StringValue("ListLogicDatabases.LogicDatabaseList["+ i +"].SearchName");
				logicDatabase.DbType = context.StringValue("ListLogicDatabases.LogicDatabaseList["+ i +"].DbType");

				List<string> logicDatabase_ownerIdList = new List<string>();
				for (int j = 0; j < context.Length("ListLogicDatabases.LogicDatabaseList["+ i +"].OwnerIdList.Length"); j++) {
					logicDatabase_ownerIdList.Add(context.StringValue("ListLogicDatabases.LogicDatabaseList["+ i +"].OwnerIdList["+ j +"]"));
				}
				logicDatabase.OwnerIdList = logicDatabase_ownerIdList;

				List<string> logicDatabase_ownerNameList = new List<string>();
				for (int j = 0; j < context.Length("ListLogicDatabases.LogicDatabaseList["+ i +"].OwnerNameList.Length"); j++) {
					logicDatabase_ownerNameList.Add(context.StringValue("ListLogicDatabases.LogicDatabaseList["+ i +"].OwnerNameList["+ j +"]"));
				}
				logicDatabase.OwnerNameList = logicDatabase_ownerNameList;

				listLogicDatabasesResponse_logicDatabaseList.Add(logicDatabase);
			}
			listLogicDatabasesResponse.LogicDatabaseList = listLogicDatabasesResponse_logicDatabaseList;
        
			return listLogicDatabasesResponse;
        }
    }
}
