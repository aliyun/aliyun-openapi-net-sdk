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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class InsertConfigCenterResponseUnmarshaller
    {
        public static InsertConfigCenterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			InsertConfigCenterResponse insertConfigCenterResponse = new InsertConfigCenterResponse();

			insertConfigCenterResponse.HttpResponse = _ctx.HttpResponse;
			insertConfigCenterResponse.Code = _ctx.IntegerValue("InsertConfigCenter.Code");
			insertConfigCenterResponse.Message = _ctx.StringValue("InsertConfigCenter.Message");
			insertConfigCenterResponse.RequestId = _ctx.StringValue("InsertConfigCenter.RequestId");
        
			return insertConfigCenterResponse;
        }
    }
}
