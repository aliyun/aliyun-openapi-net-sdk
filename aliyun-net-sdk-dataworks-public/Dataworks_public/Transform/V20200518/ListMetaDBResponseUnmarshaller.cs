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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListMetaDBResponseUnmarshaller
    {
        public static ListMetaDBResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMetaDBResponse listMetaDBResponse = new ListMetaDBResponse();

			listMetaDBResponse.HttpResponse = _ctx.HttpResponse;
			listMetaDBResponse.RequestId = _ctx.StringValue("ListMetaDB.RequestId");

			ListMetaDBResponse.ListMetaDB_DatabaseInfo databaseInfo = new ListMetaDBResponse.ListMetaDB_DatabaseInfo();
			databaseInfo.TotalCount = _ctx.LongValue("ListMetaDB.DatabaseInfo.TotalCount");

			List<ListMetaDBResponse.ListMetaDB_DatabaseInfo.ListMetaDB_DbListItem> databaseInfo_dbList = new List<ListMetaDBResponse.ListMetaDB_DatabaseInfo.ListMetaDB_DbListItem>();
			for (int i = 0; i < _ctx.Length("ListMetaDB.DatabaseInfo.DbList.Length"); i++) {
				ListMetaDBResponse.ListMetaDB_DatabaseInfo.ListMetaDB_DbListItem dbListItem = new ListMetaDBResponse.ListMetaDB_DatabaseInfo.ListMetaDB_DbListItem();
				dbListItem.Name = _ctx.StringValue("ListMetaDB.DatabaseInfo.DbList["+ i +"].Name");
				dbListItem.Type = _ctx.StringValue("ListMetaDB.DatabaseInfo.DbList["+ i +"].Type");
				dbListItem.OwnerId = _ctx.StringValue("ListMetaDB.DatabaseInfo.DbList["+ i +"].OwnerId");
				dbListItem.Location = _ctx.StringValue("ListMetaDB.DatabaseInfo.DbList["+ i +"].Location");
				dbListItem.CreateTimeStamp = _ctx.LongValue("ListMetaDB.DatabaseInfo.DbList["+ i +"].CreateTimeStamp");
				dbListItem.ModifiedTimeStamp = _ctx.LongValue("ListMetaDB.DatabaseInfo.DbList["+ i +"].ModifiedTimeStamp");
				dbListItem.UUID = _ctx.StringValue("ListMetaDB.DatabaseInfo.DbList["+ i +"].UUID");

				databaseInfo_dbList.Add(dbListItem);
			}
			databaseInfo.DbList = databaseInfo_dbList;
			listMetaDBResponse.DatabaseInfo = databaseInfo;
        
			return listMetaDBResponse;
        }
    }
}
