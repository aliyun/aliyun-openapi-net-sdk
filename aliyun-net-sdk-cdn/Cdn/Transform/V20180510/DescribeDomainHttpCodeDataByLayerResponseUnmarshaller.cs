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
    public class DescribeDomainHttpCodeDataByLayerResponseUnmarshaller
    {
        public static DescribeDomainHttpCodeDataByLayerResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainHttpCodeDataByLayerResponse describeDomainHttpCodeDataByLayerResponse = new DescribeDomainHttpCodeDataByLayerResponse();

			describeDomainHttpCodeDataByLayerResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainHttpCodeDataByLayerResponse.RequestId = _ctx.StringValue("DescribeDomainHttpCodeDataByLayer.RequestId");
			describeDomainHttpCodeDataByLayerResponse.DataInterval = _ctx.StringValue("DescribeDomainHttpCodeDataByLayer.DataInterval");

			List<DescribeDomainHttpCodeDataByLayerResponse.DescribeDomainHttpCodeDataByLayer_DataModule> describeDomainHttpCodeDataByLayerResponse_httpCodeDataInterval = new List<DescribeDomainHttpCodeDataByLayerResponse.DescribeDomainHttpCodeDataByLayer_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDomainHttpCodeDataByLayer.HttpCodeDataInterval.Length"); i++) {
				DescribeDomainHttpCodeDataByLayerResponse.DescribeDomainHttpCodeDataByLayer_DataModule dataModule = new DescribeDomainHttpCodeDataByLayerResponse.DescribeDomainHttpCodeDataByLayer_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDomainHttpCodeDataByLayer.HttpCodeDataInterval["+ i +"].TimeStamp");
				dataModule._Value = _ctx.StringValue("DescribeDomainHttpCodeDataByLayer.HttpCodeDataInterval["+ i +"].Value");
				dataModule.TotalValue = _ctx.StringValue("DescribeDomainHttpCodeDataByLayer.HttpCodeDataInterval["+ i +"].TotalValue");

				describeDomainHttpCodeDataByLayerResponse_httpCodeDataInterval.Add(dataModule);
			}
			describeDomainHttpCodeDataByLayerResponse.HttpCodeDataInterval = describeDomainHttpCodeDataByLayerResponse_httpCodeDataInterval;
        
			return describeDomainHttpCodeDataByLayerResponse;
        }
    }
}
