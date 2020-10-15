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
using Aliyun.Acs.dataworks_public.Model.V20180601;

namespace Aliyun.Acs.dataworks_public.Transform.V20180601
{
    public class ListEmrHiveDatabasesResponseUnmarshaller
    {
        public static ListEmrHiveDatabasesResponse Unmarshall(UnmarshallerContext context)
        {
			ListEmrHiveDatabasesResponse listEmrHiveDatabasesResponse = new ListEmrHiveDatabasesResponse();

			listEmrHiveDatabasesResponse.HttpResponse = context.HttpResponse;
			listEmrHiveDatabasesResponse.ErrorCode = context.StringValue("ListEmrHiveDatabases.ErrorCode");
			listEmrHiveDatabasesResponse.ErrorMessage = context.StringValue("ListEmrHiveDatabases.ErrorMessage");
			listEmrHiveDatabasesResponse.RequestId = context.StringValue("ListEmrHiveDatabases.RequestId");

			List<ListEmrHiveDatabasesResponse.ListEmrHiveDatabases_HiveDatabase> listEmrHiveDatabasesResponse_data = new List<ListEmrHiveDatabasesResponse.ListEmrHiveDatabases_HiveDatabase>();
			for (int i = 0; i < context.Length("ListEmrHiveDatabases.Data.Length"); i++) {
				ListEmrHiveDatabasesResponse.ListEmrHiveDatabases_HiveDatabase hiveDatabase = new ListEmrHiveDatabasesResponse.ListEmrHiveDatabases_HiveDatabase();
				hiveDatabase.Name = context.StringValue("ListEmrHiveDatabases.Data["+ i +"].Name");
				hiveDatabase.Type = context.StringValue("ListEmrHiveDatabases.Data["+ i +"].Type");
				hiveDatabase.Owner = context.StringValue("ListEmrHiveDatabases.Data["+ i +"].Owner");
				hiveDatabase.OwnerId = context.StringValue("ListEmrHiveDatabases.Data["+ i +"].OwnerId");
				hiveDatabase.Comment = context.StringValue("ListEmrHiveDatabases.Data["+ i +"].Comment");
				hiveDatabase.Location = context.StringValue("ListEmrHiveDatabases.Data["+ i +"].Location");
				hiveDatabase.Status = context.StringValue("ListEmrHiveDatabases.Data["+ i +"].Status");
				hiveDatabase.Parameters = context.StringValue("ListEmrHiveDatabases.Data["+ i +"].Parameters");
				hiveDatabase.GmtCreate = context.LongValue("ListEmrHiveDatabases.Data["+ i +"].GmtCreate");
				hiveDatabase.GmtModified = context.LongValue("ListEmrHiveDatabases.Data["+ i +"].GmtModified");
				hiveDatabase.OwnerType = context.StringValue("ListEmrHiveDatabases.Data["+ i +"].OwnerType");
				hiveDatabase.Region = context.StringValue("ListEmrHiveDatabases.Data["+ i +"].Region");

				listEmrHiveDatabasesResponse_data.Add(hiveDatabase);
			}
			listEmrHiveDatabasesResponse.Data = listEmrHiveDatabasesResponse_data;
        
			return listEmrHiveDatabasesResponse;
        }
    }
}
