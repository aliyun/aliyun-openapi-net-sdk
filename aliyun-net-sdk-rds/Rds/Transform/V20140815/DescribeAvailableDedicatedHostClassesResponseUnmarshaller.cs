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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeAvailableDedicatedHostClassesResponseUnmarshaller
    {
        public static DescribeAvailableDedicatedHostClassesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAvailableDedicatedHostClassesResponse describeAvailableDedicatedHostClassesResponse = new DescribeAvailableDedicatedHostClassesResponse();

			describeAvailableDedicatedHostClassesResponse.HttpResponse = _ctx.HttpResponse;
			describeAvailableDedicatedHostClassesResponse.RequestId = _ctx.StringValue("DescribeAvailableDedicatedHostClasses.RequestId");

			List<DescribeAvailableDedicatedHostClassesResponse.DescribeAvailableDedicatedHostClasses_HostClassesItem> describeAvailableDedicatedHostClassesResponse_hostClasses = new List<DescribeAvailableDedicatedHostClassesResponse.DescribeAvailableDedicatedHostClasses_HostClassesItem>();
			for (int i = 0; i < _ctx.Length("DescribeAvailableDedicatedHostClasses.HostClasses.Length"); i++) {
				DescribeAvailableDedicatedHostClassesResponse.DescribeAvailableDedicatedHostClasses_HostClassesItem hostClassesItem = new DescribeAvailableDedicatedHostClassesResponse.DescribeAvailableDedicatedHostClasses_HostClassesItem();
				hostClassesItem.HostClassName = _ctx.StringValue("DescribeAvailableDedicatedHostClasses.HostClasses["+ i +"].HostClassName");
				hostClassesItem.Description = _ctx.StringValue("DescribeAvailableDedicatedHostClasses.HostClasses["+ i +"].Description");

				describeAvailableDedicatedHostClassesResponse_hostClasses.Add(hostClassesItem);
			}
			describeAvailableDedicatedHostClassesResponse.HostClasses = describeAvailableDedicatedHostClassesResponse_hostClasses;
        
			return describeAvailableDedicatedHostClassesResponse;
        }
    }
}
