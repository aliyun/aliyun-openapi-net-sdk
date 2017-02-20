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
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainQpsDataResponseUnmarshaller
    {
        public static DescribeDomainQpsDataResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainQpsDataResponse describeDomainQpsDataResponse = new DescribeDomainQpsDataResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDomainQpsData.RequestId"),
                DomainName = context.StringValue("DescribeDomainQpsData.DomainName"),
                DataInterval = context.StringValue("DescribeDomainQpsData.DataInterval"),
                StartTime = context.StringValue("DescribeDomainQpsData.StartTime"),
                EndTime = context.StringValue("DescribeDomainQpsData.EndTime")
            };
            List<DescribeDomainQpsDataResponse.DataModule> qpsDataInterval = new List<DescribeDomainQpsDataResponse.DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainQpsData.QpsDataInterval.Length"); i++) {
                DescribeDomainQpsDataResponse.DataModule dataModule = new DescribeDomainQpsDataResponse.DataModule()
                {
                    TimeStamp = context.StringValue($"DescribeDomainQpsData.QpsDataInterval[{i}].TimeStamp"),
                    Value = context.StringValue($"DescribeDomainQpsData.QpsDataInterval[{i}].Value"),
                    DomesticValue = context.StringValue($"DescribeDomainQpsData.QpsDataInterval[{i}].DomesticValue"),
                    OverseasValue = context.StringValue($"DescribeDomainQpsData.QpsDataInterval[{i}].OverseasValue"),
                    AccValue = context.StringValue($"DescribeDomainQpsData.QpsDataInterval[{i}].AccValue"),
                    AccDomesticValue = context.StringValue($"DescribeDomainQpsData.QpsDataInterval[{i}].AccDomesticValue"),
                    AccOverseasValue = context.StringValue($"DescribeDomainQpsData.QpsDataInterval[{i}].AccOverseasValue")
                };
                qpsDataInterval.Add(dataModule);
			}
			describeDomainQpsDataResponse.QpsDataInterval = qpsDataInterval;
        
			return describeDomainQpsDataResponse;
        }
    }
}