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
using Aliyun.Acs.ComputeNestSupplier.Model.V20210521;

namespace Aliyun.Acs.ComputeNestSupplier.Transform.V20210521
{
    public class ListServiceUsagesResponseUnmarshaller
    {
        public static ListServiceUsagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListServiceUsagesResponse listServiceUsagesResponse = new ListServiceUsagesResponse();

			listServiceUsagesResponse.HttpResponse = _ctx.HttpResponse;
			listServiceUsagesResponse.RequestId = _ctx.StringValue("ListServiceUsages.RequestId");
			listServiceUsagesResponse.NextToken = _ctx.StringValue("ListServiceUsages.NextToken");
			listServiceUsagesResponse.MaxResults = _ctx.IntegerValue("ListServiceUsages.MaxResults");
			listServiceUsagesResponse.TotalCount = _ctx.IntegerValue("ListServiceUsages.TotalCount");

			List<ListServiceUsagesResponse.ListServiceUsages_Policy> listServiceUsagesResponse_serviceUsages = new List<ListServiceUsagesResponse.ListServiceUsages_Policy>();
			for (int i = 0; i < _ctx.Length("ListServiceUsages.ServiceUsages.Length"); i++) {
				ListServiceUsagesResponse.ListServiceUsages_Policy policy = new ListServiceUsagesResponse.ListServiceUsages_Policy();
				policy.UserAliUid = _ctx.LongValue("ListServiceUsages.ServiceUsages["+ i +"].UserAliUid");
				policy.ServiceId = _ctx.StringValue("ListServiceUsages.ServiceUsages["+ i +"].ServiceId");
				policy.ServiceName = _ctx.StringValue("ListServiceUsages.ServiceUsages["+ i +"].ServiceName");
				policy.SupplierName = _ctx.StringValue("ListServiceUsages.ServiceUsages["+ i +"].SupplierName");
				policy.Status = _ctx.StringValue("ListServiceUsages.ServiceUsages["+ i +"].Status");
				policy.Comments = _ctx.StringValue("ListServiceUsages.ServiceUsages["+ i +"].Comments");
				policy.CreateTime = _ctx.StringValue("ListServiceUsages.ServiceUsages["+ i +"].CreateTime");
				policy.UpdateTime = _ctx.StringValue("ListServiceUsages.ServiceUsages["+ i +"].UpdateTime");

				ListServiceUsagesResponse.ListServiceUsages_Policy.ListServiceUsages_UserInformation userInformation = new ListServiceUsagesResponse.ListServiceUsages_Policy.ListServiceUsages_UserInformation();
				userInformation.Name = _ctx.StringValue("ListServiceUsages.ServiceUsages["+ i +"].UserInformation.Name");
				userInformation.EmailAddress = _ctx.StringValue("ListServiceUsages.ServiceUsages["+ i +"].UserInformation.EmailAddress");
				userInformation.Company = _ctx.StringValue("ListServiceUsages.ServiceUsages["+ i +"].UserInformation.Company");
				userInformation.Country = _ctx.StringValue("ListServiceUsages.ServiceUsages["+ i +"].UserInformation.Country");
				userInformation.Telephone = _ctx.StringValue("ListServiceUsages.ServiceUsages["+ i +"].UserInformation.Telephone");
				userInformation.Title = _ctx.StringValue("ListServiceUsages.ServiceUsages["+ i +"].UserInformation.Title");
				userInformation.Industry = _ctx.StringValue("ListServiceUsages.ServiceUsages["+ i +"].UserInformation.Industry");
				userInformation.Source = _ctx.StringValue("ListServiceUsages.ServiceUsages["+ i +"].UserInformation.Source");
				policy.UserInformation = userInformation;

				listServiceUsagesResponse_serviceUsages.Add(policy);
			}
			listServiceUsagesResponse.ServiceUsages = listServiceUsagesResponse_serviceUsages;
        
			return listServiceUsagesResponse;
        }
    }
}
