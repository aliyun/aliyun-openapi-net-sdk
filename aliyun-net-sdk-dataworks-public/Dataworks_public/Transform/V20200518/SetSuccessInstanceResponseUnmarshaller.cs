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
    public class SetSuccessInstanceResponseUnmarshaller
    {
        public static SetSuccessInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			SetSuccessInstanceResponse setSuccessInstanceResponse = new SetSuccessInstanceResponse();

			setSuccessInstanceResponse.HttpResponse = context.HttpResponse;
			setSuccessInstanceResponse.ErrorCode = context.StringValue("SetSuccessInstance.ErrorCode");
			setSuccessInstanceResponse.ErrorMessage = context.StringValue("SetSuccessInstance.ErrorMessage");
			setSuccessInstanceResponse.HttpStatusCode = context.IntegerValue("SetSuccessInstance.HttpStatusCode");
			setSuccessInstanceResponse.RequestId = context.StringValue("SetSuccessInstance.RequestId");
			setSuccessInstanceResponse.Success = context.BooleanValue("SetSuccessInstance.Success");
			setSuccessInstanceResponse.Data = context.BooleanValue("SetSuccessInstance.Data");
        
			return setSuccessInstanceResponse;
        }
    }
}
