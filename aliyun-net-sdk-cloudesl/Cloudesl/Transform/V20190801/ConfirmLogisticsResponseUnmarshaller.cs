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
using Aliyun.Acs.cloudesl.Model.V20190801;

namespace Aliyun.Acs.cloudesl.Transform.V20190801
{
    public class ConfirmLogisticsResponseUnmarshaller
    {
        public static ConfirmLogisticsResponse Unmarshall(UnmarshallerContext context)
        {
			ConfirmLogisticsResponse confirmLogisticsResponse = new ConfirmLogisticsResponse();

			confirmLogisticsResponse.HttpResponse = context.HttpResponse;
			confirmLogisticsResponse.ErrorMessage = context.StringValue("ConfirmLogistics.ErrorMessage");
			confirmLogisticsResponse.ErrorCode = context.StringValue("ConfirmLogistics.ErrorCode");
			confirmLogisticsResponse.Message = context.StringValue("ConfirmLogistics.Message");
			confirmLogisticsResponse.DynamicCode = context.StringValue("ConfirmLogistics.DynamicCode");
			confirmLogisticsResponse.Code = context.StringValue("ConfirmLogistics.Code");
			confirmLogisticsResponse.DynamicMessage = context.StringValue("ConfirmLogistics.DynamicMessage");
			confirmLogisticsResponse.Acceptance = context.StringValue("ConfirmLogistics.Acceptance");
			confirmLogisticsResponse.RequestId = context.StringValue("ConfirmLogistics.RequestId");
			confirmLogisticsResponse.Success = context.BooleanValue("ConfirmLogistics.Success");
        
			return confirmLogisticsResponse;
        }
    }
}
