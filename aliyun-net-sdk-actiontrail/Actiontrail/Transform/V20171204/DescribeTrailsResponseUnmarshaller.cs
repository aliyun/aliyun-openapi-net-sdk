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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Actiontrail.Model.V20171204;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Actiontrail.Transform.V20171204
{
    public class DescribeTrailsResponseUnmarshaller
    {
        public static DescribeTrailsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTrailsResponse describeTrailsResponse = new DescribeTrailsResponse();

			describeTrailsResponse.HttpResponse = context.HttpResponse;
			describeTrailsResponse.RequestId = context.StringValue("DescribeTrails.RequestId");

			List<DescribeTrailsResponse.DescribeTrails_TrailListItem> describeTrailsResponse_trailList = new List<DescribeTrailsResponse.DescribeTrails_TrailListItem>();
			for (int i = 0; i < context.Length("DescribeTrails.TrailList.Length"); i++) {
				DescribeTrailsResponse.DescribeTrails_TrailListItem trailListItem = new DescribeTrailsResponse.DescribeTrails_TrailListItem();
				trailListItem.Name = context.StringValue("DescribeTrails.TrailList["+ i +"].Name");
				trailListItem.HomeRegion = context.StringValue("DescribeTrails.TrailList["+ i +"].HomeRegion");
				trailListItem.RoleName = context.StringValue("DescribeTrails.TrailList["+ i +"].RoleName");
				trailListItem.Status = context.StringValue("DescribeTrails.TrailList["+ i +"].Status");
				trailListItem.IncludeGlobalServiceEvent = context.StringValue("DescribeTrails.TrailList["+ i +"].IncludeGlobalServiceEvent");
				trailListItem.OssBucketName = context.StringValue("DescribeTrails.TrailList["+ i +"].OssBucketName");
				trailListItem.OssKeyPrefix = context.StringValue("DescribeTrails.TrailList["+ i +"].OssKeyPrefix");
				trailListItem.Region = context.StringValue("DescribeTrails.TrailList["+ i +"].Region");
				trailListItem.EventRW = context.StringValue("DescribeTrails.TrailList["+ i +"].EventRW");
				trailListItem.Type = context.StringValue("DescribeTrails.TrailList["+ i +"].Type");
				trailListItem.SlsWriteRoleArn = context.StringValue("DescribeTrails.TrailList["+ i +"].SlsWriteRoleArn");
				trailListItem.SlsProjectArn = context.StringValue("DescribeTrails.TrailList["+ i +"].SlsProjectArn");

				describeTrailsResponse_trailList.Add(trailListItem);
			}
			describeTrailsResponse.TrailList = describeTrailsResponse_trailList;
        
			return describeTrailsResponse;
        }
    }
}