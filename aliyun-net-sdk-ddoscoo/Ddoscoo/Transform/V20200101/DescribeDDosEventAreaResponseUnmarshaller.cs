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
    public class DescribeDDosEventAreaResponseUnmarshaller
    {
        public static DescribeDDosEventAreaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDDosEventAreaResponse describeDDosEventAreaResponse = new DescribeDDosEventAreaResponse();

			describeDDosEventAreaResponse.HttpResponse = _ctx.HttpResponse;
			describeDDosEventAreaResponse.RequestId = _ctx.StringValue("DescribeDDosEventArea.RequestId");

			List<DescribeDDosEventAreaResponse.DescribeDDosEventArea_EventArea> describeDDosEventAreaResponse_areas = new List<DescribeDDosEventAreaResponse.DescribeDDosEventArea_EventArea>();
			for (int i = 0; i < _ctx.Length("DescribeDDosEventArea.Areas.Length"); i++) {
				DescribeDDosEventAreaResponse.DescribeDDosEventArea_EventArea eventArea = new DescribeDDosEventAreaResponse.DescribeDDosEventArea_EventArea();
				eventArea.InPkts = _ctx.LongValue("DescribeDDosEventArea.Areas["+ i +"].InPkts");
				eventArea.Area = _ctx.StringValue("DescribeDDosEventArea.Areas["+ i +"].Area");

				describeDDosEventAreaResponse_areas.Add(eventArea);
			}
			describeDDosEventAreaResponse.Areas = describeDDosEventAreaResponse_areas;
        
			return describeDDosEventAreaResponse;
        }
    }
}
