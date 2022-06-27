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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class GetMultiRateConfigListResponseUnmarshaller
    {
        public static GetMultiRateConfigListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMultiRateConfigListResponse getMultiRateConfigListResponse = new GetMultiRateConfigListResponse();

			getMultiRateConfigListResponse.HttpResponse = _ctx.HttpResponse;
			getMultiRateConfigListResponse.RequestId = _ctx.StringValue("GetMultiRateConfigList.RequestId");
			getMultiRateConfigListResponse.Message = _ctx.StringValue("GetMultiRateConfigList.Message");
			getMultiRateConfigListResponse.Code = _ctx.IntegerValue("GetMultiRateConfigList.Code");

			List<GetMultiRateConfigListResponse.GetMultiRateConfigList_Info> getMultiRateConfigListResponse_groupInfo = new List<GetMultiRateConfigListResponse.GetMultiRateConfigList_Info>();
			for (int i = 0; i < _ctx.Length("GetMultiRateConfigList.GroupInfo.Length"); i++) {
				GetMultiRateConfigListResponse.GetMultiRateConfigList_Info info = new GetMultiRateConfigListResponse.GetMultiRateConfigList_Info();
				info.App = _ctx.StringValue("GetMultiRateConfigList.GroupInfo["+ i +"].App");
				info.AvFormat = _ctx.StringValue("GetMultiRateConfigList.GroupInfo["+ i +"].AvFormat");
				info.GroupId = _ctx.StringValue("GetMultiRateConfigList.GroupInfo["+ i +"].GroupId");
				info.Count = _ctx.IntegerValue("GetMultiRateConfigList.GroupInfo["+ i +"].Count");

				getMultiRateConfigListResponse_groupInfo.Add(info);
			}
			getMultiRateConfigListResponse.GroupInfo = getMultiRateConfigListResponse_groupInfo;
        
			return getMultiRateConfigListResponse;
        }
    }
}
