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
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainFileSizeProportionDataResponseUnmarshaller
    {
        public static DescribeDomainFileSizeProportionDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainFileSizeProportionDataResponse describeDomainFileSizeProportionDataResponse = new DescribeDomainFileSizeProportionDataResponse();

			describeDomainFileSizeProportionDataResponse.HttpResponse = context.HttpResponse;
			describeDomainFileSizeProportionDataResponse.RequestId = context.StringValue("DescribeDomainFileSizeProportionData.RequestId");
			describeDomainFileSizeProportionDataResponse.DomainName = context.StringValue("DescribeDomainFileSizeProportionData.DomainName");
			describeDomainFileSizeProportionDataResponse.DataInterval = context.StringValue("DescribeDomainFileSizeProportionData.DataInterval");
			describeDomainFileSizeProportionDataResponse.StartTime = context.StringValue("DescribeDomainFileSizeProportionData.StartTime");
			describeDomainFileSizeProportionDataResponse.EndTime = context.StringValue("DescribeDomainFileSizeProportionData.EndTime");

			List<DescribeDomainFileSizeProportionDataResponse.DescribeDomainFileSizeProportionData_UsageData> describeDomainFileSizeProportionDataResponse_fileSizeProportionDataInterval = new List<DescribeDomainFileSizeProportionDataResponse.DescribeDomainFileSizeProportionData_UsageData>();
			for (int i = 0; i < context.Length("DescribeDomainFileSizeProportionData.FileSizeProportionDataInterval.Length"); i++) {
				DescribeDomainFileSizeProportionDataResponse.DescribeDomainFileSizeProportionData_UsageData usageData = new DescribeDomainFileSizeProportionDataResponse.DescribeDomainFileSizeProportionData_UsageData();
				usageData.TimeStamp = context.StringValue("DescribeDomainFileSizeProportionData.FileSizeProportionDataInterval["+ i +"].TimeStamp");

				List<DescribeDomainFileSizeProportionDataResponse.DescribeDomainFileSizeProportionData_UsageData.DescribeDomainFileSizeProportionData_FileSizeProportionData> usageData_value = new List<DescribeDomainFileSizeProportionDataResponse.DescribeDomainFileSizeProportionData_UsageData.DescribeDomainFileSizeProportionData_FileSizeProportionData>();
				for (int j = 0; j < context.Length("DescribeDomainFileSizeProportionData.FileSizeProportionDataInterval["+ i +"].Value.Length"); j++) {
					DescribeDomainFileSizeProportionDataResponse.DescribeDomainFileSizeProportionData_UsageData.DescribeDomainFileSizeProportionData_FileSizeProportionData fileSizeProportionData = new DescribeDomainFileSizeProportionDataResponse.DescribeDomainFileSizeProportionData_UsageData.DescribeDomainFileSizeProportionData_FileSizeProportionData();
					fileSizeProportionData.FileSize = context.StringValue("DescribeDomainFileSizeProportionData.FileSizeProportionDataInterval["+ i +"].Value["+ j +"].FileSize");
					fileSizeProportionData.Proportion = context.StringValue("DescribeDomainFileSizeProportionData.FileSizeProportionDataInterval["+ i +"].Value["+ j +"].Proportion");

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