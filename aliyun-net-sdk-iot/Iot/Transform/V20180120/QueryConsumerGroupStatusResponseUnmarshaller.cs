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
    public class QueryConsumerGroupStatusResponseUnmarshaller
    {
        public static QueryConsumerGroupStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryConsumerGroupStatusResponse queryConsumerGroupStatusResponse = new QueryConsumerGroupStatusResponse();

			queryConsumerGroupStatusResponse.HttpResponse = _ctx.HttpResponse;
			queryConsumerGroupStatusResponse.RequestId = _ctx.StringValue("QueryConsumerGroupStatus.RequestId");
			queryConsumerGroupStatusResponse.Success = _ctx.BooleanValue("QueryConsumerGroupStatus.Success");
			queryConsumerGroupStatusResponse.ErrorMessage = _ctx.StringValue("QueryConsumerGroupStatus.ErrorMessage");
			queryConsumerGroupStatusResponse.AccumulationCount = _ctx.IntegerValue("QueryConsumerGroupStatus.AccumulationCount");
			queryConsumerGroupStatusResponse.ConsumerSpeed = _ctx.IntegerValue("QueryConsumerGroupStatus.ConsumerSpeed");
			queryConsumerGroupStatusResponse.LastConsumerTime = _ctx.StringValue("QueryConsumerGroupStatus.LastConsumerTime");
			queryConsumerGroupStatusResponse.Code = _ctx.StringValue("QueryConsumerGroupStatus.Code");
			queryConsumerGroupStatusResponse.AccumulatedConsumeCountPerMinute = _ctx.IntegerValue("QueryConsumerGroupStatus.AccumulatedConsumeCountPerMinute");
			queryConsumerGroupStatusResponse.RealTimeConsumeCountPerMinute = _ctx.IntegerValue("QueryConsumerGroupStatus.RealTimeConsumeCountPerMinute");

			List<QueryConsumerGroupStatusResponse.QueryConsumerGroupStatus_ConsumerGroupClientConnectionInfo> queryConsumerGroupStatusResponse_clientConnectionStatusList = new List<QueryConsumerGroupStatusResponse.QueryConsumerGroupStatus_ConsumerGroupClientConnectionInfo>();
			for (int i = 0; i < _ctx.Length("QueryConsumerGroupStatus.ClientConnectionStatusList.Length"); i++) {
				QueryConsumerGroupStatusResponse.QueryConsumerGroupStatus_ConsumerGroupClientConnectionInfo consumerGroupClientConnectionInfo = new QueryConsumerGroupStatusResponse.QueryConsumerGroupStatus_ConsumerGroupClientConnectionInfo();
				consumerGroupClientConnectionInfo.ClientId = _ctx.StringValue("QueryConsumerGroupStatus.ClientConnectionStatusList["+ i +"].ClientId");
				consumerGroupClientConnectionInfo.ClientIpPort = _ctx.StringValue("QueryConsumerGroupStatus.ClientConnectionStatusList["+ i +"].ClientIpPort");
				consumerGroupClientConnectionInfo.OnlineTime = _ctx.LongValue("QueryConsumerGroupStatus.ClientConnectionStatusList["+ i +"].OnlineTime");
				consumerGroupClientConnectionInfo.RealTimeConsumeCountPerMinute = _ctx.IntegerValue("QueryConsumerGroupStatus.ClientConnectionStatusList["+ i +"].RealTimeConsumeCountPerMinute");
				consumerGroupClientConnectionInfo.AccumulatedConsumeCountPerMinute = _ctx.IntegerValue("QueryConsumerGroupStatus.ClientConnectionStatusList["+ i +"].AccumulatedConsumeCountPerMinute");

				queryConsumerGroupStatusResponse_clientConnectionStatusList.Add(consumerGroupClientConnectionInfo);
			}
			queryConsumerGroupStatusResponse.ClientConnectionStatusList = queryConsumerGroupStatusResponse_clientConnectionStatusList;
        
			return queryConsumerGroupStatusResponse;
        }
    }
}
