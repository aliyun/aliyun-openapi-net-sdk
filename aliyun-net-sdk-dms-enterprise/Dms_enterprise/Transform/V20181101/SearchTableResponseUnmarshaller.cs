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
        public static SearchTableResponse Unmarshall(UnmarshallerContext context)
        {
			SearchTableResponse searchTableResponse = new SearchTableResponse();

			searchTableResponse.HttpResponse = context.HttpResponse;
			searchTableResponse.RequestId = context.StringValue("SearchTable.RequestId");
			searchTableResponse.Success = context.BooleanValue("SearchTable.Success");
			searchTableResponse.ErrorMessage = context.StringValue("SearchTable.ErrorMessage");
			searchTableResponse.ErrorCode = context.StringValue("SearchTable.ErrorCode");
			searchTableResponse.TotalCount = context.LongValue("SearchTable.TotalCount");

			List<SearchTableResponse.SearchTable_SearchTable> searchTableResponse_searchTableList = new List<SearchTableResponse.SearchTable_SearchTable>();
			for (int i = 0; i < context.Length("SearchTable.SearchTableList.Length"); i++) {
				SearchTableResponse.SearchTable_SearchTable searchTable = new SearchTableResponse.SearchTable_SearchTable();
				searchTable.TableId = context.StringValue("SearchTable.SearchTableList["+ i +"].TableId");
				searchTable.DatabaseId = context.StringValue("SearchTable.SearchTableList["+ i +"].DatabaseId");
				searchTable.TableName = context.StringValue("SearchTable.SearchTableList["+ i +"].TableName");
				searchTable.TableSchemaName = context.StringValue("SearchTable.SearchTableList["+ i +"].TableSchemaName");
				searchTable.Engine = context.StringValue("SearchTable.SearchTableList["+ i +"].Engine");
				searchTable.Encoding = context.StringValue("SearchTable.SearchTableList["+ i +"].Encoding");
				searchTable.Logic = context.BooleanValue("SearchTable.SearchTableList["+ i +"].Logic");
				searchTable.EnvType = context.StringValue("SearchTable.SearchTableList["+ i +"].EnvType");
				searchTable.DBSearchName = context.StringValue("SearchTable.SearchTableList["+ i +"].DBSearchName");

				List<string> searchTable_ownerIdList = new List<string>();
				for (int j = 0; j < context.Length("SearchTable.SearchTableList["+ i +"].OwnerIdList.Length"); j++) {
					searchTable_ownerIdList.Add(context.StringValue("SearchTable.SearchTableList["+ i +"].OwnerIdList["+ j +"]"));
				}
				searchTable.OwnerIdList = searchTable_ownerIdList;

				List<string> searchTable_ownerNameList = new List<string>();
				for (int j = 0; j < context.Length("SearchTable.SearchTableList["+ i +"].OwnerNameList.Length"); j++) {
					searchTable_ownerNameList.Add(context.StringValue("SearchTable.SearchTableList["+ i +"].OwnerNameList["+ j +"]"));
				}
				searchTable.OwnerNameList = searchTable_ownerNameList;

				searchTableResponse_searchTableList.Add(searchTable);
			}
			searchTableResponse.SearchTableList = searchTableResponse_searchTableList;
        
			return searchTableResponse;
        }
    }
}
