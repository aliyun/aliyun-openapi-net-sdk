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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeVpcHoneyPotCriteriaResponseUnmarshaller
    {
        public static DescribeVpcHoneyPotCriteriaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVpcHoneyPotCriteriaResponse describeVpcHoneyPotCriteriaResponse = new DescribeVpcHoneyPotCriteriaResponse();

			describeVpcHoneyPotCriteriaResponse.HttpResponse = _ctx.HttpResponse;
			describeVpcHoneyPotCriteriaResponse.RequestId = _ctx.StringValue("DescribeVpcHoneyPotCriteria.RequestId");

			List<DescribeVpcHoneyPotCriteriaResponse.DescribeVpcHoneyPotCriteria_Criteria> describeVpcHoneyPotCriteriaResponse_criteriaList = new List<DescribeVpcHoneyPotCriteriaResponse.DescribeVpcHoneyPotCriteria_Criteria>();
			for (int i = 0; i < _ctx.Length("DescribeVpcHoneyPotCriteria.CriteriaList.Length"); i++) {
				DescribeVpcHoneyPotCriteriaResponse.DescribeVpcHoneyPotCriteria_Criteria criteria = new DescribeVpcHoneyPotCriteriaResponse.DescribeVpcHoneyPotCriteria_Criteria();
				criteria.Values = _ctx.StringValue("DescribeVpcHoneyPotCriteria.CriteriaList["+ i +"].Values");
				criteria.Name = _ctx.StringValue("DescribeVpcHoneyPotCriteria.CriteriaList["+ i +"].Name");
				criteria.Type = _ctx.StringValue("DescribeVpcHoneyPotCriteria.CriteriaList["+ i +"].Type");

				describeVpcHoneyPotCriteriaResponse_criteriaList.Add(criteria);
			}
			describeVpcHoneyPotCriteriaResponse.CriteriaList = describeVpcHoneyPotCriteriaResponse_criteriaList;
        
			return describeVpcHoneyPotCriteriaResponse;
        }
    }
}
