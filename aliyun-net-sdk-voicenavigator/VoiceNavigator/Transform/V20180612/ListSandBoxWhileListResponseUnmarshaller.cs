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
using Aliyun.Acs.VoiceNavigator.Model.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Transform.V20180612
{
    public class ListSandBoxWhileListResponseUnmarshaller
    {
        public static ListSandBoxWhileListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSandBoxWhileListResponse listSandBoxWhileListResponse = new ListSandBoxWhileListResponse();

			listSandBoxWhileListResponse.HttpResponse = _ctx.HttpResponse;
			listSandBoxWhileListResponse.PageSize = _ctx.IntegerValue("ListSandBoxWhileList.PageSize");
			listSandBoxWhileListResponse.RequestId = _ctx.StringValue("ListSandBoxWhileList.RequestId");
			listSandBoxWhileListResponse.PageNumber = _ctx.IntegerValue("ListSandBoxWhileList.PageNumber");
			listSandBoxWhileListResponse.TotalCount = _ctx.LongValue("ListSandBoxWhileList.TotalCount");

			List<ListSandBoxWhileListResponse.ListSandBoxWhileList_WhiteListItem> listSandBoxWhileListResponse_whiteList = new List<ListSandBoxWhileListResponse.ListSandBoxWhileList_WhiteListItem>();
			for (int i = 0; i < _ctx.Length("ListSandBoxWhileList.WhiteList.Length"); i++) {
				ListSandBoxWhileListResponse.ListSandBoxWhileList_WhiteListItem whiteListItem = new ListSandBoxWhileListResponse.ListSandBoxWhileList_WhiteListItem();
				whiteListItem.Uuid = _ctx.StringValue("ListSandBoxWhileList.WhiteList["+ i +"].Uuid");
				whiteListItem.PhoneNumber = _ctx.StringValue("ListSandBoxWhileList.WhiteList["+ i +"].PhoneNumber");
				whiteListItem.Description = _ctx.StringValue("ListSandBoxWhileList.WhiteList["+ i +"].Description");
				whiteListItem.IsEnable = _ctx.IntegerValue("ListSandBoxWhileList.WhiteList["+ i +"].IsEnable");
				whiteListItem.GmtCreate = _ctx.LongValue("ListSandBoxWhileList.WhiteList["+ i +"].GmtCreate");
				whiteListItem.InstanceId = _ctx.StringValue("ListSandBoxWhileList.WhiteList["+ i +"].InstanceId");
				whiteListItem.GmtModified = _ctx.LongValue("ListSandBoxWhileList.WhiteList["+ i +"].GmtModified");
				whiteListItem.Name = _ctx.StringValue("ListSandBoxWhileList.WhiteList["+ i +"].Name");

				listSandBoxWhileListResponse_whiteList.Add(whiteListItem);
			}
			listSandBoxWhileListResponse.WhiteList = listSandBoxWhileListResponse_whiteList;
        
			return listSandBoxWhileListResponse;
        }
    }
}
