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
    public class CreateDataAPIServiceResponseUnmarshaller
    {
        public static CreateDataAPIServiceResponse Unmarshall(UnmarshallerContext context)
        {
			CreateDataAPIServiceResponse createDataAPIServiceResponse = new CreateDataAPIServiceResponse();

			createDataAPIServiceResponse.HttpResponse = context.HttpResponse;
			createDataAPIServiceResponse.RequestId = context.StringValue("CreateDataAPIService.RequestId");
			createDataAPIServiceResponse.Success = context.BooleanValue("CreateDataAPIService.Success");
			createDataAPIServiceResponse.Code = context.StringValue("CreateDataAPIService.Code");
			createDataAPIServiceResponse.ErrorMessage = context.StringValue("CreateDataAPIService.ErrorMessage");

			CreateDataAPIServiceResponse.CreateDataAPIService_Data data = new CreateDataAPIServiceResponse.CreateDataAPIService_Data();
			data.ApiSrn = context.StringValue("CreateDataAPIService.Data.ApiSrn");
			data.CreateTime = context.LongValue("CreateDataAPIService.Data.CreateTime");
			data.LastUpdateTime = context.LongValue("CreateDataAPIService.Data.LastUpdateTime");
			createDataAPIServiceResponse.Data = data;
        
			return createDataAPIServiceResponse;
        }
    }
}
