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
using Aliyun.Acs.Ram.Model.V20150501;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ram.Transform.V20150501
{
    public class ListPolicyVersionsResponseUnmarshaller
    {
        public static ListPolicyVersionsResponse Unmarshall(UnmarshallerContext context)
        {
			ListPolicyVersionsResponse listPolicyVersionsResponse = new ListPolicyVersionsResponse();

			listPolicyVersionsResponse.HttpResponse = context.HttpResponse;
			listPolicyVersionsResponse.RequestId = context.StringValue("ListPolicyVersions.RequestId");

			List<ListPolicyVersionsResponse.ListPolicyVersions_PolicyVersion> listPolicyVersionsResponse_policyVersions = new List<ListPolicyVersionsResponse.ListPolicyVersions_PolicyVersion>();
			for (int i = 0; i < context.Length("ListPolicyVersions.PolicyVersions.Length"); i++) {
				ListPolicyVersionsResponse.ListPolicyVersions_PolicyVersion policyVersion = new ListPolicyVersionsResponse.ListPolicyVersions_PolicyVersion();
				policyVersion.VersionId = context.StringValue("ListPolicyVersions.PolicyVersions["+ i +"].VersionId");
				policyVersion.IsDefaultVersion = context.BooleanValue("ListPolicyVersions.PolicyVersions["+ i +"].IsDefaultVersion");
				policyVersion.PolicyDocument = context.StringValue("ListPolicyVersions.PolicyVersions["+ i +"].PolicyDocument");
				policyVersion.CreateDate = context.StringValue("ListPolicyVersions.PolicyVersions["+ i +"].CreateDate");

				listPolicyVersionsResponse_policyVersions.Add(policyVersion);
			}
			listPolicyVersionsResponse.PolicyVersions = listPolicyVersionsResponse_policyVersions;
        
			return listPolicyVersionsResponse;
        }
    }
}