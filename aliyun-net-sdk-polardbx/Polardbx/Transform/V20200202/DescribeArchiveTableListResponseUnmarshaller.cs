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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeArchiveTableListResponseUnmarshaller
    {
        public static DescribeArchiveTableListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeArchiveTableListResponse describeArchiveTableListResponse = new DescribeArchiveTableListResponse();

			describeArchiveTableListResponse.HttpResponse = _ctx.HttpResponse;
			describeArchiveTableListResponse.RequestId = _ctx.StringValue("DescribeArchiveTableList.RequestId");

			DescribeArchiveTableListResponse.DescribeArchiveTableList_Data data = new DescribeArchiveTableListResponse.DescribeArchiveTableList_Data();
			data.Total = _ctx.LongValue("DescribeArchiveTableList.Data.Total");
			data.PageIndex = _ctx.LongValue("DescribeArchiveTableList.Data.PageIndex");
			data.PageSize = _ctx.LongValue("DescribeArchiveTableList.Data.PageSize");
			data.TobeArchivedConut = _ctx.IntegerValue("DescribeArchiveTableList.Data.TobeArchivedConut");
			data.RunningCount = _ctx.IntegerValue("DescribeArchiveTableList.Data.RunningCount");
			data.SuccessCount = _ctx.IntegerValue("DescribeArchiveTableList.Data.SuccessCount");
			data.PausedCount = _ctx.IntegerValue("DescribeArchiveTableList.Data.PausedCount");

			List<DescribeArchiveTableListResponse.DescribeArchiveTableList_Data.DescribeArchiveTableList_ArchiveTable> data_tables = new List<DescribeArchiveTableListResponse.DescribeArchiveTableList_Data.DescribeArchiveTableList_ArchiveTable>();
			for (int i = 0; i < _ctx.Length("DescribeArchiveTableList.Data.Tables.Length"); i++) {
				DescribeArchiveTableListResponse.DescribeArchiveTableList_Data.DescribeArchiveTableList_ArchiveTable archiveTable = new DescribeArchiveTableListResponse.DescribeArchiveTableList_Data.DescribeArchiveTableList_ArchiveTable();
				archiveTable.SchemaName = _ctx.StringValue("DescribeArchiveTableList.Data.Tables["+ i +"].SchemaName");
				archiveTable.TableName = _ctx.StringValue("DescribeArchiveTableList.Data.Tables["+ i +"].TableName");
				archiveTable.CreatedDate = _ctx.LongValue("DescribeArchiveTableList.Data.Tables["+ i +"].CreatedDate");
				archiveTable.SpaceSize = _ctx.DoubleValue("DescribeArchiveTableList.Data.Tables["+ i +"].SpaceSize");
				archiveTable.FileCount = _ctx.IntegerValue("DescribeArchiveTableList.Data.Tables["+ i +"].FileCount");
				archiveTable.LastSuccessArchiveTime = _ctx.LongValue("DescribeArchiveTableList.Data.Tables["+ i +"].LastSuccessArchiveTime");
				archiveTable.ArchiveStatus = _ctx.StringValue("DescribeArchiveTableList.Data.Tables["+ i +"].ArchiveStatus");

				data_tables.Add(archiveTable);
			}
			data.Tables = data_tables;
			describeArchiveTableListResponse.Data = data;
        
			return describeArchiveTableListResponse;
        }
    }
}
