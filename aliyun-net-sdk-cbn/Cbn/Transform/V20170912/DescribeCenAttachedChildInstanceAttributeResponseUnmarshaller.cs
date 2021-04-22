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
    public class DescribeCenAttachedChildInstanceAttributeResponseUnmarshaller
    {
        public static DescribeCenAttachedChildInstanceAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCenAttachedChildInstanceAttributeResponse describeCenAttachedChildInstanceAttributeResponse = new DescribeCenAttachedChildInstanceAttributeResponse();

			describeCenAttachedChildInstanceAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeCenAttachedChildInstanceAttributeResponse.RequestId = _ctx.StringValue("DescribeCenAttachedChildInstanceAttribute.RequestId");
			describeCenAttachedChildInstanceAttributeResponse.CenId = _ctx.StringValue("DescribeCenAttachedChildInstanceAttribute.CenId");
			describeCenAttachedChildInstanceAttributeResponse.ChildInstanceId = _ctx.StringValue("DescribeCenAttachedChildInstanceAttribute.ChildInstanceId");
			describeCenAttachedChildInstanceAttributeResponse.ChildInstanceType = _ctx.StringValue("DescribeCenAttachedChildInstanceAttribute.ChildInstanceType");
			describeCenAttachedChildInstanceAttributeResponse.ChildInstanceRegionId = _ctx.StringValue("DescribeCenAttachedChildInstanceAttribute.ChildInstanceRegionId");
			describeCenAttachedChildInstanceAttributeResponse.ChildInstanceOwnerId = _ctx.LongValue("DescribeCenAttachedChildInstanceAttribute.ChildInstanceOwnerId");
			describeCenAttachedChildInstanceAttributeResponse.Status = _ctx.StringValue("DescribeCenAttachedChildInstanceAttribute.Status");
			describeCenAttachedChildInstanceAttributeResponse.ChildInstanceName = _ctx.StringValue("DescribeCenAttachedChildInstanceAttribute.ChildInstanceName");
			describeCenAttachedChildInstanceAttributeResponse.ChildInstanceAttachTime = _ctx.StringValue("DescribeCenAttachedChildInstanceAttribute.ChildInstanceAttachTime");
			describeCenAttachedChildInstanceAttributeResponse.Ipv6StatusInCen = _ctx.StringValue("DescribeCenAttachedChildInstanceAttribute.Ipv6StatusInCen");

			List<DescribeCenAttachedChildInstanceAttributeResponse.DescribeCenAttachedChildInstanceAttribute_ChildInstanceRouteTable> describeCenAttachedChildInstanceAttributeResponse_childInstanceRouteTables = new List<DescribeCenAttachedChildInstanceAttributeResponse.DescribeCenAttachedChildInstanceAttribute_ChildInstanceRouteTable>();
			for (int i = 0; i < _ctx.Length("DescribeCenAttachedChildInstanceAttribute.ChildInstanceRouteTables.Length"); i++) {
				DescribeCenAttachedChildInstanceAttributeResponse.DescribeCenAttachedChildInstanceAttribute_ChildInstanceRouteTable childInstanceRouteTable = new DescribeCenAttachedChildInstanceAttributeResponse.DescribeCenAttachedChildInstanceAttribute_ChildInstanceRouteTable();
				childInstanceRouteTable.RouteTableId = _ctx.StringValue("DescribeCenAttachedChildInstanceAttribute.ChildInstanceRouteTables["+ i +"].RouteTableId");
				childInstanceRouteTable.RouteTableType = _ctx.StringValue("DescribeCenAttachedChildInstanceAttribute.ChildInstanceRouteTables["+ i +"].RouteTableType");

				describeCenAttachedChildInstanceAttributeResponse_childInstanceRouteTables.Add(childInstanceRouteTable);
			}
			describeCenAttachedChildInstanceAttributeResponse.ChildInstanceRouteTables = describeCenAttachedChildInstanceAttributeResponse_childInstanceRouteTables;
        
			return describeCenAttachedChildInstanceAttributeResponse;
        }
    }
}
