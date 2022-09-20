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
    public class GetQueueAttributesResponseUnmarshaller
    {
        public static GetQueueAttributesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetQueueAttributesResponse getQueueAttributesResponse = new GetQueueAttributesResponse();

			getQueueAttributesResponse.HttpResponse = _ctx.HttpResponse;
			getQueueAttributesResponse.RequestId = _ctx.StringValue("GetQueueAttributes.RequestId");
			getQueueAttributesResponse.Code = _ctx.LongValue("GetQueueAttributes.Code");
			getQueueAttributesResponse.Status = _ctx.StringValue("GetQueueAttributes.Status");
			getQueueAttributesResponse.Message = _ctx.StringValue("GetQueueAttributes.Message");
			getQueueAttributesResponse.Success = _ctx.BooleanValue("GetQueueAttributes.Success");

			GetQueueAttributesResponse.GetQueueAttributes_Data data = new GetQueueAttributesResponse.GetQueueAttributes_Data();
			data.QueueUrl = _ctx.StringValue("GetQueueAttributes.Data.QueueUrl");
			data.QueueInternalUrl = _ctx.StringValue("GetQueueAttributes.Data.QueueInternalUrl");
			data.QueueName = _ctx.StringValue("GetQueueAttributes.Data.QueueName");
			data.CreateTime = _ctx.LongValue("GetQueueAttributes.Data.CreateTime");
			data.LastModifyTime = _ctx.LongValue("GetQueueAttributes.Data.LastModifyTime");
			data.DelaySeconds = _ctx.LongValue("GetQueueAttributes.Data.DelaySeconds");
			data.MaximumMessageSize = _ctx.LongValue("GetQueueAttributes.Data.MaximumMessageSize");
			data.MessageRetentionPeriod = _ctx.LongValue("GetQueueAttributes.Data.MessageRetentionPeriod");
			data.VisibilityTimeout = _ctx.LongValue("GetQueueAttributes.Data.VisibilityTimeout");
			data.PollingWaitSeconds = _ctx.LongValue("GetQueueAttributes.Data.PollingWaitSeconds");
			data.ActiveMessages = _ctx.LongValue("GetQueueAttributes.Data.ActiveMessages");
			data.InactiveMessages = _ctx.LongValue("GetQueueAttributes.Data.InactiveMessages");
			data.DelayMessages = _ctx.LongValue("GetQueueAttributes.Data.DelayMessages");
			data.LoggingEnabled = _ctx.BooleanValue("GetQueueAttributes.Data.LoggingEnabled");
			getQueueAttributesResponse.Data = data;
        
			return getQueueAttributesResponse;
        }
    }
}
