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
    public class DescribeDataHubTopicsResponseUnmarshaller
    {
        public static DescribeDataHubTopicsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataHubTopicsResponse describeDataHubTopicsResponse = new DescribeDataHubTopicsResponse();

			describeDataHubTopicsResponse.HttpResponse = context.HttpResponse;
			describeDataHubTopicsResponse.RequestId = context.StringValue("DescribeDataHubTopics.RequestId");
			describeDataHubTopicsResponse.PageSize = context.IntegerValue("DescribeDataHubTopics.PageSize");
			describeDataHubTopicsResponse.CurrentPage = context.IntegerValue("DescribeDataHubTopics.CurrentPage");
			describeDataHubTopicsResponse.TotalCount = context.IntegerValue("DescribeDataHubTopics.TotalCount");

			List<DescribeDataHubTopicsResponse.DescribeDataHubTopics_Topic> describeDataHubTopicsResponse_items = new List<DescribeDataHubTopicsResponse.DescribeDataHubTopics_Topic>();
			for (int i = 0; i < context.Length("DescribeDataHubTopics.Items.Length"); i++) {
				DescribeDataHubTopicsResponse.DescribeDataHubTopics_Topic topic = new DescribeDataHubTopicsResponse.DescribeDataHubTopics_Topic();
				topic.Id = context.LongValue("DescribeDataHubTopics.Items["+ i +"].Id");
				topic.Name = context.StringValue("DescribeDataHubTopics.Items["+ i +"].Name");
				topic.Description = context.StringValue("DescribeDataHubTopics.Items["+ i +"].Description");
				topic.CreationTime = context.LongValue("DescribeDataHubTopics.Items["+ i +"].CreationTime");
				topic.RecordType = context.StringValue("DescribeDataHubTopics.Items["+ i +"].RecordType");
				topic.LifeCycle = context.IntegerValue("DescribeDataHubTopics.Items["+ i +"].LifeCycle");
				topic.UserId = context.LongValue("DescribeDataHubTopics.Items["+ i +"].UserId");
				topic.LoginName = context.StringValue("DescribeDataHubTopics.Items["+ i +"].LoginName");
				topic.DisplayName = context.StringValue("DescribeDataHubTopics.Items["+ i +"].DisplayName");

				describeDataHubTopicsResponse_items.Add(topic);
			}
			describeDataHubTopicsResponse.Items = describeDataHubTopicsResponse_items;
        
			return describeDataHubTopicsResponse;
        }
    }
}
