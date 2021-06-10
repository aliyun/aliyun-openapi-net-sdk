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
        public static GetOrderBaseInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOrderBaseInfoResponse getOrderBaseInfoResponse = new GetOrderBaseInfoResponse();

			getOrderBaseInfoResponse.HttpResponse = _ctx.HttpResponse;
			getOrderBaseInfoResponse.RequestId = _ctx.StringValue("GetOrderBaseInfo.RequestId");
			getOrderBaseInfoResponse.ErrorCode = _ctx.StringValue("GetOrderBaseInfo.ErrorCode");
			getOrderBaseInfoResponse.ErrorMessage = _ctx.StringValue("GetOrderBaseInfo.ErrorMessage");
			getOrderBaseInfoResponse.Success = _ctx.BooleanValue("GetOrderBaseInfo.Success");

			GetOrderBaseInfoResponse.GetOrderBaseInfo_OrderBaseInfo orderBaseInfo = new GetOrderBaseInfoResponse.GetOrderBaseInfo_OrderBaseInfo();
			orderBaseInfo.Comment = _ctx.StringValue("GetOrderBaseInfo.OrderBaseInfo.Comment");
			orderBaseInfo.CreateTime = _ctx.StringValue("GetOrderBaseInfo.OrderBaseInfo.CreateTime");
			orderBaseInfo.Committer = _ctx.StringValue("GetOrderBaseInfo.OrderBaseInfo.Committer");
			orderBaseInfo.WorkflowInstanceId = _ctx.LongValue("GetOrderBaseInfo.OrderBaseInfo.WorkflowInstanceId");
			orderBaseInfo.CommitterId = _ctx.LongValue("GetOrderBaseInfo.OrderBaseInfo.CommitterId");
			orderBaseInfo.LastModifyTime = _ctx.StringValue("GetOrderBaseInfo.OrderBaseInfo.LastModifyTime");
			orderBaseInfo.StatusCode = _ctx.StringValue("GetOrderBaseInfo.OrderBaseInfo.StatusCode");
			orderBaseInfo.WorkflowStatusDesc = _ctx.StringValue("GetOrderBaseInfo.OrderBaseInfo.WorkflowStatusDesc");
			orderBaseInfo.StatusDesc = _ctx.StringValue("GetOrderBaseInfo.OrderBaseInfo.StatusDesc");
			orderBaseInfo.PluginType = _ctx.StringValue("GetOrderBaseInfo.OrderBaseInfo.PluginType");
			orderBaseInfo.OrderId = _ctx.LongValue("GetOrderBaseInfo.OrderBaseInfo.OrderId");

			List<string> orderBaseInfo_relatedUserNickList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetOrderBaseInfo.OrderBaseInfo.RelatedUserNickList.Length"); i++) {
				orderBaseInfo_relatedUserNickList.Add(_ctx.StringValue("GetOrderBaseInfo.OrderBaseInfo.RelatedUserNickList["+ i +"]"));
			}
			orderBaseInfo.RelatedUserNickList = orderBaseInfo_relatedUserNickList;

			List<string> orderBaseInfo_relatedUserList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetOrderBaseInfo.OrderBaseInfo.RelatedUserList.Length"); i++) {
				orderBaseInfo_relatedUserList.Add(_ctx.StringValue("GetOrderBaseInfo.OrderBaseInfo.RelatedUserList["+ i +"]"));
			}
			orderBaseInfo.RelatedUserList = orderBaseInfo_relatedUserList;
			getOrderBaseInfoResponse.OrderBaseInfo = orderBaseInfo;
        
			return getOrderBaseInfoResponse;
        }
    }
}
