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
        public static DescribeGatewaysResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGatewaysResponse describeGatewaysResponse = new DescribeGatewaysResponse();

			describeGatewaysResponse.HttpResponse = context.HttpResponse;
			describeGatewaysResponse.RequestId = context.StringValue("DescribeGateways.RequestId");
			describeGatewaysResponse.Success = context.BooleanValue("DescribeGateways.Success");
			describeGatewaysResponse.Code = context.StringValue("DescribeGateways.Code");
			describeGatewaysResponse.Message = context.StringValue("DescribeGateways.Message");
			describeGatewaysResponse.TotalCount = context.IntegerValue("DescribeGateways.TotalCount");
			describeGatewaysResponse.PageNumber = context.IntegerValue("DescribeGateways.PageNumber");
			describeGatewaysResponse.PageSize = context.IntegerValue("DescribeGateways.PageSize");

			List<DescribeGatewaysResponse.DescribeGateways_Gateway> describeGatewaysResponse_gateways = new List<DescribeGatewaysResponse.DescribeGateways_Gateway>();
			for (int i = 0; i < context.Length("DescribeGateways.Gateways.Length"); i++) {
				DescribeGatewaysResponse.DescribeGateways_Gateway gateway = new DescribeGatewaysResponse.DescribeGateways_Gateway();
				gateway.GatewayId = context.StringValue("DescribeGateways.Gateways["+ i +"].GatewayId");
				gateway.StorageBundleId = context.StringValue("DescribeGateways.Gateways["+ i +"].StorageBundleId");
				gateway.Name = context.StringValue("DescribeGateways.Gateways["+ i +"].Name");
				gateway.Description = context.StringValue("DescribeGateways.Gateways["+ i +"].Description");
				gateway.Location = context.StringValue("DescribeGateways.Gateways["+ i +"].Location");
				gateway.Category = context.StringValue("DescribeGateways.Gateways["+ i +"].Category");
				gateway.Type = context.StringValue("DescribeGateways.Gateways["+ i +"].Type");
				gateway.GatewayClass = context.StringValue("DescribeGateways.Gateways["+ i +"].GatewayClass");
				gateway.Model = context.StringValue("DescribeGateways.Gateways["+ i +"].Model");
				gateway.SerialNumber = context.StringValue("DescribeGateways.Gateways["+ i +"].SerialNumber");
				gateway.Status = context.StringValue("DescribeGateways.Gateways["+ i +"].Status");
				gateway.EcsInstanceId = context.StringValue("DescribeGateways.Gateways["+ i +"].EcsInstanceId");
				gateway.VpcId = context.StringValue("DescribeGateways.Gateways["+ i +"].VpcId");
				gateway.VSwitchId = context.StringValue("DescribeGateways.Gateways["+ i +"].VSwitchId");
				gateway.Ip = context.StringValue("DescribeGateways.Gateways["+ i +"].Ip");
				gateway.InnerIp = context.StringValue("DescribeGateways.Gateways["+ i +"].InnerIp");
				gateway.CreatedTime = context.LongValue("DescribeGateways.Gateways["+ i +"].CreatedTime");
				gateway.ActivatedTime = context.LongValue("DescribeGateways.Gateways["+ i +"].ActivatedTime");
				gateway.TaskId = context.StringValue("DescribeGateways.Gateways["+ i +"].TaskId");
				gateway.GatewayVersion = context.StringValue("DescribeGateways.Gateways["+ i +"].GatewayVersion");
				gateway.BuyURL = context.StringValue("DescribeGateways.Gateways["+ i +"].BuyURL");
				gateway.RenewURL = context.StringValue("DescribeGateways.Gateways["+ i +"].RenewURL");
				gateway.IsPostPaid = context.BooleanValue("DescribeGateways.Gateways["+ i +"].IsPostPaid");
				gateway.IsReleaseAfterExpiration = context.BooleanValue("DescribeGateways.Gateways["+ i +"].IsReleaseAfterExpiration");
				gateway.ExpiredTime = context.LongValue("DescribeGateways.Gateways["+ i +"].ExpiredTime");
				gateway.ExpireStatus = context.IntegerValue("DescribeGateways.Gateways["+ i +"].ExpireStatus");
				gateway.CommonBuyInstanceId = context.StringValue("DescribeGateways.Gateways["+ i +"].CommonBuyInstanceId");
				gateway.PublicNetworkBandwidth = context.IntegerValue("DescribeGateways.Gateways["+ i +"].PublicNetworkBandwidth");
				gateway.GatewayType = context.StringValue("DescribeGateways.Gateways["+ i +"].GatewayType");
				gateway.ElasticGateway = context.BooleanValue("DescribeGateways.Gateways["+ i +"].ElasticGateway");
				gateway.MaxThroughput = context.IntegerValue("DescribeGateways.Gateways["+ i +"].MaxThroughput");
				gateway.Capacity = context.IntegerValue("DescribeGateways.Gateways["+ i +"].Capacity");
				gateway.DataLoadType = context.StringValue("DescribeGateways.Gateways["+ i +"].DataLoadType");
				gateway.DataLoadInterval = context.IntegerValue("DescribeGateways.Gateways["+ i +"].DataLoadInterval");
				gateway.LastErrorKey = context.StringValue("DescribeGateways.Gateways["+ i +"].LastErrorKey");

				List<string> gateway_elasticNodes = new List<string>();
				for (int j = 0; j < context.Length("DescribeGateways.Gateways["+ i +"].ElasticNodes.Length"); j++) {
					gateway_elasticNodes.Add(context.StringValue("DescribeGateways.Gateways["+ i +"].ElasticNodes["+ j +"]"));
				}
				gateway.ElasticNodes = gateway_elasticNodes;

				describeGatewaysResponse_gateways.Add(gateway);
			}
			describeGatewaysResponse.Gateways = describeGatewaysResponse_gateways;
        
			return describeGatewaysResponse;
        }
    }
}
