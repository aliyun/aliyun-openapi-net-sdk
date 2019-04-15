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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeSearchConditionResponseUnmarshaller
    {
        public static DescribeSearchConditionResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSearchConditionResponse describeSearchConditionResponse = new DescribeSearchConditionResponse();

			describeSearchConditionResponse.HttpResponse = context.HttpResponse;
			describeSearchConditionResponse.RequestId = context.StringValue("DescribeSearchCondition.RequestId");

			List<DescribeSearchConditionResponse.DescribeSearchCondition_Condition> describeSearchConditionResponse_conditionList = new List<DescribeSearchConditionResponse.DescribeSearchCondition_Condition>();
			for (int i = 0; i < context.Length("DescribeSearchCondition.ConditionList.Length"); i++) {
				DescribeSearchConditionResponse.DescribeSearchCondition_Condition condition = new DescribeSearchConditionResponse.DescribeSearchCondition_Condition();
				condition.Name = context.StringValue("DescribeSearchCondition.ConditionList["+ i +"].Name");
				condition.AssetType = context.StringValue("DescribeSearchCondition.ConditionList["+ i +"].AssetType");
				condition.Tag = context.StringValue("DescribeSearchCondition.ConditionList["+ i +"].Tag");
				condition.Region = context.StringValue("DescribeSearchCondition.ConditionList["+ i +"].Region");
				condition.SafeStatus = context.StringValue("DescribeSearchCondition.ConditionList["+ i +"].SafeStatus");
				condition.ClientStatus = context.StringValue("DescribeSearchCondition.ConditionList["+ i +"].ClientStatus");
				condition.GroupId = context.StringValue("DescribeSearchCondition.ConditionList["+ i +"].GroupId");
				condition.Os = context.StringValue("DescribeSearchCondition.ConditionList["+ i +"].Os");
				condition.Remark = context.StringValue("DescribeSearchCondition.ConditionList["+ i +"].Remark");

				describeSearchConditionResponse_conditionList.Add(condition);
			}
			describeSearchConditionResponse.ConditionList = describeSearchConditionResponse_conditionList;
        
			return describeSearchConditionResponse;
        }
    }
}
