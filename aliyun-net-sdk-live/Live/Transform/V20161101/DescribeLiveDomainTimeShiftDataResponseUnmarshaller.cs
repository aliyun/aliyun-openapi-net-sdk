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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveDomainTimeShiftDataResponseUnmarshaller
    {
        public static DescribeLiveDomainTimeShiftDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainTimeShiftDataResponse describeLiveDomainTimeShiftDataResponse = new DescribeLiveDomainTimeShiftDataResponse();

			describeLiveDomainTimeShiftDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainTimeShiftDataResponse.RequestId = _ctx.StringValue("DescribeLiveDomainTimeShiftData.RequestId");

			List<DescribeLiveDomainTimeShiftDataResponse.DescribeLiveDomainTimeShiftData_DataModule> describeLiveDomainTimeShiftDataResponse_timeShiftData = new List<DescribeLiveDomainTimeShiftDataResponse.DescribeLiveDomainTimeShiftData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainTimeShiftData.TimeShiftData.Length"); i++) {
				DescribeLiveDomainTimeShiftDataResponse.DescribeLiveDomainTimeShiftData_DataModule dataModule = new DescribeLiveDomainTimeShiftDataResponse.DescribeLiveDomainTimeShiftData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeLiveDomainTimeShiftData.TimeShiftData["+ i +"].TimeStamp");
				dataModule.Size = _ctx.StringValue("DescribeLiveDomainTimeShiftData.TimeShiftData["+ i +"].Size");
				dataModule.Type = _ctx.StringValue("DescribeLiveDomainTimeShiftData.TimeShiftData["+ i +"].Type");

				describeLiveDomainTimeShiftDataResponse_timeShiftData.Add(dataModule);
			}
			describeLiveDomainTimeShiftDataResponse.TimeShiftData = describeLiveDomainTimeShiftDataResponse_timeShiftData;
        
			return describeLiveDomainTimeShiftDataResponse;
        }
    }
}
