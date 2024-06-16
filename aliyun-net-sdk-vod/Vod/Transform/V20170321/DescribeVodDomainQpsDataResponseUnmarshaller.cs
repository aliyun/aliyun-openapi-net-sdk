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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodDomainQpsDataResponseUnmarshaller
    {
        public static DescribeVodDomainQpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodDomainQpsDataResponse describeVodDomainQpsDataResponse = new DescribeVodDomainQpsDataResponse();

			describeVodDomainQpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVodDomainQpsDataResponse.EndTime = _ctx.StringValue("DescribeVodDomainQpsData.EndTime");
			describeVodDomainQpsDataResponse.StartTime = _ctx.StringValue("DescribeVodDomainQpsData.StartTime");
			describeVodDomainQpsDataResponse.RequestId = _ctx.StringValue("DescribeVodDomainQpsData.RequestId");
			describeVodDomainQpsDataResponse.DomainName = _ctx.StringValue("DescribeVodDomainQpsData.DomainName");
			describeVodDomainQpsDataResponse.DataInterval = _ctx.StringValue("DescribeVodDomainQpsData.DataInterval");

			List<DescribeVodDomainQpsDataResponse.DescribeVodDomainQpsData_DataModule> describeVodDomainQpsDataResponse_qpsDataInterval = new List<DescribeVodDomainQpsDataResponse.DescribeVodDomainQpsData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeVodDomainQpsData.QpsDataInterval.Length"); i++) {
				DescribeVodDomainQpsDataResponse.DescribeVodDomainQpsData_DataModule dataModule = new DescribeVodDomainQpsDataResponse.DescribeVodDomainQpsData_DataModule();
				dataModule.AccValue = _ctx.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].AccValue");
				dataModule.AccDomesticValue = _ctx.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].AccDomesticValue");
				dataModule.AccOverseasValue = _ctx.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].AccOverseasValue");
				dataModule.HttpsValue = _ctx.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].HttpsValue");
				dataModule.HttpsOverseasValue = _ctx.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].HttpsOverseasValue");
				dataModule.DomesticValue = _ctx.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].DomesticValue");
				dataModule.HttpsAccOverseasValue = _ctx.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].HttpsAccOverseasValue");
				dataModule.HttpsDomesticValue = _ctx.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].HttpsDomesticValue");
				dataModule.HttpsAccValue = _ctx.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].HttpsAccValue");
				dataModule._Value = _ctx.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].Value");
				dataModule.OverseasValue = _ctx.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].OverseasValue");
				dataModule.TimeStamp = _ctx.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].TimeStamp");
				dataModule.HttpsAccDomesticValue = _ctx.StringValue("DescribeVodDomainQpsData.QpsDataInterval["+ i +"].HttpsAccDomesticValue");

				describeVodDomainQpsDataResponse_qpsDataInterval.Add(dataModule);
			}
			describeVodDomainQpsDataResponse.QpsDataInterval = describeVodDomainQpsDataResponse_qpsDataInterval;
        
			return describeVodDomainQpsDataResponse;
        }
    }
}
