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
using Aliyun.Acs.ivision.Model.V20190308;

namespace Aliyun.Acs.ivision.Transform.V20190308
{
    public class DescribeFaceGroupsResponseUnmarshaller
    {
        public static DescribeFaceGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeFaceGroupsResponse describeFaceGroupsResponse = new DescribeFaceGroupsResponse();

			describeFaceGroupsResponse.HttpResponse = context.HttpResponse;
			describeFaceGroupsResponse.RequestId = context.StringValue("DescribeFaceGroups.RequestId");
			describeFaceGroupsResponse.CurrentPage = context.LongValue("DescribeFaceGroups.CurrentPage");
			describeFaceGroupsResponse.PageSize = context.LongValue("DescribeFaceGroups.PageSize");
			describeFaceGroupsResponse.NextPageToken = context.StringValue("DescribeFaceGroups.NextPageToken");
			describeFaceGroupsResponse.TotalNum = context.LongValue("DescribeFaceGroups.TotalNum");

			List<DescribeFaceGroupsResponse.DescribeFaceGroups_Group> describeFaceGroupsResponse_groups = new List<DescribeFaceGroupsResponse.DescribeFaceGroups_Group>();
			for (int i = 0; i < context.Length("DescribeFaceGroups.Groups.Length"); i++) {
				DescribeFaceGroupsResponse.DescribeFaceGroups_Group group = new DescribeFaceGroupsResponse.DescribeFaceGroups_Group();
				group.GroupId = context.StringValue("DescribeFaceGroups.Groups["+ i +"].GroupId");
				group.Name = context.StringValue("DescribeFaceGroups.Groups["+ i +"].Name");
				group.CreationTime = context.StringValue("DescribeFaceGroups.Groups["+ i +"].CreationTime");

				describeFaceGroupsResponse_groups.Add(group);
			}
			describeFaceGroupsResponse.Groups = describeFaceGroupsResponse_groups;
        
			return describeFaceGroupsResponse;
        }
    }
}
