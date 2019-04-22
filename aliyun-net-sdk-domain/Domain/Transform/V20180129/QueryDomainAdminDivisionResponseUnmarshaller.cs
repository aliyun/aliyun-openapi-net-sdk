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
using Aliyun.Acs.Domain.Model.V20180129;

namespace Aliyun.Acs.Domain.Transform.V20180129
{
    public class QueryDomainAdminDivisionResponseUnmarshaller
    {
        public static QueryDomainAdminDivisionResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDomainAdminDivisionResponse queryDomainAdminDivisionResponse = new QueryDomainAdminDivisionResponse();

			queryDomainAdminDivisionResponse.HttpResponse = context.HttpResponse;
			queryDomainAdminDivisionResponse.RequestId = context.StringValue("QueryDomainAdminDivision.RequestId");

			List<QueryDomainAdminDivisionResponse.QueryDomainAdminDivision_AdminDivision> queryDomainAdminDivisionResponse_adminDivisions = new List<QueryDomainAdminDivisionResponse.QueryDomainAdminDivision_AdminDivision>();
			for (int i = 0; i < context.Length("QueryDomainAdminDivision.AdminDivisions.Length"); i++) {
				QueryDomainAdminDivisionResponse.QueryDomainAdminDivision_AdminDivision adminDivision = new QueryDomainAdminDivisionResponse.QueryDomainAdminDivision_AdminDivision();
				adminDivision.DivisionName = context.StringValue("QueryDomainAdminDivision.AdminDivisions["+ i +"].DivisionName");

				List<QueryDomainAdminDivisionResponse.QueryDomainAdminDivision_AdminDivision.QueryDomainAdminDivision_ChildrenItem> adminDivision_children = new List<QueryDomainAdminDivisionResponse.QueryDomainAdminDivision_AdminDivision.QueryDomainAdminDivision_ChildrenItem>();
				for (int j = 0; j < context.Length("QueryDomainAdminDivision.AdminDivisions["+ i +"].Children.Length"); j++) {
					QueryDomainAdminDivisionResponse.QueryDomainAdminDivision_AdminDivision.QueryDomainAdminDivision_ChildrenItem childrenItem = new QueryDomainAdminDivisionResponse.QueryDomainAdminDivision_AdminDivision.QueryDomainAdminDivision_ChildrenItem();
					childrenItem.ChildDivisionName = context.StringValue("QueryDomainAdminDivision.AdminDivisions["+ i +"].Children["+ j +"].ChildDivisionName");

					adminDivision_children.Add(childrenItem);
				}
				adminDivision.Children = adminDivision_children;

				queryDomainAdminDivisionResponse_adminDivisions.Add(adminDivision);
			}
			queryDomainAdminDivisionResponse.AdminDivisions = queryDomainAdminDivisionResponse_adminDivisions;
        
			return queryDomainAdminDivisionResponse;
        }
    }
}
