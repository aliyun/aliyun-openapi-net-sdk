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
using Aliyun.Acs.wss.Model.V20211221;

namespace Aliyun.Acs.wss.Transform.V20211221
{
    public class DescribeDeliveryAddressResponseUnmarshaller
    {
        public static DescribeDeliveryAddressResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDeliveryAddressResponse describeDeliveryAddressResponse = new DescribeDeliveryAddressResponse();

			describeDeliveryAddressResponse.HttpResponse = _ctx.HttpResponse;
			describeDeliveryAddressResponse.TotalCount = _ctx.IntegerValue("DescribeDeliveryAddress.TotalCount");
			describeDeliveryAddressResponse.RequestId = _ctx.StringValue("DescribeDeliveryAddress.RequestId");

			List<DescribeDeliveryAddressResponse.DescribeDeliveryAddress_Address> describeDeliveryAddressResponse_addresses = new List<DescribeDeliveryAddressResponse.DescribeDeliveryAddress_Address>();
			for (int i = 0; i < _ctx.Length("DescribeDeliveryAddress.Addresses.Length"); i++) {
				DescribeDeliveryAddressResponse.DescribeDeliveryAddress_Address address = new DescribeDeliveryAddressResponse.DescribeDeliveryAddress_Address();
				address.PostalCode = _ctx.StringValue("DescribeDeliveryAddress.Addresses["+ i +"].PostalCode");
				address.Contacts = _ctx.StringValue("DescribeDeliveryAddress.Addresses["+ i +"].Contacts");
				address.Mobile = _ctx.StringValue("DescribeDeliveryAddress.Addresses["+ i +"].Mobile");
				address.DefaultAddress = _ctx.BooleanValue("DescribeDeliveryAddress.Addresses["+ i +"].DefaultAddress");
				address.Detail = _ctx.StringValue("DescribeDeliveryAddress.Addresses["+ i +"].Detail");

				DescribeDeliveryAddressResponse.DescribeDeliveryAddress_Address.DescribeDeliveryAddress_Province province = new DescribeDeliveryAddressResponse.DescribeDeliveryAddress_Address.DescribeDeliveryAddress_Province();
				province.ProvinceId = _ctx.LongValue("DescribeDeliveryAddress.Addresses["+ i +"].Province.ProvinceId");
				province.ProvinceName = _ctx.StringValue("DescribeDeliveryAddress.Addresses["+ i +"].Province.ProvinceName");
				address.Province = province;

				DescribeDeliveryAddressResponse.DescribeDeliveryAddress_Address.DescribeDeliveryAddress_City city = new DescribeDeliveryAddressResponse.DescribeDeliveryAddress_Address.DescribeDeliveryAddress_City();
				city.CityId = _ctx.LongValue("DescribeDeliveryAddress.Addresses["+ i +"].City.CityId");
				city.CityName = _ctx.StringValue("DescribeDeliveryAddress.Addresses["+ i +"].City.CityName");
				address.City = city;

				DescribeDeliveryAddressResponse.DescribeDeliveryAddress_Address.DescribeDeliveryAddress_Area area = new DescribeDeliveryAddressResponse.DescribeDeliveryAddress_Address.DescribeDeliveryAddress_Area();
				area.AreaName = _ctx.StringValue("DescribeDeliveryAddress.Addresses["+ i +"].Area.AreaName");
				area.AreaId = _ctx.LongValue("DescribeDeliveryAddress.Addresses["+ i +"].Area.AreaId");
				address.Area = area;

				DescribeDeliveryAddressResponse.DescribeDeliveryAddress_Address.DescribeDeliveryAddress_Town town = new DescribeDeliveryAddressResponse.DescribeDeliveryAddress_Address.DescribeDeliveryAddress_Town();
				town.TownName = _ctx.StringValue("DescribeDeliveryAddress.Addresses["+ i +"].Town.TownName");
				town.TownId = _ctx.LongValue("DescribeDeliveryAddress.Addresses["+ i +"].Town.TownId");
				address.Town = town;

				describeDeliveryAddressResponse_addresses.Add(address);
			}
			describeDeliveryAddressResponse.Addresses = describeDeliveryAddressResponse_addresses;
        
			return describeDeliveryAddressResponse;
        }
    }
}
