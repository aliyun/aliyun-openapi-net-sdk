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
    public class GetLogicDatabaseResponseUnmarshaller
    {
        public static GetLogicDatabaseResponse Unmarshall(UnmarshallerContext context)
        {
			GetLogicDatabaseResponse getLogicDatabaseResponse = new GetLogicDatabaseResponse();

			getLogicDatabaseResponse.HttpResponse = context.HttpResponse;
			getLogicDatabaseResponse.RequestId = context.StringValue("GetLogicDatabase.RequestId");
			getLogicDatabaseResponse.Success = context.BooleanValue("GetLogicDatabase.Success");
			getLogicDatabaseResponse.ErrorMessage = context.StringValue("GetLogicDatabase.ErrorMessage");
			getLogicDatabaseResponse.ErrorCode = context.StringValue("GetLogicDatabase.ErrorCode");

			GetLogicDatabaseResponse.GetLogicDatabase_LogicDatabase logicDatabase = new GetLogicDatabaseResponse.GetLogicDatabase_LogicDatabase();
			logicDatabase.Logic = context.BooleanValue("GetLogicDatabase.LogicDatabase.Logic");
			logicDatabase.EnvType = context.StringValue("GetLogicDatabase.LogicDatabase.EnvType");
			logicDatabase.SchemaName = context.StringValue("GetLogicDatabase.LogicDatabase.SchemaName");
			logicDatabase.SearchName = context.StringValue("GetLogicDatabase.LogicDatabase.SearchName");
			logicDatabase.DbType = context.StringValue("GetLogicDatabase.LogicDatabase.DbType");
			logicDatabase.DatabaseId = context.StringValue("GetLogicDatabase.LogicDatabase.DatabaseId");

			List<string> logicDatabase_ownerIdList = new List<string>();
			for (int i = 0; i < context.Length("GetLogicDatabase.LogicDatabase.OwnerIdList.Length"); i++) {
				logicDatabase_ownerIdList.Add(context.StringValue("GetLogicDatabase.LogicDatabase.OwnerIdList["+ i +"]"));
			}
			logicDatabase.OwnerIdList = logicDatabase_ownerIdList;

			List<string> logicDatabase_ownerNameList = new List<string>();
			for (int i = 0; i < context.Length("GetLogicDatabase.LogicDatabase.OwnerNameList.Length"); i++) {
				logicDatabase_ownerNameList.Add(context.StringValue("GetLogicDatabase.LogicDatabase.OwnerNameList["+ i +"]"));
			}
			logicDatabase.OwnerNameList = logicDatabase_ownerNameList;
			getLogicDatabaseResponse.LogicDatabase = logicDatabase;
        
			return getLogicDatabaseResponse;
        }
    }
}
