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
    public class ListBusinessResponseUnmarshaller
    {
        public static ListBusinessResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListBusinessResponse listBusinessResponse = new ListBusinessResponse();

			listBusinessResponse.HttpResponse = _ctx.HttpResponse;
			listBusinessResponse.RequestId = _ctx.StringValue("ListBusiness.RequestId");
			listBusinessResponse.Success = _ctx.BooleanValue("ListBusiness.Success");
			listBusinessResponse.ErrorCode = _ctx.StringValue("ListBusiness.ErrorCode");
			listBusinessResponse.ErrorMessage = _ctx.StringValue("ListBusiness.ErrorMessage");
			listBusinessResponse.HttpStatusCode = _ctx.IntegerValue("ListBusiness.HttpStatusCode");

			ListBusinessResponse.ListBusiness_Data data = new ListBusinessResponse.ListBusiness_Data();
			data.PageNumber = _ctx.IntegerValue("ListBusiness.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListBusiness.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListBusiness.Data.TotalCount");

			List<ListBusinessResponse.ListBusiness_Data.ListBusiness_BusinessItem> data_business = new List<ListBusinessResponse.ListBusiness_Data.ListBusiness_BusinessItem>();
			for (int i = 0; i < _ctx.Length("ListBusiness.Data.Business.Length"); i++) {
				ListBusinessResponse.ListBusiness_Data.ListBusiness_BusinessItem businessItem = new ListBusinessResponse.ListBusiness_Data.ListBusiness_BusinessItem();
				businessItem.BusinessId = _ctx.LongValue("ListBusiness.Data.Business["+ i +"].BusinessId");
				businessItem.BusinessName = _ctx.StringValue("ListBusiness.Data.Business["+ i +"].BusinessName");
				businessItem.ProjectId = _ctx.LongValue("ListBusiness.Data.Business["+ i +"].ProjectId");
				businessItem.Owner = _ctx.StringValue("ListBusiness.Data.Business["+ i +"].Owner");
				businessItem.Description = _ctx.StringValue("ListBusiness.Data.Business["+ i +"].Description");
				businessItem.UseType = _ctx.StringValue("ListBusiness.Data.Business["+ i +"].UseType");

				data_business.Add(businessItem);
			}
			data.Business = data_business;
			listBusinessResponse.Data = data;
        
			return listBusinessResponse;
        }
    }
}
