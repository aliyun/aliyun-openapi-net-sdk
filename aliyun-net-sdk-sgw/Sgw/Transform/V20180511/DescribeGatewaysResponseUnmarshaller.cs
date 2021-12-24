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
    public class DescribeGatewaysResponseUnmarshaller
    {
        public static DescribeGatewaysResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGatewaysResponse describeGatewaysResponse = new DescribeGatewaysResponse();

			describeGatewaysResponse.HttpResponse = _ctx.HttpResponse;
			describeGatewaysResponse.TotalCount = _ctx.IntegerValue("DescribeGateways.TotalCount");
			describeGatewaysResponse.RequestId = _ctx.StringValue("DescribeGateways.RequestId");
			describeGatewaysResponse.Message = _ctx.StringValue("DescribeGateways.Message");
			describeGatewaysResponse.PageSize = _ctx.IntegerValue("DescribeGateways.PageSize");
			describeGatewaysResponse.PageNumber = _ctx.IntegerValue("DescribeGateways.PageNumber");
			describeGatewaysResponse.Code = _ctx.StringValue("DescribeGateways.Code");
			describeGatewaysResponse.Success = _ctx.BooleanValue("DescribeGateways.Success");

			List<DescribeGatewaysResponse.DescribeGateways_Gateway> describeGatewaysResponse_gateways = new List<DescribeGatewaysResponse.DescribeGateways_Gateway>();
			for (int i = 0; i < _ctx.Length("DescribeGateways.Gateways.Length"); i++) {
				DescribeGatewaysResponse.DescribeGateways_Gateway gateway = new DescribeGatewaysResponse.DescribeGateways_Gateway();
				gateway.VpcId = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].VpcId");
				gateway.Status = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].Status");
				gateway.SerialNumber = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].SerialNumber");
				gateway.Type = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].Type");
				gateway.Capacity = _ctx.IntegerValue("DescribeGateways.Gateways["+ i +"].Capacity");
				gateway.GatewayId = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].GatewayId");
				gateway.IsReleaseAfterExpiration = _ctx.BooleanValue("DescribeGateways.Gateways["+ i +"].IsReleaseAfterExpiration");
				gateway.GatewayType = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].GatewayType");
				gateway.BuyURL = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].BuyURL");
				gateway.EcsInstanceId = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].EcsInstanceId");
				gateway.MaxThroughput = _ctx.IntegerValue("DescribeGateways.Gateways["+ i +"].MaxThroughput");
				gateway.GatewayClass = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].GatewayClass");
				gateway.InnerIp = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].InnerIp");
				gateway.Description = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].Description");
				gateway.Name = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].Name");
				gateway.InnerIpv6Ip = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].InnerIpv6Ip");
				gateway.CreatedTime = _ctx.LongValue("DescribeGateways.Gateways["+ i +"].CreatedTime");
				gateway.ExpireStatus = _ctx.IntegerValue("DescribeGateways.Gateways["+ i +"].ExpireStatus");
				gateway.DataLoadInterval = _ctx.IntegerValue("DescribeGateways.Gateways["+ i +"].DataLoadInterval");
				gateway.RenewURL = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].RenewURL");
				gateway.IsPostPaid = _ctx.BooleanValue("DescribeGateways.Gateways["+ i +"].IsPostPaid");
				gateway.PublicNetworkBandwidth = _ctx.IntegerValue("DescribeGateways.Gateways["+ i +"].PublicNetworkBandwidth");
				gateway.StorageBundleId = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].StorageBundleId");
				gateway.Ip = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].Ip");
				gateway.LastErrorKey = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].LastErrorKey");
				gateway.Model = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].Model");
				gateway.VSwitchId = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].VSwitchId");
				gateway.CommonBuyInstanceId = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].CommonBuyInstanceId");
				gateway.ExpiredTime = _ctx.LongValue("DescribeGateways.Gateways["+ i +"].ExpiredTime");
				gateway.GatewayVersion = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].GatewayVersion");
				gateway.DataLoadType = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].DataLoadType");
				gateway.ElasticGateway = _ctx.BooleanValue("DescribeGateways.Gateways["+ i +"].ElasticGateway");
				gateway.Category = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].Category");
				gateway.ActivatedTime = _ctx.LongValue("DescribeGateways.Gateways["+ i +"].ActivatedTime");
				gateway.TaskId = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].TaskId");
				gateway.Location = _ctx.StringValue("DescribeGateways.Gateways["+ i +"].Location");

				List<string> gateway_elasticNodes = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeGateways.Gateways["+ i +"].ElasticNodes.Length"); j++) {
					gateway_elasticNodes.Add(_ctx.StringValue("DescribeGateways.Gateways["+ i +"].ElasticNodes["+ j +"]"));
				}
				gateway.ElasticNodes = gateway_elasticNodes;

				describeGatewaysResponse_gateways.Add(gateway);
			}
			describeGatewaysResponse.Gateways = describeGatewaysResponse_gateways;
        
			return describeGatewaysResponse;
        }
    }
}
