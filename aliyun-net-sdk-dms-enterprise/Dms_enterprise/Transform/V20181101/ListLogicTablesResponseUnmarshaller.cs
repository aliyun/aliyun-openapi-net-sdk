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
    public class ListLogicTablesResponseUnmarshaller
    {
        public static ListLogicTablesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLogicTablesResponse listLogicTablesResponse = new ListLogicTablesResponse();

			listLogicTablesResponse.HttpResponse = _ctx.HttpResponse;
			listLogicTablesResponse.TotalCount = _ctx.LongValue("ListLogicTables.TotalCount");
			listLogicTablesResponse.RequestId = _ctx.StringValue("ListLogicTables.RequestId");
			listLogicTablesResponse.ErrorCode = _ctx.StringValue("ListLogicTables.ErrorCode");
			listLogicTablesResponse.ErrorMessage = _ctx.StringValue("ListLogicTables.ErrorMessage");
			listLogicTablesResponse.Success = _ctx.BooleanValue("ListLogicTables.Success");

			List<ListLogicTablesResponse.ListLogicTables_LogicTable> listLogicTablesResponse_logicTableList = new List<ListLogicTablesResponse.ListLogicTables_LogicTable>();
			for (int i = 0; i < _ctx.Length("ListLogicTables.LogicTableList.Length"); i++) {
				ListLogicTablesResponse.ListLogicTables_LogicTable logicTable = new ListLogicTablesResponse.ListLogicTables_LogicTable();
				logicTable.DatabaseId = _ctx.StringValue("ListLogicTables.LogicTableList["+ i +"].DatabaseId");
				logicTable.TableName = _ctx.StringValue("ListLogicTables.LogicTableList["+ i +"].TableName");
				logicTable.TableCount = _ctx.StringValue("ListLogicTables.LogicTableList["+ i +"].TableCount");
				logicTable.SchemaName = _ctx.StringValue("ListLogicTables.LogicTableList["+ i +"].SchemaName");
				logicTable.Logic = _ctx.BooleanValue("ListLogicTables.LogicTableList["+ i +"].Logic");
				logicTable.TableExpr = _ctx.StringValue("ListLogicTables.LogicTableList["+ i +"].TableExpr");
				logicTable.TableGuid = _ctx.StringValue("ListLogicTables.LogicTableList["+ i +"].TableGuid");
				logicTable.TableId = _ctx.StringValue("ListLogicTables.LogicTableList["+ i +"].TableId");

				List<string> logicTable_ownerIdList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListLogicTables.LogicTableList["+ i +"].OwnerIdList.Length"); j++) {
					logicTable_ownerIdList.Add(_ctx.StringValue("ListLogicTables.LogicTableList["+ i +"].OwnerIdList["+ j +"]"));
				}
				logicTable.OwnerIdList = logicTable_ownerIdList;

				List<string> logicTable_ownerNameList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListLogicTables.LogicTableList["+ i +"].OwnerNameList.Length"); j++) {
					logicTable_ownerNameList.Add(_ctx.StringValue("ListLogicTables.LogicTableList["+ i +"].OwnerNameList["+ j +"]"));
				}
				logicTable.OwnerNameList = logicTable_ownerNameList;

				listLogicTablesResponse_logicTableList.Add(logicTable);
			}
			listLogicTablesResponse.LogicTableList = listLogicTablesResponse_logicTableList;
        
			return listLogicTablesResponse;
        }
    }
}
