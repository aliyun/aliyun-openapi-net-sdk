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
    public class ListTablesResponseUnmarshaller
    {
        public static ListTablesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTablesResponse listTablesResponse = new ListTablesResponse();

			listTablesResponse.HttpResponse = _ctx.HttpResponse;
			listTablesResponse.TotalCount = _ctx.LongValue("ListTables.TotalCount");
			listTablesResponse.RequestId = _ctx.StringValue("ListTables.RequestId");
			listTablesResponse.ErrorCode = _ctx.StringValue("ListTables.ErrorCode");
			listTablesResponse.ErrorMessage = _ctx.StringValue("ListTables.ErrorMessage");
			listTablesResponse.Success = _ctx.BooleanValue("ListTables.Success");

			List<ListTablesResponse.ListTables_Table> listTablesResponse_tableList = new List<ListTablesResponse.ListTables_Table>();
			for (int i = 0; i < _ctx.Length("ListTables.TableList.Length"); i++) {
				ListTablesResponse.ListTables_Table table = new ListTablesResponse.ListTables_Table();
				table.DatabaseId = _ctx.StringValue("ListTables.TableList["+ i +"].DatabaseId");
				table.TableName = _ctx.StringValue("ListTables.TableList["+ i +"].TableName");
				table.StoreCapacity = _ctx.LongValue("ListTables.TableList["+ i +"].StoreCapacity");
				table.Description = _ctx.StringValue("ListTables.TableList["+ i +"].Description");
				table.Encoding = _ctx.StringValue("ListTables.TableList["+ i +"].Encoding");
				table.TableSchemaName = _ctx.StringValue("ListTables.TableList["+ i +"].TableSchemaName");
				table.TableType = _ctx.StringValue("ListTables.TableList["+ i +"].TableType");
				table.TableGuid = _ctx.StringValue("ListTables.TableList["+ i +"].TableGuid");
				table.Engine = _ctx.StringValue("ListTables.TableList["+ i +"].Engine");
				table.NumRows = _ctx.LongValue("ListTables.TableList["+ i +"].NumRows");
				table.TableId = _ctx.StringValue("ListTables.TableList["+ i +"].TableId");

				List<string> table_ownerIdList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListTables.TableList["+ i +"].OwnerIdList.Length"); j++) {
					table_ownerIdList.Add(_ctx.StringValue("ListTables.TableList["+ i +"].OwnerIdList["+ j +"]"));
				}
				table.OwnerIdList = table_ownerIdList;

				List<string> table_ownerNameList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListTables.TableList["+ i +"].OwnerNameList.Length"); j++) {
					table_ownerNameList.Add(_ctx.StringValue("ListTables.TableList["+ i +"].OwnerNameList["+ j +"]"));
				}
				table.OwnerNameList = table_ownerNameList;

				listTablesResponse_tableList.Add(table);
			}
			listTablesResponse.TableList = listTablesResponse_tableList;
        
			return listTablesResponse;
        }
    }
}
