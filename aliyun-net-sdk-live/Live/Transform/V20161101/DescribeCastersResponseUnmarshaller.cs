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
using Aliyun.Acs.live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeCastersResponseUnmarshaller
    {
        public static DescribeCastersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCastersResponse describeCastersResponse = new DescribeCastersResponse();

			describeCastersResponse.HttpResponse = context.HttpResponse;
			describeCastersResponse.RequestId = context.StringValue("DescribeCasters.RequestId");
			describeCastersResponse.Total = context.IntegerValue("DescribeCasters.Total");

			List<DescribeCastersResponse.DescribeCasters_Caster> describeCastersResponse_casterList = new List<DescribeCastersResponse.DescribeCasters_Caster>();
			for (int i = 0; i < context.Length("DescribeCasters.CasterList.Length"); i++) {
				DescribeCastersResponse.DescribeCasters_Caster caster = new DescribeCastersResponse.DescribeCasters_Caster();
				caster.Status = context.IntegerValue("DescribeCasters.CasterList["+ i +"].Status");
				caster.NormType = context.IntegerValue("DescribeCasters.CasterList["+ i +"].NormType");
				caster.CasterId = context.StringValue("DescribeCasters.CasterList["+ i +"].CasterId");
				caster.CasterName = context.StringValue("DescribeCasters.CasterList["+ i +"].CasterName");
				caster.CreateTime = context.StringValue("DescribeCasters.CasterList["+ i +"].CreateTime");
				caster.Period = context.IntegerValue("DescribeCasters.CasterList["+ i +"].Period");
				caster.ChargeType = context.StringValue("DescribeCasters.CasterList["+ i +"].ChargeType");
				caster.CasterTemplate = context.StringValue("DescribeCasters.CasterList["+ i +"].CasterTemplate");

				describeCastersResponse_casterList.Add(caster);
			}
			describeCastersResponse.CasterList = describeCastersResponse_casterList;
        
			return describeCastersResponse;
        }
    }
}