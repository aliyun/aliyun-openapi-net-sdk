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
using Aliyun.Acs.cloudesl.Model.V20180801;

namespace Aliyun.Acs.cloudesl.Transform.V20180801
{
    public class DescribeUserOperationLogResponseUnmarshaller
    {
        public static DescribeUserOperationLogResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUserOperationLogResponse describeUserOperationLogResponse = new DescribeUserOperationLogResponse();

			describeUserOperationLogResponse.HttpResponse = context.HttpResponse;
			describeUserOperationLogResponse.RequestId = context.StringValue("DescribeUserOperationLog.RequestId");
			describeUserOperationLogResponse.Success = context.BooleanValue("DescribeUserOperationLog.Success");
			describeUserOperationLogResponse.Message = context.StringValue("DescribeUserOperationLog.Message");
			describeUserOperationLogResponse.ErrorCode = context.StringValue("DescribeUserOperationLog.ErrorCode");
			describeUserOperationLogResponse.TotalCount = context.IntegerValue("DescribeUserOperationLog.TotalCount");
			describeUserOperationLogResponse.PageNumber = context.IntegerValue("DescribeUserOperationLog.PageNumber");
			describeUserOperationLogResponse.PageSize = context.IntegerValue("DescribeUserOperationLog.PageSize");

			List<DescribeUserOperationLogResponse.DescribeUserOperationLog_OperationLogInfo> describeUserOperationLogResponse_operationLogs = new List<DescribeUserOperationLogResponse.DescribeUserOperationLog_OperationLogInfo>();
			for (int i = 0; i < context.Length("DescribeUserOperationLog.OperationLogs.Length"); i++) {
				DescribeUserOperationLogResponse.DescribeUserOperationLog_OperationLogInfo operationLogInfo = new DescribeUserOperationLogResponse.DescribeUserOperationLog_OperationLogInfo();
				operationLogInfo.OperateType = context.StringValue("DescribeUserOperationLog.OperationLogs["+ i +"].OperateType");
				operationLogInfo.OperateStatus = context.StringValue("DescribeUserOperationLog.OperationLogs["+ i +"].OperateStatus");
				operationLogInfo.OperateUserId = context.LongValue("DescribeUserOperationLog.OperationLogs["+ i +"].OperateUserId");
				operationLogInfo.OperateTime = context.StringValue("DescribeUserOperationLog.OperationLogs["+ i +"].OperateTime");
				operationLogInfo.StoreId = context.StringValue("DescribeUserOperationLog.OperationLogs["+ i +"].StoreId");
				operationLogInfo.ItemTitle = context.StringValue("DescribeUserOperationLog.OperationLogs["+ i +"].ItemTitle");
				operationLogInfo.ItemId = context.StringValue("DescribeUserOperationLog.OperationLogs["+ i +"].ItemId");
				operationLogInfo.ItemActionPrice = context.IntegerValue("DescribeUserOperationLog.OperationLogs["+ i +"].ItemActionPrice");
				operationLogInfo.ItemBarCode = context.StringValue("DescribeUserOperationLog.OperationLogs["+ i +"].ItemBarCode");
				operationLogInfo.EslBarCode = context.StringValue("DescribeUserOperationLog.OperationLogs["+ i +"].EslBarCode");
				operationLogInfo.ShelfCode = context.StringValue("DescribeUserOperationLog.OperationLogs["+ i +"].ShelfCode");

				describeUserOperationLogResponse_operationLogs.Add(operationLogInfo);
			}
			describeUserOperationLogResponse.OperationLogs = describeUserOperationLogResponse_operationLogs;
        
			return describeUserOperationLogResponse;
        }
    }
}
