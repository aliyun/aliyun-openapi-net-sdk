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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class ListUserOrganizationResponseUnmarshaller
    {
        public static ListUserOrganizationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUserOrganizationResponse listUserOrganizationResponse = new ListUserOrganizationResponse();

			listUserOrganizationResponse.HttpResponse = _ctx.HttpResponse;
			listUserOrganizationResponse.RequestId = _ctx.StringValue("ListUserOrganization.RequestId");
			listUserOrganizationResponse.Success = _ctx.BooleanValue("ListUserOrganization.Success");
			listUserOrganizationResponse.ErrorCode = _ctx.StringValue("ListUserOrganization.ErrorCode");
			listUserOrganizationResponse.ErrorMessage = _ctx.StringValue("ListUserOrganization.ErrorMessage");

			List<ListUserOrganizationResponse.ListUserOrganization_Organization> listUserOrganizationResponse_object = new List<ListUserOrganizationResponse.ListUserOrganization_Organization>();
			for (int i = 0; i < _ctx.Length("ListUserOrganization.Object.Length"); i++) {
				ListUserOrganizationResponse.ListUserOrganization_Organization organization = new ListUserOrganizationResponse.ListUserOrganization_Organization();
				organization.Name = _ctx.StringValue("ListUserOrganization.Object["+ i +"].Name");
				organization.Id = _ctx.StringValue("ListUserOrganization.Object["+ i +"].Id");

				listUserOrganizationResponse_object.Add(organization);
			}
			listUserOrganizationResponse._Object = listUserOrganizationResponse_object;
        
			return listUserOrganizationResponse;
        }
    }
}
