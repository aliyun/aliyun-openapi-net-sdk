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
using Aliyun.Acs.cusanalytic_sc_online.Model.V20190524;

namespace Aliyun.Acs.cusanalytic_sc_online.Transform.V20190524
{
    public class GetLocationsResponseUnmarshaller
    {
        public static GetLocationsResponse Unmarshall(UnmarshallerContext context)
        {
			GetLocationsResponse getLocationsResponse = new GetLocationsResponse();

			getLocationsResponse.HttpResponse = context.HttpResponse;
			getLocationsResponse.StoreId = context.LongValue("GetLocations.StoreId");

			List<GetLocationsResponse.GetLocations_LocationItem> getLocationsResponse_locationItems = new List<GetLocationsResponse.GetLocations_LocationItem>();
			for (int i = 0; i < context.Length("GetLocations.LocationItems.Length"); i++) {
				GetLocationsResponse.GetLocations_LocationItem locationItem = new GetLocationsResponse.GetLocations_LocationItem();
				locationItem.Status = context.IntegerValue("GetLocations.LocationItems["+ i +"].Status");
				locationItem.StoreId = context.LongValue("GetLocations.LocationItems["+ i +"].StoreId");
				locationItem.Name = context.StringValue("GetLocations.LocationItems["+ i +"].Name");
				locationItem.Link = context.BooleanValue("GetLocations.LocationItems["+ i +"].Link");
				locationItem.LocationType = context.StringValue("GetLocations.LocationItems["+ i +"].LocationType");
				locationItem.LocationId = context.LongValue("GetLocations.LocationItems["+ i +"].LocationId");
				locationItem.ParentLocationId = context.LongValue("GetLocations.LocationItems["+ i +"].ParentLocationId");
				locationItem.LayerType = context.StringValue("GetLocations.LocationItems["+ i +"].LayerType");

				getLocationsResponse_locationItems.Add(locationItem);
			}
			getLocationsResponse.LocationItems = getLocationsResponse_locationItems;
        
			return getLocationsResponse;
        }
    }
}
