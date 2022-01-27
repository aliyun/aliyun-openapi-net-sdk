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
    public class DescribeEmrHiveTableResponseUnmarshaller
    {
        public static DescribeEmrHiveTableResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEmrHiveTableResponse describeEmrHiveTableResponse = new DescribeEmrHiveTableResponse();

			describeEmrHiveTableResponse.HttpResponse = _ctx.HttpResponse;
			describeEmrHiveTableResponse.ErrorCode = _ctx.StringValue("DescribeEmrHiveTable.ErrorCode");
			describeEmrHiveTableResponse.ErrorMessage = _ctx.StringValue("DescribeEmrHiveTable.ErrorMessage");
			describeEmrHiveTableResponse.RequestId = _ctx.StringValue("DescribeEmrHiveTable.RequestId");

			DescribeEmrHiveTableResponse.DescribeEmrHiveTable_Data data = new DescribeEmrHiveTableResponse.DescribeEmrHiveTable_Data();
			data.ClusterBizId = _ctx.StringValue("DescribeEmrHiveTable.Data.ClusterBizId");
			data.TableName = _ctx.StringValue("DescribeEmrHiveTable.Data.TableName");
			data.TableType = _ctx.StringValue("DescribeEmrHiveTable.Data.TableType");
			data.Owner = _ctx.StringValue("DescribeEmrHiveTable.Data.Owner");
			data.OwnerType = _ctx.StringValue("DescribeEmrHiveTable.Data.OwnerType");
			data.IsTemporary = _ctx.BooleanValue("DescribeEmrHiveTable.Data.IsTemporary");
			data.SerializationLib = _ctx.StringValue("DescribeEmrHiveTable.Data.SerializationLib");
			data.InputFormat = _ctx.StringValue("DescribeEmrHiveTable.Data.InputFormat");
			data.OutputFormat = _ctx.StringValue("DescribeEmrHiveTable.Data.OutputFormat");
			data.Location = _ctx.StringValue("DescribeEmrHiveTable.Data.Location");
			data.LastAccessTime = _ctx.StringValue("DescribeEmrHiveTable.Data.LastAccessTime");
			data.GmtCreate = _ctx.StringValue("DescribeEmrHiveTable.Data.GmtCreate");
			data.GmtModified = _ctx.StringValue("DescribeEmrHiveTable.Data.GmtModified");
			data.TableComment = _ctx.StringValue("DescribeEmrHiveTable.Data.TableComment");
			data.TableParameters = _ctx.StringValue("DescribeEmrHiveTable.Data.TableParameters");
			data.PartitionKeys = _ctx.StringValue("DescribeEmrHiveTable.Data.PartitionKeys");
			data.IsCompressed = _ctx.BooleanValue("DescribeEmrHiveTable.Data.IsCompressed");
			data.ClusterBizName = _ctx.StringValue("DescribeEmrHiveTable.Data.ClusterBizName");
			data.DatabaseName = _ctx.StringValue("DescribeEmrHiveTable.Data.DatabaseName");
			data.OwnerId = _ctx.StringValue("DescribeEmrHiveTable.Data.OwnerId");
			data.TableDesc = _ctx.StringValue("DescribeEmrHiveTable.Data.TableDesc");
			data.LastModifyTime = _ctx.StringValue("DescribeEmrHiveTable.Data.LastModifyTime");
			data.TableSize = _ctx.LongValue("DescribeEmrHiveTable.Data.TableSize");

			List<DescribeEmrHiveTableResponse.DescribeEmrHiveTable_Data.DescribeEmrHiveTable_TableColumn> data_columns = new List<DescribeEmrHiveTableResponse.DescribeEmrHiveTable_Data.DescribeEmrHiveTable_TableColumn>();
			for (int i = 0; i < _ctx.Length("DescribeEmrHiveTable.Data.Columns.Length"); i++) {
				DescribeEmrHiveTableResponse.DescribeEmrHiveTable_Data.DescribeEmrHiveTable_TableColumn tableColumn = new DescribeEmrHiveTableResponse.DescribeEmrHiveTable_Data.DescribeEmrHiveTable_TableColumn();
				tableColumn.ColumnPosition = _ctx.IntegerValue("DescribeEmrHiveTable.Data.Columns["+ i +"].ColumnPosition");
				tableColumn.ColumnName = _ctx.StringValue("DescribeEmrHiveTable.Data.Columns["+ i +"].ColumnName");
				tableColumn.ColumnType = _ctx.StringValue("DescribeEmrHiveTable.Data.Columns["+ i +"].ColumnType");
				tableColumn.ColumnComment = _ctx.StringValue("DescribeEmrHiveTable.Data.Columns["+ i +"].ColumnComment");
				tableColumn.GmtCreate = _ctx.StringValue("DescribeEmrHiveTable.Data.Columns["+ i +"].GmtCreate");
				tableColumn.GmtModified = _ctx.StringValue("DescribeEmrHiveTable.Data.Columns["+ i +"].GmtModified");
				tableColumn.Comment = _ctx.StringValue("DescribeEmrHiveTable.Data.Columns["+ i +"].Comment");

				data_columns.Add(tableColumn);
			}
			data.Columns = data_columns;
			describeEmrHiveTableResponse.Data = data;
        
			return describeEmrHiveTableResponse;
        }
    }
}
