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
using Aliyun.Acs.AiContent.Model.V20240611;

namespace Aliyun.Acs.AiContent.Transform.V20240611
{
    public class AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponseUnmarshaller
    {
        public static AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse = new AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse();

			aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.HttpResponse = _ctx.HttpResponse;
			aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.RequestId = _ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.requestId");
			aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.Success = _ctx.BooleanValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.success");
			aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.ErrCode = _ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.errCode");
			aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.ErrMessage = _ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.errMessage");
			aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.HttpStatusCode = _ctx.IntegerValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.httpStatusCode");

			List<AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.AliyunConsoleOpenApiQueryAliyunConsoleServcieList_DataItem> aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse_data = new List<AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.AliyunConsoleOpenApiQueryAliyunConsoleServcieList_DataItem>();
			for (int i = 0; i < _ctx.Length("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data.Length"); i++) {
				AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.AliyunConsoleOpenApiQueryAliyunConsoleServcieList_DataItem dataItem = new AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.AliyunConsoleOpenApiQueryAliyunConsoleServcieList_DataItem();
				dataItem.ServiceCode = _ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].ServiceCode");
				dataItem.ServiceName = _ctx.StringValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].ServiceName");
				dataItem.FreeCount = _ctx.IntegerValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].FreeCount");
				dataItem.FreeConcurrencyCount = _ctx.IntegerValue("AliyunConsoleOpenApiQueryAliyunConsoleServcieList.Data["+ i +"].FreeConcurrencyCount");

				aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse_data.Add(dataItem);
			}
			aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse.Data = aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse_data;
        
			return aliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse;
        }
    }
}
