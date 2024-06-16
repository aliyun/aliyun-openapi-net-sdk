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
    public class GetVpdRouteEntryResponseUnmarshaller
    {
        public static GetVpdRouteEntryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVpdRouteEntryResponse getVpdRouteEntryResponse = new GetVpdRouteEntryResponse();

			getVpdRouteEntryResponse.HttpResponse = _ctx.HttpResponse;
			getVpdRouteEntryResponse.Code = _ctx.IntegerValue("GetVpdRouteEntry.Code");
			getVpdRouteEntryResponse.Message = _ctx.StringValue("GetVpdRouteEntry.Message");
			getVpdRouteEntryResponse.RequestId = _ctx.StringValue("GetVpdRouteEntry.RequestId");

			GetVpdRouteEntryResponse.GetVpdRouteEntry_Content content = new GetVpdRouteEntryResponse.GetVpdRouteEntry_Content();
			content.RegionId = _ctx.StringValue("GetVpdRouteEntry.Content.RegionId");
			content.VpdRouteEntryId = _ctx.StringValue("GetVpdRouteEntry.Content.VpdRouteEntryId");
			content.TenantId = _ctx.StringValue("GetVpdRouteEntry.Content.TenantId");
			content.VpdId = _ctx.StringValue("GetVpdRouteEntry.Content.VpdId");
			content.DestinationCidrBlock = _ctx.StringValue("GetVpdRouteEntry.Content.DestinationCidrBlock");
			content.NextHopType = _ctx.StringValue("GetVpdRouteEntry.Content.NextHopType");
			content.NextHopId = _ctx.StringValue("GetVpdRouteEntry.Content.NextHopId");
			content.RouteType = _ctx.StringValue("GetVpdRouteEntry.Content.RouteType");
			content.Status = _ctx.StringValue("GetVpdRouteEntry.Content.Status");
			content.GmtModified = _ctx.StringValue("GetVpdRouteEntry.Content.GmtModified");
			getVpdRouteEntryResponse.Content = content;
        
			return getVpdRouteEntryResponse;
        }
    }
}
