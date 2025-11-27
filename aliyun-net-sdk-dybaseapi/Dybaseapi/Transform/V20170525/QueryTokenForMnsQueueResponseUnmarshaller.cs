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
using Aliyun.Acs.Dybaseapi.Model.V20170525;

namespace Aliyun.Acs.Dybaseapi.Transform.V20170525
{
    public class QueryTokenForMnsQueueResponseUnmarshaller
    {
        public static QueryTokenForMnsQueueResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTokenForMnsQueueResponse queryTokenForMnsQueueResponse = new QueryTokenForMnsQueueResponse();

			queryTokenForMnsQueueResponse.HttpResponse = context.HttpResponse;
			queryTokenForMnsQueueResponse.RequestId = context.StringValue("QueryTokenForMnsQueue.RequestId");
			queryTokenForMnsQueueResponse.Code = context.StringValue("QueryTokenForMnsQueue.Code");
			queryTokenForMnsQueueResponse.Message = context.StringValue("QueryTokenForMnsQueue.Message");

			QueryTokenForMnsQueueResponse.QueryTokenForMnsQueue_MessageTokenDTO messageTokenDTO = new QueryTokenForMnsQueueResponse.QueryTokenForMnsQueue_MessageTokenDTO();
			messageTokenDTO.AccessKeyId = context.StringValue("QueryTokenForMnsQueue.MessageTokenDTO.AccessKeyId");
			messageTokenDTO.AccessKeySecret = context.StringValue("QueryTokenForMnsQueue.MessageTokenDTO.AccessKeySecret");
			messageTokenDTO.SecurityToken = context.StringValue("QueryTokenForMnsQueue.MessageTokenDTO.SecurityToken");
			messageTokenDTO.CreateTime = context.StringValue("QueryTokenForMnsQueue.MessageTokenDTO.CreateTime");
			messageTokenDTO.ExpireTime = context.StringValue("QueryTokenForMnsQueue.MessageTokenDTO.ExpireTime");
			queryTokenForMnsQueueResponse.MessageTokenDTO = messageTokenDTO;
        
			return queryTokenForMnsQueueResponse;
        }
    }
}
