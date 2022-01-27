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
    public class CreateDagComplementResponseUnmarshaller
    {
        public static CreateDagComplementResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateDagComplementResponse createDagComplementResponse = new CreateDagComplementResponse();

			createDagComplementResponse.HttpResponse = _ctx.HttpResponse;
			createDagComplementResponse.ErrorCode = _ctx.StringValue("CreateDagComplement.ErrorCode");
			createDagComplementResponse.ErrorMessage = _ctx.StringValue("CreateDagComplement.ErrorMessage");
			createDagComplementResponse.HttpStatusCode = _ctx.IntegerValue("CreateDagComplement.HttpStatusCode");
			createDagComplementResponse.RequestId = _ctx.StringValue("CreateDagComplement.RequestId");
			createDagComplementResponse.Success = _ctx.BooleanValue("CreateDagComplement.Success");

			List<string> createDagComplementResponse_data = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateDagComplement.Data.Length"); i++) {
				createDagComplementResponse_data.Add(_ctx.StringValue("CreateDagComplement.Data["+ i +"]"));
			}
			createDagComplementResponse.Data = createDagComplementResponse_data;
        
			return createDagComplementResponse;
        }
    }
}
