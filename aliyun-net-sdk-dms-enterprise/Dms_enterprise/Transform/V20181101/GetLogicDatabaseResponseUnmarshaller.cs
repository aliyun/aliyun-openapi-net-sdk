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
        public static GetLogicDatabaseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetLogicDatabaseResponse getLogicDatabaseResponse = new GetLogicDatabaseResponse();

			getLogicDatabaseResponse.HttpResponse = _ctx.HttpResponse;
			getLogicDatabaseResponse.RequestId = _ctx.StringValue("GetLogicDatabase.RequestId");
			getLogicDatabaseResponse.ErrorCode = _ctx.StringValue("GetLogicDatabase.ErrorCode");
			getLogicDatabaseResponse.ErrorMessage = _ctx.StringValue("GetLogicDatabase.ErrorMessage");
			getLogicDatabaseResponse.Success = _ctx.BooleanValue("GetLogicDatabase.Success");

			GetLogicDatabaseResponse.GetLogicDatabase_LogicDatabase logicDatabase = new GetLogicDatabaseResponse.GetLogicDatabase_LogicDatabase();
			logicDatabase.DatabaseId = _ctx.StringValue("GetLogicDatabase.LogicDatabase.DatabaseId");
			logicDatabase.DbType = _ctx.StringValue("GetLogicDatabase.LogicDatabase.DbType");
			logicDatabase.Logic = _ctx.BooleanValue("GetLogicDatabase.LogicDatabase.Logic");
			logicDatabase.SchemaName = _ctx.StringValue("GetLogicDatabase.LogicDatabase.SchemaName");
			logicDatabase.SearchName = _ctx.StringValue("GetLogicDatabase.LogicDatabase.SearchName");
			logicDatabase.EnvType = _ctx.StringValue("GetLogicDatabase.LogicDatabase.EnvType");

			List<string> logicDatabase_ownerIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetLogicDatabase.LogicDatabase.OwnerIdList.Length"); i++) {
				logicDatabase_ownerIdList.Add(_ctx.StringValue("GetLogicDatabase.LogicDatabase.OwnerIdList["+ i +"]"));
			}
			logicDatabase.OwnerIdList = logicDatabase_ownerIdList;

			List<string> logicDatabase_ownerNameList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetLogicDatabase.LogicDatabase.OwnerNameList.Length"); i++) {
				logicDatabase_ownerNameList.Add(_ctx.StringValue("GetLogicDatabase.LogicDatabase.OwnerNameList["+ i +"]"));
			}
			logicDatabase.OwnerNameList = logicDatabase_ownerNameList;
			getLogicDatabaseResponse.LogicDatabase = logicDatabase;
        
			return getLogicDatabaseResponse;
        }
    }
}
