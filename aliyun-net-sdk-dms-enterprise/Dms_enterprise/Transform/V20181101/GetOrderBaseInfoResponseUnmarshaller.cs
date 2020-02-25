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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class GetOrderBaseInfoResponseUnmarshaller
    {
        public static GetOrderBaseInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetOrderBaseInfoResponse getOrderBaseInfoResponse = new GetOrderBaseInfoResponse();

			getOrderBaseInfoResponse.HttpResponse = context.HttpResponse;
			getOrderBaseInfoResponse.RequestId = context.StringValue("GetOrderBaseInfo.RequestId");
			getOrderBaseInfoResponse.Success = context.BooleanValue("GetOrderBaseInfo.Success");
			getOrderBaseInfoResponse.ErrorMessage = context.StringValue("GetOrderBaseInfo.ErrorMessage");
			getOrderBaseInfoResponse.ErrorCode = context.StringValue("GetOrderBaseInfo.ErrorCode");

			GetOrderBaseInfoResponse.GetOrderBaseInfo_OrderBaseInfo orderBaseInfo = new GetOrderBaseInfoResponse.GetOrderBaseInfo_OrderBaseInfo();
			orderBaseInfo.Comment = context.StringValue("GetOrderBaseInfo.OrderBaseInfo.Comment");
			orderBaseInfo.Committer = context.StringValue("GetOrderBaseInfo.OrderBaseInfo.Committer");
			orderBaseInfo.CommitterId = context.LongValue("GetOrderBaseInfo.OrderBaseInfo.CommitterId");
			orderBaseInfo.CreateTime = context.StringValue("GetOrderBaseInfo.OrderBaseInfo.CreateTime");
			orderBaseInfo.LastModifyTime = context.StringValue("GetOrderBaseInfo.OrderBaseInfo.LastModifyTime");
			orderBaseInfo.OrderId = context.LongValue("GetOrderBaseInfo.OrderBaseInfo.OrderId");
			orderBaseInfo.PluginType = context.StringValue("GetOrderBaseInfo.OrderBaseInfo.PluginType");
			orderBaseInfo.StatusCode = context.StringValue("GetOrderBaseInfo.OrderBaseInfo.StatusCode");
			orderBaseInfo.StatusDesc = context.StringValue("GetOrderBaseInfo.OrderBaseInfo.StatusDesc");
			orderBaseInfo.WorkflowInstanceId = context.LongValue("GetOrderBaseInfo.OrderBaseInfo.WorkflowInstanceId");
			orderBaseInfo.WorkflowStatusDesc = context.StringValue("GetOrderBaseInfo.OrderBaseInfo.WorkflowStatusDesc");

			List<string> orderBaseInfo_relatedUserList = new List<string>();
			for (int i = 0; i < context.Length("GetOrderBaseInfo.OrderBaseInfo.RelatedUserList.Length"); i++) {
				orderBaseInfo_relatedUserList.Add(context.StringValue("GetOrderBaseInfo.OrderBaseInfo.RelatedUserList["+ i +"]"));
			}
			orderBaseInfo.RelatedUserList = orderBaseInfo_relatedUserList;

			List<string> orderBaseInfo_relatedUserNickList = new List<string>();
			for (int i = 0; i < context.Length("GetOrderBaseInfo.OrderBaseInfo.RelatedUserNickList.Length"); i++) {
				orderBaseInfo_relatedUserNickList.Add(context.StringValue("GetOrderBaseInfo.OrderBaseInfo.RelatedUserNickList["+ i +"]"));
			}
			orderBaseInfo.RelatedUserNickList = orderBaseInfo_relatedUserNickList;
			getOrderBaseInfoResponse.OrderBaseInfo = orderBaseInfo;
        
			return getOrderBaseInfoResponse;
        }
    }
}
