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
        public static ListLogicDatabasesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLogicDatabasesResponse listLogicDatabasesResponse = new ListLogicDatabasesResponse();

			listLogicDatabasesResponse.HttpResponse = _ctx.HttpResponse;
			listLogicDatabasesResponse.TotalCount = _ctx.LongValue("ListLogicDatabases.TotalCount");
			listLogicDatabasesResponse.RequestId = _ctx.StringValue("ListLogicDatabases.RequestId");
			listLogicDatabasesResponse.ErrorCode = _ctx.StringValue("ListLogicDatabases.ErrorCode");
			listLogicDatabasesResponse.ErrorMessage = _ctx.StringValue("ListLogicDatabases.ErrorMessage");
			listLogicDatabasesResponse.Success = _ctx.BooleanValue("ListLogicDatabases.Success");

			List<ListLogicDatabasesResponse.ListLogicDatabases_LogicDatabase> listLogicDatabasesResponse_logicDatabaseList = new List<ListLogicDatabasesResponse.ListLogicDatabases_LogicDatabase>();
			for (int i = 0; i < _ctx.Length("ListLogicDatabases.LogicDatabaseList.Length"); i++) {
				ListLogicDatabasesResponse.ListLogicDatabases_LogicDatabase logicDatabase = new ListLogicDatabasesResponse.ListLogicDatabases_LogicDatabase();
				logicDatabase.DatabaseId = _ctx.StringValue("ListLogicDatabases.LogicDatabaseList["+ i +"].DatabaseId");
				logicDatabase.DbType = _ctx.StringValue("ListLogicDatabases.LogicDatabaseList["+ i +"].DbType");
				logicDatabase.Logic = _ctx.BooleanValue("ListLogicDatabases.LogicDatabaseList["+ i +"].Logic");
				logicDatabase.SchemaName = _ctx.StringValue("ListLogicDatabases.LogicDatabaseList["+ i +"].SchemaName");
				logicDatabase.SearchName = _ctx.StringValue("ListLogicDatabases.LogicDatabaseList["+ i +"].SearchName");
				logicDatabase.EnvType = _ctx.StringValue("ListLogicDatabases.LogicDatabaseList["+ i +"].EnvType");

				List<string> logicDatabase_ownerIdList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListLogicDatabases.LogicDatabaseList["+ i +"].OwnerIdList.Length"); j++) {
					logicDatabase_ownerIdList.Add(_ctx.StringValue("ListLogicDatabases.LogicDatabaseList["+ i +"].OwnerIdList["+ j +"]"));
				}
				logicDatabase.OwnerIdList = logicDatabase_ownerIdList;

				List<string> logicDatabase_ownerNameList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListLogicDatabases.LogicDatabaseList["+ i +"].OwnerNameList.Length"); j++) {
					logicDatabase_ownerNameList.Add(_ctx.StringValue("ListLogicDatabases.LogicDatabaseList["+ i +"].OwnerNameList["+ j +"]"));
				}
				logicDatabase.OwnerNameList = logicDatabase_ownerNameList;

				listLogicDatabasesResponse_logicDatabaseList.Add(logicDatabase);
			}
			listLogicDatabasesResponse.LogicDatabaseList = listLogicDatabasesResponse_logicDatabaseList;
        
			return listLogicDatabasesResponse;
        }
    }
}
