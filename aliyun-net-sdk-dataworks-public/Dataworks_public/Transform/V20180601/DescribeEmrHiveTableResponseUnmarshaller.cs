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
        public static DescribeEmrHiveTableResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEmrHiveTableResponse describeEmrHiveTableResponse = new DescribeEmrHiveTableResponse();

			describeEmrHiveTableResponse.HttpResponse = context.HttpResponse;
			describeEmrHiveTableResponse.ErrorCode = context.StringValue("DescribeEmrHiveTable.ErrorCode");
			describeEmrHiveTableResponse.ErrorMessage = context.StringValue("DescribeEmrHiveTable.ErrorMessage");
			describeEmrHiveTableResponse.RequestId = context.StringValue("DescribeEmrHiveTable.RequestId");

			DescribeEmrHiveTableResponse.DescribeEmrHiveTable_Data data = new DescribeEmrHiveTableResponse.DescribeEmrHiveTable_Data();
			data.ClusterBizId = context.StringValue("DescribeEmrHiveTable.Data.ClusterBizId");
			data.TableName = context.StringValue("DescribeEmrHiveTable.Data.TableName");
			data.TableType = context.StringValue("DescribeEmrHiveTable.Data.TableType");
			data.Owner = context.StringValue("DescribeEmrHiveTable.Data.Owner");
			data.OwnerType = context.StringValue("DescribeEmrHiveTable.Data.OwnerType");
			data.IsTemporary = context.BooleanValue("DescribeEmrHiveTable.Data.IsTemporary");
			data.SerializationLib = context.StringValue("DescribeEmrHiveTable.Data.SerializationLib");
			data.InputFormat = context.StringValue("DescribeEmrHiveTable.Data.InputFormat");
			data.OutputFormat = context.StringValue("DescribeEmrHiveTable.Data.OutputFormat");
			data.Location = context.StringValue("DescribeEmrHiveTable.Data.Location");
			data.LastAccessTime = context.StringValue("DescribeEmrHiveTable.Data.LastAccessTime");
			data.GmtCreate = context.StringValue("DescribeEmrHiveTable.Data.GmtCreate");
			data.GmtModified = context.StringValue("DescribeEmrHiveTable.Data.GmtModified");
			data.TableComment = context.StringValue("DescribeEmrHiveTable.Data.TableComment");
			data.TableParameters = context.StringValue("DescribeEmrHiveTable.Data.TableParameters");
			data.PartitionKeys = context.StringValue("DescribeEmrHiveTable.Data.PartitionKeys");
			data.IsCompressed = context.BooleanValue("DescribeEmrHiveTable.Data.IsCompressed");
			data.ClusterBizName = context.StringValue("DescribeEmrHiveTable.Data.ClusterBizName");
			data.DatabaseName = context.StringValue("DescribeEmrHiveTable.Data.DatabaseName");
			data.OwnerId = context.StringValue("DescribeEmrHiveTable.Data.OwnerId");
			data.TableDesc = context.StringValue("DescribeEmrHiveTable.Data.TableDesc");
			data.LastModifyTime = context.StringValue("DescribeEmrHiveTable.Data.LastModifyTime");
			data.TableSize = context.LongValue("DescribeEmrHiveTable.Data.TableSize");

			List<DescribeEmrHiveTableResponse.DescribeEmrHiveTable_Data.DescribeEmrHiveTable_TableColumn> data_columns = new List<DescribeEmrHiveTableResponse.DescribeEmrHiveTable_Data.DescribeEmrHiveTable_TableColumn>();
			for (int i = 0; i < context.Length("DescribeEmrHiveTable.Data.Columns.Length"); i++) {
				DescribeEmrHiveTableResponse.DescribeEmrHiveTable_Data.DescribeEmrHiveTable_TableColumn tableColumn = new DescribeEmrHiveTableResponse.DescribeEmrHiveTable_Data.DescribeEmrHiveTable_TableColumn();
				tableColumn.ColumnPosition = context.IntegerValue("DescribeEmrHiveTable.Data.Columns["+ i +"].ColumnPosition");
				tableColumn.ColumnName = context.StringValue("DescribeEmrHiveTable.Data.Columns["+ i +"].ColumnName");
				tableColumn.ColumnType = context.StringValue("DescribeEmrHiveTable.Data.Columns["+ i +"].ColumnType");
				tableColumn.ColumnComment = context.StringValue("DescribeEmrHiveTable.Data.Columns["+ i +"].ColumnComment");
				tableColumn.GmtCreate = context.StringValue("DescribeEmrHiveTable.Data.Columns["+ i +"].GmtCreate");
				tableColumn.GmtModified = context.StringValue("DescribeEmrHiveTable.Data.Columns["+ i +"].GmtModified");
				tableColumn.Comment = context.StringValue("DescribeEmrHiveTable.Data.Columns["+ i +"].Comment");

				data_columns.Add(tableColumn);
			}
			data.Columns = data_columns;
			describeEmrHiveTableResponse.Data = data;
        
			return describeEmrHiveTableResponse;
        }
    }
}
