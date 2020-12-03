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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryPageByApplyIdResponseUnmarshaller
    {
        public static QueryPageByApplyIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryPageByApplyIdResponse queryPageByApplyIdResponse = new QueryPageByApplyIdResponse();

			queryPageByApplyIdResponse.HttpResponse = _ctx.HttpResponse;
			queryPageByApplyIdResponse.RequestId = _ctx.StringValue("QueryPageByApplyId.RequestId");
			queryPageByApplyIdResponse.Success = _ctx.BooleanValue("QueryPageByApplyId.Success");
			queryPageByApplyIdResponse.Code = _ctx.StringValue("QueryPageByApplyId.Code");
			queryPageByApplyIdResponse.ErrorMessage = _ctx.StringValue("QueryPageByApplyId.ErrorMessage");
			queryPageByApplyIdResponse.PageSize = _ctx.IntegerValue("QueryPageByApplyId.PageSize");
			queryPageByApplyIdResponse.Page = _ctx.IntegerValue("QueryPageByApplyId.Page");
			queryPageByApplyIdResponse.PageCount = _ctx.IntegerValue("QueryPageByApplyId.PageCount");
			queryPageByApplyIdResponse.Total = _ctx.IntegerValue("QueryPageByApplyId.Total");

			List<QueryPageByApplyIdResponse.QueryPageByApplyId_ApplyDeviceInfo> queryPageByApplyIdResponse_applyDeviceList = new List<QueryPageByApplyIdResponse.QueryPageByApplyId_ApplyDeviceInfo>();
			for (int i = 0; i < _ctx.Length("QueryPageByApplyId.ApplyDeviceList.Length"); i++) {
				QueryPageByApplyIdResponse.QueryPageByApplyId_ApplyDeviceInfo applyDeviceInfo = new QueryPageByApplyIdResponse.QueryPageByApplyId_ApplyDeviceInfo();
				applyDeviceInfo.DeviceId = _ctx.StringValue("QueryPageByApplyId.ApplyDeviceList["+ i +"].DeviceId");
				applyDeviceInfo.DeviceName = _ctx.StringValue("QueryPageByApplyId.ApplyDeviceList["+ i +"].DeviceName");
				applyDeviceInfo.DeviceSecret = _ctx.StringValue("QueryPageByApplyId.ApplyDeviceList["+ i +"].DeviceSecret");
				applyDeviceInfo.IotId = _ctx.StringValue("QueryPageByApplyId.ApplyDeviceList["+ i +"].IotId");

				queryPageByApplyIdResponse_applyDeviceList.Add(applyDeviceInfo);
			}
			queryPageByApplyIdResponse.ApplyDeviceList = queryPageByApplyIdResponse_applyDeviceList;
        
			return queryPageByApplyIdResponse;
        }
    }
}
