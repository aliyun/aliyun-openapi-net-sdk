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
        public static DescribeTrailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTrailsResponse describeTrailsResponse = new DescribeTrailsResponse();

			describeTrailsResponse.HttpResponse = _ctx.HttpResponse;
			describeTrailsResponse.RequestId = _ctx.StringValue("DescribeTrails.RequestId");

			List<DescribeTrailsResponse.DescribeTrails_TrailListItem> describeTrailsResponse_trailList = new List<DescribeTrailsResponse.DescribeTrails_TrailListItem>();
			for (int i = 0; i < _ctx.Length("DescribeTrails.TrailList.Length"); i++) {
				DescribeTrailsResponse.DescribeTrails_TrailListItem trailListItem = new DescribeTrailsResponse.DescribeTrails_TrailListItem();
				trailListItem.Name = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].Name");
				trailListItem.HomeRegion = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].HomeRegion");
				trailListItem.RoleName = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].RoleName");
				trailListItem.OssBucketName = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].OssBucketName");
				trailListItem.OssKeyPrefix = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].OssKeyPrefix");
				trailListItem.EventRW = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].EventRW");
				trailListItem.SlsWriteRoleArn = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].SlsWriteRoleArn");
				trailListItem.SlsProjectArn = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].SlsProjectArn");
				trailListItem.Status = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].Status");
				trailListItem.TrailRegion = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].TrailRegion");
				trailListItem.CreateTime = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].CreateTime");
				trailListItem.UpdateTime = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].UpdateTime");
				trailListItem.StartLoggingTime = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].StartLoggingTime");
				trailListItem.StopLoggingTime = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].StopLoggingTime");
				trailListItem.MnsTopicArn = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].MnsTopicArn");
				trailListItem.IsOrganizationTrail = _ctx.BooleanValue("DescribeTrails.TrailList["+ i +"].IsOrganizationTrail");

				describeTrailsResponse_trailList.Add(trailListItem);
			}
			describeTrailsResponse.TrailList = describeTrailsResponse_trailList;
        
			return describeTrailsResponse;
        }
    }
}
