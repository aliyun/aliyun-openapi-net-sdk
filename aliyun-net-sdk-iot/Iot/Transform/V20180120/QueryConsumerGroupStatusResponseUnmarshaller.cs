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
        public static QueryConsumerGroupStatusResponse Unmarshall(UnmarshallerContext context)
        {
			QueryConsumerGroupStatusResponse queryConsumerGroupStatusResponse = new QueryConsumerGroupStatusResponse();

			queryConsumerGroupStatusResponse.HttpResponse = context.HttpResponse;
			queryConsumerGroupStatusResponse.RequestId = context.StringValue("QueryConsumerGroupStatus.RequestId");
			queryConsumerGroupStatusResponse.Success = context.BooleanValue("QueryConsumerGroupStatus.Success");
			queryConsumerGroupStatusResponse.ErrorMessage = context.StringValue("QueryConsumerGroupStatus.ErrorMessage");
			queryConsumerGroupStatusResponse.AccumulationCount = context.IntegerValue("QueryConsumerGroupStatus.AccumulationCount");
			queryConsumerGroupStatusResponse.ConsumerSpeed = context.IntegerValue("QueryConsumerGroupStatus.ConsumerSpeed");
			queryConsumerGroupStatusResponse.LastConsumerTime = context.StringValue("QueryConsumerGroupStatus.LastConsumerTime");
			queryConsumerGroupStatusResponse.Code = context.StringValue("QueryConsumerGroupStatus.Code");

			List<QueryConsumerGroupStatusResponse.QueryConsumerGroupStatus_ConsumerGroupClientConnectionInfo> queryConsumerGroupStatusResponse_clientConnectionStatusList = new List<QueryConsumerGroupStatusResponse.QueryConsumerGroupStatus_ConsumerGroupClientConnectionInfo>();
			for (int i = 0; i < context.Length("QueryConsumerGroupStatus.ClientConnectionStatusList.Length"); i++) {
				QueryConsumerGroupStatusResponse.QueryConsumerGroupStatus_ConsumerGroupClientConnectionInfo consumerGroupClientConnectionInfo = new QueryConsumerGroupStatusResponse.QueryConsumerGroupStatus_ConsumerGroupClientConnectionInfo();
				consumerGroupClientConnectionInfo.ClientId = context.StringValue("QueryConsumerGroupStatus.ClientConnectionStatusList["+ i +"].ClientId");
				consumerGroupClientConnectionInfo.ClientIpPort = context.StringValue("QueryConsumerGroupStatus.ClientConnectionStatusList["+ i +"].ClientIpPort");
				consumerGroupClientConnectionInfo.OnlineTime = context.LongValue("QueryConsumerGroupStatus.ClientConnectionStatusList["+ i +"].OnlineTime");

				queryConsumerGroupStatusResponse_clientConnectionStatusList.Add(consumerGroupClientConnectionInfo);
			}
			queryConsumerGroupStatusResponse.ClientConnectionStatusList = queryConsumerGroupStatusResponse_clientConnectionStatusList;
        
			return queryConsumerGroupStatusResponse;
        }
    }
}
