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
using Aliyun.Acs.openanalytics.Model.V20180301;

namespace Aliyun.Acs.openanalytics.Transform.V20180301
{
    public class DescribeRegionListResponseUnmarshaller
    {
        public static DescribeRegionListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRegionListResponse describeRegionListResponse = new DescribeRegionListResponse();

			describeRegionListResponse.HttpResponse = context.HttpResponse;
			describeRegionListResponse.RequestId = context.StringValue("DescribeRegionList.RequestId");
			describeRegionListResponse.RegionId = context.StringValue("DescribeRegionList.RegionId");

			List<DescribeRegionListResponse.DescribeRegionList_RegionListItem> describeRegionListResponse_regionList = new List<DescribeRegionListResponse.DescribeRegionList_RegionListItem>();
			for (int i = 0; i < context.Length("DescribeRegionList.RegionList.Length"); i++) {
				DescribeRegionListResponse.DescribeRegionList_RegionListItem regionListItem = new DescribeRegionListResponse.DescribeRegionList_RegionListItem();
				regionListItem.RegionID = context.StringValue("DescribeRegionList.RegionList["+ i +"].RegionID");

				describeRegionListResponse_regionList.Add(regionListItem);
			}
			describeRegionListResponse.RegionList = describeRegionListResponse_regionList;
        
			return describeRegionListResponse;
        }
    }
}
