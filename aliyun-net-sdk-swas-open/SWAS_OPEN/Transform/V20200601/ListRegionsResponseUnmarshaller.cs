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
using Aliyun.Acs.SWAS_OPEN.Model.V20200601;

namespace Aliyun.Acs.SWAS_OPEN.Transform.V20200601
{
    public class ListRegionsResponseUnmarshaller
    {
        public static ListRegionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRegionsResponse listRegionsResponse = new ListRegionsResponse();

			listRegionsResponse.HttpResponse = _ctx.HttpResponse;
			listRegionsResponse.RequestId = _ctx.StringValue("ListRegions.RequestId");

			List<ListRegionsResponse.ListRegions_Region> listRegionsResponse_regions = new List<ListRegionsResponse.ListRegions_Region>();
			for (int i = 0; i < _ctx.Length("ListRegions.Regions.Length"); i++) {
				ListRegionsResponse.ListRegions_Region region = new ListRegionsResponse.ListRegions_Region();
				region.LocalName = _ctx.StringValue("ListRegions.Regions["+ i +"].LocalName");
				region.RegionEndpoint = _ctx.StringValue("ListRegions.Regions["+ i +"].RegionEndpoint");
				region.RegionId = _ctx.StringValue("ListRegions.Regions["+ i +"].RegionId");

				listRegionsResponse_regions.Add(region);
			}
			listRegionsResponse.Regions = listRegionsResponse_regions;
        
			return listRegionsResponse;
        }
    }
}
