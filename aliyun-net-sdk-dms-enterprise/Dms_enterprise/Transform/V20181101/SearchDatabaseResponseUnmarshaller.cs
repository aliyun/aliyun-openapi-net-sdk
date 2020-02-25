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
    public class SearchDatabaseResponseUnmarshaller
    {
        public static SearchDatabaseResponse Unmarshall(UnmarshallerContext context)
        {
			SearchDatabaseResponse searchDatabaseResponse = new SearchDatabaseResponse();

			searchDatabaseResponse.HttpResponse = context.HttpResponse;
			searchDatabaseResponse.RequestId = context.StringValue("SearchDatabase.RequestId");
			searchDatabaseResponse.Success = context.BooleanValue("SearchDatabase.Success");
			searchDatabaseResponse.ErrorMessage = context.StringValue("SearchDatabase.ErrorMessage");
			searchDatabaseResponse.ErrorCode = context.StringValue("SearchDatabase.ErrorCode");
			searchDatabaseResponse.TotalCount = context.LongValue("SearchDatabase.TotalCount");

			List<SearchDatabaseResponse.SearchDatabase_SearchDatabase> searchDatabaseResponse_searchDatabaseList = new List<SearchDatabaseResponse.SearchDatabase_SearchDatabase>();
			for (int i = 0; i < context.Length("SearchDatabase.SearchDatabaseList.Length"); i++) {
				SearchDatabaseResponse.SearchDatabase_SearchDatabase searchDatabase = new SearchDatabaseResponse.SearchDatabase_SearchDatabase();
				searchDatabase.DatabaseId = context.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].DatabaseId");
				searchDatabase.Logic = context.BooleanValue("SearchDatabase.SearchDatabaseList["+ i +"].Logic");
				searchDatabase.EnvType = context.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].EnvType");
				searchDatabase.SchemaName = context.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].SchemaName");
				searchDatabase.SearchName = context.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].SearchName");
				searchDatabase.DbType = context.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].DbType");
				searchDatabase.Host = context.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].Host");
				searchDatabase.Port = context.IntegerValue("SearchDatabase.SearchDatabaseList["+ i +"].Port");
				searchDatabase.Sid = context.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].Sid");
				searchDatabase.DbaId = context.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].DbaId");
				searchDatabase.Encoding = context.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].Encoding");
				searchDatabase.Alias = context.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].Alias");
				searchDatabase.DatalinkName = context.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].DatalinkName");

				List<string> searchDatabase_ownerIdList = new List<string>();
				for (int j = 0; j < context.Length("SearchDatabase.SearchDatabaseList["+ i +"].OwnerIdList.Length"); j++) {
					searchDatabase_ownerIdList.Add(context.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].OwnerIdList["+ j +"]"));
				}
				searchDatabase.OwnerIdList = searchDatabase_ownerIdList;

				List<string> searchDatabase_ownerNameList = new List<string>();
				for (int j = 0; j < context.Length("SearchDatabase.SearchDatabaseList["+ i +"].OwnerNameList.Length"); j++) {
					searchDatabase_ownerNameList.Add(context.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].OwnerNameList["+ j +"]"));
				}
				searchDatabase.OwnerNameList = searchDatabase_ownerNameList;

				searchDatabaseResponse_searchDatabaseList.Add(searchDatabase);
			}
			searchDatabaseResponse.SearchDatabaseList = searchDatabaseResponse_searchDatabaseList;
        
			return searchDatabaseResponse;
        }
    }
}
