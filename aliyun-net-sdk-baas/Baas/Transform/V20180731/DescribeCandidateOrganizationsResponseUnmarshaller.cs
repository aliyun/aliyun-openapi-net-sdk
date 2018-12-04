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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class DescribeCandidateOrganizationsResponseUnmarshaller
    {
        public static DescribeCandidateOrganizationsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCandidateOrganizationsResponse describeCandidateOrganizationsResponse = new DescribeCandidateOrganizationsResponse();

			describeCandidateOrganizationsResponse.HttpResponse = context.HttpResponse;
			describeCandidateOrganizationsResponse.RequestId = context.StringValue("DescribeCandidateOrganizations.RequestId");
			describeCandidateOrganizationsResponse.Success = context.BooleanValue("DescribeCandidateOrganizations.Success");
			describeCandidateOrganizationsResponse.ErrorCode = context.IntegerValue("DescribeCandidateOrganizations.ErrorCode");

			List<DescribeCandidateOrganizationsResponse.DescribeCandidateOrganizations_DescribeCandidateOrganization> describeCandidateOrganizationsResponse_result = new List<DescribeCandidateOrganizationsResponse.DescribeCandidateOrganizations_DescribeCandidateOrganization>();
			for (int i = 0; i < context.Length("DescribeCandidateOrganizations.Result.Length"); i++) {
				DescribeCandidateOrganizationsResponse.DescribeCandidateOrganizations_DescribeCandidateOrganization describeCandidateOrganization = new DescribeCandidateOrganizationsResponse.DescribeCandidateOrganizations_DescribeCandidateOrganization();
				describeCandidateOrganization.OrganizationId = context.StringValue("DescribeCandidateOrganizations.Result["+ i +"].OrganizationId");
				describeCandidateOrganization.OrganizationName = context.StringValue("DescribeCandidateOrganizations.Result["+ i +"].OrganizationName");
				describeCandidateOrganization.ClusterState = context.StringValue("DescribeCandidateOrganizations.Result["+ i +"].ClusterState");
				describeCandidateOrganization.ServiceState = context.StringValue("DescribeCandidateOrganizations.Result["+ i +"].ServiceState");

				describeCandidateOrganizationsResponse_result.Add(describeCandidateOrganization);
			}
			describeCandidateOrganizationsResponse.Result = describeCandidateOrganizationsResponse_result;
        
			return describeCandidateOrganizationsResponse;
        }
    }
}