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
using Aliyun.Acs.scdn.Model.V20171115;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class DescribeScdnDomainHttpCodeDataResponseUnmarshaller
    {
        public static DescribeScdnDomainHttpCodeDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainHttpCodeDataResponse describeScdnDomainHttpCodeDataResponse = new DescribeScdnDomainHttpCodeDataResponse();

			describeScdnDomainHttpCodeDataResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainHttpCodeDataResponse.RequestId = context.StringValue("DescribeScdnDomainHttpCodeData.RequestId");
			describeScdnDomainHttpCodeDataResponse.DomainName = context.StringValue("DescribeScdnDomainHttpCodeData.DomainName");
			describeScdnDomainHttpCodeDataResponse.StartTime = context.StringValue("DescribeScdnDomainHttpCodeData.StartTime");
			describeScdnDomainHttpCodeDataResponse.EndTime = context.StringValue("DescribeScdnDomainHttpCodeData.EndTime");
			describeScdnDomainHttpCodeDataResponse.DataInterval = context.StringValue("DescribeScdnDomainHttpCodeData.DataInterval");

			List<DescribeScdnDomainHttpCodeDataResponse.DescribeScdnDomainHttpCodeData_DataModule> describeScdnDomainHttpCodeDataResponse_dataPerInterval = new List<DescribeScdnDomainHttpCodeDataResponse.DescribeScdnDomainHttpCodeData_DataModule>();
			for (int i = 0; i < context.Length("DescribeScdnDomainHttpCodeData.DataPerInterval.Length"); i++) {
				DescribeScdnDomainHttpCodeDataResponse.DescribeScdnDomainHttpCodeData_DataModule dataModule = new DescribeScdnDomainHttpCodeDataResponse.DescribeScdnDomainHttpCodeData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeScdnDomainHttpCodeData.DataPerInterval["+ i +"].TimeStamp");

				List<DescribeScdnDomainHttpCodeDataResponse.DescribeScdnDomainHttpCodeData_DataModule.DescribeScdnDomainHttpCodeData_HttpCodeDataModule> dataModule_httpCodeDataPerInterval = new List<DescribeScdnDomainHttpCodeDataResponse.DescribeScdnDomainHttpCodeData_DataModule.DescribeScdnDomainHttpCodeData_HttpCodeDataModule>();
				for (int j = 0; j < context.Length("DescribeScdnDomainHttpCodeData.DataPerInterval["+ i +"].HttpCodeDataPerInterval.Length"); j++) {
					DescribeScdnDomainHttpCodeDataResponse.DescribeScdnDomainHttpCodeData_DataModule.DescribeScdnDomainHttpCodeData_HttpCodeDataModule httpCodeDataModule = new DescribeScdnDomainHttpCodeDataResponse.DescribeScdnDomainHttpCodeData_DataModule.DescribeScdnDomainHttpCodeData_HttpCodeDataModule();
					httpCodeDataModule.Code = context.StringValue("DescribeScdnDomainHttpCodeData.DataPerInterval["+ i +"].HttpCodeDataPerInterval["+ j +"].Code");
					httpCodeDataModule.Proportion = context.StringValue("DescribeScdnDomainHttpCodeData.DataPerInterval["+ i +"].HttpCodeDataPerInterval["+ j +"].Proportion");
					httpCodeDataModule.Count = context.StringValue("DescribeScdnDomainHttpCodeData.DataPerInterval["+ i +"].HttpCodeDataPerInterval["+ j +"].Count");

					dataModule_httpCodeDataPerInterval.Add(httpCodeDataModule);
				}
				dataModule.HttpCodeDataPerInterval = dataModule_httpCodeDataPerInterval;

				describeScdnDomainHttpCodeDataResponse_dataPerInterval.Add(dataModule);
			}
			describeScdnDomainHttpCodeDataResponse.DataPerInterval = describeScdnDomainHttpCodeDataResponse_dataPerInterval;
        
			return describeScdnDomainHttpCodeDataResponse;
        }
    }
}
