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
    public class SearchTableResponseUnmarshaller
    {
        public static SearchTableResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchTableResponse searchTableResponse = new SearchTableResponse();

			searchTableResponse.HttpResponse = _ctx.HttpResponse;
			searchTableResponse.TotalCount = _ctx.LongValue("SearchTable.TotalCount");
			searchTableResponse.RequestId = _ctx.StringValue("SearchTable.RequestId");
			searchTableResponse.ErrorCode = _ctx.StringValue("SearchTable.ErrorCode");
			searchTableResponse.ErrorMessage = _ctx.StringValue("SearchTable.ErrorMessage");
			searchTableResponse.Success = _ctx.BooleanValue("SearchTable.Success");

			List<SearchTableResponse.SearchTable_SearchTable> searchTableResponse_searchTableList = new List<SearchTableResponse.SearchTable_SearchTable>();
			for (int i = 0; i < _ctx.Length("SearchTable.SearchTableList.Length"); i++) {
				SearchTableResponse.SearchTable_SearchTable searchTable = new SearchTableResponse.SearchTable_SearchTable();
				searchTable.DatabaseId = _ctx.StringValue("SearchTable.SearchTableList["+ i +"].DatabaseId");
				searchTable.TableName = _ctx.StringValue("SearchTable.SearchTableList["+ i +"].TableName");
				searchTable.DBSearchName = _ctx.StringValue("SearchTable.SearchTableList["+ i +"].DBSearchName");
				searchTable.Logic = _ctx.BooleanValue("SearchTable.SearchTableList["+ i +"].Logic");
				searchTable.EnvType = _ctx.StringValue("SearchTable.SearchTableList["+ i +"].EnvType");
				searchTable.DbName = _ctx.StringValue("SearchTable.SearchTableList["+ i +"].DbName");
				searchTable.Description = _ctx.StringValue("SearchTable.SearchTableList["+ i +"].Description");
				searchTable.Encoding = _ctx.StringValue("SearchTable.SearchTableList["+ i +"].Encoding");
				searchTable.DbType = _ctx.StringValue("SearchTable.SearchTableList["+ i +"].DbType");
				searchTable.TableSchemaName = _ctx.StringValue("SearchTable.SearchTableList["+ i +"].TableSchemaName");
				searchTable.TableGuid = _ctx.StringValue("SearchTable.SearchTableList["+ i +"].TableGuid");
				searchTable.Engine = _ctx.StringValue("SearchTable.SearchTableList["+ i +"].Engine");
				searchTable.TableId = _ctx.StringValue("SearchTable.SearchTableList["+ i +"].TableId");

				List<string> searchTable_ownerIdList = new List<string>();
				for (int j = 0; j < _ctx.Length("SearchTable.SearchTableList["+ i +"].OwnerIdList.Length"); j++) {
					searchTable_ownerIdList.Add(_ctx.StringValue("SearchTable.SearchTableList["+ i +"].OwnerIdList["+ j +"]"));
				}
				searchTable.OwnerIdList = searchTable_ownerIdList;

				List<string> searchTable_ownerNameList = new List<string>();
				for (int j = 0; j < _ctx.Length("SearchTable.SearchTableList["+ i +"].OwnerNameList.Length"); j++) {
					searchTable_ownerNameList.Add(_ctx.StringValue("SearchTable.SearchTableList["+ i +"].OwnerNameList["+ j +"]"));
				}
				searchTable.OwnerNameList = searchTable_ownerNameList;

				searchTableResponse_searchTableList.Add(searchTable);
			}
			searchTableResponse.SearchTableList = searchTableResponse_searchTableList;
        
			return searchTableResponse;
        }
    }
}
