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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnDomainHttpCodeDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainHttpCodeDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnDomainHttpCodeDataResponse describeDcdnDomainHttpCodeDataResponse = new DescribeDcdnDomainHttpCodeDataResponse();

			describeDcdnDomainHttpCodeDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnDomainHttpCodeDataResponse.RequestId = _ctx.StringValue("DescribeDcdnDomainHttpCodeData.RequestId");
			describeDcdnDomainHttpCodeDataResponse.DomainName = _ctx.StringValue("DescribeDcdnDomainHttpCodeData.DomainName");
			describeDcdnDomainHttpCodeDataResponse.StartTime = _ctx.StringValue("DescribeDcdnDomainHttpCodeData.StartTime");
			describeDcdnDomainHttpCodeDataResponse.EndTime = _ctx.StringValue("DescribeDcdnDomainHttpCodeData.EndTime");
			describeDcdnDomainHttpCodeDataResponse.DataInterval = _ctx.StringValue("DescribeDcdnDomainHttpCodeData.DataInterval");

			List<DescribeDcdnDomainHttpCodeDataResponse.DescribeDcdnDomainHttpCodeData_DataModule> describeDcdnDomainHttpCodeDataResponse_dataPerInterval = new List<DescribeDcdnDomainHttpCodeDataResponse.DescribeDcdnDomainHttpCodeData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDomainHttpCodeData.DataPerInterval.Length"); i++) {
				DescribeDcdnDomainHttpCodeDataResponse.DescribeDcdnDomainHttpCodeData_DataModule dataModule = new DescribeDcdnDomainHttpCodeDataResponse.DescribeDcdnDomainHttpCodeData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDcdnDomainHttpCodeData.DataPerInterval["+ i +"].TimeStamp");

				List<DescribeDcdnDomainHttpCodeDataResponse.DescribeDcdnDomainHttpCodeData_DataModule.DescribeDcdnDomainHttpCodeData_HttpCodeDataModule> dataModule_httpCodeDataPerInterval = new List<DescribeDcdnDomainHttpCodeDataResponse.DescribeDcdnDomainHttpCodeData_DataModule.DescribeDcdnDomainHttpCodeData_HttpCodeDataModule>();
				for (int j = 0; j < _ctx.Length("DescribeDcdnDomainHttpCodeData.DataPerInterval["+ i +"].HttpCodeDataPerInterval.Length"); j++) {
					DescribeDcdnDomainHttpCodeDataResponse.DescribeDcdnDomainHttpCodeData_DataModule.DescribeDcdnDomainHttpCodeData_HttpCodeDataModule httpCodeDataModule = new DescribeDcdnDomainHttpCodeDataResponse.DescribeDcdnDomainHttpCodeData_DataModule.DescribeDcdnDomainHttpCodeData_HttpCodeDataModule();
					httpCodeDataModule.Code = _ctx.IntegerValue("DescribeDcdnDomainHttpCodeData.DataPerInterval["+ i +"].HttpCodeDataPerInterval["+ j +"].Code");
					httpCodeDataModule.Proportion = _ctx.FloatValue("DescribeDcdnDomainHttpCodeData.DataPerInterval["+ i +"].HttpCodeDataPerInterval["+ j +"].Proportion");
					httpCodeDataModule.Count = _ctx.FloatValue("DescribeDcdnDomainHttpCodeData.DataPerInterval["+ i +"].HttpCodeDataPerInterval["+ j +"].Count");

					dataModule_httpCodeDataPerInterval.Add(httpCodeDataModule);
				}
				dataModule.HttpCodeDataPerInterval = dataModule_httpCodeDataPerInterval;

				describeDcdnDomainHttpCodeDataResponse_dataPerInterval.Add(dataModule);
			}
			describeDcdnDomainHttpCodeDataResponse.DataPerInterval = describeDcdnDomainHttpCodeDataResponse_dataPerInterval;
        
			return describeDcdnDomainHttpCodeDataResponse;
        }
    }
}
