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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeInstanceAttachmentAttributesResponseUnmarshaller
    {
        public static DescribeInstanceAttachmentAttributesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceAttachmentAttributesResponse describeInstanceAttachmentAttributesResponse = new DescribeInstanceAttachmentAttributesResponse();

			describeInstanceAttachmentAttributesResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceAttachmentAttributesResponse.RequestId = _ctx.StringValue("DescribeInstanceAttachmentAttributes.RequestId");
			describeInstanceAttachmentAttributesResponse.TotalCount = _ctx.IntegerValue("DescribeInstanceAttachmentAttributes.TotalCount");
			describeInstanceAttachmentAttributesResponse.PageNumber = _ctx.IntegerValue("DescribeInstanceAttachmentAttributes.PageNumber");
			describeInstanceAttachmentAttributesResponse.PageSize = _ctx.IntegerValue("DescribeInstanceAttachmentAttributes.PageSize");

			List<DescribeInstanceAttachmentAttributesResponse.DescribeInstanceAttachmentAttributes_Instance> describeInstanceAttachmentAttributesResponse_instances = new List<DescribeInstanceAttachmentAttributesResponse.DescribeInstanceAttachmentAttributes_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceAttachmentAttributes.Instances.Length"); i++) {
				DescribeInstanceAttachmentAttributesResponse.DescribeInstanceAttachmentAttributes_Instance instance = new DescribeInstanceAttachmentAttributesResponse.DescribeInstanceAttachmentAttributes_Instance();
				instance.InstanceId = _ctx.StringValue("DescribeInstanceAttachmentAttributes.Instances["+ i +"].InstanceId");
				instance.PrivatePoolOptionsId = _ctx.StringValue("DescribeInstanceAttachmentAttributes.Instances["+ i +"].PrivatePoolOptionsId");
				instance.PrivatePoolOptionsMatchCriteria = _ctx.StringValue("DescribeInstanceAttachmentAttributes.Instances["+ i +"].PrivatePoolOptionsMatchCriteria");

				describeInstanceAttachmentAttributesResponse_instances.Add(instance);
			}
			describeInstanceAttachmentAttributesResponse.Instances = describeInstanceAttachmentAttributesResponse_instances;
        
			return describeInstanceAttachmentAttributesResponse;
        }
    }
}
