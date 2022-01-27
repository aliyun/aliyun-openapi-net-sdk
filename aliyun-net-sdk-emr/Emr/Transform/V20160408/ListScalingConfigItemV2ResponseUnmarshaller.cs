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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListScalingConfigItemV2ResponseUnmarshaller
    {
        public static ListScalingConfigItemV2Response Unmarshall(UnmarshallerContext _ctx)
        {
			ListScalingConfigItemV2Response listScalingConfigItemV2Response = new ListScalingConfigItemV2Response();

			listScalingConfigItemV2Response.HttpResponse = _ctx.HttpResponse;
			listScalingConfigItemV2Response.RequestId = _ctx.StringValue("ListScalingConfigItemV2.RequestId");
			listScalingConfigItemV2Response.PageNumber = _ctx.IntegerValue("ListScalingConfigItemV2.PageNumber");
			listScalingConfigItemV2Response.PageSize = _ctx.IntegerValue("ListScalingConfigItemV2.PageSize");
			listScalingConfigItemV2Response.TotalCount = _ctx.IntegerValue("ListScalingConfigItemV2.TotalCount");
			listScalingConfigItemV2Response.NextToken = _ctx.StringValue("ListScalingConfigItemV2.NextToken");

			List<ListScalingConfigItemV2Response.ListScalingConfigItemV2_Item> listScalingConfigItemV2Response_items = new List<ListScalingConfigItemV2Response.ListScalingConfigItemV2_Item>();
			for (int i = 0; i < _ctx.Length("ListScalingConfigItemV2.Items.Length"); i++) {
				ListScalingConfigItemV2Response.ListScalingConfigItemV2_Item item = new ListScalingConfigItemV2Response.ListScalingConfigItemV2_Item();
				item.ConfigItemType = _ctx.StringValue("ListScalingConfigItemV2.Items["+ i +"].ConfigItemType");
				item.ScalingGroupBizId = _ctx.StringValue("ListScalingConfigItemV2.Items["+ i +"].ScalingGroupBizId");
				item.ScalingConfigItemBizId = _ctx.StringValue("ListScalingConfigItemV2.Items["+ i +"].ScalingConfigItemBizId");
				item.ConfigItemInformation = _ctx.StringValue("ListScalingConfigItemV2.Items["+ i +"].ConfigItemInformation");

				listScalingConfigItemV2Response_items.Add(item);
			}
			listScalingConfigItemV2Response.Items = listScalingConfigItemV2Response_items;
        
			return listScalingConfigItemV2Response;
        }
    }
}
