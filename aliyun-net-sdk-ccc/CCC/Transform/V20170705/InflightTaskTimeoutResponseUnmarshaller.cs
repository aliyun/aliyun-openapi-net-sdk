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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class InflightTaskTimeoutResponseUnmarshaller
    {
        public static InflightTaskTimeoutResponse Unmarshall(UnmarshallerContext context)
        {
			InflightTaskTimeoutResponse inflightTaskTimeoutResponse = new InflightTaskTimeoutResponse();

			inflightTaskTimeoutResponse.HttpResponse = context.HttpResponse;
			inflightTaskTimeoutResponse.RequestId = context.StringValue("InflightTaskTimeout.RequestId");
			inflightTaskTimeoutResponse.Success = context.BooleanValue("InflightTaskTimeout.Success");
			inflightTaskTimeoutResponse.Code = context.StringValue("InflightTaskTimeout.Code");
			inflightTaskTimeoutResponse.Message = context.StringValue("InflightTaskTimeout.Message");
			inflightTaskTimeoutResponse.HttpStatusCode = context.IntegerValue("InflightTaskTimeout.HttpStatusCode");
        
			return inflightTaskTimeoutResponse;
        }
    }
}
