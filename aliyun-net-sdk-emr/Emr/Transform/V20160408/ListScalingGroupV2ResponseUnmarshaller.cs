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
    public class ListScalingGroupV2ResponseUnmarshaller
    {
        public static ListScalingGroupV2Response Unmarshall(UnmarshallerContext _ctx)
        {
			ListScalingGroupV2Response listScalingGroupV2Response = new ListScalingGroupV2Response();

			listScalingGroupV2Response.HttpResponse = _ctx.HttpResponse;
			listScalingGroupV2Response.RequestId = _ctx.StringValue("ListScalingGroupV2.RequestId");
			listScalingGroupV2Response.PageNumber = _ctx.IntegerValue("ListScalingGroupV2.PageNumber");
			listScalingGroupV2Response.PageSize = _ctx.IntegerValue("ListScalingGroupV2.PageSize");
			listScalingGroupV2Response.TotalCount = _ctx.IntegerValue("ListScalingGroupV2.TotalCount");
			listScalingGroupV2Response.NextToken = _ctx.StringValue("ListScalingGroupV2.NextToken");

			List<ListScalingGroupV2Response.ListScalingGroupV2_Item> listScalingGroupV2Response_items = new List<ListScalingGroupV2Response.ListScalingGroupV2_Item>();
			for (int i = 0; i < _ctx.Length("ListScalingGroupV2.Items.Length"); i++) {
				ListScalingGroupV2Response.ListScalingGroupV2_Item item = new ListScalingGroupV2Response.ListScalingGroupV2_Item();
				item.ScalingGroupId = _ctx.StringValue("ListScalingGroupV2.Items["+ i +"].ScalingGroupId");
				item.Name = _ctx.StringValue("ListScalingGroupV2.Items["+ i +"].Name");
				item.Description = _ctx.StringValue("ListScalingGroupV2.Items["+ i +"].Description");
				item.ActiveStatus = _ctx.StringValue("ListScalingGroupV2.Items["+ i +"].ActiveStatus");
				item.HostGroupBizId = _ctx.StringValue("ListScalingGroupV2.Items["+ i +"].HostGroupBizId");
				item.ScalingInMode = _ctx.StringValue("ListScalingGroupV2.Items["+ i +"].ScalingInMode");
				item.ScalingMinSize = _ctx.IntegerValue("ListScalingGroupV2.Items["+ i +"].ScalingMinSize");
				item.ScalingMaxSize = _ctx.IntegerValue("ListScalingGroupV2.Items["+ i +"].ScalingMaxSize");

				listScalingGroupV2Response_items.Add(item);
			}
			listScalingGroupV2Response.Items = listScalingGroupV2Response_items;
        
			return listScalingGroupV2Response;
        }
    }
}
