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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class DescribeInstanceResponseUnmarshaller
    {
        public static DescribeInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceResponse describeInstanceResponse = new DescribeInstanceResponse();

			describeInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceResponse.Code = _ctx.StringValue("DescribeInstance.Code");
			describeInstanceResponse.HttpStatusCode = _ctx.IntegerValue("DescribeInstance.HttpStatusCode");
			describeInstanceResponse.Message = _ctx.StringValue("DescribeInstance.Message");
			describeInstanceResponse.RequestId = _ctx.StringValue("DescribeInstance.RequestId");
			describeInstanceResponse.Success = _ctx.BooleanValue("DescribeInstance.Success");

			DescribeInstanceResponse.DescribeInstance_Instance instance = new DescribeInstanceResponse.DescribeInstance_Instance();
			instance.CallCenterInstanceId = _ctx.StringValue("DescribeInstance.Instance.CallCenterInstanceId");
			instance.CreationTime = _ctx.LongValue("DescribeInstance.Instance.CreationTime");
			instance.InstanceDescription = _ctx.StringValue("DescribeInstance.Instance.InstanceDescription");
			instance.InstanceId = _ctx.StringValue("DescribeInstance.Instance.InstanceId");
			instance.InstanceName = _ctx.StringValue("DescribeInstance.Instance.InstanceName");
			instance.MaxConcurrentConversation = _ctx.IntegerValue("DescribeInstance.Instance.MaxConcurrentConversation");
			instance.NluServiceType = _ctx.StringValue("DescribeInstance.Instance.NluServiceType");
			instance.Owner = _ctx.StringValue("DescribeInstance.Instance.Owner");
			instance.CreatorId = _ctx.LongValue("DescribeInstance.Instance.CreatorId");
			instance.CreatorName = _ctx.StringValue("DescribeInstance.Instance.CreatorName");
			instance.OwnerName = _ctx.StringValue("DescribeInstance.Instance.OwnerName");
			instance.ResourceGroupId = _ctx.StringValue("DescribeInstance.Instance.ResourceGroupId");

			DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_NluProfile nluProfile = new DescribeInstanceResponse.DescribeInstance_Instance.DescribeInstance_NluProfile();
			nluProfile.AccessKey = _ctx.StringValue("DescribeInstance.Instance.NluProfile.AccessKey");
			nluProfile.Endpoint = _ctx.StringValue("DescribeInstance.Instance.NluProfile.Endpoint");
			nluProfile.SecretKey = _ctx.StringValue("DescribeInstance.Instance.NluProfile.SecretKey");
			instance.NluProfile = nluProfile;
			describeInstanceResponse.Instance = instance;
        
			return describeInstanceResponse;
        }
    }
}
