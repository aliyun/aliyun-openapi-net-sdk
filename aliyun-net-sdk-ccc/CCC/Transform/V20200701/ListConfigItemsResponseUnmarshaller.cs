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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class ListConfigItemsResponseUnmarshaller
    {
        public static ListConfigItemsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListConfigItemsResponse listConfigItemsResponse = new ListConfigItemsResponse();

			listConfigItemsResponse.HttpResponse = _ctx.HttpResponse;
			listConfigItemsResponse.Code = _ctx.StringValue("ListConfigItems.Code");
			listConfigItemsResponse.HttpStatusCode = _ctx.IntegerValue("ListConfigItems.HttpStatusCode");
			listConfigItemsResponse.Message = _ctx.StringValue("ListConfigItems.Message");
			listConfigItemsResponse.RequestId = _ctx.StringValue("ListConfigItems.RequestId");

			List<string> listConfigItemsResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("ListConfigItems.Params.Length"); i++) {
				listConfigItemsResponse_params.Add(_ctx.StringValue("ListConfigItems.Params["+ i +"]"));
			}
			listConfigItemsResponse._Params = listConfigItemsResponse_params;

			List<ListConfigItemsResponse.ListConfigItems_ConfigItem> listConfigItemsResponse_data = new List<ListConfigItemsResponse.ListConfigItems_ConfigItem>();
			for (int i = 0; i < _ctx.Length("ListConfigItems.Data.Length"); i++) {
				ListConfigItemsResponse.ListConfigItems_ConfigItem configItem = new ListConfigItemsResponse.ListConfigItems_ConfigItem();
				configItem.InstanceId = _ctx.StringValue("ListConfigItems.Data["+ i +"].InstanceId");
				configItem.Name = _ctx.StringValue("ListConfigItems.Data["+ i +"].Name");
				configItem.ObjectId = _ctx.StringValue("ListConfigItems.Data["+ i +"].ObjectId");
				configItem.ObjectType = _ctx.StringValue("ListConfigItems.Data["+ i +"].ObjectType");
				configItem._Value = _ctx.StringValue("ListConfigItems.Data["+ i +"].Value");

				listConfigItemsResponse_data.Add(configItem);
			}
			listConfigItemsResponse.Data = listConfigItemsResponse_data;
        
			return listConfigItemsResponse;
        }
    }
}
