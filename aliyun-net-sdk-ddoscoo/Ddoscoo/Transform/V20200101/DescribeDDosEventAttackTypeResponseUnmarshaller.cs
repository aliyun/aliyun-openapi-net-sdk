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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeDDosEventAttackTypeResponseUnmarshaller
    {
        public static DescribeDDosEventAttackTypeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDDosEventAttackTypeResponse describeDDosEventAttackTypeResponse = new DescribeDDosEventAttackTypeResponse();

			describeDDosEventAttackTypeResponse.HttpResponse = _ctx.HttpResponse;
			describeDDosEventAttackTypeResponse.RequestId = _ctx.StringValue("DescribeDDosEventAttackType.RequestId");

			List<DescribeDDosEventAttackTypeResponse.DescribeDDosEventAttackType_EventAttackType> describeDDosEventAttackTypeResponse_attackTypes = new List<DescribeDDosEventAttackTypeResponse.DescribeDDosEventAttackType_EventAttackType>();
			for (int i = 0; i < _ctx.Length("DescribeDDosEventAttackType.AttackTypes.Length"); i++) {
				DescribeDDosEventAttackTypeResponse.DescribeDDosEventAttackType_EventAttackType eventAttackType = new DescribeDDosEventAttackTypeResponse.DescribeDDosEventAttackType_EventAttackType();
				eventAttackType.AttackType = _ctx.StringValue("DescribeDDosEventAttackType.AttackTypes["+ i +"].AttackType");
				eventAttackType.InPkts = _ctx.LongValue("DescribeDDosEventAttackType.AttackTypes["+ i +"].InPkts");

				describeDDosEventAttackTypeResponse_attackTypes.Add(eventAttackType);
			}
			describeDDosEventAttackTypeResponse.AttackTypes = describeDDosEventAttackTypeResponse_attackTypes;
        
			return describeDDosEventAttackTypeResponse;
        }
    }
}
