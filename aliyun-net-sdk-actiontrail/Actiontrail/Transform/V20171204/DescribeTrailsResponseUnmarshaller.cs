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
using Aliyun.Acs.Actiontrail.Model.V20171204;

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
				trailListItem.OssBucketName = context.StringValue("DescribeTrails.TrailList["+ i +"].OssBucketName");
				trailListItem.OssKeyPrefix = context.StringValue("DescribeTrails.TrailList["+ i +"].OssKeyPrefix");
				trailListItem.EventRW = context.StringValue("DescribeTrails.TrailList["+ i +"].EventRW");
				trailListItem.SlsWriteRoleArn = context.StringValue("DescribeTrails.TrailList["+ i +"].SlsWriteRoleArn");
				trailListItem.SlsProjectArn = context.StringValue("DescribeTrails.TrailList["+ i +"].SlsProjectArn");
				trailListItem.Status = context.StringValue("DescribeTrails.TrailList["+ i +"].Status");
				trailListItem.TrailRegion = context.StringValue("DescribeTrails.TrailList["+ i +"].TrailRegion");
				trailListItem.CreateTime = context.StringValue("DescribeTrails.TrailList["+ i +"].CreateTime");
				trailListItem.UpdateTime = context.StringValue("DescribeTrails.TrailList["+ i +"].UpdateTime");
				trailListItem.StartLoggingTime = context.StringValue("DescribeTrails.TrailList["+ i +"].StartLoggingTime");
				trailListItem.StopLoggingTime = context.StringValue("DescribeTrails.TrailList["+ i +"].StopLoggingTime");
				trailListItem.MnsTopicArn = context.StringValue("DescribeTrails.TrailList["+ i +"].MnsTopicArn");
				trailListItem.IsOrganizationTrail = context.BooleanValue("DescribeTrails.TrailList["+ i +"].IsOrganizationTrail");

				describeTrailsResponse_trailList.Add(trailListItem);
			}
			describeTrailsResponse.TrailList = describeTrailsResponse_trailList;
        
			return describeTrailsResponse;
        }
    }
}
