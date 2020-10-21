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
        public static DescribeGatewayResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGatewayResponse describeGatewayResponse = new DescribeGatewayResponse();

			describeGatewayResponse.HttpResponse = context.HttpResponse;
			describeGatewayResponse.RequestId = context.StringValue("DescribeGateway.RequestId");
			describeGatewayResponse.Success = context.BooleanValue("DescribeGateway.Success");
			describeGatewayResponse.Code = context.StringValue("DescribeGateway.Code");
			describeGatewayResponse.Message = context.StringValue("DescribeGateway.Message");
			describeGatewayResponse.GatewayId = context.StringValue("DescribeGateway.GatewayId");
			describeGatewayResponse.StorageBundleId = context.StringValue("DescribeGateway.StorageBundleId");
			describeGatewayResponse.Name = context.StringValue("DescribeGateway.Name");
			describeGatewayResponse.Description = context.StringValue("DescribeGateway.Description");
			describeGatewayResponse.Location = context.StringValue("DescribeGateway.Location");
			describeGatewayResponse.Category = context.StringValue("DescribeGateway.Category");
			describeGatewayResponse.Type = context.StringValue("DescribeGateway.Type");
			describeGatewayResponse.GatewayClass = context.StringValue("DescribeGateway.GatewayClass");
			describeGatewayResponse.Model = context.StringValue("DescribeGateway.Model");
			describeGatewayResponse.SerialNumber = context.StringValue("DescribeGateway.SerialNumber");
			describeGatewayResponse.Status = context.StringValue("DescribeGateway.Status");
			describeGatewayResponse.EcsInstanceId = context.StringValue("DescribeGateway.EcsInstanceId");
			describeGatewayResponse.VpcId = context.StringValue("DescribeGateway.VpcId");
			describeGatewayResponse.VSwitchId = context.StringValue("DescribeGateway.VSwitchId");
			describeGatewayResponse.Ip = context.StringValue("DescribeGateway.Ip");
			describeGatewayResponse.InnerIp = context.StringValue("DescribeGateway.InnerIp");
			describeGatewayResponse.CreatedTime = context.LongValue("DescribeGateway.CreatedTime");
			describeGatewayResponse.ActivatedTime = context.LongValue("DescribeGateway.ActivatedTime");
			describeGatewayResponse.TaskId = context.StringValue("DescribeGateway.TaskId");
			describeGatewayResponse.GatewayVersion = context.StringValue("DescribeGateway.GatewayVersion");
			describeGatewayResponse.BuyURL = context.StringValue("DescribeGateway.BuyURL");
			describeGatewayResponse.RenewURL = context.StringValue("DescribeGateway.RenewURL");
			describeGatewayResponse.IsPostPaid = context.BooleanValue("DescribeGateway.IsPostPaid");
			describeGatewayResponse.IsReleaseAfterExpiration = context.BooleanValue("DescribeGateway.IsReleaseAfterExpiration");
			describeGatewayResponse.ExpiredTime = context.LongValue("DescribeGateway.ExpiredTime");
			describeGatewayResponse.ExpireStatus = context.IntegerValue("DescribeGateway.ExpireStatus");
			describeGatewayResponse.CommonBuyInstanceId = context.StringValue("DescribeGateway.CommonBuyInstanceId");
			describeGatewayResponse.PublicNetworkBandwidth = context.IntegerValue("DescribeGateway.PublicNetworkBandwidth");
			describeGatewayResponse.GatewayType = context.StringValue("DescribeGateway.GatewayType");
			describeGatewayResponse.ElasticGateway = context.BooleanValue("DescribeGateway.ElasticGateway");
			describeGatewayResponse.MaxThroughput = context.IntegerValue("DescribeGateway.MaxThroughput");
			describeGatewayResponse.Capacity = context.IntegerValue("DescribeGateway.Capacity");
			describeGatewayResponse.DataLoadType = context.StringValue("DescribeGateway.DataLoadType");
			describeGatewayResponse.DataLoadInterval = context.IntegerValue("DescribeGateway.DataLoadInterval");
			describeGatewayResponse.LastErrorKey = context.StringValue("DescribeGateway.LastErrorKey");

			List<string> describeGatewayResponse_elasticNodes = new List<string>();
			for (int i = 0; i < context.Length("DescribeGateway.ElasticNodes.Length"); i++) {
				describeGatewayResponse_elasticNodes.Add(context.StringValue("DescribeGateway.ElasticNodes["+ i +"]"));
			}
			describeGatewayResponse.ElasticNodes = describeGatewayResponse_elasticNodes;
        
			return describeGatewayResponse;
        }
    }
}
