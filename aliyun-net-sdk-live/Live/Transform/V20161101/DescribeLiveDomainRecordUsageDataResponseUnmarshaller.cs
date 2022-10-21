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
    public class DescribeLiveDomainRecordUsageDataResponseUnmarshaller
    {
        public static DescribeLiveDomainRecordUsageDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainRecordUsageDataResponse describeLiveDomainRecordUsageDataResponse = new DescribeLiveDomainRecordUsageDataResponse();

			describeLiveDomainRecordUsageDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainRecordUsageDataResponse.RequestId = _ctx.StringValue("DescribeLiveDomainRecordUsageData.RequestId");

			List<DescribeLiveDomainRecordUsageDataResponse.DescribeLiveDomainRecordUsageData_DataModule> describeLiveDomainRecordUsageDataResponse_recordUsageData = new List<DescribeLiveDomainRecordUsageDataResponse.DescribeLiveDomainRecordUsageData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainRecordUsageData.RecordUsageData.Length"); i++) {
				DescribeLiveDomainRecordUsageDataResponse.DescribeLiveDomainRecordUsageData_DataModule dataModule = new DescribeLiveDomainRecordUsageDataResponse.DescribeLiveDomainRecordUsageData_DataModule();
				dataModule.Type = _ctx.StringValue("DescribeLiveDomainRecordUsageData.RecordUsageData["+ i +"].Type");
				dataModule.Duration = _ctx.LongValue("DescribeLiveDomainRecordUsageData.RecordUsageData["+ i +"].Duration");
				dataModule.Domain = _ctx.StringValue("DescribeLiveDomainRecordUsageData.RecordUsageData["+ i +"].Domain");
				dataModule.TimeStamp = _ctx.StringValue("DescribeLiveDomainRecordUsageData.RecordUsageData["+ i +"].TimeStamp");
				dataModule.Count = _ctx.LongValue("DescribeLiveDomainRecordUsageData.RecordUsageData["+ i +"].Count");

				describeLiveDomainRecordUsageDataResponse_recordUsageData.Add(dataModule);
			}
			describeLiveDomainRecordUsageDataResponse.RecordUsageData = describeLiveDomainRecordUsageDataResponse_recordUsageData;
        
			return describeLiveDomainRecordUsageDataResponse;
        }
    }
}
