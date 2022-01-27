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
    public class QueryDeviceFileResponseUnmarshaller
    {
        public static QueryDeviceFileResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceFileResponse queryDeviceFileResponse = new QueryDeviceFileResponse();

			queryDeviceFileResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceFileResponse.RequestId = _ctx.StringValue("QueryDeviceFile.RequestId");
			queryDeviceFileResponse.Success = _ctx.BooleanValue("QueryDeviceFile.Success");
			queryDeviceFileResponse.Code = _ctx.StringValue("QueryDeviceFile.Code");
			queryDeviceFileResponse.ErrorMessage = _ctx.StringValue("QueryDeviceFile.ErrorMessage");

			QueryDeviceFileResponse.QueryDeviceFile_Data data = new QueryDeviceFileResponse.QueryDeviceFile_Data();
			data.FileId = _ctx.StringValue("QueryDeviceFile.Data.FileId");
			data.Name = _ctx.StringValue("QueryDeviceFile.Data.Name");
			data.Size = _ctx.StringValue("QueryDeviceFile.Data.Size");
			data.UtcCreatedOn = _ctx.StringValue("QueryDeviceFile.Data.UtcCreatedOn");
			data.DownloadUrl = _ctx.StringValue("QueryDeviceFile.Data.DownloadUrl");
			queryDeviceFileResponse.Data = data;
        
			return queryDeviceFileResponse;
        }
    }
}
