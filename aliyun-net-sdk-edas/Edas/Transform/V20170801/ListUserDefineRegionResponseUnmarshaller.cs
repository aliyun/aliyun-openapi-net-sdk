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
    public class ListUserDefineRegionResponseUnmarshaller
    {
        public static ListUserDefineRegionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUserDefineRegionResponse listUserDefineRegionResponse = new ListUserDefineRegionResponse();

			listUserDefineRegionResponse.HttpResponse = _ctx.HttpResponse;
			listUserDefineRegionResponse.Code = _ctx.IntegerValue("ListUserDefineRegion.Code");
			listUserDefineRegionResponse.Message = _ctx.StringValue("ListUserDefineRegion.Message");
			listUserDefineRegionResponse.RequestId = _ctx.StringValue("ListUserDefineRegion.RequestId");

			List<ListUserDefineRegionResponse.ListUserDefineRegion_UserDefineRegionEntity> listUserDefineRegionResponse_userDefineRegionList = new List<ListUserDefineRegionResponse.ListUserDefineRegion_UserDefineRegionEntity>();
			for (int i = 0; i < _ctx.Length("ListUserDefineRegion.UserDefineRegionList.Length"); i++) {
				ListUserDefineRegionResponse.ListUserDefineRegion_UserDefineRegionEntity userDefineRegionEntity = new ListUserDefineRegionResponse.ListUserDefineRegion_UserDefineRegionEntity();
				userDefineRegionEntity.Id = _ctx.LongValue("ListUserDefineRegion.UserDefineRegionList["+ i +"].Id");
				userDefineRegionEntity.UserId = _ctx.StringValue("ListUserDefineRegion.UserDefineRegionList["+ i +"].UserId");
				userDefineRegionEntity.RegionId = _ctx.StringValue("ListUserDefineRegion.UserDefineRegionList["+ i +"].RegionId");
				userDefineRegionEntity.RegionName = _ctx.StringValue("ListUserDefineRegion.UserDefineRegionList["+ i +"].RegionName");
				userDefineRegionEntity.Description = _ctx.StringValue("ListUserDefineRegion.UserDefineRegionList["+ i +"].Description");
				userDefineRegionEntity.BelongRegion = _ctx.StringValue("ListUserDefineRegion.UserDefineRegionList["+ i +"].BelongRegion");
				userDefineRegionEntity.DebugEnable = _ctx.BooleanValue("ListUserDefineRegion.UserDefineRegionList["+ i +"].DebugEnable");

				listUserDefineRegionResponse_userDefineRegionList.Add(userDefineRegionEntity);
			}
			listUserDefineRegionResponse.UserDefineRegionList = listUserDefineRegionResponse_userDefineRegionList;
        
			return listUserDefineRegionResponse;
        }
    }
}
