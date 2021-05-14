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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeDrdsInstanceVersionResponseUnmarshaller
    {
        public static DescribeDrdsInstanceVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDrdsInstanceVersionResponse describeDrdsInstanceVersionResponse = new DescribeDrdsInstanceVersionResponse();

			describeDrdsInstanceVersionResponse.HttpResponse = _ctx.HttpResponse;
			describeDrdsInstanceVersionResponse.RequestId = _ctx.StringValue("DescribeDrdsInstanceVersion.RequestId");
			describeDrdsInstanceVersionResponse.Success = _ctx.BooleanValue("DescribeDrdsInstanceVersion.Success");

			DescribeDrdsInstanceVersionResponse.DescribeDrdsInstanceVersion_Data data = new DescribeDrdsInstanceVersionResponse.DescribeDrdsInstanceVersion_Data();
			data.InstanceVersion = _ctx.StringValue("DescribeDrdsInstanceVersion.Data.InstanceVersion");
			data.NewestVersion = _ctx.StringValue("DescribeDrdsInstanceVersion.Data.NewestVersion");
			describeDrdsInstanceVersionResponse.Data = data;
        
			return describeDrdsInstanceVersionResponse;
        }
    }
}
