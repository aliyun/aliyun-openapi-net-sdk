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
using Aliyun.Acs.Actiontrail.Model.V20200706;

namespace Aliyun.Acs.Actiontrail.Transform.V20200706
{
    public class DescribeTrailsResponseUnmarshaller
    {
        public static DescribeTrailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTrailsResponse describeTrailsResponse = new DescribeTrailsResponse();

			describeTrailsResponse.HttpResponse = _ctx.HttpResponse;
			describeTrailsResponse.RequestId = _ctx.StringValue("DescribeTrails.RequestId");

			List<DescribeTrailsResponse.DescribeTrails_Trail> describeTrailsResponse_trailList = new List<DescribeTrailsResponse.DescribeTrails_Trail>();
			for (int i = 0; i < _ctx.Length("DescribeTrails.TrailList.Length"); i++) {
				DescribeTrailsResponse.DescribeTrails_Trail trail = new DescribeTrailsResponse.DescribeTrails_Trail();
				trail.Status = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].Status");
				trail.HomeRegion = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].HomeRegion");
				trail.StartLoggingTime = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].StartLoggingTime");
				trail.CreateTime = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].CreateTime");
				trail.StopLoggingTime = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].StopLoggingTime");
				trail.OrganizationId = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].OrganizationId");
				trail.SlsWriteRoleArn = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].SlsWriteRoleArn");
				trail.OssBucketLocation = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].OssBucketLocation");
				trail.TrailRegion = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].TrailRegion");
				trail.Name = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].Name");
				trail.IsOrganizationTrail = _ctx.BooleanValue("DescribeTrails.TrailList["+ i +"].IsOrganizationTrail");
				trail.SlsProjectArn = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].SlsProjectArn");
				trail.EventRW = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].EventRW");
				trail.OssKeyPrefix = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].OssKeyPrefix");
				trail.UpdateTime = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].UpdateTime");
				trail.Region = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].Region");
				trail.OssBucketName = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].OssBucketName");
				trail.OssWriteRoleArn = _ctx.StringValue("DescribeTrails.TrailList["+ i +"].OssWriteRoleArn");
				trail.IsShadowTrail = _ctx.LongValue("DescribeTrails.TrailList["+ i +"].IsShadowTrail");

				describeTrailsResponse_trailList.Add(trail);
			}
			describeTrailsResponse.TrailList = describeTrailsResponse_trailList;
        
			return describeTrailsResponse;
        }
    }
}
