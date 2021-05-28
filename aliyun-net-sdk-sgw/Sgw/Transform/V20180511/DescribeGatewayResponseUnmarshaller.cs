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
    public class DescribeGatewayResponseUnmarshaller
    {
        public static DescribeGatewayResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGatewayResponse describeGatewayResponse = new DescribeGatewayResponse();

			describeGatewayResponse.HttpResponse = _ctx.HttpResponse;
			describeGatewayResponse.RequestId = _ctx.StringValue("DescribeGateway.RequestId");
			describeGatewayResponse.Success = _ctx.BooleanValue("DescribeGateway.Success");
			describeGatewayResponse.Code = _ctx.StringValue("DescribeGateway.Code");
			describeGatewayResponse.Message = _ctx.StringValue("DescribeGateway.Message");
			describeGatewayResponse.GatewayId = _ctx.StringValue("DescribeGateway.GatewayId");
			describeGatewayResponse.StorageBundleId = _ctx.StringValue("DescribeGateway.StorageBundleId");
			describeGatewayResponse.Name = _ctx.StringValue("DescribeGateway.Name");
			describeGatewayResponse.Description = _ctx.StringValue("DescribeGateway.Description");
			describeGatewayResponse.Location = _ctx.StringValue("DescribeGateway.Location");
			describeGatewayResponse.Category = _ctx.StringValue("DescribeGateway.Category");
			describeGatewayResponse.Type = _ctx.StringValue("DescribeGateway.Type");
			describeGatewayResponse.GatewayClass = _ctx.StringValue("DescribeGateway.GatewayClass");
			describeGatewayResponse.Model = _ctx.StringValue("DescribeGateway.Model");
			describeGatewayResponse.SerialNumber = _ctx.StringValue("DescribeGateway.SerialNumber");
			describeGatewayResponse.Status = _ctx.StringValue("DescribeGateway.Status");
			describeGatewayResponse.EcsInstanceId = _ctx.StringValue("DescribeGateway.EcsInstanceId");
			describeGatewayResponse.VpcId = _ctx.StringValue("DescribeGateway.VpcId");
			describeGatewayResponse.VSwitchId = _ctx.StringValue("DescribeGateway.VSwitchId");
			describeGatewayResponse.Ip = _ctx.StringValue("DescribeGateway.Ip");
			describeGatewayResponse.InnerIp = _ctx.StringValue("DescribeGateway.InnerIp");
			describeGatewayResponse.CreatedTime = _ctx.LongValue("DescribeGateway.CreatedTime");
			describeGatewayResponse.ActivatedTime = _ctx.LongValue("DescribeGateway.ActivatedTime");
			describeGatewayResponse.TaskId = _ctx.StringValue("DescribeGateway.TaskId");
			describeGatewayResponse.GatewayVersion = _ctx.StringValue("DescribeGateway.GatewayVersion");
			describeGatewayResponse.BuyURL = _ctx.StringValue("DescribeGateway.BuyURL");
			describeGatewayResponse.RenewURL = _ctx.StringValue("DescribeGateway.RenewURL");
			describeGatewayResponse.IsPostPaid = _ctx.BooleanValue("DescribeGateway.IsPostPaid");
			describeGatewayResponse.IsReleaseAfterExpiration = _ctx.BooleanValue("DescribeGateway.IsReleaseAfterExpiration");
			describeGatewayResponse.ExpiredTime = _ctx.LongValue("DescribeGateway.ExpiredTime");
			describeGatewayResponse.ExpireStatus = _ctx.IntegerValue("DescribeGateway.ExpireStatus");
			describeGatewayResponse.CommonBuyInstanceId = _ctx.StringValue("DescribeGateway.CommonBuyInstanceId");
			describeGatewayResponse.PublicNetworkBandwidth = _ctx.IntegerValue("DescribeGateway.PublicNetworkBandwidth");
			describeGatewayResponse.GatewayType = _ctx.StringValue("DescribeGateway.GatewayType");
			describeGatewayResponse.ElasticGateway = _ctx.BooleanValue("DescribeGateway.ElasticGateway");
			describeGatewayResponse.MaxThroughput = _ctx.IntegerValue("DescribeGateway.MaxThroughput");
			describeGatewayResponse.Capacity = _ctx.IntegerValue("DescribeGateway.Capacity");
			describeGatewayResponse.DataLoadType = _ctx.StringValue("DescribeGateway.DataLoadType");
			describeGatewayResponse.DataLoadInterval = _ctx.IntegerValue("DescribeGateway.DataLoadInterval");
			describeGatewayResponse.LastErrorKey = _ctx.StringValue("DescribeGateway.LastErrorKey");
			describeGatewayResponse.InnerIpv6Ip = _ctx.StringValue("DescribeGateway.InnerIpv6Ip");

			List<string> describeGatewayResponse_elasticNodes = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeGateway.ElasticNodes.Length"); i++) {
				describeGatewayResponse_elasticNodes.Add(_ctx.StringValue("DescribeGateway.ElasticNodes["+ i +"]"));
			}
			describeGatewayResponse.ElasticNodes = describeGatewayResponse_elasticNodes;
        
			return describeGatewayResponse;
        }
    }
}
