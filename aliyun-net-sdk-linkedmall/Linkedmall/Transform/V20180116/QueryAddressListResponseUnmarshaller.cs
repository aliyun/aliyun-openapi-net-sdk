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
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class QueryAddressListResponseUnmarshaller
    {
        public static QueryAddressListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAddressListResponse queryAddressListResponse = new QueryAddressListResponse();

			queryAddressListResponse.HttpResponse = context.HttpResponse;
			queryAddressListResponse.Code = context.StringValue("QueryAddressList.Code");
			queryAddressListResponse.RequestId = context.StringValue("QueryAddressList.RequestId");
			queryAddressListResponse.Message = context.StringValue("QueryAddressList.Message");

			List<QueryAddressListResponse.QueryAddressList_Address> queryAddressListResponse_addressList = new List<QueryAddressListResponse.QueryAddressList_Address>();
			for (int i = 0; i < context.Length("QueryAddressList.AddressList.Length"); i++) {
				QueryAddressListResponse.QueryAddressList_Address address = new QueryAddressListResponse.QueryAddressList_Address();
				address.AddressId = context.LongValue("QueryAddressList.AddressList["+ i +"].AddressId");
				address.FullName = context.StringValue("QueryAddressList.AddressList["+ i +"].FullName");
				address.Mobile = context.StringValue("QueryAddressList.AddressList["+ i +"].Mobile");
				address.Country = context.StringValue("QueryAddressList.AddressList["+ i +"].Country");
				address.Province = context.StringValue("QueryAddressList.AddressList["+ i +"].Province");
				address.City = context.StringValue("QueryAddressList.AddressList["+ i +"].City");
				address.Town = context.StringValue("QueryAddressList.AddressList["+ i +"].Town");
				address.TownDivisionCode = context.StringValue("QueryAddressList.AddressList["+ i +"].TownDivisionCode");
				address.AddressDetail = context.StringValue("QueryAddressList.AddressList["+ i +"].AddressDetail");
				address.PostCode = context.StringValue("QueryAddressList.AddressList["+ i +"].PostCode");
				address.Status = context.IntegerValue("QueryAddressList.AddressList["+ i +"].Status");
				address.DivisionCode = context.StringValue("QueryAddressList.AddressList["+ i +"].DivisionCode");
				address.Area = context.StringValue("QueryAddressList.AddressList["+ i +"].Area");

				queryAddressListResponse_addressList.Add(address);
			}
			queryAddressListResponse.AddressList = queryAddressListResponse_addressList;
        
			return queryAddressListResponse;
        }
    }
}
