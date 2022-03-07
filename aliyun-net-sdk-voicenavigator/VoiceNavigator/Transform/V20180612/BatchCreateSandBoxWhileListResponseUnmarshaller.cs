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
    public class BatchCreateSandBoxWhileListResponseUnmarshaller
    {
        public static BatchCreateSandBoxWhileListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchCreateSandBoxWhileListResponse batchCreateSandBoxWhileListResponse = new BatchCreateSandBoxWhileListResponse();

			batchCreateSandBoxWhileListResponse.HttpResponse = _ctx.HttpResponse;
			batchCreateSandBoxWhileListResponse.RequestId = _ctx.StringValue("BatchCreateSandBoxWhileList.RequestId");
			batchCreateSandBoxWhileListResponse.Repeat = _ctx.BooleanValue("BatchCreateSandBoxWhileList.Repeat");

			List<BatchCreateSandBoxWhileListResponse.BatchCreateSandBoxWhileList_WhiteListItem> batchCreateSandBoxWhileListResponse_whiteList = new List<BatchCreateSandBoxWhileListResponse.BatchCreateSandBoxWhileList_WhiteListItem>();
			for (int i = 0; i < _ctx.Length("BatchCreateSandBoxWhileList.WhiteList.Length"); i++) {
				BatchCreateSandBoxWhileListResponse.BatchCreateSandBoxWhileList_WhiteListItem whiteListItem = new BatchCreateSandBoxWhileListResponse.BatchCreateSandBoxWhileList_WhiteListItem();
				whiteListItem.Uuid = _ctx.StringValue("BatchCreateSandBoxWhileList.WhiteList["+ i +"].Uuid");
				whiteListItem.PhoneNumber = _ctx.StringValue("BatchCreateSandBoxWhileList.WhiteList["+ i +"].PhoneNumber");
				whiteListItem.Description = _ctx.StringValue("BatchCreateSandBoxWhileList.WhiteList["+ i +"].Description");
				whiteListItem.IsEnable = _ctx.IntegerValue("BatchCreateSandBoxWhileList.WhiteList["+ i +"].IsEnable");
				whiteListItem.GmtCreate = _ctx.LongValue("BatchCreateSandBoxWhileList.WhiteList["+ i +"].GmtCreate");
				whiteListItem.InstanceId = _ctx.StringValue("BatchCreateSandBoxWhileList.WhiteList["+ i +"].InstanceId");
				whiteListItem.GmtModified = _ctx.LongValue("BatchCreateSandBoxWhileList.WhiteList["+ i +"].GmtModified");
				whiteListItem.Name = _ctx.StringValue("BatchCreateSandBoxWhileList.WhiteList["+ i +"].Name");

				batchCreateSandBoxWhileListResponse_whiteList.Add(whiteListItem);
			}
			batchCreateSandBoxWhileListResponse.WhiteList = batchCreateSandBoxWhileListResponse_whiteList;
        
			return batchCreateSandBoxWhileListResponse;
        }
    }
}
