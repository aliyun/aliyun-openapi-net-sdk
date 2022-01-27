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
			describeGatewayResponse.Description = _ctx.StringValue("DescribeGateway.Description");
			describeGatewayResponse.CreatedTime = _ctx.LongValue("DescribeGateway.CreatedTime");
			describeGatewayResponse.PublicNetworkBandwidth = _ctx.IntegerValue("DescribeGateway.PublicNetworkBandwidth");
			describeGatewayResponse.DataLoadType = _ctx.StringValue("DescribeGateway.DataLoadType");
			describeGatewayResponse.Category = _ctx.StringValue("DescribeGateway.Category");
			describeGatewayResponse.TaskId = _ctx.StringValue("DescribeGateway.TaskId");
			describeGatewayResponse.Message = _ctx.StringValue("DescribeGateway.Message");
			describeGatewayResponse.ExpireStatus = _ctx.IntegerValue("DescribeGateway.ExpireStatus");
			describeGatewayResponse.Ip = _ctx.StringValue("DescribeGateway.Ip");
			describeGatewayResponse.GatewayType = _ctx.StringValue("DescribeGateway.GatewayType");
			describeGatewayResponse.StorageBundleId = _ctx.StringValue("DescribeGateway.StorageBundleId");
			describeGatewayResponse.GatewayClass = _ctx.StringValue("DescribeGateway.GatewayClass");
			describeGatewayResponse.Success = _ctx.BooleanValue("DescribeGateway.Success");
			describeGatewayResponse.Name = _ctx.StringValue("DescribeGateway.Name");
			describeGatewayResponse.IsPostPaid = _ctx.BooleanValue("DescribeGateway.IsPostPaid");
			describeGatewayResponse.Capacity = _ctx.IntegerValue("DescribeGateway.Capacity");
			describeGatewayResponse.ExpiredTime = _ctx.LongValue("DescribeGateway.ExpiredTime");
			describeGatewayResponse.GatewayVersion = _ctx.StringValue("DescribeGateway.GatewayVersion");
			describeGatewayResponse.IsReleaseAfterExpiration = _ctx.BooleanValue("DescribeGateway.IsReleaseAfterExpiration");
			describeGatewayResponse.Status = _ctx.StringValue("DescribeGateway.Status");
			describeGatewayResponse.BuyURL = _ctx.StringValue("DescribeGateway.BuyURL");
			describeGatewayResponse.MaxThroughput = _ctx.IntegerValue("DescribeGateway.MaxThroughput");
			describeGatewayResponse.DataLoadInterval = _ctx.IntegerValue("DescribeGateway.DataLoadInterval");
			describeGatewayResponse.InnerIp = _ctx.StringValue("DescribeGateway.InnerIp");
			describeGatewayResponse.RequestId = _ctx.StringValue("DescribeGateway.RequestId");
			describeGatewayResponse.VSwitchId = _ctx.StringValue("DescribeGateway.VSwitchId");
			describeGatewayResponse.GatewayId = _ctx.StringValue("DescribeGateway.GatewayId");
			describeGatewayResponse.Code = _ctx.StringValue("DescribeGateway.Code");
			describeGatewayResponse.EcsInstanceId = _ctx.StringValue("DescribeGateway.EcsInstanceId");
			describeGatewayResponse.Type = _ctx.StringValue("DescribeGateway.Type");
			describeGatewayResponse.RenewURL = _ctx.StringValue("DescribeGateway.RenewURL");
			describeGatewayResponse.VpcId = _ctx.StringValue("DescribeGateway.VpcId");
			describeGatewayResponse.SerialNumber = _ctx.StringValue("DescribeGateway.SerialNumber");
			describeGatewayResponse.ActivatedTime = _ctx.LongValue("DescribeGateway.ActivatedTime");
			describeGatewayResponse.ElasticGateway = _ctx.BooleanValue("DescribeGateway.ElasticGateway");
			describeGatewayResponse.CommonBuyInstanceId = _ctx.StringValue("DescribeGateway.CommonBuyInstanceId");
			describeGatewayResponse.InnerIpv6Ip = _ctx.StringValue("DescribeGateway.InnerIpv6Ip");
			describeGatewayResponse.Model = _ctx.StringValue("DescribeGateway.Model");
			describeGatewayResponse.LastErrorKey = _ctx.StringValue("DescribeGateway.LastErrorKey");
			describeGatewayResponse.Location = _ctx.StringValue("DescribeGateway.Location");

			List<string> describeGatewayResponse_elasticNodes = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeGateway.ElasticNodes.Length"); i++) {
				describeGatewayResponse_elasticNodes.Add(_ctx.StringValue("DescribeGateway.ElasticNodes["+ i +"]"));
			}
			describeGatewayResponse.ElasticNodes = describeGatewayResponse_elasticNodes;
        
			return describeGatewayResponse;
        }
    }
}
