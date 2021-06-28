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
        public static DescribeFaceGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFaceGroupsResponse describeFaceGroupsResponse = new DescribeFaceGroupsResponse();

			describeFaceGroupsResponse.HttpResponse = _ctx.HttpResponse;
			describeFaceGroupsResponse.TotalNum = _ctx.LongValue("DescribeFaceGroups.TotalNum");
			describeFaceGroupsResponse.PageSize = _ctx.LongValue("DescribeFaceGroups.PageSize");
			describeFaceGroupsResponse.RequestId = _ctx.StringValue("DescribeFaceGroups.RequestId");
			describeFaceGroupsResponse.CurrentPage = _ctx.LongValue("DescribeFaceGroups.CurrentPage");
			describeFaceGroupsResponse.NextPageToken = _ctx.StringValue("DescribeFaceGroups.NextPageToken");

			List<DescribeFaceGroupsResponse.DescribeFaceGroups_Group> describeFaceGroupsResponse_groups = new List<DescribeFaceGroupsResponse.DescribeFaceGroups_Group>();
			for (int i = 0; i < _ctx.Length("DescribeFaceGroups.Groups.Length"); i++) {
				DescribeFaceGroupsResponse.DescribeFaceGroups_Group group = new DescribeFaceGroupsResponse.DescribeFaceGroups_Group();
				group.CreationTime = _ctx.StringValue("DescribeFaceGroups.Groups["+ i +"].CreationTime");
				group.GroupId = _ctx.StringValue("DescribeFaceGroups.Groups["+ i +"].GroupId");
				group.Name = _ctx.StringValue("DescribeFaceGroups.Groups["+ i +"].Name");

				describeFaceGroupsResponse_groups.Add(group);
			}
			describeFaceGroupsResponse.Groups = describeFaceGroupsResponse_groups;
        
			return describeFaceGroupsResponse;
        }
    }
}
