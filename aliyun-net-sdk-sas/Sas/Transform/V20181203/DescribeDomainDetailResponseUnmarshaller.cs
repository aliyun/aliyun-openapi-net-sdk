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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeDomainDetailResponseUnmarshaller
    {
        public static DescribeDomainDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainDetailResponse describeDomainDetailResponse = new DescribeDomainDetailResponse();

			describeDomainDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainDetailResponse.RequestId = _ctx.StringValue("DescribeDomainDetail.RequestId");
			describeDomainDetailResponse.Domain = _ctx.StringValue("DescribeDomainDetail.Domain");
			describeDomainDetailResponse.RootDomain = _ctx.StringValue("DescribeDomainDetail.RootDomain");
			describeDomainDetailResponse.VulCount = _ctx.IntegerValue("DescribeDomainDetail.VulCount");
			describeDomainDetailResponse.AlarmCount = _ctx.IntegerValue("DescribeDomainDetail.AlarmCount");

			List<DescribeDomainDetailResponse.DescribeDomainDetail_DomainDetailItem> describeDomainDetailResponse_domainDetailItems = new List<DescribeDomainDetailResponse.DescribeDomainDetail_DomainDetailItem>();
			for (int i = 0; i < _ctx.Length("DescribeDomainDetail.DomainDetailItems.Length"); i++) {
				DescribeDomainDetailResponse.DescribeDomainDetail_DomainDetailItem domainDetailItem = new DescribeDomainDetailResponse.DescribeDomainDetail_DomainDetailItem();
				domainDetailItem.InternetIp = _ctx.StringValue("DescribeDomainDetail.DomainDetailItems["+ i +"].InternetIp");
				domainDetailItem.InstanceId = _ctx.StringValue("DescribeDomainDetail.DomainDetailItems["+ i +"].InstanceId");
				domainDetailItem.Uuid = _ctx.StringValue("DescribeDomainDetail.DomainDetailItems["+ i +"].Uuid");
				domainDetailItem.AssetType = _ctx.StringValue("DescribeDomainDetail.DomainDetailItems["+ i +"].AssetType");
				domainDetailItem.InstanceName = _ctx.StringValue("DescribeDomainDetail.DomainDetailItems["+ i +"].InstanceName");
				domainDetailItem.MachineIp = _ctx.StringValue("DescribeDomainDetail.DomainDetailItems["+ i +"].MachineIp");
				domainDetailItem.IntranetIp = _ctx.StringValue("DescribeDomainDetail.DomainDetailItems["+ i +"].IntranetIp");

				describeDomainDetailResponse_domainDetailItems.Add(domainDetailItem);
			}
			describeDomainDetailResponse.DomainDetailItems = describeDomainDetailResponse_domainDetailItems;
        
			return describeDomainDetailResponse;
        }
    }
}
