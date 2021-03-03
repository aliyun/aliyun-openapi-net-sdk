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
    public class ListEmrHiveTablesResponseUnmarshaller
    {
        public static ListEmrHiveTablesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEmrHiveTablesResponse listEmrHiveTablesResponse = new ListEmrHiveTablesResponse();

			listEmrHiveTablesResponse.HttpResponse = _ctx.HttpResponse;
			listEmrHiveTablesResponse.ErrorCode = _ctx.StringValue("ListEmrHiveTables.ErrorCode");
			listEmrHiveTablesResponse.ErrorMessage = _ctx.StringValue("ListEmrHiveTables.ErrorMessage");
			listEmrHiveTablesResponse.RequestId = _ctx.StringValue("ListEmrHiveTables.RequestId");

			ListEmrHiveTablesResponse.ListEmrHiveTables_Data data = new ListEmrHiveTablesResponse.ListEmrHiveTables_Data();
			data.PageNumber = _ctx.IntegerValue("ListEmrHiveTables.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListEmrHiveTables.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListEmrHiveTables.Data.TotalCount");

			List<ListEmrHiveTablesResponse.ListEmrHiveTables_Data.ListEmrHiveTables_HiveTables> data_pagedData = new List<ListEmrHiveTablesResponse.ListEmrHiveTables_Data.ListEmrHiveTables_HiveTables>();
			for (int i = 0; i < _ctx.Length("ListEmrHiveTables.Data.PagedData.Length"); i++) {
				ListEmrHiveTablesResponse.ListEmrHiveTables_Data.ListEmrHiveTables_HiveTables hiveTables = new ListEmrHiveTablesResponse.ListEmrHiveTables_Data.ListEmrHiveTables_HiveTables();
				hiveTables.ClusterBizId = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].ClusterBizId");
				hiveTables.TableName = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].TableName");
				hiveTables.TableType = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].TableType");
				hiveTables.Owner = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].Owner");
				hiveTables.OwnerType = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].OwnerType");
				hiveTables.IsTemporary = _ctx.BooleanValue("ListEmrHiveTables.Data.PagedData["+ i +"].IsTemporary");
				hiveTables.SerializationLib = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].SerializationLib");
				hiveTables.InputFormat = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].InputFormat");
				hiveTables.OutputFormat = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].OutputFormat");
				hiveTables.Location = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].Location");
				hiveTables.LastAccessTime = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].LastAccessTime");
				hiveTables.GmtCreate = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].GmtCreate");
				hiveTables.GmtModified = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].GmtModified");
				hiveTables.TableComment = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].TableComment");
				hiveTables.TableParameters = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].TableParameters");
				hiveTables.PartitionKeys = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].PartitionKeys");
				hiveTables.IsCompressed = _ctx.BooleanValue("ListEmrHiveTables.Data.PagedData["+ i +"].IsCompressed");
				hiveTables.ClusterBizName = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].ClusterBizName");
				hiveTables.DatabaseName = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].DatabaseName");
				hiveTables.OwnerId = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].OwnerId");
				hiveTables.LastModifyTime = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].LastModifyTime");
				hiveTables.TableDesc = _ctx.StringValue("ListEmrHiveTables.Data.PagedData["+ i +"].TableDesc");

				data_pagedData.Add(hiveTables);
			}
			data.PagedData = data_pagedData;
			listEmrHiveTablesResponse.Data = data;
        
			return listEmrHiveTablesResponse;
        }
    }
}
