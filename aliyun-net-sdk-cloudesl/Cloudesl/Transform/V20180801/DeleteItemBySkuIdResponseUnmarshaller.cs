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
using Aliyun.Acs.cloudesl.Model.V20180801;

namespace Aliyun.Acs.cloudesl.Transform.V20180801
{
    public class DeleteItemBySkuIdResponseUnmarshaller
    {
        public static DeleteItemBySkuIdResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteItemBySkuIdResponse deleteItemBySkuIdResponse = new DeleteItemBySkuIdResponse();

			deleteItemBySkuIdResponse.HttpResponse = context.HttpResponse;
			deleteItemBySkuIdResponse.RequestId = context.StringValue("DeleteItemBySkuId.RequestId");
			deleteItemBySkuIdResponse.Success = context.BooleanValue("DeleteItemBySkuId.Success");
			deleteItemBySkuIdResponse.Message = context.StringValue("DeleteItemBySkuId.Message");
			deleteItemBySkuIdResponse.ErrorCode = context.StringValue("DeleteItemBySkuId.ErrorCode");
        
			return deleteItemBySkuIdResponse;
        }
    }
}
