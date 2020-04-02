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
    public class QueryAddressDetailResponseUnmarshaller
    {
        public static QueryAddressDetailResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAddressDetailResponse queryAddressDetailResponse = new QueryAddressDetailResponse();

			queryAddressDetailResponse.HttpResponse = context.HttpResponse;
			queryAddressDetailResponse.RequestId = context.StringValue("QueryAddressDetail.RequestId");
			queryAddressDetailResponse.Code = context.StringValue("QueryAddressDetail.Code");
			queryAddressDetailResponse.Message = context.StringValue("QueryAddressDetail.Message");

			QueryAddressDetailResponse.QueryAddressDetail_DeliveryAddress deliveryAddress = new QueryAddressDetailResponse.QueryAddressDetail_DeliveryAddress();
			deliveryAddress.AddressId = context.LongValue("QueryAddressDetail.DeliveryAddress.AddressId");
			deliveryAddress.FullName = context.StringValue("QueryAddressDetail.DeliveryAddress.FullName");
			deliveryAddress.Mobile = context.StringValue("QueryAddressDetail.DeliveryAddress.Mobile");
			deliveryAddress.Country = context.StringValue("QueryAddressDetail.DeliveryAddress.Country");
			deliveryAddress.Province = context.StringValue("QueryAddressDetail.DeliveryAddress.Province");
			deliveryAddress.City = context.StringValue("QueryAddressDetail.DeliveryAddress.City");
			deliveryAddress.Area = context.StringValue("QueryAddressDetail.DeliveryAddress.Area");
			deliveryAddress.DivisionCode = context.StringValue("QueryAddressDetail.DeliveryAddress.DivisionCode");
			deliveryAddress.Town = context.StringValue("QueryAddressDetail.DeliveryAddress.Town");
			deliveryAddress.TownDivisionCode = context.StringValue("QueryAddressDetail.DeliveryAddress.TownDivisionCode");
			deliveryAddress.AddressDetail = context.StringValue("QueryAddressDetail.DeliveryAddress.AddressDetail");
			deliveryAddress.PostCode = context.StringValue("QueryAddressDetail.DeliveryAddress.PostCode");
			deliveryAddress.Status = context.IntegerValue("QueryAddressDetail.DeliveryAddress.Status");
			queryAddressDetailResponse.DeliveryAddress = deliveryAddress;
        
			return queryAddressDetailResponse;
        }
    }
}
