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
    public class DescribeSearchConditionResponseUnmarshaller
    {
        public static DescribeSearchConditionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSearchConditionResponse describeSearchConditionResponse = new DescribeSearchConditionResponse();

			describeSearchConditionResponse.HttpResponse = _ctx.HttpResponse;
			describeSearchConditionResponse.RequestId = _ctx.StringValue("DescribeSearchCondition.RequestId");

			List<DescribeSearchConditionResponse.DescribeSearchCondition_Condition> describeSearchConditionResponse_conditionList = new List<DescribeSearchConditionResponse.DescribeSearchCondition_Condition>();
			for (int i = 0; i < _ctx.Length("DescribeSearchCondition.ConditionList.Length"); i++) {
				DescribeSearchConditionResponse.DescribeSearchCondition_Condition condition = new DescribeSearchConditionResponse.DescribeSearchCondition_Condition();
				condition.Name = _ctx.StringValue("DescribeSearchCondition.ConditionList["+ i +"].Name");
				condition.FilterConditions = _ctx.StringValue("DescribeSearchCondition.ConditionList["+ i +"].FilterConditions");
				condition.NameKey = _ctx.StringValue("DescribeSearchCondition.ConditionList["+ i +"].NameKey");
				condition.ConditionType = _ctx.StringValue("DescribeSearchCondition.ConditionList["+ i +"].ConditionType");

				describeSearchConditionResponse_conditionList.Add(condition);
			}
			describeSearchConditionResponse.ConditionList = describeSearchConditionResponse_conditionList;
        
			return describeSearchConditionResponse;
        }
    }
}
