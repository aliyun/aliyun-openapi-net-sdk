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
    public class GetDataServiceApplicationResponseUnmarshaller
    {
        public static GetDataServiceApplicationResponse Unmarshall(UnmarshallerContext context)
        {
			GetDataServiceApplicationResponse getDataServiceApplicationResponse = new GetDataServiceApplicationResponse();

			getDataServiceApplicationResponse.HttpResponse = context.HttpResponse;
			getDataServiceApplicationResponse.ErrorCode = context.StringValue("GetDataServiceApplication.ErrorCode");
			getDataServiceApplicationResponse.ErrorMessage = context.StringValue("GetDataServiceApplication.ErrorMessage");
			getDataServiceApplicationResponse.HttpStatusCode = context.IntegerValue("GetDataServiceApplication.HttpStatusCode");
			getDataServiceApplicationResponse.RequestId = context.StringValue("GetDataServiceApplication.RequestId");
			getDataServiceApplicationResponse.Success = context.BooleanValue("GetDataServiceApplication.Success");

			GetDataServiceApplicationResponse.GetDataServiceApplication_Data data = new GetDataServiceApplicationResponse.GetDataServiceApplication_Data();
			data.ApplicationCode = context.StringValue("GetDataServiceApplication.Data.ApplicationCode");
			data.ApplicationId = context.LongValue("GetDataServiceApplication.Data.ApplicationId");
			data.ApplicationKey = context.StringValue("GetDataServiceApplication.Data.ApplicationKey");
			data.ApplicationName = context.StringValue("GetDataServiceApplication.Data.ApplicationName");
			data.ApplicationSecret = context.StringValue("GetDataServiceApplication.Data.ApplicationSecret");
			data.ProjectId = context.LongValue("GetDataServiceApplication.Data.ProjectId");
			getDataServiceApplicationResponse.Data = data;
        
			return getDataServiceApplicationResponse;
        }
    }
}
