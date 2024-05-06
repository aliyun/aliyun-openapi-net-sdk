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
    public class ListElasticNetworkInterfacesResponseUnmarshaller
    {
        public static ListElasticNetworkInterfacesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListElasticNetworkInterfacesResponse listElasticNetworkInterfacesResponse = new ListElasticNetworkInterfacesResponse();

			listElasticNetworkInterfacesResponse.HttpResponse = _ctx.HttpResponse;
			listElasticNetworkInterfacesResponse.Code = _ctx.IntegerValue("ListElasticNetworkInterfaces.Code");
			listElasticNetworkInterfacesResponse.Message = _ctx.StringValue("ListElasticNetworkInterfaces.Message");
			listElasticNetworkInterfacesResponse.RequestId = _ctx.StringValue("ListElasticNetworkInterfaces.RequestId");

			ListElasticNetworkInterfacesResponse.ListElasticNetworkInterfaces_Content content = new ListElasticNetworkInterfacesResponse.ListElasticNetworkInterfaces_Content();
			content.Total = _ctx.LongValue("ListElasticNetworkInterfaces.Content.Total");

			List<ListElasticNetworkInterfacesResponse.ListElasticNetworkInterfaces_Content.ListElasticNetworkInterfaces_DataItem> content_data = new List<ListElasticNetworkInterfacesResponse.ListElasticNetworkInterfaces_Content.ListElasticNetworkInterfaces_DataItem>();
			for (int i = 0; i < _ctx.Length("ListElasticNetworkInterfaces.Content.Data.Length"); i++) {
				ListElasticNetworkInterfacesResponse.ListElasticNetworkInterfaces_Content.ListElasticNetworkInterfaces_DataItem dataItem = new ListElasticNetworkInterfacesResponse.ListElasticNetworkInterfaces_Content.ListElasticNetworkInterfaces_DataItem();
				dataItem.RegionId = _ctx.StringValue("ListElasticNetworkInterfaces.Content.Data["+ i +"].RegionId");
				dataItem.ZoneId = _ctx.StringValue("ListElasticNetworkInterfaces.Content.Data["+ i +"].ZoneId");
				dataItem.ElasticNetworkInterfaceId = _ctx.StringValue("ListElasticNetworkInterfaces.Content.Data["+ i +"].ElasticNetworkInterfaceId");
				dataItem.NodeId = _ctx.StringValue("ListElasticNetworkInterfaces.Content.Data["+ i +"].NodeId");
				dataItem.Status = _ctx.StringValue("ListElasticNetworkInterfaces.Content.Data["+ i +"].Status");
				dataItem.Ip = _ctx.StringValue("ListElasticNetworkInterfaces.Content.Data["+ i +"].Ip");
				dataItem.VpcId = _ctx.StringValue("ListElasticNetworkInterfaces.Content.Data["+ i +"].VpcId");
				dataItem.VSwitchId = _ctx.StringValue("ListElasticNetworkInterfaces.Content.Data["+ i +"].VSwitchId");
				dataItem.Message = _ctx.StringValue("ListElasticNetworkInterfaces.Content.Data["+ i +"].Message");
				dataItem.Mac = _ctx.StringValue("ListElasticNetworkInterfaces.Content.Data["+ i +"].Mac");
				dataItem.Type = _ctx.StringValue("ListElasticNetworkInterfaces.Content.Data["+ i +"].Type");
				dataItem.Gateway = _ctx.StringValue("ListElasticNetworkInterfaces.Content.Data["+ i +"].Gateway");
				dataItem.Mask = _ctx.StringValue("ListElasticNetworkInterfaces.Content.Data["+ i +"].Mask");
				dataItem.CreateTime = _ctx.StringValue("ListElasticNetworkInterfaces.Content.Data["+ i +"].CreateTime");
				dataItem.GmtModified = _ctx.StringValue("ListElasticNetworkInterfaces.Content.Data["+ i +"].GmtModified");
				dataItem.Description = _ctx.StringValue("ListElasticNetworkInterfaces.Content.Data["+ i +"].Description");
				dataItem.SecurityGroupId = _ctx.StringValue("ListElasticNetworkInterfaces.Content.Data["+ i +"].SecurityGroupId");

				content_data.Add(dataItem);
			}
			content.Data = content_data;
			listElasticNetworkInterfacesResponse.Content = content;
        
			return listElasticNetworkInterfacesResponse;
        }
    }
}
