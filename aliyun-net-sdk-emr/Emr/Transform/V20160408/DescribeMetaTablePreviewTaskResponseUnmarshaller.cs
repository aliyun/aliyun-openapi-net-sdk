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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeMetaTablePreviewTaskResponseUnmarshaller
    {
        public static DescribeMetaTablePreviewTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMetaTablePreviewTaskResponse describeMetaTablePreviewTaskResponse = new DescribeMetaTablePreviewTaskResponse();

			describeMetaTablePreviewTaskResponse.HttpResponse = _ctx.HttpResponse;
			describeMetaTablePreviewTaskResponse.RequestId = _ctx.StringValue("DescribeMetaTablePreviewTask.RequestId");
			describeMetaTablePreviewTaskResponse.TaskId = _ctx.StringValue("DescribeMetaTablePreviewTask.TaskId");
			describeMetaTablePreviewTaskResponse.TaskStatus = _ctx.StringValue("DescribeMetaTablePreviewTask.TaskStatus");
			describeMetaTablePreviewTaskResponse.StartTime = _ctx.LongValue("DescribeMetaTablePreviewTask.StartTime");
			describeMetaTablePreviewTaskResponse.EndTime = _ctx.LongValue("DescribeMetaTablePreviewTask.EndTime");
			describeMetaTablePreviewTaskResponse.ExecuteTime = _ctx.LongValue("DescribeMetaTablePreviewTask.ExecuteTime");
			describeMetaTablePreviewTaskResponse.TaskProcess = _ctx.IntegerValue("DescribeMetaTablePreviewTask.TaskProcess");

			DescribeMetaTablePreviewTaskResponse.DescribeMetaTablePreviewTask_Data data = new DescribeMetaTablePreviewTaskResponse.DescribeMetaTablePreviewTask_Data();

			List<string> data_headers = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeMetaTablePreviewTask.Data.Headers.Length"); i++) {
				data_headers.Add(_ctx.StringValue("DescribeMetaTablePreviewTask.Data.Headers["+ i +"]"));
			}
			data.Headers = data_headers;

			List<DescribeMetaTablePreviewTaskResponse.DescribeMetaTablePreviewTask_Data.DescribeMetaTablePreviewTask_Row> data_rows = new List<DescribeMetaTablePreviewTaskResponse.DescribeMetaTablePreviewTask_Data.DescribeMetaTablePreviewTask_Row>();
			for (int i = 0; i < _ctx.Length("DescribeMetaTablePreviewTask.Data.Rows.Length"); i++) {
				DescribeMetaTablePreviewTaskResponse.DescribeMetaTablePreviewTask_Data.DescribeMetaTablePreviewTask_Row row = new DescribeMetaTablePreviewTaskResponse.DescribeMetaTablePreviewTask_Data.DescribeMetaTablePreviewTask_Row();

				List<string> row_columns = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeMetaTablePreviewTask.Data.Rows["+ i +"].Columns.Length"); j++) {
					row_columns.Add(_ctx.StringValue("DescribeMetaTablePreviewTask.Data.Rows["+ i +"].Columns["+ j +"]"));
				}
				row.Columns = row_columns;

				data_rows.Add(row);
			}
			data.Rows = data_rows;
			describeMetaTablePreviewTaskResponse.Data = data;
        
			return describeMetaTablePreviewTaskResponse;
        }
    }
}
