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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryConsumerGroupByGroupIdResponseUnmarshaller
    {
        public static QueryConsumerGroupByGroupIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryConsumerGroupByGroupIdResponse queryConsumerGroupByGroupIdResponse = new QueryConsumerGroupByGroupIdResponse();

			queryConsumerGroupByGroupIdResponse.HttpResponse = _ctx.HttpResponse;
			queryConsumerGroupByGroupIdResponse.RequestId = _ctx.StringValue("QueryConsumerGroupByGroupId.RequestId");
			queryConsumerGroupByGroupIdResponse.Success = _ctx.BooleanValue("QueryConsumerGroupByGroupId.Success");
			queryConsumerGroupByGroupIdResponse.ErrorMessage = _ctx.StringValue("QueryConsumerGroupByGroupId.ErrorMessage");
			queryConsumerGroupByGroupIdResponse.Code = _ctx.StringValue("QueryConsumerGroupByGroupId.Code");

			QueryConsumerGroupByGroupIdResponse.QueryConsumerGroupByGroupId_Data data = new QueryConsumerGroupByGroupIdResponse.QueryConsumerGroupByGroupId_Data();
			data.IotId = _ctx.StringValue("QueryConsumerGroupByGroupId.Data.IotId");
			data.GroupId = _ctx.StringValue("QueryConsumerGroupByGroupId.Data.GroupId");
			data.GroupName = _ctx.StringValue("QueryConsumerGroupByGroupId.Data.GroupName");
			data.Creator = _ctx.StringValue("QueryConsumerGroupByGroupId.Data.Creator");
			data.CreateTime = _ctx.StringValue("QueryConsumerGroupByGroupId.Data.CreateTime");
			data.AuthType = _ctx.StringValue("QueryConsumerGroupByGroupId.Data.AuthType");
			queryConsumerGroupByGroupIdResponse.Data = data;
        
			return queryConsumerGroupByGroupIdResponse;
        }
    }
}
