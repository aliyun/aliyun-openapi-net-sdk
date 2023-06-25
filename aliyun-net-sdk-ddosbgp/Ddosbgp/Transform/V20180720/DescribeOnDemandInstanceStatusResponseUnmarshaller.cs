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
using Aliyun.Acs.ddosbgp.Model.V20180720;

namespace Aliyun.Acs.ddosbgp.Transform.V20180720
{
    public class DescribeOnDemandInstanceStatusResponseUnmarshaller
    {
        public static DescribeOnDemandInstanceStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOnDemandInstanceStatusResponse describeOnDemandInstanceStatusResponse = new DescribeOnDemandInstanceStatusResponse();

			describeOnDemandInstanceStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeOnDemandInstanceStatusResponse.RequestId = _ctx.StringValue("DescribeOnDemandInstanceStatus.RequestId");

			List<DescribeOnDemandInstanceStatusResponse.DescribeOnDemandInstanceStatus_Instance> describeOnDemandInstanceStatusResponse_instances = new List<DescribeOnDemandInstanceStatusResponse.DescribeOnDemandInstanceStatus_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeOnDemandInstanceStatus.Instances.Length"); i++) {
				DescribeOnDemandInstanceStatusResponse.DescribeOnDemandInstanceStatus_Instance instance = new DescribeOnDemandInstanceStatusResponse.DescribeOnDemandInstanceStatus_Instance();
				instance.UserId = _ctx.StringValue("DescribeOnDemandInstanceStatus.Instances["+ i +"].UserId");
				instance.Mode = _ctx.StringValue("DescribeOnDemandInstanceStatus.Instances["+ i +"].Mode");
				instance.InstanceId = _ctx.StringValue("DescribeOnDemandInstanceStatus.Instances["+ i +"].InstanceId");
				instance.Declared = _ctx.StringValue("DescribeOnDemandInstanceStatus.Instances["+ i +"].Declared");
				instance.RegistedAs = _ctx.StringValue("DescribeOnDemandInstanceStatus.Instances["+ i +"].RegistedAs");
				instance.Net = _ctx.StringValue("DescribeOnDemandInstanceStatus.Instances["+ i +"].Net");
				instance.Desc = _ctx.StringValue("DescribeOnDemandInstanceStatus.Instances["+ i +"].Desc");

				describeOnDemandInstanceStatusResponse_instances.Add(instance);
			}
			describeOnDemandInstanceStatusResponse.Instances = describeOnDemandInstanceStatusResponse_instances;
        
			return describeOnDemandInstanceStatusResponse;
        }
    }
}
