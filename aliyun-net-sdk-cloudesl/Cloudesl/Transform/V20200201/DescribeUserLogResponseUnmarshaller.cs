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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribeUserLogResponseUnmarshaller
    {
        public static DescribeUserLogResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUserLogResponse describeUserLogResponse = new DescribeUserLogResponse();

			describeUserLogResponse.HttpResponse = context.HttpResponse;
			describeUserLogResponse.ErrorMessage = context.StringValue("DescribeUserLog.ErrorMessage");
			describeUserLogResponse.ErrorCode = context.StringValue("DescribeUserLog.ErrorCode");
			describeUserLogResponse.PageNumber = context.IntegerValue("DescribeUserLog.PageNumber");
			describeUserLogResponse.Message = context.StringValue("DescribeUserLog.Message");
			describeUserLogResponse.DynamicCode = context.StringValue("DescribeUserLog.DynamicCode");
			describeUserLogResponse.Code = context.StringValue("DescribeUserLog.Code");
			describeUserLogResponse.PageSize = context.IntegerValue("DescribeUserLog.PageSize");
			describeUserLogResponse.DynamicMessage = context.StringValue("DescribeUserLog.DynamicMessage");
			describeUserLogResponse.RequestId = context.StringValue("DescribeUserLog.RequestId");
			describeUserLogResponse.Success = context.BooleanValue("DescribeUserLog.Success");
			describeUserLogResponse.TotalCount = context.IntegerValue("DescribeUserLog.TotalCount");

			List<DescribeUserLogResponse.DescribeUserLog_UserLogInfo> describeUserLogResponse_userLogs = new List<DescribeUserLogResponse.DescribeUserLog_UserLogInfo>();
			for (int i = 0; i < context.Length("DescribeUserLog.UserLogs.Length"); i++) {
				DescribeUserLogResponse.DescribeUserLog_UserLogInfo userLogInfo = new DescribeUserLogResponse.DescribeUserLog_UserLogInfo();
				userLogInfo.ResultCode = context.StringValue("DescribeUserLog.UserLogs["+ i +"].ResultCode");
				userLogInfo.OperationSendTime = context.StringValue("DescribeUserLog.UserLogs["+ i +"].OperationSendTime");
				userLogInfo.GmtCreate = context.StringValue("DescribeUserLog.UserLogs["+ i +"].GmtCreate");
				userLogInfo.StoreId = context.StringValue("DescribeUserLog.UserLogs["+ i +"].StoreId");
				userLogInfo.GmtModified = context.StringValue("DescribeUserLog.UserLogs["+ i +"].GmtModified");
				userLogInfo.ActionPrice = context.StringValue("DescribeUserLog.UserLogs["+ i +"].ActionPrice");
				userLogInfo.OperationStatus = context.StringValue("DescribeUserLog.UserLogs["+ i +"].OperationStatus");
				userLogInfo.PriceUnit = context.StringValue("DescribeUserLog.UserLogs["+ i +"].PriceUnit");
				userLogInfo.LogId = context.StringValue("DescribeUserLog.UserLogs["+ i +"].LogId");
				userLogInfo.ItemShortTitle = context.StringValue("DescribeUserLog.UserLogs["+ i +"].ItemShortTitle");
				userLogInfo.OperationType = context.StringValue("DescribeUserLog.UserLogs["+ i +"].OperationType");
				userLogInfo.OperationResponseTime = context.StringValue("DescribeUserLog.UserLogs["+ i +"].OperationResponseTime");
				userLogInfo.SpendTime = context.StringValue("DescribeUserLog.UserLogs["+ i +"].SpendTime");
				userLogInfo.EslBarCode = context.StringValue("DescribeUserLog.UserLogs["+ i +"].EslBarCode");
				userLogInfo.ItemId = context.StringValue("DescribeUserLog.UserLogs["+ i +"].ItemId");
				userLogInfo.ItemBarCode = context.StringValue("DescribeUserLog.UserLogs["+ i +"].ItemBarCode");
				userLogInfo.BePromotion = context.BooleanValue("DescribeUserLog.UserLogs["+ i +"].BePromotion");
				userLogInfo.UserId = context.StringValue("DescribeUserLog.UserLogs["+ i +"].UserId");

				describeUserLogResponse_userLogs.Add(userLogInfo);
			}
			describeUserLogResponse.UserLogs = describeUserLogResponse_userLogs;
        
			return describeUserLogResponse;
        }
    }
}
