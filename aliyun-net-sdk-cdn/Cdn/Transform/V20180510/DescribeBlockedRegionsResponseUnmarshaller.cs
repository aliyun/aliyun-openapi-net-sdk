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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeBlockedRegionsResponseUnmarshaller
    {
        public static DescribeBlockedRegionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBlockedRegionsResponse describeBlockedRegionsResponse = new DescribeBlockedRegionsResponse();

			describeBlockedRegionsResponse.HttpResponse = _ctx.HttpResponse;
			describeBlockedRegionsResponse.RequestId = _ctx.StringValue("DescribeBlockedRegions.RequestId");

			List<DescribeBlockedRegionsResponse.DescribeBlockedRegions_InfoItem> describeBlockedRegionsResponse_infoList = new List<DescribeBlockedRegionsResponse.DescribeBlockedRegions_InfoItem>();
			for (int i = 0; i < _ctx.Length("DescribeBlockedRegions.InfoList.Length"); i++) {
				DescribeBlockedRegionsResponse.DescribeBlockedRegions_InfoItem infoItem = new DescribeBlockedRegionsResponse.DescribeBlockedRegions_InfoItem();
				infoItem.CountriesAndRegions = _ctx.StringValue("DescribeBlockedRegions.InfoList["+ i +"].CountriesAndRegions");
				infoItem.CountriesAndRegionsName = _ctx.StringValue("DescribeBlockedRegions.InfoList["+ i +"].CountriesAndRegionsName");
				infoItem.Continent = _ctx.StringValue("DescribeBlockedRegions.InfoList["+ i +"].Continent");

				describeBlockedRegionsResponse_infoList.Add(infoItem);
			}
			describeBlockedRegionsResponse.InfoList = describeBlockedRegionsResponse_infoList;
        
			return describeBlockedRegionsResponse;
        }
    }
}
