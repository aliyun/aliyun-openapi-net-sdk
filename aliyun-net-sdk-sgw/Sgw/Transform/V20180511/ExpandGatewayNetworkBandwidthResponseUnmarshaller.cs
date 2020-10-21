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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class ExpandGatewayNetworkBandwidthResponseUnmarshaller
    {
        public static ExpandGatewayNetworkBandwidthResponse Unmarshall(UnmarshallerContext context)
        {
			ExpandGatewayNetworkBandwidthResponse expandGatewayNetworkBandwidthResponse = new ExpandGatewayNetworkBandwidthResponse();

			expandGatewayNetworkBandwidthResponse.HttpResponse = context.HttpResponse;
			expandGatewayNetworkBandwidthResponse.RequestId = context.StringValue("ExpandGatewayNetworkBandwidth.RequestId");
			expandGatewayNetworkBandwidthResponse.Success = context.BooleanValue("ExpandGatewayNetworkBandwidth.Success");
			expandGatewayNetworkBandwidthResponse.Code = context.StringValue("ExpandGatewayNetworkBandwidth.Code");
			expandGatewayNetworkBandwidthResponse.Message = context.StringValue("ExpandGatewayNetworkBandwidth.Message");
			expandGatewayNetworkBandwidthResponse.TaskId = context.StringValue("ExpandGatewayNetworkBandwidth.TaskId");
			expandGatewayNetworkBandwidthResponse.BuyURL = context.StringValue("ExpandGatewayNetworkBandwidth.BuyURL");
        
			return expandGatewayNetworkBandwidthResponse;
        }
    }
}
