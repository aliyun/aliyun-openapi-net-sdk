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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class ListApplicationGroupsResponseUnmarshaller
    {
        public static ListApplicationGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListApplicationGroupsResponse listApplicationGroupsResponse = new ListApplicationGroupsResponse();

			listApplicationGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listApplicationGroupsResponse.NextToken = _ctx.StringValue("ListApplicationGroups.NextToken");
			listApplicationGroupsResponse.RequestId = _ctx.StringValue("ListApplicationGroups.RequestId");
			listApplicationGroupsResponse.MaxResults = _ctx.IntegerValue("ListApplicationGroups.MaxResults");

			List<ListApplicationGroupsResponse.ListApplicationGroups_ApplicationGroup> listApplicationGroupsResponse_applicationGroups = new List<ListApplicationGroupsResponse.ListApplicationGroups_ApplicationGroup>();
			for (int i = 0; i < _ctx.Length("ListApplicationGroups.ApplicationGroups.Length"); i++) {
				ListApplicationGroupsResponse.ListApplicationGroups_ApplicationGroup applicationGroup = new ListApplicationGroupsResponse.ListApplicationGroups_ApplicationGroup();
				applicationGroup.CmsGroupId = _ctx.StringValue("ListApplicationGroups.ApplicationGroups["+ i +"].CmsGroupId");
				applicationGroup.DeployRegionId = _ctx.StringValue("ListApplicationGroups.ApplicationGroups["+ i +"].DeployRegionId");
				applicationGroup.UpdateDate = _ctx.StringValue("ListApplicationGroups.ApplicationGroups["+ i +"].UpdateDate");
				applicationGroup.Description = _ctx.StringValue("ListApplicationGroups.ApplicationGroups["+ i +"].Description");
				applicationGroup.ImportTagKey = _ctx.StringValue("ListApplicationGroups.ApplicationGroups["+ i +"].ImportTagKey");
				applicationGroup.ApplicationName = _ctx.StringValue("ListApplicationGroups.ApplicationGroups["+ i +"].ApplicationName");
				applicationGroup.ImportTagValue = _ctx.StringValue("ListApplicationGroups.ApplicationGroups["+ i +"].ImportTagValue");
				applicationGroup.Name = _ctx.StringValue("ListApplicationGroups.ApplicationGroups["+ i +"].Name");
				applicationGroup.CreateDate = _ctx.StringValue("ListApplicationGroups.ApplicationGroups["+ i +"].CreateDate");
				applicationGroup.Status = _ctx.StringValue("ListApplicationGroups.ApplicationGroups["+ i +"].Status");
				applicationGroup.DeployParameters = _ctx.StringValue("ListApplicationGroups.ApplicationGroups["+ i +"].DeployParameters");
				applicationGroup.StatusReason = _ctx.StringValue("ListApplicationGroups.ApplicationGroups["+ i +"].StatusReason");

				listApplicationGroupsResponse_applicationGroups.Add(applicationGroup);
			}
			listApplicationGroupsResponse.ApplicationGroups = listApplicationGroupsResponse_applicationGroups;
        
			return listApplicationGroupsResponse;
        }
    }
}
