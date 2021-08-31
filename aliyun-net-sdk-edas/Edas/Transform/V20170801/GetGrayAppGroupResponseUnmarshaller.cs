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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class GetGrayAppGroupResponseUnmarshaller
    {
        public static GetGrayAppGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetGrayAppGroupResponse getGrayAppGroupResponse = new GetGrayAppGroupResponse();

			getGrayAppGroupResponse.HttpResponse = _ctx.HttpResponse;
			getGrayAppGroupResponse.RequestId = _ctx.StringValue("GetGrayAppGroup.RequestId");
			getGrayAppGroupResponse.Code = _ctx.IntegerValue("GetGrayAppGroup.Code");
			getGrayAppGroupResponse.Message = _ctx.StringValue("GetGrayAppGroup.Message");

			List<GetGrayAppGroupResponse.GetGrayAppGroup_DataItem> getGrayAppGroupResponse_data = new List<GetGrayAppGroupResponse.GetGrayAppGroup_DataItem>();
			for (int i = 0; i < _ctx.Length("GetGrayAppGroup.Data.Length"); i++) {
				GetGrayAppGroupResponse.GetGrayAppGroup_DataItem dataItem = new GetGrayAppGroupResponse.GetGrayAppGroup_DataItem();
				dataItem.AppId = _ctx.StringValue("GetGrayAppGroup.Data["+ i +"].AppId");
				dataItem.AppName = _ctx.StringValue("GetGrayAppGroup.Data["+ i +"].AppName");
				dataItem.RegionId = _ctx.StringValue("GetGrayAppGroup.Data["+ i +"].RegionId");
				dataItem.RegionName = _ctx.StringValue("GetGrayAppGroup.Data["+ i +"].RegionName");

				List<GetGrayAppGroupResponse.GetGrayAppGroup_DataItem.GetGrayAppGroup_GroupListItem> dataItem_groupList = new List<GetGrayAppGroupResponse.GetGrayAppGroup_DataItem.GetGrayAppGroup_GroupListItem>();
				for (int j = 0; j < _ctx.Length("GetGrayAppGroup.Data["+ i +"].GroupList.Length"); j++) {
					GetGrayAppGroupResponse.GetGrayAppGroup_DataItem.GetGrayAppGroup_GroupListItem groupListItem = new GetGrayAppGroupResponse.GetGrayAppGroup_DataItem.GetGrayAppGroup_GroupListItem();
					groupListItem.Id = _ctx.StringValue("GetGrayAppGroup.Data["+ i +"].GroupList["+ j +"].Id");
					groupListItem.GroupName = _ctx.StringValue("GetGrayAppGroup.Data["+ i +"].GroupList["+ j +"].GroupName");
					groupListItem.PackageVersion = _ctx.StringValue("GetGrayAppGroup.Data["+ i +"].GroupList["+ j +"].PackageVersion");
					groupListItem.Instances = _ctx.IntegerValue("GetGrayAppGroup.Data["+ i +"].GroupList["+ j +"].Instances");
					groupListItem.ClusterId = _ctx.StringValue("GetGrayAppGroup.Data["+ i +"].GroupList["+ j +"].ClusterId");
					groupListItem.DpathPointcutName = _ctx.StringValue("GetGrayAppGroup.Data["+ i +"].GroupList["+ j +"].DpathPointcutName");

					dataItem_groupList.Add(groupListItem);
				}
				dataItem.GroupList = dataItem_groupList;

				getGrayAppGroupResponse_data.Add(dataItem);
			}
			getGrayAppGroupResponse.Data = getGrayAppGroupResponse_data;
        
			return getGrayAppGroupResponse;
        }
    }
}
