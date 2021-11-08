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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class DescribeApmResponseUnmarshaller
    {
        public static DescribeApmResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeApmResponse describeApmResponse = new DescribeApmResponse();

			describeApmResponse.HttpResponse = _ctx.HttpResponse;
			describeApmResponse.RequestId = _ctx.StringValue("DescribeApm.RequestId");

			DescribeApmResponse.DescribeApm_Result result = new DescribeApmResponse.DescribeApm_Result();
			result.CreatedAt = _ctx.StringValue("DescribeApm.Result.CreatedAt");
			result.DeployedReplica = _ctx.LongValue("DescribeApm.Result.DeployedReplica");
			result.Description = _ctx.StringValue("DescribeApm.Result.Description");
			result.EndTime = _ctx.LongValue("DescribeApm.Result.EndTime");
			result.InstanceId = _ctx.StringValue("DescribeApm.Result.InstanceId");
			result.NodeAmount = _ctx.LongValue("DescribeApm.Result.NodeAmount");
			result.OutputES = _ctx.StringValue("DescribeApm.Result.OutputES");
			result.OutputESUserName = _ctx.StringValue("DescribeApm.Result.OutputESUserName");
			result.OutputEsDescription = _ctx.StringValue("DescribeApm.Result.OutputEsDescription");
			result.OwnerId = _ctx.StringValue("DescribeApm.Result.OwnerId");
			result.PaymentType = _ctx.StringValue("DescribeApm.Result.PaymentType");
			result.Region = _ctx.StringValue("DescribeApm.Result.Region");
			result.Replica = _ctx.LongValue("DescribeApm.Result.Replica");
			result.ResourceSpec = _ctx.StringValue("DescribeApm.Result.ResourceSpec");
			result.Status = _ctx.StringValue("DescribeApm.Result.Status");
			result.Version = _ctx.StringValue("DescribeApm.Result.Version");
			result.VpcId = _ctx.StringValue("DescribeApm.Result.VpcId");
			result.VsArea = _ctx.StringValue("DescribeApm.Result.VsArea");
			result.VswitchId = _ctx.StringValue("DescribeApm.Result.VswitchId");
			describeApmResponse.Result = result;
        
			return describeApmResponse;
        }
    }
}
