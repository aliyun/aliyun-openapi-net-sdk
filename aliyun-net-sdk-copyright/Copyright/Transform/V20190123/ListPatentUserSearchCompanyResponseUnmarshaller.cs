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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class ListPatentUserSearchCompanyResponseUnmarshaller
    {
        public static ListPatentUserSearchCompanyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPatentUserSearchCompanyResponse listPatentUserSearchCompanyResponse = new ListPatentUserSearchCompanyResponse();

			listPatentUserSearchCompanyResponse.HttpResponse = _ctx.HttpResponse;
			listPatentUserSearchCompanyResponse.RequestId = _ctx.StringValue("ListPatentUserSearchCompany.RequestId");
			listPatentUserSearchCompanyResponse.Success = _ctx.BooleanValue("ListPatentUserSearchCompany.Success");

			List<ListPatentUserSearchCompanyResponse.ListPatentUserSearchCompany_Produces> listPatentUserSearchCompanyResponse_data = new List<ListPatentUserSearchCompanyResponse.ListPatentUserSearchCompany_Produces>();
			for (int i = 0; i < _ctx.Length("ListPatentUserSearchCompany.Data.Length"); i++) {
				ListPatentUserSearchCompanyResponse.ListPatentUserSearchCompany_Produces produces = new ListPatentUserSearchCompanyResponse.ListPatentUserSearchCompany_Produces();
				produces.EnterpriseName = _ctx.StringValue("ListPatentUserSearchCompany.Data["+ i +"].EnterpriseName");
				produces.Id = _ctx.LongValue("ListPatentUserSearchCompany.Data["+ i +"].Id");
				produces.Type = _ctx.IntegerValue("ListPatentUserSearchCompany.Data["+ i +"].Type");

				listPatentUserSearchCompanyResponse_data.Add(produces);
			}
			listPatentUserSearchCompanyResponse.Data = listPatentUserSearchCompanyResponse_data;
        
			return listPatentUserSearchCompanyResponse;
        }
    }
}
