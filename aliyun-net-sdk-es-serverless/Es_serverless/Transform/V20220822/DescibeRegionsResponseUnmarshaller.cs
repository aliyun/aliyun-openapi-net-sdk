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
using Aliyun.Acs.es_serverless.Model.V20220822;

namespace Aliyun.Acs.es_serverless.Transform.V20220822
{
    public class DescibeRegionsResponseUnmarshaller
    {
        public static DescibeRegionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescibeRegionsResponse descibeRegionsResponse = new DescibeRegionsResponse();

			descibeRegionsResponse.HttpResponse = _ctx.HttpResponse;
			descibeRegionsResponse.RequestId = _ctx.StringValue("DescibeRegions.requestId");

			List<DescibeRegionsResponse.DescibeRegions_RegionInfo> descibeRegionsResponse_result = new List<DescibeRegionsResponse.DescibeRegions_RegionInfo>();
			for (int i = 0; i < _ctx.Length("DescibeRegions.Result.Length"); i++) {
				DescibeRegionsResponse.DescibeRegions_RegionInfo regionInfo = new DescibeRegionsResponse.DescibeRegions_RegionInfo();
				regionInfo.RegionId = _ctx.StringValue("DescibeRegions.Result["+ i +"].regionId");
				regionInfo.LocalName = _ctx.StringValue("DescibeRegions.Result["+ i +"].localName");
				regionInfo.Endpoint = _ctx.StringValue("DescibeRegions.Result["+ i +"].endpoint");

				descibeRegionsResponse_result.Add(regionInfo);
			}
			descibeRegionsResponse.Result = descibeRegionsResponse_result;
        
			return descibeRegionsResponse;
        }
    }
}
