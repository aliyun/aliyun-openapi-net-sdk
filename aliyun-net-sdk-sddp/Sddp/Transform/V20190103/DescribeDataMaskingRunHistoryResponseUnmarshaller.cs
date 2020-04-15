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
        public static DescribeDataMaskingRunHistoryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataMaskingRunHistoryResponse describeDataMaskingRunHistoryResponse = new DescribeDataMaskingRunHistoryResponse();

			describeDataMaskingRunHistoryResponse.HttpResponse = context.HttpResponse;
			describeDataMaskingRunHistoryResponse.RequestId = context.StringValue("DescribeDataMaskingRunHistory.RequestId");
			describeDataMaskingRunHistoryResponse.PageSize = context.IntegerValue("DescribeDataMaskingRunHistory.PageSize");
			describeDataMaskingRunHistoryResponse.CurrentPage = context.IntegerValue("DescribeDataMaskingRunHistory.CurrentPage");
			describeDataMaskingRunHistoryResponse.TotalCount = context.IntegerValue("DescribeDataMaskingRunHistory.TotalCount");

			List<DescribeDataMaskingRunHistoryResponse.DescribeDataMaskingRunHistory_Task> describeDataMaskingRunHistoryResponse_items = new List<DescribeDataMaskingRunHistoryResponse.DescribeDataMaskingRunHistory_Task>();
			for (int i = 0; i < context.Length("DescribeDataMaskingRunHistory.Items.Length"); i++) {
				DescribeDataMaskingRunHistoryResponse.DescribeDataMaskingRunHistory_Task task = new DescribeDataMaskingRunHistoryResponse.DescribeDataMaskingRunHistory_Task();
				task.Id = context.LongValue("DescribeDataMaskingRunHistory.Items["+ i +"].Id");
				task.TaskId = context.StringValue("DescribeDataMaskingRunHistory.Items["+ i +"].TaskId");
				task.StartTime = context.LongValue("DescribeDataMaskingRunHistory.Items["+ i +"].StartTime");
				task.RunIndex = context.IntegerValue("DescribeDataMaskingRunHistory.Items["+ i +"].RunIndex");
				task.Type = context.IntegerValue("DescribeDataMaskingRunHistory.Items["+ i +"].Type");
				task.DstType = context.IntegerValue("DescribeDataMaskingRunHistory.Items["+ i +"].DstType");
				task.Percentage = context.IntegerValue("DescribeDataMaskingRunHistory.Items["+ i +"].Percentage");
				task.SrcType = context.IntegerValue("DescribeDataMaskingRunHistory.Items["+ i +"].SrcType");
				task.MaskingCount = context.LongValue("DescribeDataMaskingRunHistory.Items["+ i +"].MaskingCount");
				task.ConflictCount = context.LongValue("DescribeDataMaskingRunHistory.Items["+ i +"].ConflictCount");
				task.Status = context.IntegerValue("DescribeDataMaskingRunHistory.Items["+ i +"].Status");
				task.FailCode = context.StringValue("DescribeDataMaskingRunHistory.Items["+ i +"].FailCode");
				task.DstTypeCode = context.StringValue("DescribeDataMaskingRunHistory.Items["+ i +"].DstTypeCode");
				task.SrcTypeCode = context.StringValue("DescribeDataMaskingRunHistory.Items["+ i +"].SrcTypeCode");

				describeDataMaskingRunHistoryResponse_items.Add(task);
			}
			describeDataMaskingRunHistoryResponse.Items = describeDataMaskingRunHistoryResponse_items;
        
			return describeDataMaskingRunHistoryResponse;
        }
    }
}
