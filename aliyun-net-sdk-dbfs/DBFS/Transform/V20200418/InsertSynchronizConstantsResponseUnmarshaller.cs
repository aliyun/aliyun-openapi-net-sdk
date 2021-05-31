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
    public class InsertSynchronizConstantsResponseUnmarshaller
    {
        public static InsertSynchronizConstantsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			InsertSynchronizConstantsResponse insertSynchronizConstantsResponse = new InsertSynchronizConstantsResponse();

			insertSynchronizConstantsResponse.HttpResponse = _ctx.HttpResponse;
			insertSynchronizConstantsResponse.RequestId = _ctx.StringValue("InsertSynchronizConstants.RequestId");
			insertSynchronizConstantsResponse.Data = _ctx.StringValue("InsertSynchronizConstants.Data");
			insertSynchronizConstantsResponse.PageSize = _ctx.LongValue("InsertSynchronizConstants.PageSize");
			insertSynchronizConstantsResponse.TotalCount = _ctx.LongValue("InsertSynchronizConstants.TotalCount");
			insertSynchronizConstantsResponse.PageNumber = _ctx.LongValue("InsertSynchronizConstants.PageNumber");
        
			return insertSynchronizConstantsResponse;
        }
    }
}
