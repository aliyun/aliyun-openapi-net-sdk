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
using Aliyun.Acs.eflo.Model.V20220530;

namespace Aliyun.Acs.eflo.Transform.V20220530
{
    public class ListLeniPrivateIpAddressesResponseUnmarshaller
    {
        public static ListLeniPrivateIpAddressesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLeniPrivateIpAddressesResponse listLeniPrivateIpAddressesResponse = new ListLeniPrivateIpAddressesResponse();

			listLeniPrivateIpAddressesResponse.HttpResponse = _ctx.HttpResponse;
			listLeniPrivateIpAddressesResponse.Code = _ctx.IntegerValue("ListLeniPrivateIpAddresses.Code");
			listLeniPrivateIpAddressesResponse.Message = _ctx.StringValue("ListLeniPrivateIpAddresses.Message");
			listLeniPrivateIpAddressesResponse.RequestId = _ctx.StringValue("ListLeniPrivateIpAddresses.RequestId");

			ListLeniPrivateIpAddressesResponse.ListLeniPrivateIpAddresses_Content content = new ListLeniPrivateIpAddressesResponse.ListLeniPrivateIpAddresses_Content();
			content.Total = _ctx.LongValue("ListLeniPrivateIpAddresses.Content.Total");

			List<ListLeniPrivateIpAddressesResponse.ListLeniPrivateIpAddresses_Content.ListLeniPrivateIpAddresses_DataItem> content_data = new List<ListLeniPrivateIpAddressesResponse.ListLeniPrivateIpAddresses_Content.ListLeniPrivateIpAddresses_DataItem>();
			for (int i = 0; i < _ctx.Length("ListLeniPrivateIpAddresses.Content.Data.Length"); i++) {
				ListLeniPrivateIpAddressesResponse.ListLeniPrivateIpAddresses_Content.ListLeniPrivateIpAddresses_DataItem dataItem = new ListLeniPrivateIpAddressesResponse.ListLeniPrivateIpAddresses_Content.ListLeniPrivateIpAddresses_DataItem();
				dataItem.ElasticNetworkInterfaceId = _ctx.StringValue("ListLeniPrivateIpAddresses.Content.Data["+ i +"].ElasticNetworkInterfaceId");
				dataItem.RegionId = _ctx.StringValue("ListLeniPrivateIpAddresses.Content.Data["+ i +"].RegionId");
				dataItem.GmtCreate = _ctx.StringValue("ListLeniPrivateIpAddresses.Content.Data["+ i +"].GmtCreate");
				dataItem.GmtModified = _ctx.StringValue("ListLeniPrivateIpAddresses.Content.Data["+ i +"].GmtModified");
				dataItem.IpName = _ctx.StringValue("ListLeniPrivateIpAddresses.Content.Data["+ i +"].IpName");
				dataItem.PrivateIpAddress = _ctx.StringValue("ListLeniPrivateIpAddresses.Content.Data["+ i +"].PrivateIpAddress");
				dataItem.Status = _ctx.StringValue("ListLeniPrivateIpAddresses.Content.Data["+ i +"].Status");
				dataItem.Description = _ctx.StringValue("ListLeniPrivateIpAddresses.Content.Data["+ i +"].Description");
				dataItem.Message = _ctx.StringValue("ListLeniPrivateIpAddresses.Content.Data["+ i +"].Message");

				content_data.Add(dataItem);
			}
			content.Data = content_data;
			listLeniPrivateIpAddressesResponse.Content = content;
        
			return listLeniPrivateIpAddressesResponse;
        }
    }
}
