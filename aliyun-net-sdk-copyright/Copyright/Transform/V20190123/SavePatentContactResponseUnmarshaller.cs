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
    public class SavePatentContactResponseUnmarshaller
    {
        public static SavePatentContactResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SavePatentContactResponse savePatentContactResponse = new SavePatentContactResponse();

			savePatentContactResponse.HttpResponse = _ctx.HttpResponse;
			savePatentContactResponse.PageNum = _ctx.IntegerValue("SavePatentContact.PageNum");
			savePatentContactResponse.PageSize = _ctx.IntegerValue("SavePatentContact.PageSize");
			savePatentContactResponse.RequestId = _ctx.StringValue("SavePatentContact.RequestId");
			savePatentContactResponse.Success = _ctx.BooleanValue("SavePatentContact.Success");
			savePatentContactResponse.TotalItemNum = _ctx.IntegerValue("SavePatentContact.TotalItemNum");
			savePatentContactResponse.TotalPageNum = _ctx.IntegerValue("SavePatentContact.TotalPageNum");

			List<SavePatentContactResponse.SavePatentContact_Produces> savePatentContactResponse_data = new List<SavePatentContactResponse.SavePatentContact_Produces>();
			for (int i = 0; i < _ctx.Length("SavePatentContact.Data.Length"); i++) {
				SavePatentContactResponse.SavePatentContact_Produces produces = new SavePatentContactResponse.SavePatentContact_Produces();
				produces.Email = _ctx.StringValue("SavePatentContact.Data["+ i +"].Email");
				produces.Id = _ctx.LongValue("SavePatentContact.Data["+ i +"].Id");
				produces.Mobile = _ctx.StringValue("SavePatentContact.Data["+ i +"].Mobile");
				produces.Name = _ctx.StringValue("SavePatentContact.Data["+ i +"].Name");

				savePatentContactResponse_data.Add(produces);
			}
			savePatentContactResponse.Data = savePatentContactResponse_data;
        
			return savePatentContactResponse;
        }
    }
}
