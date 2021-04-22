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
    public class DescribeCenRouteMapsResponseUnmarshaller
    {
        public static DescribeCenRouteMapsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCenRouteMapsResponse describeCenRouteMapsResponse = new DescribeCenRouteMapsResponse();

			describeCenRouteMapsResponse.HttpResponse = _ctx.HttpResponse;
			describeCenRouteMapsResponse.RequestId = _ctx.StringValue("DescribeCenRouteMaps.RequestId");
			describeCenRouteMapsResponse.TotalCount = _ctx.IntegerValue("DescribeCenRouteMaps.TotalCount");
			describeCenRouteMapsResponse.PageNumber = _ctx.IntegerValue("DescribeCenRouteMaps.PageNumber");
			describeCenRouteMapsResponse.PageSize = _ctx.IntegerValue("DescribeCenRouteMaps.PageSize");

			List<DescribeCenRouteMapsResponse.DescribeCenRouteMaps_RouteMap> describeCenRouteMapsResponse_routeMaps = new List<DescribeCenRouteMapsResponse.DescribeCenRouteMaps_RouteMap>();
			for (int i = 0; i < _ctx.Length("DescribeCenRouteMaps.RouteMaps.Length"); i++) {
				DescribeCenRouteMapsResponse.DescribeCenRouteMaps_RouteMap routeMap = new DescribeCenRouteMapsResponse.DescribeCenRouteMaps_RouteMap();
				routeMap.Status = _ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].Status");
				routeMap.RouteMapId = _ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].RouteMapId");
				routeMap.CenId = _ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].CenId");
				routeMap.CenRegionId = _ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].CenRegionId");
				routeMap.Description = _ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].Description");
				routeMap.MapResult = _ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].MapResult");
				routeMap.Priority = _ctx.IntegerValue("DescribeCenRouteMaps.RouteMaps["+ i +"].Priority");
				routeMap.NextPriority = _ctx.IntegerValue("DescribeCenRouteMaps.RouteMaps["+ i +"].NextPriority");
				routeMap.CidrMatchMode = _ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].CidrMatchMode");
				routeMap.AsPathMatchMode = _ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].AsPathMatchMode");
				routeMap.CommunityMatchMode = _ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].CommunityMatchMode");
				routeMap.CommunityOperateMode = _ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].CommunityOperateMode");
				routeMap.Preference = _ctx.IntegerValue("DescribeCenRouteMaps.RouteMaps["+ i +"].Preference");
				routeMap.TransmitDirection = _ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].TransmitDirection");
				routeMap.SourceInstanceIdsReverseMatch = _ctx.BooleanValue("DescribeCenRouteMaps.RouteMaps["+ i +"].SourceInstanceIdsReverseMatch");
				routeMap.DestinationInstanceIdsReverseMatch = _ctx.BooleanValue("DescribeCenRouteMaps.RouteMaps["+ i +"].DestinationInstanceIdsReverseMatch");
				routeMap.GatewayZoneId = _ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].GatewayZoneId");
				routeMap.MatchAddressType = _ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].MatchAddressType");

				List<string> routeMap_sourceInstanceIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenRouteMaps.RouteMaps["+ i +"].SourceInstanceIds.Length"); j++) {
					routeMap_sourceInstanceIds.Add(_ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].SourceInstanceIds["+ j +"]"));
				}
				routeMap.SourceInstanceIds = routeMap_sourceInstanceIds;

				List<string> routeMap_destinationInstanceIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenRouteMaps.RouteMaps["+ i +"].DestinationInstanceIds.Length"); j++) {
					routeMap_destinationInstanceIds.Add(_ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].DestinationInstanceIds["+ j +"]"));
				}
				routeMap.DestinationInstanceIds = routeMap_destinationInstanceIds;

				List<string> routeMap_sourceRouteTableIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenRouteMaps.RouteMaps["+ i +"].SourceRouteTableIds.Length"); j++) {
					routeMap_sourceRouteTableIds.Add(_ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].SourceRouteTableIds["+ j +"]"));
				}
				routeMap.SourceRouteTableIds = routeMap_sourceRouteTableIds;

				List<string> routeMap_destinationRouteTableIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenRouteMaps.RouteMaps["+ i +"].DestinationRouteTableIds.Length"); j++) {
					routeMap_destinationRouteTableIds.Add(_ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].DestinationRouteTableIds["+ j +"]"));
				}
				routeMap.DestinationRouteTableIds = routeMap_destinationRouteTableIds;

				List<string> routeMap_sourceRegionIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenRouteMaps.RouteMaps["+ i +"].SourceRegionIds.Length"); j++) {
					routeMap_sourceRegionIds.Add(_ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].SourceRegionIds["+ j +"]"));
				}
				routeMap.SourceRegionIds = routeMap_sourceRegionIds;

				List<string> routeMap_sourceChildInstanceTypes = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenRouteMaps.RouteMaps["+ i +"].SourceChildInstanceTypes.Length"); j++) {
					routeMap_sourceChildInstanceTypes.Add(_ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].SourceChildInstanceTypes["+ j +"]"));
				}
				routeMap.SourceChildInstanceTypes = routeMap_sourceChildInstanceTypes;

				List<string> routeMap_destinationChildInstanceTypes = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenRouteMaps.RouteMaps["+ i +"].DestinationChildInstanceTypes.Length"); j++) {
					routeMap_destinationChildInstanceTypes.Add(_ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].DestinationChildInstanceTypes["+ j +"]"));
				}
				routeMap.DestinationChildInstanceTypes = routeMap_destinationChildInstanceTypes;

				List<string> routeMap_destinationCidrBlocks = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenRouteMaps.RouteMaps["+ i +"].DestinationCidrBlocks.Length"); j++) {
					routeMap_destinationCidrBlocks.Add(_ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].DestinationCidrBlocks["+ j +"]"));
				}
				routeMap.DestinationCidrBlocks = routeMap_destinationCidrBlocks;

				List<string> routeMap_routeTypes = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenRouteMaps.RouteMaps["+ i +"].RouteTypes.Length"); j++) {
					routeMap_routeTypes.Add(_ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].RouteTypes["+ j +"]"));
				}
				routeMap.RouteTypes = routeMap_routeTypes;

				List<string> routeMap_matchAsns = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenRouteMaps.RouteMaps["+ i +"].MatchAsns.Length"); j++) {
					routeMap_matchAsns.Add(_ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].MatchAsns["+ j +"]"));
				}
				routeMap.MatchAsns = routeMap_matchAsns;

				List<string> routeMap_matchCommunitySet = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenRouteMaps.RouteMaps["+ i +"].MatchCommunitySet.Length"); j++) {
					routeMap_matchCommunitySet.Add(_ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].MatchCommunitySet["+ j +"]"));
				}
				routeMap.MatchCommunitySet = routeMap_matchCommunitySet;

				List<string> routeMap_operateCommunitySet = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenRouteMaps.RouteMaps["+ i +"].OperateCommunitySet.Length"); j++) {
					routeMap_operateCommunitySet.Add(_ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].OperateCommunitySet["+ j +"]"));
				}
				routeMap.OperateCommunitySet = routeMap_operateCommunitySet;

				List<string> routeMap_prependAsPath = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenRouteMaps.RouteMaps["+ i +"].PrependAsPath.Length"); j++) {
					routeMap_prependAsPath.Add(_ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].PrependAsPath["+ j +"]"));
				}
				routeMap.PrependAsPath = routeMap_prependAsPath;

				List<string> routeMap_destinationRegionIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenRouteMaps.RouteMaps["+ i +"].DestinationRegionIds.Length"); j++) {
					routeMap_destinationRegionIds.Add(_ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].DestinationRegionIds["+ j +"]"));
				}
				routeMap.DestinationRegionIds = routeMap_destinationRegionIds;

				List<string> routeMap_originalRouteTableIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenRouteMaps.RouteMaps["+ i +"].OriginalRouteTableIds.Length"); j++) {
					routeMap_originalRouteTableIds.Add(_ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].OriginalRouteTableIds["+ j +"]"));
				}
				routeMap.OriginalRouteTableIds = routeMap_originalRouteTableIds;

				List<string> routeMap_srcZoneIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCenRouteMaps.RouteMaps["+ i +"].SrcZoneIds.Length"); j++) {
					routeMap_srcZoneIds.Add(_ctx.StringValue("DescribeCenRouteMaps.RouteMaps["+ i +"].SrcZoneIds["+ j +"]"));
				}
				routeMap.SrcZoneIds = routeMap_srcZoneIds;

				describeCenRouteMapsResponse_routeMaps.Add(routeMap);
			}
			describeCenRouteMapsResponse.RouteMaps = describeCenRouteMapsResponse_routeMaps;
        
			return describeCenRouteMapsResponse;
        }
    }
}
