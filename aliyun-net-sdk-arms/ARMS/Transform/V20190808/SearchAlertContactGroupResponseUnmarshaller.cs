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
using Aliyun.Acs.ARMS.Model.V20190808;

namespace Aliyun.Acs.ARMS.Transform.V20190808
{
    public class SearchAlertContactGroupResponseUnmarshaller
    {
        public static SearchAlertContactGroupResponse Unmarshall(UnmarshallerContext context)
        {
			SearchAlertContactGroupResponse searchAlertContactGroupResponse = new SearchAlertContactGroupResponse();

			searchAlertContactGroupResponse.HttpResponse = context.HttpResponse;
			searchAlertContactGroupResponse.RequestId = context.StringValue("SearchAlertContactGroup.RequestId");

			List<SearchAlertContactGroupResponse.SearchAlertContactGroup_ContactGroup> searchAlertContactGroupResponse_contactGroups = new List<SearchAlertContactGroupResponse.SearchAlertContactGroup_ContactGroup>();
			for (int i = 0; i < context.Length("SearchAlertContactGroup.ContactGroups.Length"); i++) {
				SearchAlertContactGroupResponse.SearchAlertContactGroup_ContactGroup contactGroup = new SearchAlertContactGroupResponse.SearchAlertContactGroup_ContactGroup();
				contactGroup.ContactGroupId = context.LongValue("SearchAlertContactGroup.ContactGroups["+ i +"].ContactGroupId");
				contactGroup.ContactGroupName = context.StringValue("SearchAlertContactGroup.ContactGroups["+ i +"].ContactGroupName");
				contactGroup.UserId = context.StringValue("SearchAlertContactGroup.ContactGroups["+ i +"].UserId");
				contactGroup.CreateTime = context.LongValue("SearchAlertContactGroup.ContactGroups["+ i +"].CreateTime");
				contactGroup.UpdateTime = context.LongValue("SearchAlertContactGroup.ContactGroups["+ i +"].UpdateTime");

				searchAlertContactGroupResponse_contactGroups.Add(contactGroup);
			}
			searchAlertContactGroupResponse.ContactGroups = searchAlertContactGroupResponse_contactGroups;
        
			return searchAlertContactGroupResponse;
        }
    }
}
