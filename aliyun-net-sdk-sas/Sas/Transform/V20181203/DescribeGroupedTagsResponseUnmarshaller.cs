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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeGroupedTagsResponseUnmarshaller
    {
        public static DescribeGroupedTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGroupedTagsResponse describeGroupedTagsResponse = new DescribeGroupedTagsResponse();

			describeGroupedTagsResponse.HttpResponse = _ctx.HttpResponse;
			describeGroupedTagsResponse.RequestId = _ctx.StringValue("DescribeGroupedTags.RequestId");
			describeGroupedTagsResponse.Success = _ctx.BooleanValue("DescribeGroupedTags.Success");
			describeGroupedTagsResponse.Count = _ctx.IntegerValue("DescribeGroupedTags.Count");
			describeGroupedTagsResponse.HttpStatusCode = _ctx.IntegerValue("DescribeGroupedTags.HttpStatusCode");

			List<DescribeGroupedTagsResponse.DescribeGroupedTags_GroupedFiled> describeGroupedTagsResponse_groupedFileds = new List<DescribeGroupedTagsResponse.DescribeGroupedTags_GroupedFiled>();
			for (int i = 0; i < _ctx.Length("DescribeGroupedTags.GroupedFileds.Length"); i++) {
				DescribeGroupedTagsResponse.DescribeGroupedTags_GroupedFiled groupedFiled = new DescribeGroupedTagsResponse.DescribeGroupedTags_GroupedFiled();
				groupedFiled.Name = _ctx.StringValue("DescribeGroupedTags.GroupedFileds["+ i +"].Name");
				groupedFiled.TagId = _ctx.IntegerValue("DescribeGroupedTags.GroupedFileds["+ i +"].TagId");
				groupedFiled.Count = _ctx.StringValue("DescribeGroupedTags.GroupedFileds["+ i +"].Count");

				describeGroupedTagsResponse_groupedFileds.Add(groupedFiled);
			}
			describeGroupedTagsResponse.GroupedFileds = describeGroupedTagsResponse_groupedFileds;
        
			return describeGroupedTagsResponse;
        }
    }
}
