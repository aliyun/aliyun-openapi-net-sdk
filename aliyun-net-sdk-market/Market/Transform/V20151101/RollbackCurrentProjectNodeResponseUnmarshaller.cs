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
using Aliyun.Acs.Market.Model.V20151101;

namespace Aliyun.Acs.Market.Transform.V20151101
{
    public class RollbackCurrentProjectNodeResponseUnmarshaller
    {
        public static RollbackCurrentProjectNodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RollbackCurrentProjectNodeResponse rollbackCurrentProjectNodeResponse = new RollbackCurrentProjectNodeResponse();

			rollbackCurrentProjectNodeResponse.HttpResponse = _ctx.HttpResponse;
			rollbackCurrentProjectNodeResponse.RequestId = _ctx.StringValue("RollbackCurrentProjectNode.RequestId");
			rollbackCurrentProjectNodeResponse.Result = _ctx.BooleanValue("RollbackCurrentProjectNode.Result");
			rollbackCurrentProjectNodeResponse.Success = _ctx.BooleanValue("RollbackCurrentProjectNode.Success");
        
			return rollbackCurrentProjectNodeResponse;
        }
    }
}
