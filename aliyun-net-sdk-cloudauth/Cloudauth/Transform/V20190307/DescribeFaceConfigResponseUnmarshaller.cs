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
using Aliyun.Acs.Cloudauth.Model.V20190307;

namespace Aliyun.Acs.Cloudauth.Transform.V20190307
{
    public class DescribeFaceConfigResponseUnmarshaller
    {
        public static DescribeFaceConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFaceConfigResponse describeFaceConfigResponse = new DescribeFaceConfigResponse();

			describeFaceConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeFaceConfigResponse.RequestId = _ctx.StringValue("DescribeFaceConfig.RequestId");

			List<DescribeFaceConfigResponse.DescribeFaceConfig_ItemsItem> describeFaceConfigResponse_items = new List<DescribeFaceConfigResponse.DescribeFaceConfig_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeFaceConfig.Items.Length"); i++) {
				DescribeFaceConfigResponse.DescribeFaceConfig_ItemsItem itemsItem = new DescribeFaceConfigResponse.DescribeFaceConfig_ItemsItem();
				itemsItem.BizType = _ctx.StringValue("DescribeFaceConfig.Items["+ i +"].BizType");
				itemsItem.BizName = _ctx.StringValue("DescribeFaceConfig.Items["+ i +"].BizName");
				itemsItem.GmtUpdated = _ctx.LongValue("DescribeFaceConfig.Items["+ i +"].GmtUpdated");

				describeFaceConfigResponse_items.Add(itemsItem);
			}
			describeFaceConfigResponse.Items = describeFaceConfigResponse_items;
        
			return describeFaceConfigResponse;
        }
    }
}
