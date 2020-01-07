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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class DeleteAppResourceAllocResponseUnmarshaller
    {
        public static DeleteAppResourceAllocResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteAppResourceAllocResponse deleteAppResourceAllocResponse = new DeleteAppResourceAllocResponse();

			deleteAppResourceAllocResponse.HttpResponse = context.HttpResponse;
			deleteAppResourceAllocResponse.Code = context.IntegerValue("DeleteAppResourceAlloc.Code");
			deleteAppResourceAllocResponse.ErrMsg = context.StringValue("DeleteAppResourceAlloc.ErrMsg");
			deleteAppResourceAllocResponse.RequestId = context.StringValue("DeleteAppResourceAlloc.RequestId");
			deleteAppResourceAllocResponse.Success = context.BooleanValue("DeleteAppResourceAlloc.Success");
        
			return deleteAppResourceAllocResponse;
        }
    }
}
