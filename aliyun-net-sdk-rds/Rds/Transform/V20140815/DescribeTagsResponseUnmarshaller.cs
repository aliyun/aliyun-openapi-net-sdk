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
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeTagsResponseUnmarshaller
    {
        public static DescribeTagsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTagsResponse describeTagsResponse = new DescribeTagsResponse();

			describeTagsResponse.HttpResponse = context.HttpResponse;
			describeTagsResponse.RequestId = context.StringValue("DescribeTags.RequestId");

			List<DescribeTagsResponse.TagInfos> items = new List<DescribeTagsResponse.TagInfos>();
			for (int i = 0; i < context.Length("DescribeTags.Items.Length"); i++) {
				DescribeTagsResponse.TagInfos tagInfos = new DescribeTagsResponse.TagInfos();
				tagInfos.TagKey = context.StringValue("DescribeTags.Items["+ i +"].TagKey");
				tagInfos.TagValue = context.StringValue("DescribeTags.Items["+ i +"].TagValue");

				List<string> dBInstanceIds = new List<string>();
				for (int j = 0; j < context.Length("DescribeTags.Items["+ i +"].DBInstanceIds.Length"); j++) {
					dBInstanceIds.Add(context.StringValue("DescribeTags.Items["+ i +"].DBInstanceIds["+ j +"]"));
				}
				tagInfos.DBInstanceIds = dBInstanceIds;

				items.Add(tagInfos);
			}
			describeTagsResponse.Items = items;
        
			return describeTagsResponse;
        }
    }
}