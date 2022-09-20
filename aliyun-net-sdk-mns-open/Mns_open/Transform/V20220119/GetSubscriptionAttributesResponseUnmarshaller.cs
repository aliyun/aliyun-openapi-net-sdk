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
using Aliyun.Acs.Mns_open.Model.V20220119;

namespace Aliyun.Acs.Mns_open.Transform.V20220119
{
    public class GetSubscriptionAttributesResponseUnmarshaller
    {
        public static GetSubscriptionAttributesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSubscriptionAttributesResponse getSubscriptionAttributesResponse = new GetSubscriptionAttributesResponse();

			getSubscriptionAttributesResponse.HttpResponse = _ctx.HttpResponse;
			getSubscriptionAttributesResponse.RequestId = _ctx.StringValue("GetSubscriptionAttributes.RequestId");
			getSubscriptionAttributesResponse.Code = _ctx.LongValue("GetSubscriptionAttributes.Code");
			getSubscriptionAttributesResponse.Status = _ctx.StringValue("GetSubscriptionAttributes.Status");
			getSubscriptionAttributesResponse.Message = _ctx.StringValue("GetSubscriptionAttributes.Message");
			getSubscriptionAttributesResponse.Success = _ctx.BooleanValue("GetSubscriptionAttributes.Success");

			GetSubscriptionAttributesResponse.GetSubscriptionAttributes_Data data = new GetSubscriptionAttributesResponse.GetSubscriptionAttributes_Data();
			data.SubscriptionName = _ctx.StringValue("GetSubscriptionAttributes.Data.SubscriptionName");
			data.TopicOwner = _ctx.StringValue("GetSubscriptionAttributes.Data.TopicOwner");
			data.TopicName = _ctx.StringValue("GetSubscriptionAttributes.Data.TopicName");
			data.Endpoint = _ctx.StringValue("GetSubscriptionAttributes.Data.Endpoint");
			data.FilterTag = _ctx.StringValue("GetSubscriptionAttributes.Data.FilterTag");
			data.CreateTime = _ctx.LongValue("GetSubscriptionAttributes.Data.CreateTime");
			data.LastModifyTime = _ctx.LongValue("GetSubscriptionAttributes.Data.LastModifyTime");
			data.NotifyStrategy = _ctx.StringValue("GetSubscriptionAttributes.Data.NotifyStrategy");
			data.NotifyContentFormat = _ctx.StringValue("GetSubscriptionAttributes.Data.NotifyContentFormat");
			data.SubscriptionURL = _ctx.StringValue("GetSubscriptionAttributes.Data.SubscriptionURL");
			getSubscriptionAttributesResponse.Data = data;
        
			return getSubscriptionAttributesResponse;
        }
    }
}
