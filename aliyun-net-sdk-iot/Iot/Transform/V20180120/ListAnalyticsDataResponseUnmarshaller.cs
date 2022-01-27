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
    public class ListAnalyticsDataResponseUnmarshaller
    {
        public static ListAnalyticsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAnalyticsDataResponse listAnalyticsDataResponse = new ListAnalyticsDataResponse();

			listAnalyticsDataResponse.HttpResponse = _ctx.HttpResponse;
			listAnalyticsDataResponse.RequestId = _ctx.StringValue("ListAnalyticsData.RequestId");
			listAnalyticsDataResponse.Success = _ctx.BooleanValue("ListAnalyticsData.Success");
			listAnalyticsDataResponse.Code = _ctx.StringValue("ListAnalyticsData.Code");
			listAnalyticsDataResponse.ErrorMessage = _ctx.StringValue("ListAnalyticsData.ErrorMessage");

			ListAnalyticsDataResponse.ListAnalyticsData_Data data = new ListAnalyticsDataResponse.ListAnalyticsData_Data();
			data.HasNext = _ctx.BooleanValue("ListAnalyticsData.Data.HasNext");
			data.ResultJson = _ctx.StringValue("ListAnalyticsData.Data.ResultJson");
			data.Count = _ctx.LongValue("ListAnalyticsData.Data.Count");
			data.PageNum = _ctx.IntegerValue("ListAnalyticsData.Data.PageNum");
			data.PageSize = _ctx.IntegerValue("ListAnalyticsData.Data.PageSize");
			listAnalyticsDataResponse.Data = data;
        
			return listAnalyticsDataResponse;
        }
    }
}
