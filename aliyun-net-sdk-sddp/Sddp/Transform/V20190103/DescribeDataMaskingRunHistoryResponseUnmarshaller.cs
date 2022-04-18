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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeDataMaskingRunHistoryResponseUnmarshaller
    {
        public static DescribeDataMaskingRunHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataMaskingRunHistoryResponse describeDataMaskingRunHistoryResponse = new DescribeDataMaskingRunHistoryResponse();

			describeDataMaskingRunHistoryResponse.HttpResponse = _ctx.HttpResponse;
			describeDataMaskingRunHistoryResponse.CurrentPage = _ctx.IntegerValue("DescribeDataMaskingRunHistory.CurrentPage");
			describeDataMaskingRunHistoryResponse.RequestId = _ctx.StringValue("DescribeDataMaskingRunHistory.RequestId");
			describeDataMaskingRunHistoryResponse.PageSize = _ctx.IntegerValue("DescribeDataMaskingRunHistory.PageSize");
			describeDataMaskingRunHistoryResponse.TotalCount = _ctx.IntegerValue("DescribeDataMaskingRunHistory.TotalCount");

			List<DescribeDataMaskingRunHistoryResponse.DescribeDataMaskingRunHistory_Task> describeDataMaskingRunHistoryResponse_items = new List<DescribeDataMaskingRunHistoryResponse.DescribeDataMaskingRunHistory_Task>();
			for (int i = 0; i < _ctx.Length("DescribeDataMaskingRunHistory.Items.Length"); i++) {
				DescribeDataMaskingRunHistoryResponse.DescribeDataMaskingRunHistory_Task task = new DescribeDataMaskingRunHistoryResponse.DescribeDataMaskingRunHistory_Task();
				task.Status = _ctx.IntegerValue("DescribeDataMaskingRunHistory.Items["+ i +"].Status");
				task.Type = _ctx.IntegerValue("DescribeDataMaskingRunHistory.Items["+ i +"].Type");
				task.SrcType = _ctx.IntegerValue("DescribeDataMaskingRunHistory.Items["+ i +"].SrcType");
				task.SrcTableName = _ctx.StringValue("DescribeDataMaskingRunHistory.Items["+ i +"].SrcTableName");
				task.MaskingCount = _ctx.LongValue("DescribeDataMaskingRunHistory.Items["+ i +"].MaskingCount");
				task.Percentage = _ctx.IntegerValue("DescribeDataMaskingRunHistory.Items["+ i +"].Percentage");
				task.DstType = _ctx.IntegerValue("DescribeDataMaskingRunHistory.Items["+ i +"].DstType");
				task.FailMsg = _ctx.StringValue("DescribeDataMaskingRunHistory.Items["+ i +"].FailMsg");
				task.FailCode = _ctx.StringValue("DescribeDataMaskingRunHistory.Items["+ i +"].FailCode");
				task.ConflictCount = _ctx.LongValue("DescribeDataMaskingRunHistory.Items["+ i +"].ConflictCount");
				task.DstTypeCode = _ctx.StringValue("DescribeDataMaskingRunHistory.Items["+ i +"].DstTypeCode");
				task.EndTime = _ctx.LongValue("DescribeDataMaskingRunHistory.Items["+ i +"].EndTime");
				task.RunIndex = _ctx.IntegerValue("DescribeDataMaskingRunHistory.Items["+ i +"].RunIndex");
				task.StartTime = _ctx.LongValue("DescribeDataMaskingRunHistory.Items["+ i +"].StartTime");
				task.HasSubProcess = _ctx.IntegerValue("DescribeDataMaskingRunHistory.Items["+ i +"].HasSubProcess");
				task.HasDownloadFile = _ctx.IntegerValue("DescribeDataMaskingRunHistory.Items["+ i +"].HasDownloadFile");
				task.TaskId = _ctx.StringValue("DescribeDataMaskingRunHistory.Items["+ i +"].TaskId");
				task.SrcTypeCode = _ctx.StringValue("DescribeDataMaskingRunHistory.Items["+ i +"].SrcTypeCode");
				task.Id = _ctx.LongValue("DescribeDataMaskingRunHistory.Items["+ i +"].Id");

				describeDataMaskingRunHistoryResponse_items.Add(task);
			}
			describeDataMaskingRunHistoryResponse.Items = describeDataMaskingRunHistoryResponse_items;
        
			return describeDataMaskingRunHistoryResponse;
        }
    }
}
