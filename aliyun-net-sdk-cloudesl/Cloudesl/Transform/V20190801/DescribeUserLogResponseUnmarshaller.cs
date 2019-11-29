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
using Aliyun.Acs.cloudesl.Model.V20190801;

namespace Aliyun.Acs.cloudesl.Transform.V20190801
{
    public class DescribeUserLogResponseUnmarshaller
    {
        public static DescribeUserLogResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUserLogResponse describeUserLogResponse = new DescribeUserLogResponse();

			describeUserLogResponse.HttpResponse = context.HttpResponse;
			describeUserLogResponse.ErrorMessage = context.StringValue("DescribeUserLog.ErrorMessage");
			describeUserLogResponse.PageNumber = context.IntegerValue("DescribeUserLog.PageNumber");
			describeUserLogResponse.ErrorCode = context.StringValue("DescribeUserLog.ErrorCode");
			describeUserLogResponse.Message = context.StringValue("DescribeUserLog.Message");
			describeUserLogResponse.DynamicCode = context.StringValue("DescribeUserLog.DynamicCode");
			describeUserLogResponse.PageSize = context.IntegerValue("DescribeUserLog.PageSize");
			describeUserLogResponse.Code = context.StringValue("DescribeUserLog.Code");
			describeUserLogResponse.DynamicMessage = context.StringValue("DescribeUserLog.DynamicMessage");
			describeUserLogResponse.TotalCount = context.IntegerValue("DescribeUserLog.TotalCount");
			describeUserLogResponse.RequestId = context.StringValue("DescribeUserLog.RequestId");
			describeUserLogResponse.Success = context.BooleanValue("DescribeUserLog.Success");

			List<DescribeUserLogResponse.DescribeUserLog_UserLogInfo> describeUserLogResponse_userLogs = new List<DescribeUserLogResponse.DescribeUserLog_UserLogInfo>();
			for (int i = 0; i < context.Length("DescribeUserLog.UserLogs.Length"); i++) {
				DescribeUserLogResponse.DescribeUserLog_UserLogInfo userLogInfo = new DescribeUserLogResponse.DescribeUserLog_UserLogInfo();
				userLogInfo.OperateType = context.StringValue("DescribeUserLog.UserLogs["+ i +"].OperateType");
				userLogInfo.OperateUserId = context.LongValue("DescribeUserLog.UserLogs["+ i +"].OperateUserId");
				userLogInfo.Mac = context.StringValue("DescribeUserLog.UserLogs["+ i +"].Mac");
				userLogInfo.ItemActionPrice = context.IntegerValue("DescribeUserLog.UserLogs["+ i +"].ItemActionPrice");
				userLogInfo.StoreId = context.StringValue("DescribeUserLog.UserLogs["+ i +"].StoreId");
				userLogInfo.EslBarCode = context.StringValue("DescribeUserLog.UserLogs["+ i +"].EslBarCode");
				userLogInfo.OperateStatus = context.StringValue("DescribeUserLog.UserLogs["+ i +"].OperateStatus");
				userLogInfo.ItemBarCode = context.StringValue("DescribeUserLog.UserLogs["+ i +"].ItemBarCode");
				userLogInfo.ItemId = context.LongValue("DescribeUserLog.UserLogs["+ i +"].ItemId");
				userLogInfo.ShelfCode = context.StringValue("DescribeUserLog.UserLogs["+ i +"].ShelfCode");
				userLogInfo.OperateTime = context.StringValue("DescribeUserLog.UserLogs["+ i +"].OperateTime");
				userLogInfo.ItemTitle = context.StringValue("DescribeUserLog.UserLogs["+ i +"].ItemTitle");

				describeUserLogResponse_userLogs.Add(userLogInfo);
			}
			describeUserLogResponse.UserLogs = describeUserLogResponse_userLogs;
        
			return describeUserLogResponse;
        }
    }
}
