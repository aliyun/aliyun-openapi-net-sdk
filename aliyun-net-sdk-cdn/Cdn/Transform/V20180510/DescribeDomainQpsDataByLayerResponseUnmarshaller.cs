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
    public class DescribeDomainQpsDataByLayerResponseUnmarshaller
    {
        public static DescribeDomainQpsDataByLayerResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainQpsDataByLayerResponse describeDomainQpsDataByLayerResponse = new DescribeDomainQpsDataByLayerResponse();

			describeDomainQpsDataByLayerResponse.HttpResponse = context.HttpResponse;
			describeDomainQpsDataByLayerResponse.RequestId = context.StringValue("DescribeDomainQpsDataByLayer.RequestId");
			describeDomainQpsDataByLayerResponse.DomainName = context.StringValue("DescribeDomainQpsDataByLayer.DomainName");
			describeDomainQpsDataByLayerResponse.StartTime = context.StringValue("DescribeDomainQpsDataByLayer.StartTime");
			describeDomainQpsDataByLayerResponse.EndTime = context.StringValue("DescribeDomainQpsDataByLayer.EndTime");
			describeDomainQpsDataByLayerResponse.DataInterval = context.StringValue("DescribeDomainQpsDataByLayer.DataInterval");
			describeDomainQpsDataByLayerResponse.Layer = context.StringValue("DescribeDomainQpsDataByLayer.Layer");

			List<DescribeDomainQpsDataByLayerResponse.DescribeDomainQpsDataByLayer_DataModule> describeDomainQpsDataByLayerResponse_qpsDataInterval = new List<DescribeDomainQpsDataByLayerResponse.DescribeDomainQpsDataByLayer_DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainQpsDataByLayer.QpsDataInterval.Length"); i++) {
				DescribeDomainQpsDataByLayerResponse.DescribeDomainQpsDataByLayer_DataModule dataModule = new DescribeDomainQpsDataByLayerResponse.DescribeDomainQpsDataByLayer_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDomainQpsDataByLayer.QpsDataInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeDomainQpsDataByLayer.QpsDataInterval["+ i +"].Value");
				dataModule.DomesticValue = context.StringValue("DescribeDomainQpsDataByLayer.QpsDataInterval["+ i +"].DomesticValue");
				dataModule.OverseasValue = context.StringValue("DescribeDomainQpsDataByLayer.QpsDataInterval["+ i +"].OverseasValue");
				dataModule.AccValue = context.StringValue("DescribeDomainQpsDataByLayer.QpsDataInterval["+ i +"].AccValue");
				dataModule.AccDomesticValue = context.StringValue("DescribeDomainQpsDataByLayer.QpsDataInterval["+ i +"].AccDomesticValue");
				dataModule.AccOverseasValue = context.StringValue("DescribeDomainQpsDataByLayer.QpsDataInterval["+ i +"].AccOverseasValue");

				describeDomainQpsDataByLayerResponse_qpsDataInterval.Add(dataModule);
			}
			describeDomainQpsDataByLayerResponse.QpsDataInterval = describeDomainQpsDataByLayerResponse_qpsDataInterval;
        
			return describeDomainQpsDataByLayerResponse;
        }
    }
}
