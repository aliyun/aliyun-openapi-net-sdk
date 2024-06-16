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
    public class ListLniPrivateIpAddressResponseUnmarshaller
    {
        public static ListLniPrivateIpAddressResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLniPrivateIpAddressResponse listLniPrivateIpAddressResponse = new ListLniPrivateIpAddressResponse();

			listLniPrivateIpAddressResponse.HttpResponse = _ctx.HttpResponse;
			listLniPrivateIpAddressResponse.Code = _ctx.IntegerValue("ListLniPrivateIpAddress.Code");
			listLniPrivateIpAddressResponse.Message = _ctx.StringValue("ListLniPrivateIpAddress.Message");
			listLniPrivateIpAddressResponse.RequestId = _ctx.StringValue("ListLniPrivateIpAddress.RequestId");

			ListLniPrivateIpAddressResponse.ListLniPrivateIpAddress_Content content = new ListLniPrivateIpAddressResponse.ListLniPrivateIpAddress_Content();
			content.Total = _ctx.LongValue("ListLniPrivateIpAddress.Content.Total");

			List<ListLniPrivateIpAddressResponse.ListLniPrivateIpAddress_Content.ListLniPrivateIpAddress_DataItem> content_data = new List<ListLniPrivateIpAddressResponse.ListLniPrivateIpAddress_Content.ListLniPrivateIpAddress_DataItem>();
			for (int i = 0; i < _ctx.Length("ListLniPrivateIpAddress.Content.Data.Length"); i++) {
				ListLniPrivateIpAddressResponse.ListLniPrivateIpAddress_Content.ListLniPrivateIpAddress_DataItem dataItem = new ListLniPrivateIpAddressResponse.ListLniPrivateIpAddress_Content.ListLniPrivateIpAddress_DataItem();
				dataItem.RegionId = _ctx.StringValue("ListLniPrivateIpAddress.Content.Data["+ i +"].RegionId");
				dataItem.GmtCreate = _ctx.StringValue("ListLniPrivateIpAddress.Content.Data["+ i +"].GmtCreate");
				dataItem.NetworkInterfaceId = _ctx.StringValue("ListLniPrivateIpAddress.Content.Data["+ i +"].NetworkInterfaceId");
				dataItem.IpName = _ctx.StringValue("ListLniPrivateIpAddress.Content.Data["+ i +"].IpName");
				dataItem.PrivateIpAddress = _ctx.StringValue("ListLniPrivateIpAddress.Content.Data["+ i +"].PrivateIpAddress");
				dataItem.IpAddressMac = _ctx.StringValue("ListLniPrivateIpAddress.Content.Data["+ i +"].IpAddressMac");
				dataItem.Status = _ctx.StringValue("ListLniPrivateIpAddress.Content.Data["+ i +"].Status");
				dataItem.Description = _ctx.StringValue("ListLniPrivateIpAddress.Content.Data["+ i +"].Description");
				dataItem.Message = _ctx.StringValue("ListLniPrivateIpAddress.Content.Data["+ i +"].Message");

				content_data.Add(dataItem);
			}
			content.Data = content_data;
			listLniPrivateIpAddressResponse.Content = content;
        
			return listLniPrivateIpAddressResponse;
        }
    }
}
