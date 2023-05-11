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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class ListApiDatasourceResponseUnmarshaller
    {
        public static ListApiDatasourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListApiDatasourceResponse listApiDatasourceResponse = new ListApiDatasourceResponse();

			listApiDatasourceResponse.HttpResponse = _ctx.HttpResponse;
			listApiDatasourceResponse.RequestId = _ctx.StringValue("ListApiDatasource.RequestId");
			listApiDatasourceResponse.Success = _ctx.BooleanValue("ListApiDatasource.Success");

			ListApiDatasourceResponse.ListApiDatasource_Result result = new ListApiDatasourceResponse.ListApiDatasource_Result();
			result.PageNum = _ctx.IntegerValue("ListApiDatasource.Result.PageNum");
			result.PageSize = _ctx.IntegerValue("ListApiDatasource.Result.PageSize");
			result.TotalNum = _ctx.IntegerValue("ListApiDatasource.Result.TotalNum");

			List<ListApiDatasourceResponse.ListApiDatasource_Result.ListApiDatasource_DataItem> result_data = new List<ListApiDatasourceResponse.ListApiDatasource_Result.ListApiDatasource_DataItem>();
			for (int i = 0; i < _ctx.Length("ListApiDatasource.Result.Data.Length"); i++) {
				ListApiDatasourceResponse.ListApiDatasource_Result.ListApiDatasource_DataItem dataItem = new ListApiDatasourceResponse.ListApiDatasource_Result.ListApiDatasource_DataItem();
				dataItem.ApiId = _ctx.StringValue("ListApiDatasource.Result.Data["+ i +"].ApiId");
				dataItem.JobId = _ctx.StringValue("ListApiDatasource.Result.Data["+ i +"].JobId");
				dataItem.ShowName = _ctx.StringValue("ListApiDatasource.Result.Data["+ i +"].ShowName");
				dataItem.DataSize = _ctx.FloatValue("ListApiDatasource.Result.Data["+ i +"].DataSize");
				dataItem.StatusType = _ctx.IntegerValue("ListApiDatasource.Result.Data["+ i +"].StatusType");
				dataItem.Parameters = _ctx.StringValue("ListApiDatasource.Result.Data["+ i +"].Parameters");
				dataItem.Body = _ctx.StringValue("ListApiDatasource.Result.Data["+ i +"].Body");
				dataItem.DateUpdateTime = _ctx.StringValue("ListApiDatasource.Result.Data["+ i +"].DateUpdateTime");
				dataItem.GmtCreate = _ctx.StringValue("ListApiDatasource.Result.Data["+ i +"].GmtCreate");
				dataItem.GmtModified = _ctx.StringValue("ListApiDatasource.Result.Data["+ i +"].GmtModified");

				result_data.Add(dataItem);
			}
			result.Data = result_data;
			listApiDatasourceResponse.Result = result;
        
			return listApiDatasourceResponse;
        }
    }
}
