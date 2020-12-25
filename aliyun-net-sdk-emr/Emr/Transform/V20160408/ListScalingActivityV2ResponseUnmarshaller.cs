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
    public class ListScalingActivityV2ResponseUnmarshaller
    {
        public static ListScalingActivityV2Response Unmarshall(UnmarshallerContext _ctx)
        {
			ListScalingActivityV2Response listScalingActivityV2Response = new ListScalingActivityV2Response();

			listScalingActivityV2Response.HttpResponse = _ctx.HttpResponse;
			listScalingActivityV2Response.RequestId = _ctx.StringValue("ListScalingActivityV2.RequestId");
			listScalingActivityV2Response.PageNumber = _ctx.IntegerValue("ListScalingActivityV2.PageNumber");
			listScalingActivityV2Response.PageSize = _ctx.IntegerValue("ListScalingActivityV2.PageSize");
			listScalingActivityV2Response.TotalCount = _ctx.IntegerValue("ListScalingActivityV2.TotalCount");
			listScalingActivityV2Response.NextToken = _ctx.StringValue("ListScalingActivityV2.NextToken");

			List<ListScalingActivityV2Response.ListScalingActivityV2_Item> listScalingActivityV2Response_items = new List<ListScalingActivityV2Response.ListScalingActivityV2_Item>();
			for (int i = 0; i < _ctx.Length("ListScalingActivityV2.Items.Length"); i++) {
				ListScalingActivityV2Response.ListScalingActivityV2_Item item = new ListScalingActivityV2Response.ListScalingActivityV2_Item();
				item.BizId = _ctx.StringValue("ListScalingActivityV2.Items["+ i +"].BizId");
				item.StartTime = _ctx.LongValue("ListScalingActivityV2.Items["+ i +"].StartTime");
				item.EndTime = _ctx.LongValue("ListScalingActivityV2.Items["+ i +"].EndTime");
				item.ExpectNum = _ctx.IntegerValue("ListScalingActivityV2.Items["+ i +"].ExpectNum");
				item.InstanceIds = _ctx.StringValue("ListScalingActivityV2.Items["+ i +"].InstanceIds");
				item.TotalCapacity = _ctx.IntegerValue("ListScalingActivityV2.Items["+ i +"].TotalCapacity");
				item.Cause = _ctx.StringValue("ListScalingActivityV2.Items["+ i +"].Cause");
				item.Description = _ctx.StringValue("ListScalingActivityV2.Items["+ i +"].Description");
				item.Transition = _ctx.StringValue("ListScalingActivityV2.Items["+ i +"].Transition");
				item.Status = _ctx.StringValue("ListScalingActivityV2.Items["+ i +"].Status");
				item.ScalingRuleId = _ctx.StringValue("ListScalingActivityV2.Items["+ i +"].ScalingRuleId");
				item.ScalingRuleName = _ctx.StringValue("ListScalingActivityV2.Items["+ i +"].ScalingRuleName");
				item.HostGroupBizId = _ctx.StringValue("ListScalingActivityV2.Items["+ i +"].HostGroupBizId");
				item.HostGroupName = _ctx.StringValue("ListScalingActivityV2.Items["+ i +"].HostGroupName");

				listScalingActivityV2Response_items.Add(item);
			}
			listScalingActivityV2Response.Items = listScalingActivityV2Response_items;
        
			return listScalingActivityV2Response;
        }
    }
}
