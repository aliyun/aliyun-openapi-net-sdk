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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class CountUserResponseUnmarshaller
    {
        public static CountUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CountUserResponse countUserResponse = new CountUserResponse();

			countUserResponse.HttpResponse = _ctx.HttpResponse;
			countUserResponse.Code = _ctx.StringValue("CountUser.Code");
			countUserResponse.Success = _ctx.BooleanValue("CountUser.Success");
			countUserResponse.Message = _ctx.StringValue("CountUser.Message");
			countUserResponse.RequestId = _ctx.StringValue("CountUser.RequestId");
			countUserResponse.Model = _ctx.IntegerValue("CountUser.Model");
        
			return countUserResponse;
        }
    }
}
