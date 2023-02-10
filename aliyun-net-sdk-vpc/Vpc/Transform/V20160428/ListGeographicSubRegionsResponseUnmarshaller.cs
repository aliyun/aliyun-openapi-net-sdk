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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class ListGeographicSubRegionsResponseUnmarshaller
    {
        public static ListGeographicSubRegionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGeographicSubRegionsResponse listGeographicSubRegionsResponse = new ListGeographicSubRegionsResponse();

			listGeographicSubRegionsResponse.HttpResponse = _ctx.HttpResponse;
			listGeographicSubRegionsResponse.RequestId = _ctx.StringValue("ListGeographicSubRegions.RequestId");
			listGeographicSubRegionsResponse.Count = _ctx.LongValue("ListGeographicSubRegions.Count");

			List<string> listGeographicSubRegionsResponse_geographicSubRegions = new List<string>();
			for (int i = 0; i < _ctx.Length("ListGeographicSubRegions.GeographicSubRegions.Length"); i++) {
				listGeographicSubRegionsResponse_geographicSubRegions.Add(_ctx.StringValue("ListGeographicSubRegions.GeographicSubRegions["+ i +"]"));
			}
			listGeographicSubRegionsResponse.GeographicSubRegions = listGeographicSubRegionsResponse_geographicSubRegions;
        
			return listGeographicSubRegionsResponse;
        }
    }
}
