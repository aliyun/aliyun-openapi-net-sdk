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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ListConfigResponseUnmarshaller
    {
        public static ListConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListConfigResponse listConfigResponse = new ListConfigResponse();

			listConfigResponse.HttpResponse = _ctx.HttpResponse;
			listConfigResponse.RequestId = _ctx.StringValue("ListConfig.RequestId");
			listConfigResponse.Success = _ctx.BooleanValue("ListConfig.Success");
			listConfigResponse.Code = _ctx.StringValue("ListConfig.Code");
			listConfigResponse.Message = _ctx.StringValue("ListConfig.Message");
			listConfigResponse.HttpStatusCode = _ctx.IntegerValue("ListConfig.HttpStatusCode");

			List<ListConfigResponse.ListConfig_ConfigItem> listConfigResponse_configItems = new List<ListConfigResponse.ListConfig_ConfigItem>();
			for (int i = 0; i < _ctx.Length("ListConfig.ConfigItems.Length"); i++) {
				ListConfigResponse.ListConfig_ConfigItem configItem = new ListConfigResponse.ListConfig_ConfigItem();
				configItem.Name = _ctx.StringValue("ListConfig.ConfigItems["+ i +"].Name");
				configItem._Value = _ctx.StringValue("ListConfig.ConfigItems["+ i +"].Value");

				listConfigResponse_configItems.Add(configItem);
			}
			listConfigResponse.ConfigItems = listConfigResponse_configItems;
        
			return listConfigResponse;
        }
    }
}
