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
using Aliyun.Acs.cloudwf.Model.V20170328;

namespace Aliyun.Acs.cloudwf.Transform.V20170328
{
    public class GetStaDetailedStatusResponseUnmarshaller
    {
        public static GetStaDetailedStatusResponse Unmarshall(UnmarshallerContext context)
        {
			GetStaDetailedStatusResponse getStaDetailedStatusResponse = new GetStaDetailedStatusResponse();

			getStaDetailedStatusResponse.HttpResponse = context.HttpResponse;
			getStaDetailedStatusResponse.RequestId = context.StringValue("GetStaDetailedStatus.RequestId");
			getStaDetailedStatusResponse.Success = context.BooleanValue("GetStaDetailedStatus.Success");
			getStaDetailedStatusResponse.Message = context.StringValue("GetStaDetailedStatus.Message");
			getStaDetailedStatusResponse.Data = context.StringValue("GetStaDetailedStatus.Data");
			getStaDetailedStatusResponse.ErrorCode = context.IntegerValue("GetStaDetailedStatus.ErrorCode");
			getStaDetailedStatusResponse.ErrorMsg = context.StringValue("GetStaDetailedStatus.ErrorMsg");
        
			return getStaDetailedStatusResponse;
        }
    }
}
