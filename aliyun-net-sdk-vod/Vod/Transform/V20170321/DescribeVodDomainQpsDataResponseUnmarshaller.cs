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
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodDomainQpsDataResponseUnmarshaller
    {
        public static DescribeVodDomainQpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodDomainQpsDataResponse describeVodDomainQpsDataResponse = new DescribeVodDomainQpsDataResponse();

			describeVodDomainQpsDataResponse.HttpResponse = context.HttpResponse;
			describeVodDomainQpsDataResponse.RequestId = context.StringValue("DescribeVodDomainQpsData.RequestId");
			describeVodDomainQpsDataResponse.DomainName = context.StringValue("DescribeVodDomainQpsData.DomainName");
			describeVodDomainQpsDataResponse.StartTime = context.StringValue("DescribeVodDomainQpsData.StartTime");
			describeVodDomainQpsDataResponse.EndTime = context.StringValue("DescribeVodDomainQpsData.EndTime");
			describeVodDomainQpsDataResponse.DataInterval = context.StringValue("DescribeVodDomainQpsData.DataInterval");

			List<DescribeVodDomainQpsDataResponse.DescribeVodDomainQpsData_DataModule> describeVodDomainQpsDataResponse_qpsDataInterval = new List<DescribeVodDomainQpsDataResponse.DescribeVodDomainQpsData_DataModule>();
			for (int i = 0; i < context.Length("DescribeVodDomainQpsData.QpsDataInterval.Length"); i++) {
				DescribeVodDomainQpsDataResponse.DescribeVodDomainQpsData_DataModule dataModule = new DescribeVodDomainQpsDataResponse.DescribeVodDomainQpsData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].Value");
				dataModule.DomesticValue = context.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].DomesticValue");
				dataModule.OverseasValue = context.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].OverseasValue");
				dataModule.AccValue = context.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].AccValue");
				dataModule.AccDomesticValue = context.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].AccDomesticValue");
				dataModule.AccOverseasValue = context.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].AccOverseasValue");
				dataModule.HttpsValue = context.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].HttpsValue");
				dataModule.HttpsDomesticValue = context.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].HttpsDomesticValue");
				dataModule.HttpsOverseasValue = context.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].HttpsOverseasValue");
				dataModule.HttpsAccValue = context.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].HttpsAccValue");
				dataModule.HttpsAccDomesticValue = context.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].HttpsAccDomesticValue");
				dataModule.HttpsAccOverseasValue = context.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].HttpsAccOverseasValue");

				describeVodDomainQpsDataResponse_qpsDataInterval.Add(dataModule);
			}
			describeVodDomainQpsDataResponse.QpsDataInterval = describeVodDomainQpsDataResponse_qpsDataInterval;
        
			return describeVodDomainQpsDataResponse;
        }
    }
}