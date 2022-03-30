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
    public class DescribeLiveDrmUsageDataResponseUnmarshaller
    {
        public static DescribeLiveDrmUsageDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDrmUsageDataResponse describeLiveDrmUsageDataResponse = new DescribeLiveDrmUsageDataResponse();

			describeLiveDrmUsageDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDrmUsageDataResponse.RequestId = _ctx.StringValue("DescribeLiveDrmUsageData.RequestId");

			List<DescribeLiveDrmUsageDataResponse.DescribeLiveDrmUsageData_DataModule> describeLiveDrmUsageDataResponse_drmUsageData = new List<DescribeLiveDrmUsageDataResponse.DescribeLiveDrmUsageData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDrmUsageData.DrmUsageData.Length"); i++) {
				DescribeLiveDrmUsageDataResponse.DescribeLiveDrmUsageData_DataModule dataModule = new DescribeLiveDrmUsageDataResponse.DescribeLiveDrmUsageData_DataModule();
				dataModule.Domain = _ctx.StringValue("DescribeLiveDrmUsageData.DrmUsageData["+ i +"].Domain");
				dataModule.TimeStamp = _ctx.StringValue("DescribeLiveDrmUsageData.DrmUsageData["+ i +"].TimeStamp");
				dataModule.Count = _ctx.LongValue("DescribeLiveDrmUsageData.DrmUsageData["+ i +"].Count");
				dataModule.DrmType = _ctx.StringValue("DescribeLiveDrmUsageData.DrmUsageData["+ i +"].DrmType");
				dataModule.Region = _ctx.StringValue("DescribeLiveDrmUsageData.DrmUsageData["+ i +"].Region");

				describeLiveDrmUsageDataResponse_drmUsageData.Add(dataModule);
			}
			describeLiveDrmUsageDataResponse.DrmUsageData = describeLiveDrmUsageDataResponse_drmUsageData;
        
			return describeLiveDrmUsageDataResponse;
        }
    }
}
