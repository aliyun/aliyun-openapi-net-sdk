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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeParentPlatformsResponseUnmarshaller
    {
        public static DescribeParentPlatformsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParentPlatformsResponse describeParentPlatformsResponse = new DescribeParentPlatformsResponse();

			describeParentPlatformsResponse.HttpResponse = _ctx.HttpResponse;
			describeParentPlatformsResponse.RequestId = _ctx.StringValue("DescribeParentPlatforms.RequestId");
			describeParentPlatformsResponse.PageSize = _ctx.LongValue("DescribeParentPlatforms.PageSize");
			describeParentPlatformsResponse.PageNum = _ctx.LongValue("DescribeParentPlatforms.PageNum");
			describeParentPlatformsResponse.PageCount = _ctx.LongValue("DescribeParentPlatforms.PageCount");
			describeParentPlatformsResponse.TotalCount = _ctx.LongValue("DescribeParentPlatforms.TotalCount");

			List<DescribeParentPlatformsResponse.DescribeParentPlatforms_Platform> describeParentPlatformsResponse_platforms = new List<DescribeParentPlatformsResponse.DescribeParentPlatforms_Platform>();
			for (int i = 0; i < _ctx.Length("DescribeParentPlatforms.Platforms.Length"); i++) {
				DescribeParentPlatformsResponse.DescribeParentPlatforms_Platform platform = new DescribeParentPlatformsResponse.DescribeParentPlatforms_Platform();
				platform.Id = _ctx.StringValue("DescribeParentPlatforms.Platforms["+ i +"].Id");
				platform.Name = _ctx.StringValue("DescribeParentPlatforms.Platforms["+ i +"].Name");
				platform.Description = _ctx.StringValue("DescribeParentPlatforms.Platforms["+ i +"].Description");
				platform.Protocol = _ctx.StringValue("DescribeParentPlatforms.Platforms["+ i +"].Protocol");
				platform.Status = _ctx.StringValue("DescribeParentPlatforms.Platforms["+ i +"].Status");
				platform.GbId = _ctx.StringValue("DescribeParentPlatforms.Platforms["+ i +"].GbId");
				platform.Ip = _ctx.StringValue("DescribeParentPlatforms.Platforms["+ i +"].Ip");
				platform.Port = _ctx.LongValue("DescribeParentPlatforms.Platforms["+ i +"].Port");
				platform.ClientGbId = _ctx.StringValue("DescribeParentPlatforms.Platforms["+ i +"].ClientGbId");
				platform.ClientAuth = _ctx.BooleanValue("DescribeParentPlatforms.Platforms["+ i +"].ClientAuth");
				platform.ClientUsername = _ctx.StringValue("DescribeParentPlatforms.Platforms["+ i +"].ClientUsername");
				platform.ClientPassword = _ctx.StringValue("DescribeParentPlatforms.Platforms["+ i +"].ClientPassword");
				platform.ClientIp = _ctx.StringValue("DescribeParentPlatforms.Platforms["+ i +"].ClientIp");
				platform.ClientPort = _ctx.LongValue("DescribeParentPlatforms.Platforms["+ i +"].ClientPort");
				platform.AutoStart = _ctx.BooleanValue("DescribeParentPlatforms.Platforms["+ i +"].AutoStart");
				platform.CreatedTime = _ctx.StringValue("DescribeParentPlatforms.Platforms["+ i +"].CreatedTime");

				describeParentPlatformsResponse_platforms.Add(platform);
			}
			describeParentPlatformsResponse.Platforms = describeParentPlatformsResponse_platforms;
        
			return describeParentPlatformsResponse;
        }
    }
}
