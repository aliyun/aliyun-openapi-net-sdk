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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DeleteItemResponseUnmarshaller
    {
        public static DeleteItemResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteItemResponse deleteItemResponse = new DeleteItemResponse();

			deleteItemResponse.HttpResponse = _ctx.HttpResponse;
			deleteItemResponse.Code = _ctx.StringValue("DeleteItem.Code");
			deleteItemResponse.DynamicCode = _ctx.StringValue("DeleteItem.DynamicCode");
			deleteItemResponse.DynamicMessage = _ctx.StringValue("DeleteItem.DynamicMessage");
			deleteItemResponse.ErrorCode = _ctx.StringValue("DeleteItem.ErrorCode");
			deleteItemResponse.ErrorMessage = _ctx.StringValue("DeleteItem.ErrorMessage");
			deleteItemResponse.Message = _ctx.StringValue("DeleteItem.Message");
			deleteItemResponse.RequestId = _ctx.StringValue("DeleteItem.RequestId");
			deleteItemResponse.Success = _ctx.BooleanValue("DeleteItem.Success");
        
			return deleteItemResponse;
        }
    }
}
