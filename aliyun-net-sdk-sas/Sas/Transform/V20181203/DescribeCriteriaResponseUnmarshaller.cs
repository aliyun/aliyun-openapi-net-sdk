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
    public class DescribeCriteriaResponseUnmarshaller
    {
        public static DescribeCriteriaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCriteriaResponse describeCriteriaResponse = new DescribeCriteriaResponse();

			describeCriteriaResponse.HttpResponse = _ctx.HttpResponse;
			describeCriteriaResponse.RequestId = _ctx.StringValue("DescribeCriteria.RequestId");

			List<DescribeCriteriaResponse.DescribeCriteria_Criteria> describeCriteriaResponse_criteriaList = new List<DescribeCriteriaResponse.DescribeCriteria_Criteria>();
			for (int i = 0; i < _ctx.Length("DescribeCriteria.CriteriaList.Length"); i++) {
				DescribeCriteriaResponse.DescribeCriteria_Criteria criteria = new DescribeCriteriaResponse.DescribeCriteria_Criteria();
				criteria.Values = _ctx.StringValue("DescribeCriteria.CriteriaList["+ i +"].Values");
				criteria.Name = _ctx.StringValue("DescribeCriteria.CriteriaList["+ i +"].Name");
				criteria.Type = _ctx.StringValue("DescribeCriteria.CriteriaList["+ i +"].Type");

				describeCriteriaResponse_criteriaList.Add(criteria);
			}
			describeCriteriaResponse.CriteriaList = describeCriteriaResponse_criteriaList;
        
			return describeCriteriaResponse;
        }
    }
}
