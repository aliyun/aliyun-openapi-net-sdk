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
    public class UnbindEslDeviceShelfResponseUnmarshaller
    {
        public static UnbindEslDeviceShelfResponse Unmarshall(UnmarshallerContext context)
        {
			UnbindEslDeviceShelfResponse unbindEslDeviceShelfResponse = new UnbindEslDeviceShelfResponse();

			unbindEslDeviceShelfResponse.HttpResponse = context.HttpResponse;
			unbindEslDeviceShelfResponse.ErrorMessage = context.StringValue("UnbindEslDeviceShelf.ErrorMessage");
			unbindEslDeviceShelfResponse.ErrorCode = context.StringValue("UnbindEslDeviceShelf.ErrorCode");
			unbindEslDeviceShelfResponse.Message = context.StringValue("UnbindEslDeviceShelf.Message");
			unbindEslDeviceShelfResponse.DynamicCode = context.StringValue("UnbindEslDeviceShelf.DynamicCode");
			unbindEslDeviceShelfResponse.Code = context.StringValue("UnbindEslDeviceShelf.Code");
			unbindEslDeviceShelfResponse.DynamicMessage = context.StringValue("UnbindEslDeviceShelf.DynamicMessage");
			unbindEslDeviceShelfResponse.RequestId = context.StringValue("UnbindEslDeviceShelf.RequestId");
			unbindEslDeviceShelfResponse.Success = context.BooleanValue("UnbindEslDeviceShelf.Success");
        
			return unbindEslDeviceShelfResponse;
        }
    }
}
