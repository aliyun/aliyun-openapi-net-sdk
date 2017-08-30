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
    public class DescribeDomainPnoDataResponseUnmarshaller
    {
        public static DescribeDomainPnoDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainPnoDataResponse describeDomainPnoDataResponse = new DescribeDomainPnoDataResponse();

			describeDomainPnoDataResponse.HttpResponse = context.HttpResponse;
			describeDomainPnoDataResponse.RequestId = context.StringValue("DescribeDomainPnoData.RequestId");
			describeDomainPnoDataResponse.StartTime = context.StringValue("DescribeDomainPnoData.StartTime");
			describeDomainPnoDataResponse.EndTime = context.StringValue("DescribeDomainPnoData.EndTime");
			describeDomainPnoDataResponse.PageSize = context.IntegerValue("DescribeDomainPnoData.PageSize");
			describeDomainPnoDataResponse.PageNumber = context.IntegerValue("DescribeDomainPnoData.PageNumber");
			describeDomainPnoDataResponse.DomainName = context.StringValue("DescribeDomainPnoData.DomainName");

			List<DescribeDomainPnoDataResponse.DescribeDomainPnoData_PnoDataModel> describeDomainPnoDataResponse_pnoDataModels = new List<DescribeDomainPnoDataResponse.DescribeDomainPnoData_PnoDataModel>();
			for (int i = 0; i < context.Length("DescribeDomainPnoData.PnoDataModels.Length"); i++) {
				DescribeDomainPnoDataResponse.DescribeDomainPnoData_PnoDataModel pnoDataModel = new DescribeDomainPnoDataResponse.DescribeDomainPnoData_PnoDataModel();
				pnoDataModel.Pno = context.StringValue("DescribeDomainPnoData.PnoDataModels["+ i +"].Pno");

				List<DescribeDomainPnoDataResponse.DescribeDomainPnoData_PnoDataModel.DescribeDomainPnoData_Detail> pnoDataModel_details = new List<DescribeDomainPnoDataResponse.DescribeDomainPnoData_PnoDataModel.DescribeDomainPnoData_Detail>();
				for (int j = 0; j < context.Length("DescribeDomainPnoData.PnoDataModels["+ i +"].Details.Length"); j++) {
					DescribeDomainPnoDataResponse.DescribeDomainPnoData_PnoDataModel.DescribeDomainPnoData_Detail detail = new DescribeDomainPnoDataResponse.DescribeDomainPnoData_PnoDataModel.DescribeDomainPnoData_Detail();
					detail.TimeStamp = context.StringValue("DescribeDomainPnoData.PnoDataModels["+ i +"].Details["+ j +"].TimeStamp");
					detail.BandWidth = context.FloatValue("DescribeDomainPnoData.PnoDataModels["+ i +"].Details["+ j +"].BandWidth");

					pnoDataModel_details.Add(detail);
				}
				pnoDataModel.Details = pnoDataModel_details;

				describeDomainPnoDataResponse_pnoDataModels.Add(pnoDataModel);
			}
			describeDomainPnoDataResponse.PnoDataModels = describeDomainPnoDataResponse_pnoDataModels;
        
			return describeDomainPnoDataResponse;
        }
    }
}