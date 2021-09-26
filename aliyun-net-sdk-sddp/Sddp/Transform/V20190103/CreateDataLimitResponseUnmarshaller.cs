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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class CreateDataLimitResponseUnmarshaller
    {
        public static CreateDataLimitResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateDataLimitResponse createDataLimitResponse = new CreateDataLimitResponse();

			createDataLimitResponse.HttpResponse = _ctx.HttpResponse;
			createDataLimitResponse.RequestId = _ctx.StringValue("CreateDataLimit.RequestId");
			createDataLimitResponse.Id = _ctx.IntegerValue("CreateDataLimit.Id");
        
			return createDataLimitResponse;
        }
    }
}
