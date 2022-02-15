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
    public class ListPatentContactResponseUnmarshaller
    {
        public static ListPatentContactResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPatentContactResponse listPatentContactResponse = new ListPatentContactResponse();

			listPatentContactResponse.HttpResponse = _ctx.HttpResponse;
			listPatentContactResponse.PageNum = _ctx.IntegerValue("ListPatentContact.PageNum");
			listPatentContactResponse.PageSize = _ctx.IntegerValue("ListPatentContact.PageSize");
			listPatentContactResponse.RequestId = _ctx.StringValue("ListPatentContact.RequestId");
			listPatentContactResponse.Success = _ctx.BooleanValue("ListPatentContact.Success");
			listPatentContactResponse.TotalItemNum = _ctx.IntegerValue("ListPatentContact.TotalItemNum");
			listPatentContactResponse.TotalPageNum = _ctx.IntegerValue("ListPatentContact.TotalPageNum");

			List<ListPatentContactResponse.ListPatentContact_Produces> listPatentContactResponse_data = new List<ListPatentContactResponse.ListPatentContact_Produces>();
			for (int i = 0; i < _ctx.Length("ListPatentContact.Data.Length"); i++) {
				ListPatentContactResponse.ListPatentContact_Produces produces = new ListPatentContactResponse.ListPatentContact_Produces();
				produces.Id = _ctx.LongValue("ListPatentContact.Data["+ i +"].Id");
				produces.Name = _ctx.StringValue("ListPatentContact.Data["+ i +"].Name");
				produces.Email = _ctx.StringValue("ListPatentContact.Data["+ i +"].Email");
				produces.Mobile = _ctx.StringValue("ListPatentContact.Data["+ i +"].Mobile");

				listPatentContactResponse_data.Add(produces);
			}
			listPatentContactResponse.Data = listPatentContactResponse_data;
        
			return listPatentContactResponse;
        }
    }
}
