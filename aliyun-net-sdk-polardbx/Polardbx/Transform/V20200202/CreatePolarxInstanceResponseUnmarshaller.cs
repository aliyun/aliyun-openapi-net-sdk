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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class CreatePolarxInstanceResponseUnmarshaller
    {
        public static CreatePolarxInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreatePolarxInstanceResponse createPolarxInstanceResponse = new CreatePolarxInstanceResponse();

			createPolarxInstanceResponse.HttpResponse = _ctx.HttpResponse;
			createPolarxInstanceResponse.RequestId = _ctx.StringValue("CreatePolarxInstance.RequestId");
			createPolarxInstanceResponse.Success = _ctx.BooleanValue("CreatePolarxInstance.Success");

			CreatePolarxInstanceResponse.CreatePolarxInstance_Data data = new CreatePolarxInstanceResponse.CreatePolarxInstance_Data();
			data.OrderId = _ctx.LongValue("CreatePolarxInstance.Data.OrderId");

			List<string> data_drdsInstanceIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("CreatePolarxInstance.Data.DrdsInstanceIdList.Length"); i++) {
				data_drdsInstanceIdList.Add(_ctx.StringValue("CreatePolarxInstance.Data.DrdsInstanceIdList["+ i +"]"));
			}
			data.DrdsInstanceIdList = data_drdsInstanceIdList;
			createPolarxInstanceResponse.Data = data;
        
			return createPolarxInstanceResponse;
        }
    }
}
