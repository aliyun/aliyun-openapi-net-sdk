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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeDomainFileSizeProportionDataResponseUnmarshaller
    {
        public static DescribeDomainFileSizeProportionDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainFileSizeProportionDataResponse describeDomainFileSizeProportionDataResponse = new DescribeDomainFileSizeProportionDataResponse();

			describeDomainFileSizeProportionDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainFileSizeProportionDataResponse.RequestId = _ctx.StringValue("DescribeDomainFileSizeProportionData.RequestId");
			describeDomainFileSizeProportionDataResponse.DomainName = _ctx.StringValue("DescribeDomainFileSizeProportionData.DomainName");
			describeDomainFileSizeProportionDataResponse.DataInterval = _ctx.StringValue("DescribeDomainFileSizeProportionData.DataInterval");
			describeDomainFileSizeProportionDataResponse.StartTime = _ctx.StringValue("DescribeDomainFileSizeProportionData.StartTime");
			describeDomainFileSizeProportionDataResponse.EndTime = _ctx.StringValue("DescribeDomainFileSizeProportionData.EndTime");

			List<DescribeDomainFileSizeProportionDataResponse.DescribeDomainFileSizeProportionData_UsageData> describeDomainFileSizeProportionDataResponse_fileSizeProportionDataInterval = new List<DescribeDomainFileSizeProportionDataResponse.DescribeDomainFileSizeProportionData_UsageData>();
			for (int i = 0; i < _ctx.Length("DescribeDomainFileSizeProportionData.FileSizeProportionDataInterval.Length"); i++) {
				DescribeDomainFileSizeProportionDataResponse.DescribeDomainFileSizeProportionData_UsageData usageData = new DescribeDomainFileSizeProportionDataResponse.DescribeDomainFileSizeProportionData_UsageData();
				usageData.TimeStamp = _ctx.StringValue("DescribeDomainFileSizeProportionData.FileSizeProportionDataInterval["+ i +"].TimeStamp");

				List<DescribeDomainFileSizeProportionDataResponse.DescribeDomainFileSizeProportionData_UsageData.DescribeDomainFileSizeProportionData_FileSizeProportionData> usageData_value = new List<DescribeDomainFileSizeProportionDataResponse.DescribeDomainFileSizeProportionData_UsageData.DescribeDomainFileSizeProportionData_FileSizeProportionData>();
				for (int j = 0; j < _ctx.Length("DescribeDomainFileSizeProportionData.FileSizeProportionDataInterval["+ i +"].Value.Length"); j++) {
					DescribeDomainFileSizeProportionDataResponse.DescribeDomainFileSizeProportionData_UsageData.DescribeDomainFileSizeProportionData_FileSizeProportionData fileSizeProportionData = new DescribeDomainFileSizeProportionDataResponse.DescribeDomainFileSizeProportionData_UsageData.DescribeDomainFileSizeProportionData_FileSizeProportionData();
					fileSizeProportionData.FileSize = _ctx.StringValue("DescribeDomainFileSizeProportionData.FileSizeProportionDataInterval["+ i +"].Value["+ j +"].FileSize");
					fileSizeProportionData.Proportion = _ctx.StringValue("DescribeDomainFileSizeProportionData.FileSizeProportionDataInterval["+ i +"].Value["+ j +"].Proportion");

					usageData_value.Add(fileSizeProportionData);
				}
				usageData._Value = usageData_value;

				describeDomainFileSizeProportionDataResponse_fileSizeProportionDataInterval.Add(usageData);
			}
			describeDomainFileSizeProportionDataResponse.FileSizeProportionDataInterval = describeDomainFileSizeProportionDataResponse_fileSizeProportionDataInterval;
        
			return describeDomainFileSizeProportionDataResponse;
        }
    }
}
