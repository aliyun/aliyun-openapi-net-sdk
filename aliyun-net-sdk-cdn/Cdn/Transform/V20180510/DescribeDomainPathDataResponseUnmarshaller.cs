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
using Aliyun.Acs.Cdn.Model.V20180510;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeDomainPathDataResponseUnmarshaller
    {
        public static DescribeDomainPathDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainPathDataResponse describeDomainPathDataResponse = new DescribeDomainPathDataResponse();

			describeDomainPathDataResponse.HttpResponse = context.HttpResponse;
			describeDomainPathDataResponse.DomainName = context.StringValue("DescribeDomainPathData.DomainName");
			describeDomainPathDataResponse.StartTime = context.StringValue("DescribeDomainPathData.StartTime");
			describeDomainPathDataResponse.EndTime = context.StringValue("DescribeDomainPathData.EndTime");
			describeDomainPathDataResponse.PageSize = context.IntegerValue("DescribeDomainPathData.PageSize");
			describeDomainPathDataResponse.PageNumber = context.IntegerValue("DescribeDomainPathData.PageNumber");
			describeDomainPathDataResponse.DataInterval = context.StringValue("DescribeDomainPathData.DataInterval");
			describeDomainPathDataResponse.TotalCount = context.IntegerValue("DescribeDomainPathData.TotalCount");

			List<DescribeDomainPathDataResponse.DescribeDomainPathData_UsageData> describeDomainPathDataResponse_pathDataPerInterval = new List<DescribeDomainPathDataResponse.DescribeDomainPathData_UsageData>();
			for (int i = 0; i < context.Length("DescribeDomainPathData.PathDataPerInterval.Length"); i++) {
				DescribeDomainPathDataResponse.DescribeDomainPathData_UsageData usageData = new DescribeDomainPathDataResponse.DescribeDomainPathData_UsageData();
				usageData.Traffic = context.IntegerValue("DescribeDomainPathData.PathDataPerInterval["+ i +"].Traffic");
				usageData.Acc = context.IntegerValue("DescribeDomainPathData.PathDataPerInterval["+ i +"].Acc");
				usageData.Path = context.StringValue("DescribeDomainPathData.PathDataPerInterval["+ i +"].Path");
				usageData.Time = context.StringValue("DescribeDomainPathData.PathDataPerInterval["+ i +"].Time");

				describeDomainPathDataResponse_pathDataPerInterval.Add(usageData);
			}
			describeDomainPathDataResponse.PathDataPerInterval = describeDomainPathDataResponse_pathDataPerInterval;
        
			return describeDomainPathDataResponse;
        }
    }
}