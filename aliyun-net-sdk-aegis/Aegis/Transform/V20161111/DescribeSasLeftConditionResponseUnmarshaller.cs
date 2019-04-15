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
    public class DescribeSasLeftConditionResponseUnmarshaller
    {
        public static DescribeSasLeftConditionResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSasLeftConditionResponse describeSasLeftConditionResponse = new DescribeSasLeftConditionResponse();

			describeSasLeftConditionResponse.HttpResponse = context.HttpResponse;
			describeSasLeftConditionResponse.RequestId = context.StringValue("DescribeSasLeftCondition.RequestId");

			List<DescribeSasLeftConditionResponse.DescribeSasLeftCondition_Condition> describeSasLeftConditionResponse_conditionList = new List<DescribeSasLeftConditionResponse.DescribeSasLeftCondition_Condition>();
			for (int i = 0; i < context.Length("DescribeSasLeftCondition.ConditionList.Length"); i++) {
				DescribeSasLeftConditionResponse.DescribeSasLeftCondition_Condition condition = new DescribeSasLeftConditionResponse.DescribeSasLeftCondition_Condition();
				condition.Name = context.StringValue("DescribeSasLeftCondition.ConditionList["+ i +"].Name");
				condition.Count = context.IntegerValue("DescribeSasLeftCondition.ConditionList["+ i +"].Count");
				condition.Id = context.StringValue("DescribeSasLeftCondition.ConditionList["+ i +"].Id");

				describeSasLeftConditionResponse_conditionList.Add(condition);
			}
			describeSasLeftConditionResponse.ConditionList = describeSasLeftConditionResponse_conditionList;
        
			return describeSasLeftConditionResponse;
        }
    }
}
