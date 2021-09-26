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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeInstancePortraitResponseUnmarshaller
    {
        public static DescribeInstancePortraitResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstancePortraitResponse describeInstancePortraitResponse = new DescribeInstancePortraitResponse();

			describeInstancePortraitResponse.HttpResponse = _ctx.HttpResponse;
			describeInstancePortraitResponse.RequestId = _ctx.StringValue("DescribeInstancePortrait.RequestId");

			List<DescribeInstancePortraitResponse.DescribeInstancePortrait_InstancePortrait> describeInstancePortraitResponse_content = new List<DescribeInstancePortraitResponse.DescribeInstancePortrait_InstancePortrait>();
			for (int i = 0; i < _ctx.Length("DescribeInstancePortrait.Content.Length"); i++) {
				DescribeInstancePortraitResponse.DescribeInstancePortrait_InstancePortrait instancePortrait = new DescribeInstancePortraitResponse.DescribeInstancePortrait_InstancePortrait();
				instancePortrait.ItemKey = _ctx.StringValue("DescribeInstancePortrait.Content["+ i +"].ItemKey");
				instancePortrait.Content = _ctx.StringValue("DescribeInstancePortrait.Content["+ i +"].Content");

				describeInstancePortraitResponse_content.Add(instancePortrait);
			}
			describeInstancePortraitResponse.Content = describeInstancePortraitResponse_content;
        
			return describeInstancePortraitResponse;
        }
    }
}
