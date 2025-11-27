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
using Aliyun.Acs.OssSddp.Model.V20240222;

namespace Aliyun.Acs.OssSddp.Transform.V20240222
{
    public class GetSddpVersionResponseUnmarshaller
    {
        public static GetSddpVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSddpVersionResponse getSddpVersionResponse = new GetSddpVersionResponse();

			getSddpVersionResponse.HttpResponse = _ctx.HttpResponse;
			getSddpVersionResponse.RequestId = _ctx.StringValue("GetSddpVersion.RequestId");
			getSddpVersionResponse.Content = _ctx.IntegerValue("GetSddpVersion.Content");
        
			return getSddpVersionResponse;
        }
    }
}
