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
using Aliyun.Acs.eds_user.Model.V20210308;

namespace Aliyun.Acs.eds_user.Transform.V20210308
{
    public class DescribeOrgsResponseUnmarshaller
    {
        public static DescribeOrgsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOrgsResponse describeOrgsResponse = new DescribeOrgsResponse();

			describeOrgsResponse.HttpResponse = _ctx.HttpResponse;
			describeOrgsResponse.RequestId = _ctx.StringValue("DescribeOrgs.RequestId");
			describeOrgsResponse.NextToken = _ctx.StringValue("DescribeOrgs.NextToken");

			List<DescribeOrgsResponse.DescribeOrgs_Data> describeOrgsResponse_orgs = new List<DescribeOrgsResponse.DescribeOrgs_Data>();
			for (int i = 0; i < _ctx.Length("DescribeOrgs.Orgs.Length"); i++) {
				DescribeOrgsResponse.DescribeOrgs_Data data = new DescribeOrgsResponse.DescribeOrgs_Data();
				data.OrgName = _ctx.StringValue("DescribeOrgs.Orgs["+ i +"].OrgName");
				data.OrgId = _ctx.StringValue("DescribeOrgs.Orgs["+ i +"].OrgId");
				data.ParentOrgId = _ctx.StringValue("DescribeOrgs.Orgs["+ i +"].ParentOrgId");

				describeOrgsResponse_orgs.Add(data);
			}
			describeOrgsResponse.Orgs = describeOrgsResponse_orgs;
        
			return describeOrgsResponse;
        }
    }
}
