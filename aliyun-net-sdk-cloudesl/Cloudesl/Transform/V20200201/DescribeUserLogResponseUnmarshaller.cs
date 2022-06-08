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
        public static DescribeUserLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUserLogResponse describeUserLogResponse = new DescribeUserLogResponse();

			describeUserLogResponse.HttpResponse = _ctx.HttpResponse;
			describeUserLogResponse.RequestId = _ctx.StringValue("DescribeUserLog.RequestId");
			describeUserLogResponse.ErrorMessage = _ctx.StringValue("DescribeUserLog.ErrorMessage");
			describeUserLogResponse.Success = _ctx.BooleanValue("DescribeUserLog.Success");
			describeUserLogResponse.ErrorCode = _ctx.StringValue("DescribeUserLog.ErrorCode");
			describeUserLogResponse.Code = _ctx.StringValue("DescribeUserLog.Code");
			describeUserLogResponse.Message = _ctx.StringValue("DescribeUserLog.Message");
			describeUserLogResponse.DynamicMessage = _ctx.StringValue("DescribeUserLog.DynamicMessage");
			describeUserLogResponse.PageSize = _ctx.IntegerValue("DescribeUserLog.PageSize");
			describeUserLogResponse.PageNumber = _ctx.IntegerValue("DescribeUserLog.PageNumber");
			describeUserLogResponse.TotalCount = _ctx.IntegerValue("DescribeUserLog.TotalCount");
			describeUserLogResponse.DynamicCode = _ctx.StringValue("DescribeUserLog.DynamicCode");

			List<DescribeUserLogResponse.DescribeUserLog_UserLogInfo> describeUserLogResponse_userLogs = new List<DescribeUserLogResponse.DescribeUserLog_UserLogInfo>();
			for (int i = 0; i < _ctx.Length("DescribeUserLog.UserLogs.Length"); i++) {
				DescribeUserLogResponse.DescribeUserLog_UserLogInfo userLogInfo = new DescribeUserLogResponse.DescribeUserLog_UserLogInfo();
				userLogInfo.EslBarCode = _ctx.StringValue("DescribeUserLog.UserLogs["+ i +"].EslBarCode");
				userLogInfo.OperationSendTime = _ctx.StringValue("DescribeUserLog.UserLogs["+ i +"].OperationSendTime");
				userLogInfo.ActionPrice = _ctx.StringValue("DescribeUserLog.UserLogs["+ i +"].ActionPrice");
				userLogInfo.UserId = _ctx.StringValue("DescribeUserLog.UserLogs["+ i +"].UserId");
				userLogInfo.PriceUnit = _ctx.StringValue("DescribeUserLog.UserLogs["+ i +"].PriceUnit");
				userLogInfo.ResultCode = _ctx.StringValue("DescribeUserLog.UserLogs["+ i +"].ResultCode");
				userLogInfo.ItemId = _ctx.StringValue("DescribeUserLog.UserLogs["+ i +"].ItemId");
				userLogInfo.GmtModified = _ctx.StringValue("DescribeUserLog.UserLogs["+ i +"].GmtModified");
				userLogInfo.OperationType = _ctx.StringValue("DescribeUserLog.UserLogs["+ i +"].OperationType");
				userLogInfo.OperationResponseTime = _ctx.StringValue("DescribeUserLog.UserLogs["+ i +"].OperationResponseTime");
				userLogInfo.OperationStatus = _ctx.StringValue("DescribeUserLog.UserLogs["+ i +"].OperationStatus");
				userLogInfo.StoreId = _ctx.StringValue("DescribeUserLog.UserLogs["+ i +"].StoreId");
				userLogInfo.ItemShortTitle = _ctx.StringValue("DescribeUserLog.UserLogs["+ i +"].ItemShortTitle");
				userLogInfo.LogId = _ctx.StringValue("DescribeUserLog.UserLogs["+ i +"].LogId");
				userLogInfo.BePromotion = _ctx.BooleanValue("DescribeUserLog.UserLogs["+ i +"].BePromotion");
				userLogInfo.GmtCreate = _ctx.StringValue("DescribeUserLog.UserLogs["+ i +"].GmtCreate");
				userLogInfo.EslSignal = _ctx.IntegerValue("DescribeUserLog.UserLogs["+ i +"].EslSignal");
				userLogInfo.SpendTime = _ctx.StringValue("DescribeUserLog.UserLogs["+ i +"].SpendTime");
				userLogInfo.ItemBarCode = _ctx.StringValue("DescribeUserLog.UserLogs["+ i +"].ItemBarCode");
				userLogInfo.I18nResultKey = _ctx.StringValue("DescribeUserLog.UserLogs["+ i +"].I18nResultKey");

				describeUserLogResponse_userLogs.Add(userLogInfo);
			}
			describeUserLogResponse.UserLogs = describeUserLogResponse_userLogs;
        
			return describeUserLogResponse;
        }
    }
}
