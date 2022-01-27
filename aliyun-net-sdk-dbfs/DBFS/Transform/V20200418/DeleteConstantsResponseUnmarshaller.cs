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
using Aliyun.Acs.DBFS.Model.V20200418;

namespace Aliyun.Acs.DBFS.Transform.V20200418
{
    public class DeleteConstantsResponseUnmarshaller
    {
        public static DeleteConstantsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteConstantsResponse deleteConstantsResponse = new DeleteConstantsResponse();

			deleteConstantsResponse.HttpResponse = _ctx.HttpResponse;
			deleteConstantsResponse.RequestId = _ctx.StringValue("DeleteConstants.RequestId");
			deleteConstantsResponse.Data = _ctx.StringValue("DeleteConstants.Data");
			deleteConstantsResponse.PageSize = _ctx.LongValue("DeleteConstants.PageSize");
			deleteConstantsResponse.TotalCount = _ctx.LongValue("DeleteConstants.TotalCount");
			deleteConstantsResponse.PageNumber = _ctx.LongValue("DeleteConstants.PageNumber");
        
			return deleteConstantsResponse;
        }
    }
}
