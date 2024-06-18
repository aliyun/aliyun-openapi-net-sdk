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
    public class GetErRouteMapResponseUnmarshaller
    {
        public static GetErRouteMapResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetErRouteMapResponse getErRouteMapResponse = new GetErRouteMapResponse();

			getErRouteMapResponse.HttpResponse = _ctx.HttpResponse;
			getErRouteMapResponse.Code = _ctx.IntegerValue("GetErRouteMap.Code");
			getErRouteMapResponse.Message = _ctx.StringValue("GetErRouteMap.Message");
			getErRouteMapResponse.RequestId = _ctx.StringValue("GetErRouteMap.RequestId");

			GetErRouteMapResponse.GetErRouteMap_Content content = new GetErRouteMapResponse.GetErRouteMap_Content();
			content.RegionId = _ctx.StringValue("GetErRouteMap.Content.RegionId");
			content.TenantId = _ctx.StringValue("GetErRouteMap.Content.TenantId");
			content.GmtCreate = _ctx.StringValue("GetErRouteMap.Content.GmtCreate");
			content.GmtModified = _ctx.StringValue("GetErRouteMap.Content.GmtModified");
			content.Message = _ctx.StringValue("GetErRouteMap.Content.Message");
			content.Status = _ctx.StringValue("GetErRouteMap.Content.Status");
			content.ErRouteMapId = _ctx.StringValue("GetErRouteMap.Content.ErRouteMapId");
			content.ErId = _ctx.StringValue("GetErRouteMap.Content.ErId");
			content.RouteMapNum = _ctx.IntegerValue("GetErRouteMap.Content.RouteMapNum");
			content.Description = _ctx.StringValue("GetErRouteMap.Content.Description");
			content.DestinationCidrBlock = _ctx.StringValue("GetErRouteMap.Content.DestinationCidrBlock");
			content.TransmissionInstanceName = _ctx.StringValue("GetErRouteMap.Content.TransmissionInstanceName");
			content.TransmissionInstanceId = _ctx.StringValue("GetErRouteMap.Content.TransmissionInstanceId");
			content.TransmissionInstanceType = _ctx.StringValue("GetErRouteMap.Content.TransmissionInstanceType");
			content.ReceptionInstanceName = _ctx.StringValue("GetErRouteMap.Content.ReceptionInstanceName");
			content.ReceptionInstanceId = _ctx.StringValue("GetErRouteMap.Content.ReceptionInstanceId");
			content.ReceptionInstanceType = _ctx.StringValue("GetErRouteMap.Content.ReceptionInstanceType");
			content.Action = _ctx.StringValue("GetErRouteMap.Content.Action");
			content.TransmissionInstanceOwner = _ctx.StringValue("GetErRouteMap.Content.TransmissionInstanceOwner");
			content.ReceptionInstanceOwner = _ctx.StringValue("GetErRouteMap.Content.ReceptionInstanceOwner");
			content.ResourceGroupId = _ctx.StringValue("GetErRouteMap.Content.ResourceGroupId");
			content.ErRouteMapName = _ctx.StringValue("GetErRouteMap.Content.ErRouteMapName");
			getErRouteMapResponse.Content = content;
        
			return getErRouteMapResponse;
        }
    }
}
