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
using Aliyun.Acs.idrsservice.Model.V20200630;

namespace Aliyun.Acs.idrsservice.Transform.V20200630
{
    public class GetDepartmentResponseUnmarshaller
    {
        public static GetDepartmentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDepartmentResponse getDepartmentResponse = new GetDepartmentResponse();

			getDepartmentResponse.HttpResponse = _ctx.HttpResponse;
			getDepartmentResponse.Code = _ctx.StringValue("GetDepartment.Code");
			getDepartmentResponse.Message = _ctx.StringValue("GetDepartment.Message");
			getDepartmentResponse.RequestId = _ctx.StringValue("GetDepartment.RequestId");

			GetDepartmentResponse.GetDepartment_Data data = new GetDepartmentResponse.GetDepartment_Data();
			data.CreatedAt = _ctx.StringValue("GetDepartment.Data.CreatedAt");
			data.Description = _ctx.StringValue("GetDepartment.Data.Description");
			data.Id = _ctx.StringValue("GetDepartment.Data.Id");
			data.Name = _ctx.StringValue("GetDepartment.Data.Name");
			data.UpdatedAt = _ctx.StringValue("GetDepartment.Data.UpdatedAt");
			getDepartmentResponse.Data = data;
        
			return getDepartmentResponse;
        }
    }
}
