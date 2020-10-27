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
using Aliyun.Acs.xtrace.Model.V20190808;

namespace Aliyun.Acs.xtrace.Transform.V20190808
{
    public class CheckServiceLinkedRoleForDeletingResponseUnmarshaller
    {
        public static CheckServiceLinkedRoleForDeletingResponse Unmarshall(UnmarshallerContext context)
        {
			CheckServiceLinkedRoleForDeletingResponse checkServiceLinkedRoleForDeletingResponse = new CheckServiceLinkedRoleForDeletingResponse();

			checkServiceLinkedRoleForDeletingResponse.HttpResponse = context.HttpResponse;
			checkServiceLinkedRoleForDeletingResponse.RequestId = context.StringValue("CheckServiceLinkedRoleForDeleting.RequestId");
			checkServiceLinkedRoleForDeletingResponse.Deletable = context.BooleanValue("CheckServiceLinkedRoleForDeleting.Deletable");

			List<CheckServiceLinkedRoleForDeletingResponse.CheckServiceLinkedRoleForDeleting_RoleUsagesItem> checkServiceLinkedRoleForDeletingResponse_roleUsages = new List<CheckServiceLinkedRoleForDeletingResponse.CheckServiceLinkedRoleForDeleting_RoleUsagesItem>();
			for (int i = 0; i < context.Length("CheckServiceLinkedRoleForDeleting.RoleUsages.Length"); i++) {
				CheckServiceLinkedRoleForDeletingResponse.CheckServiceLinkedRoleForDeleting_RoleUsagesItem roleUsagesItem = new CheckServiceLinkedRoleForDeletingResponse.CheckServiceLinkedRoleForDeleting_RoleUsagesItem();
				roleUsagesItem.Region = context.StringValue("CheckServiceLinkedRoleForDeleting.RoleUsages["+ i +"].Region");

				List<string> roleUsagesItem_resources = new List<string>();
				for (int j = 0; j < context.Length("CheckServiceLinkedRoleForDeleting.RoleUsages["+ i +"].Resources.Length"); j++) {
					roleUsagesItem_resources.Add(context.StringValue("CheckServiceLinkedRoleForDeleting.RoleUsages["+ i +"].Resources["+ j +"]"));
				}
				roleUsagesItem.Resources = roleUsagesItem_resources;

				checkServiceLinkedRoleForDeletingResponse_roleUsages.Add(roleUsagesItem);
			}
			checkServiceLinkedRoleForDeletingResponse.RoleUsages = checkServiceLinkedRoleForDeletingResponse_roleUsages;
        
			return checkServiceLinkedRoleForDeletingResponse;
        }
    }
}
