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
using Aliyun.Acs.NAS.Model.V20170626;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class DescribeTieringPoliciesResponseUnmarshaller
    {
        public static DescribeTieringPoliciesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTieringPoliciesResponse describeTieringPoliciesResponse = new DescribeTieringPoliciesResponse();

			describeTieringPoliciesResponse.HttpResponse = context.HttpResponse;
			describeTieringPoliciesResponse.RequestId = context.StringValue("DescribeTieringPolicies.RequestId");
			describeTieringPoliciesResponse.TotalCount = context.IntegerValue("DescribeTieringPolicies.TotalCount");
			describeTieringPoliciesResponse.PageSize = context.IntegerValue("DescribeTieringPolicies.PageSize");
			describeTieringPoliciesResponse.PageNumber = context.IntegerValue("DescribeTieringPolicies.PageNumber");

			List<DescribeTieringPoliciesResponse.DescribeTieringPolicies_TieringPolicy> describeTieringPoliciesResponse_tieringPolicies = new List<DescribeTieringPoliciesResponse.DescribeTieringPolicies_TieringPolicy>();
			for (int i = 0; i < context.Length("DescribeTieringPolicies.TieringPolicies.Length"); i++) {
				DescribeTieringPoliciesResponse.DescribeTieringPolicies_TieringPolicy tieringPolicy = new DescribeTieringPoliciesResponse.DescribeTieringPolicies_TieringPolicy();
				tieringPolicy.Name = context.StringValue("DescribeTieringPolicies.TieringPolicies["+ i +"].Name");
				tieringPolicy.Description = context.StringValue("DescribeTieringPolicies.TieringPolicies["+ i +"].Description");
				tieringPolicy.RefCount = context.IntegerValue("DescribeTieringPolicies.TieringPolicies["+ i +"].RefCount");
				tieringPolicy.Mtime = context.LongValue("DescribeTieringPolicies.TieringPolicies["+ i +"].Mtime");
				tieringPolicy.Atime = context.LongValue("DescribeTieringPolicies.TieringPolicies["+ i +"].Atime");
				tieringPolicy.Ctime = context.LongValue("DescribeTieringPolicies.TieringPolicies["+ i +"].Ctime");
				tieringPolicy.Size = context.LongValue("DescribeTieringPolicies.TieringPolicies["+ i +"].Size");
				tieringPolicy.FileName = context.StringValue("DescribeTieringPolicies.TieringPolicies["+ i +"].FileName");
				tieringPolicy.RecallTime = context.LongValue("DescribeTieringPolicies.TieringPolicies["+ i +"].RecallTime");

				describeTieringPoliciesResponse_tieringPolicies.Add(tieringPolicy);
			}
			describeTieringPoliciesResponse.TieringPolicies = describeTieringPoliciesResponse_tieringPolicies;
        
			return describeTieringPoliciesResponse;
        }
    }
}