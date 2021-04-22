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
        public static DescribeCenAttachedChildInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCenAttachedChildInstancesResponse describeCenAttachedChildInstancesResponse = new DescribeCenAttachedChildInstancesResponse();

			describeCenAttachedChildInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeCenAttachedChildInstancesResponse.RequestId = _ctx.StringValue("DescribeCenAttachedChildInstances.RequestId");
			describeCenAttachedChildInstancesResponse.TotalCount = _ctx.IntegerValue("DescribeCenAttachedChildInstances.TotalCount");
			describeCenAttachedChildInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeCenAttachedChildInstances.PageNumber");
			describeCenAttachedChildInstancesResponse.PageSize = _ctx.IntegerValue("DescribeCenAttachedChildInstances.PageSize");

			List<DescribeCenAttachedChildInstancesResponse.DescribeCenAttachedChildInstances_ChildInstance> describeCenAttachedChildInstancesResponse_childInstances = new List<DescribeCenAttachedChildInstancesResponse.DescribeCenAttachedChildInstances_ChildInstance>();
			for (int i = 0; i < _ctx.Length("DescribeCenAttachedChildInstances.ChildInstances.Length"); i++) {
				DescribeCenAttachedChildInstancesResponse.DescribeCenAttachedChildInstances_ChildInstance childInstance = new DescribeCenAttachedChildInstancesResponse.DescribeCenAttachedChildInstances_ChildInstance();
				childInstance.CenId = _ctx.StringValue("DescribeCenAttachedChildInstances.ChildInstances["+ i +"].CenId");
				childInstance.ChildInstanceId = _ctx.StringValue("DescribeCenAttachedChildInstances.ChildInstances["+ i +"].ChildInstanceId");
				childInstance.ChildInstanceType = _ctx.StringValue("DescribeCenAttachedChildInstances.ChildInstances["+ i +"].ChildInstanceType");
				childInstance.ChildInstanceRegionId = _ctx.StringValue("DescribeCenAttachedChildInstances.ChildInstances["+ i +"].ChildInstanceRegionId");
				childInstance.ChildInstanceOwnerId = _ctx.LongValue("DescribeCenAttachedChildInstances.ChildInstances["+ i +"].ChildInstanceOwnerId");
				childInstance.Status = _ctx.StringValue("DescribeCenAttachedChildInstances.ChildInstances["+ i +"].Status");
				childInstance.ChildInstanceAttachTime = _ctx.StringValue("DescribeCenAttachedChildInstances.ChildInstances["+ i +"].ChildInstanceAttachTime");

				describeCenAttachedChildInstancesResponse_childInstances.Add(childInstance);
			}
			describeCenAttachedChildInstancesResponse.ChildInstances = describeCenAttachedChildInstancesResponse_childInstances;
        
			return describeCenAttachedChildInstancesResponse;
        }
    }
}
