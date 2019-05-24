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
    public class CreateDbResponseUnmarshaller
    {
        public static CreateDbResponse Unmarshall(UnmarshallerContext context)
        {
			CreateDbResponse createDbResponse = new CreateDbResponse();

			createDbResponse.HttpResponse = context.HttpResponse;
			createDbResponse.Code = context.IntegerValue("CreateDb.Code");
			createDbResponse.Success = context.BooleanValue("CreateDb.Success");
			createDbResponse.RequestId = context.StringValue("CreateDb.RequestId");
			createDbResponse.ErrMsg = context.StringValue("CreateDb.ErrMsg");
			createDbResponse._Class = context.StringValue("CreateDb.Class");
			createDbResponse.TransmitAliyun = context.BooleanValue("CreateDb.TransmitAliyun");

			CreateDbResponse.CreateDb_Result result = new CreateDbResponse.CreateDb_Result();
			result._Class = context.StringValue("CreateDb.Result.Class");
			createDbResponse.Result = result;
        
			return createDbResponse;
        }
    }
}
