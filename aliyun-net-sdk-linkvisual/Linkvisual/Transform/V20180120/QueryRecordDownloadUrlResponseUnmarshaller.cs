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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class QueryRecordDownloadUrlResponseUnmarshaller
    {
        public static QueryRecordDownloadUrlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryRecordDownloadUrlResponse queryRecordDownloadUrlResponse = new QueryRecordDownloadUrlResponse();

			queryRecordDownloadUrlResponse.HttpResponse = _ctx.HttpResponse;
			queryRecordDownloadUrlResponse.Code = _ctx.StringValue("QueryRecordDownloadUrl.Code");
			queryRecordDownloadUrlResponse.ErrorMessage = _ctx.StringValue("QueryRecordDownloadUrl.ErrorMessage");
			queryRecordDownloadUrlResponse.RequestId = _ctx.StringValue("QueryRecordDownloadUrl.RequestId");
			queryRecordDownloadUrlResponse.Success = _ctx.BooleanValue("QueryRecordDownloadUrl.Success");

			QueryRecordDownloadUrlResponse.QueryRecordDownloadUrl_Data data = new QueryRecordDownloadUrlResponse.QueryRecordDownloadUrl_Data();
			data.Status = _ctx.IntegerValue("QueryRecordDownloadUrl.Data.Status");
			data.Url = _ctx.StringValue("QueryRecordDownloadUrl.Data.Url");
			data.Progress = _ctx.IntegerValue("QueryRecordDownloadUrl.Data.Progress");
			queryRecordDownloadUrlResponse.Data = data;
        
			return queryRecordDownloadUrlResponse;
        }
    }
}
