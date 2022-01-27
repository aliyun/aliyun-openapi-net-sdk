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
        public static SearchDatabaseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchDatabaseResponse searchDatabaseResponse = new SearchDatabaseResponse();

			searchDatabaseResponse.HttpResponse = _ctx.HttpResponse;
			searchDatabaseResponse.TotalCount = _ctx.LongValue("SearchDatabase.TotalCount");
			searchDatabaseResponse.RequestId = _ctx.StringValue("SearchDatabase.RequestId");
			searchDatabaseResponse.ErrorCode = _ctx.StringValue("SearchDatabase.ErrorCode");
			searchDatabaseResponse.ErrorMessage = _ctx.StringValue("SearchDatabase.ErrorMessage");
			searchDatabaseResponse.Success = _ctx.BooleanValue("SearchDatabase.Success");

			List<SearchDatabaseResponse.SearchDatabase_SearchDatabase> searchDatabaseResponse_searchDatabaseList = new List<SearchDatabaseResponse.SearchDatabase_SearchDatabase>();
			for (int i = 0; i < _ctx.Length("SearchDatabase.SearchDatabaseList.Length"); i++) {
				SearchDatabaseResponse.SearchDatabase_SearchDatabase searchDatabase = new SearchDatabaseResponse.SearchDatabase_SearchDatabase();
				searchDatabase.DatabaseId = _ctx.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].DatabaseId");
				searchDatabase.Host = _ctx.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].Host");
				searchDatabase.DbaId = _ctx.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].DbaId");
				searchDatabase.SchemaName = _ctx.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].SchemaName");
				searchDatabase.Logic = _ctx.BooleanValue("SearchDatabase.SearchDatabaseList["+ i +"].Logic");
				searchDatabase.DatalinkName = _ctx.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].DatalinkName");
				searchDatabase.Port = _ctx.IntegerValue("SearchDatabase.SearchDatabaseList["+ i +"].Port");
				searchDatabase.EnvType = _ctx.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].EnvType");
				searchDatabase.Sid = _ctx.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].Sid");
				searchDatabase.Encoding = _ctx.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].Encoding");
				searchDatabase.DbType = _ctx.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].DbType");
				searchDatabase.SearchName = _ctx.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].SearchName");
				searchDatabase.Alias = _ctx.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].Alias");

				List<string> searchDatabase_ownerIdList = new List<string>();
				for (int j = 0; j < _ctx.Length("SearchDatabase.SearchDatabaseList["+ i +"].OwnerIdList.Length"); j++) {
					searchDatabase_ownerIdList.Add(_ctx.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].OwnerIdList["+ j +"]"));
				}
				searchDatabase.OwnerIdList = searchDatabase_ownerIdList;

				List<string> searchDatabase_ownerNameList = new List<string>();
				for (int j = 0; j < _ctx.Length("SearchDatabase.SearchDatabaseList["+ i +"].OwnerNameList.Length"); j++) {
					searchDatabase_ownerNameList.Add(_ctx.StringValue("SearchDatabase.SearchDatabaseList["+ i +"].OwnerNameList["+ j +"]"));
				}
				searchDatabase.OwnerNameList = searchDatabase_ownerNameList;

				searchDatabaseResponse_searchDatabaseList.Add(searchDatabase);
			}
			searchDatabaseResponse.SearchDatabaseList = searchDatabaseResponse_searchDatabaseList;
        
			return searchDatabaseResponse;
        }
    }
}
