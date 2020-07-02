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
    public class CreateDataServiceApiResponseUnmarshaller
    {
        public static CreateDataServiceApiResponse Unmarshall(UnmarshallerContext context)
        {
			CreateDataServiceApiResponse createDataServiceApiResponse = new CreateDataServiceApiResponse();

			createDataServiceApiResponse.HttpResponse = context.HttpResponse;
			createDataServiceApiResponse.Data = context.LongValue("CreateDataServiceApi.Data");
			createDataServiceApiResponse.ErrorCode = context.StringValue("CreateDataServiceApi.ErrorCode");
			createDataServiceApiResponse.ErrorMessage = context.StringValue("CreateDataServiceApi.ErrorMessage");
			createDataServiceApiResponse.HttpStatusCode = context.IntegerValue("CreateDataServiceApi.HttpStatusCode");
			createDataServiceApiResponse.Success = context.BooleanValue("CreateDataServiceApi.Success");
			createDataServiceApiResponse.RequestId = context.StringValue("CreateDataServiceApi.RequestId");
        
			return createDataServiceApiResponse;
        }
    }
}
