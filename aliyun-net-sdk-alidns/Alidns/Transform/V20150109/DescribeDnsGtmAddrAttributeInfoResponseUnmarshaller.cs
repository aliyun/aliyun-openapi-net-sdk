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
    public class DescribeDnsGtmAddrAttributeInfoResponseUnmarshaller
    {
        public static DescribeDnsGtmAddrAttributeInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDnsGtmAddrAttributeInfoResponse describeDnsGtmAddrAttributeInfoResponse = new DescribeDnsGtmAddrAttributeInfoResponse();

			describeDnsGtmAddrAttributeInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeDnsGtmAddrAttributeInfoResponse.RequestId = _ctx.StringValue("DescribeDnsGtmAddrAttributeInfo.RequestId");

			List<DescribeDnsGtmAddrAttributeInfoResponse.DescribeDnsGtmAddrAttributeInfo_AddrItem> describeDnsGtmAddrAttributeInfoResponse_addr = new List<DescribeDnsGtmAddrAttributeInfoResponse.DescribeDnsGtmAddrAttributeInfo_AddrItem>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmAddrAttributeInfo.Addr.Length"); i++) {
				DescribeDnsGtmAddrAttributeInfoResponse.DescribeDnsGtmAddrAttributeInfo_AddrItem addrItem = new DescribeDnsGtmAddrAttributeInfoResponse.DescribeDnsGtmAddrAttributeInfo_AddrItem();
				addrItem.Addr = _ctx.StringValue("DescribeDnsGtmAddrAttributeInfo.Addr["+ i +"].Addr");

				DescribeDnsGtmAddrAttributeInfoResponse.DescribeDnsGtmAddrAttributeInfo_AddrItem.DescribeDnsGtmAddrAttributeInfo_AttributeInfo attributeInfo = new DescribeDnsGtmAddrAttributeInfoResponse.DescribeDnsGtmAddrAttributeInfo_AddrItem.DescribeDnsGtmAddrAttributeInfo_AttributeInfo();
				attributeInfo.LineCode = _ctx.StringValue("DescribeDnsGtmAddrAttributeInfo.Addr["+ i +"].AttributeInfo.LineCode");
				attributeInfo.LineName = _ctx.StringValue("DescribeDnsGtmAddrAttributeInfo.Addr["+ i +"].AttributeInfo.LineName");
				attributeInfo.GroupCode = _ctx.StringValue("DescribeDnsGtmAddrAttributeInfo.Addr["+ i +"].AttributeInfo.GroupCode");
				attributeInfo.GroupName = _ctx.StringValue("DescribeDnsGtmAddrAttributeInfo.Addr["+ i +"].AttributeInfo.GroupName");
				attributeInfo.FatherCode = _ctx.StringValue("DescribeDnsGtmAddrAttributeInfo.Addr["+ i +"].AttributeInfo.FatherCode");
				addrItem.AttributeInfo = attributeInfo;

				describeDnsGtmAddrAttributeInfoResponse_addr.Add(addrItem);
			}
			describeDnsGtmAddrAttributeInfoResponse.Addr = describeDnsGtmAddrAttributeInfoResponse_addr;
        
			return describeDnsGtmAddrAttributeInfoResponse;
        }
    }
}
