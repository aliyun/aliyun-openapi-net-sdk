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
using Aliyun.Acs.Cbn.Model.V20170912;

namespace Aliyun.Acs.Cbn.Transform.V20170912
{
    public class DescribeCenAttachedChildInstancesResponseUnmarshaller
    {
        public static DescribeCenAttachedChildInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCenAttachedChildInstancesResponse describeCenAttachedChildInstancesResponse = new DescribeCenAttachedChildInstancesResponse();

			describeCenAttachedChildInstancesResponse.HttpResponse = context.HttpResponse;
			describeCenAttachedChildInstancesResponse.RequestId = context.StringValue("DescribeCenAttachedChildInstances.RequestId");
			describeCenAttachedChildInstancesResponse.TotalCount = context.IntegerValue("DescribeCenAttachedChildInstances.TotalCount");
			describeCenAttachedChildInstancesResponse.PageNumber = context.IntegerValue("DescribeCenAttachedChildInstances.PageNumber");
			describeCenAttachedChildInstancesResponse.PageSize = context.IntegerValue("DescribeCenAttachedChildInstances.PageSize");

			List<DescribeCenAttachedChildInstancesResponse.DescribeCenAttachedChildInstances_ChildInstance> describeCenAttachedChildInstancesResponse_childInstances = new List<DescribeCenAttachedChildInstancesResponse.DescribeCenAttachedChildInstances_ChildInstance>();
			for (int i = 0; i < context.Length("DescribeCenAttachedChildInstances.ChildInstances.Length"); i++) {
				DescribeCenAttachedChildInstancesResponse.DescribeCenAttachedChildInstances_ChildInstance childInstance = new DescribeCenAttachedChildInstancesResponse.DescribeCenAttachedChildInstances_ChildInstance();
				childInstance.CenId = context.StringValue("DescribeCenAttachedChildInstances.ChildInstances["+ i +"].CenId");
				childInstance.ChildInstanceId = context.StringValue("DescribeCenAttachedChildInstances.ChildInstances["+ i +"].ChildInstanceId");
				childInstance.ChildInstanceType = context.StringValue("DescribeCenAttachedChildInstances.ChildInstances["+ i +"].ChildInstanceType");
				childInstance.ChildInstanceRegionId = context.StringValue("DescribeCenAttachedChildInstances.ChildInstances["+ i +"].ChildInstanceRegionId");
				childInstance.ChildInstanceOwnerId = context.LongValue("DescribeCenAttachedChildInstances.ChildInstances["+ i +"].ChildInstanceOwnerId");
				childInstance.Status = context.StringValue("DescribeCenAttachedChildInstances.ChildInstances["+ i +"].Status");
				childInstance.ChildInstanceAttachTime = context.StringValue("DescribeCenAttachedChildInstances.ChildInstances["+ i +"].ChildInstanceAttachTime");

				describeCenAttachedChildInstancesResponse_childInstances.Add(childInstance);
			}
			describeCenAttachedChildInstancesResponse.ChildInstances = describeCenAttachedChildInstancesResponse_childInstances;
        
			return describeCenAttachedChildInstancesResponse;
        }
    }
}
