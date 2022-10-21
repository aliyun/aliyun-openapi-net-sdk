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
    public class GetTopicAttributesResponseUnmarshaller
    {
        public static GetTopicAttributesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTopicAttributesResponse getTopicAttributesResponse = new GetTopicAttributesResponse();

			getTopicAttributesResponse.HttpResponse = _ctx.HttpResponse;
			getTopicAttributesResponse.RequestId = _ctx.StringValue("GetTopicAttributes.RequestId");
			getTopicAttributesResponse.Code = _ctx.LongValue("GetTopicAttributes.Code");
			getTopicAttributesResponse.Status = _ctx.StringValue("GetTopicAttributes.Status");
			getTopicAttributesResponse.Message = _ctx.StringValue("GetTopicAttributes.Message");
			getTopicAttributesResponse.Success = _ctx.BooleanValue("GetTopicAttributes.Success");

			GetTopicAttributesResponse.GetTopicAttributes_Data data = new GetTopicAttributesResponse.GetTopicAttributes_Data();
			data.TopicName = _ctx.StringValue("GetTopicAttributes.Data.TopicName");
			data.MessageCount = _ctx.LongValue("GetTopicAttributes.Data.MessageCount");
			data.MaxMessageSize = _ctx.LongValue("GetTopicAttributes.Data.MaxMessageSize");
			data.MessageRetentionPeriod = _ctx.LongValue("GetTopicAttributes.Data.MessageRetentionPeriod");
			data.CreateTime = _ctx.LongValue("GetTopicAttributes.Data.CreateTime");
			data.LastModifyTime = _ctx.LongValue("GetTopicAttributes.Data.LastModifyTime");
			data.TopicUrl = _ctx.StringValue("GetTopicAttributes.Data.TopicUrl");
			data.LoggingEnabled = _ctx.BooleanValue("GetTopicAttributes.Data.LoggingEnabled");
			data.TopicInnerUrl = _ctx.StringValue("GetTopicAttributes.Data.TopicInnerUrl");
			getTopicAttributesResponse.Data = data;
        
			return getTopicAttributesResponse;
        }
    }
}
