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

			List<DescribeDomainFileSizeProportionDataResponse.UsageData> fileSizeProportionDataInterval = new List<DescribeDomainFileSizeProportionDataResponse.UsageData>();
			for (int i = 0; i < context.Length("DescribeDomainFileSizeProportionData.FileSizeProportionDataInterval.Length"); i++) {
				DescribeDomainFileSizeProportionDataResponse.UsageData usageData = new DescribeDomainFileSizeProportionDataResponse.UsageData();
				usageData.TimeStamp = context.StringValue("DescribeDomainFileSizeProportionData.FileSizeProportionDataInterval["+ i +"].TimeStamp");

				List<DescribeDomainFileSizeProportionDataResponse.UsageData.FileSizeProportionData> value = new List<DescribeDomainFileSizeProportionDataResponse.UsageData.FileSizeProportionData>();
				for (int j = 0; j < context.Length("DescribeDomainFileSizeProportionData.FileSizeProportionDataInterval["+ i +"].Value.Length"); j++) {
					DescribeDomainFileSizeProportionDataResponse.UsageData.FileSizeProportionData fileSizeProportionData = new DescribeDomainFileSizeProportionDataResponse.UsageData.FileSizeProportionData();
					fileSizeProportionData.FileSize = context.StringValue("DescribeDomainFileSizeProportionData.FileSizeProportionDataInterval["+ i +"].Value["+ j +"].FileSize");
					fileSizeProportionData.Proportion = context.StringValue("DescribeDomainFileSizeProportionData.FileSizeProportionDataInterval["+ i +"].Value["+ j +"].Proportion");

					value.Add(fileSizeProportionData);
				}
				usageData.Value = value;

				fileSizeProportionDataInterval.Add(usageData);
			}
			describeDomainFileSizeProportionDataResponse.FileSizeProportionDataInterval = fileSizeProportionDataInterval;
        
			return describeDomainFileSizeProportionDataResponse;
        }
    }
}