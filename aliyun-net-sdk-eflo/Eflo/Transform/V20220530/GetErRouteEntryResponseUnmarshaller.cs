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
    public class GetErRouteEntryResponseUnmarshaller
    {
        public static GetErRouteEntryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetErRouteEntryResponse getErRouteEntryResponse = new GetErRouteEntryResponse();

			getErRouteEntryResponse.HttpResponse = _ctx.HttpResponse;
			getErRouteEntryResponse.Code = _ctx.IntegerValue("GetErRouteEntry.Code");
			getErRouteEntryResponse.Message = _ctx.StringValue("GetErRouteEntry.Message");
			getErRouteEntryResponse.RequestId = _ctx.StringValue("GetErRouteEntry.RequestId");

			GetErRouteEntryResponse.GetErRouteEntry_Content content = new GetErRouteEntryResponse.GetErRouteEntry_Content();
			content.RegionId = _ctx.StringValue("GetErRouteEntry.Content.RegionId");
			content.ErRouteEntryId = _ctx.StringValue("GetErRouteEntry.Content.ErRouteEntryId");
			content.TenantId = _ctx.StringValue("GetErRouteEntry.Content.TenantId");
			content.ErId = _ctx.StringValue("GetErRouteEntry.Content.ErId");
			content.DestinationCidrBlock = _ctx.StringValue("GetErRouteEntry.Content.DestinationCidrBlock");
			content.NextHopType = _ctx.StringValue("GetErRouteEntry.Content.NextHopType");
			content.NextHopId = _ctx.StringValue("GetErRouteEntry.Content.NextHopId");
			content.RouteType = _ctx.StringValue("GetErRouteEntry.Content.RouteType");
			content.Status = _ctx.StringValue("GetErRouteEntry.Content.Status");
			content.GmtModified = _ctx.StringValue("GetErRouteEntry.Content.GmtModified");
			content.ResourceGroupId = _ctx.StringValue("GetErRouteEntry.Content.ResourceGroupId");
			getErRouteEntryResponse.Content = content;
        
			return getErRouteEntryResponse;
        }
    }
}
