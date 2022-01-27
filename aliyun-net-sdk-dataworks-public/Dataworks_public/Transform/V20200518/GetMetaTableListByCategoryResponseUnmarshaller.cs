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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetMetaTableListByCategoryResponseUnmarshaller
    {
        public static GetMetaTableListByCategoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMetaTableListByCategoryResponse getMetaTableListByCategoryResponse = new GetMetaTableListByCategoryResponse();

			getMetaTableListByCategoryResponse.HttpResponse = _ctx.HttpResponse;
			getMetaTableListByCategoryResponse.RequestId = _ctx.StringValue("GetMetaTableListByCategory.RequestId");
			getMetaTableListByCategoryResponse.ErrorCode = _ctx.StringValue("GetMetaTableListByCategory.ErrorCode");
			getMetaTableListByCategoryResponse.ErrorMessage = _ctx.StringValue("GetMetaTableListByCategory.ErrorMessage");
			getMetaTableListByCategoryResponse.HttpStatusCode = _ctx.IntegerValue("GetMetaTableListByCategory.HttpStatusCode");
			getMetaTableListByCategoryResponse.Success = _ctx.BooleanValue("GetMetaTableListByCategory.Success");

			GetMetaTableListByCategoryResponse.GetMetaTableListByCategory_Data data = new GetMetaTableListByCategoryResponse.GetMetaTableListByCategory_Data();
			data.PageNumber = _ctx.IntegerValue("GetMetaTableListByCategory.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("GetMetaTableListByCategory.Data.PageSize");
			data.TotalCount = _ctx.LongValue("GetMetaTableListByCategory.Data.TotalCount");

			List<string> data_tableGuidList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetMetaTableListByCategory.Data.TableGuidList.Length"); i++) {
				data_tableGuidList.Add(_ctx.StringValue("GetMetaTableListByCategory.Data.TableGuidList["+ i +"]"));
			}
			data.TableGuidList = data_tableGuidList;
			getMetaTableListByCategoryResponse.Data = data;
        
			return getMetaTableListByCategoryResponse;
        }
    }
}
