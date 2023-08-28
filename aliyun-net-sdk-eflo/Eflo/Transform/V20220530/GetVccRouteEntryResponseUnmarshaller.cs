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
using Aliyun.Acs.eflo.Model.V20220530;

namespace Aliyun.Acs.eflo.Transform.V20220530
{
    public class GetVccRouteEntryResponseUnmarshaller
    {
        public static GetVccRouteEntryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVccRouteEntryResponse getVccRouteEntryResponse = new GetVccRouteEntryResponse();

			getVccRouteEntryResponse.HttpResponse = _ctx.HttpResponse;
			getVccRouteEntryResponse.Code = _ctx.IntegerValue("GetVccRouteEntry.Code");
			getVccRouteEntryResponse.Message = _ctx.StringValue("GetVccRouteEntry.Message");
			getVccRouteEntryResponse.RequestId = _ctx.StringValue("GetVccRouteEntry.RequestId");

			GetVccRouteEntryResponse.GetVccRouteEntry_Content content = new GetVccRouteEntryResponse.GetVccRouteEntry_Content();
			content.RegionId = _ctx.StringValue("GetVccRouteEntry.Content.RegionId");
			content.VccRouteEntryId = _ctx.StringValue("GetVccRouteEntry.Content.VccRouteEntryId");
			content.TenantId = _ctx.StringValue("GetVccRouteEntry.Content.TenantId");
			content.VccId = _ctx.StringValue("GetVccRouteEntry.Content.VccId");
			content.DestinationCidrBlock = _ctx.StringValue("GetVccRouteEntry.Content.DestinationCidrBlock");
			content.NextHopType = _ctx.StringValue("GetVccRouteEntry.Content.NextHopType");
			content.NextHopId = _ctx.StringValue("GetVccRouteEntry.Content.NextHopId");
			content.RouteType = _ctx.StringValue("GetVccRouteEntry.Content.RouteType");
			content.Status = _ctx.StringValue("GetVccRouteEntry.Content.Status");
			content.GmtModified = _ctx.StringValue("GetVccRouteEntry.Content.GmtModified");
			getVccRouteEntryResponse.Content = content;
        
			return getVccRouteEntryResponse;
        }
    }
}
