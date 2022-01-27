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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeDnsGtmAddressPoolAvailableConfigResponseUnmarshaller
    {
        public static DescribeDnsGtmAddressPoolAvailableConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDnsGtmAddressPoolAvailableConfigResponse describeDnsGtmAddressPoolAvailableConfigResponse = new DescribeDnsGtmAddressPoolAvailableConfigResponse();

			describeDnsGtmAddressPoolAvailableConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeDnsGtmAddressPoolAvailableConfigResponse.RequestId = _ctx.StringValue("DescribeDnsGtmAddressPoolAvailableConfig.RequestId");

			List<DescribeDnsGtmAddressPoolAvailableConfigResponse.DescribeDnsGtmAddressPoolAvailableConfig_AttributeInfo> describeDnsGtmAddressPoolAvailableConfigResponse_attributeInfos = new List<DescribeDnsGtmAddressPoolAvailableConfigResponse.DescribeDnsGtmAddressPoolAvailableConfig_AttributeInfo>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmAddressPoolAvailableConfig.AttributeInfos.Length"); i++) {
				DescribeDnsGtmAddressPoolAvailableConfigResponse.DescribeDnsGtmAddressPoolAvailableConfig_AttributeInfo attributeInfo = new DescribeDnsGtmAddressPoolAvailableConfigResponse.DescribeDnsGtmAddressPoolAvailableConfig_AttributeInfo();
				attributeInfo.LineCode = _ctx.StringValue("DescribeDnsGtmAddressPoolAvailableConfig.AttributeInfos["+ i +"].LineCode");
				attributeInfo.LineName = _ctx.StringValue("DescribeDnsGtmAddressPoolAvailableConfig.AttributeInfos["+ i +"].LineName");
				attributeInfo.GroupCode = _ctx.StringValue("DescribeDnsGtmAddressPoolAvailableConfig.AttributeInfos["+ i +"].GroupCode");
				attributeInfo.GroupName = _ctx.StringValue("DescribeDnsGtmAddressPoolAvailableConfig.AttributeInfos["+ i +"].GroupName");
				attributeInfo.FatherCode = _ctx.StringValue("DescribeDnsGtmAddressPoolAvailableConfig.AttributeInfos["+ i +"].FatherCode");

				describeDnsGtmAddressPoolAvailableConfigResponse_attributeInfos.Add(attributeInfo);
			}
			describeDnsGtmAddressPoolAvailableConfigResponse.AttributeInfos = describeDnsGtmAddressPoolAvailableConfigResponse_attributeInfos;
        
			return describeDnsGtmAddressPoolAvailableConfigResponse;
        }
    }
}
