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
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class SubmitNodeTupleOrderResponseUnmarshaller
    {
        public static SubmitNodeTupleOrderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitNodeTupleOrderResponse submitNodeTupleOrderResponse = new SubmitNodeTupleOrderResponse();

			submitNodeTupleOrderResponse.HttpResponse = _ctx.HttpResponse;
			submitNodeTupleOrderResponse.RequestId = _ctx.StringValue("SubmitNodeTupleOrder.RequestId");
			submitNodeTupleOrderResponse.Success = _ctx.BooleanValue("SubmitNodeTupleOrder.Success");
			submitNodeTupleOrderResponse.Data = _ctx.StringValue("SubmitNodeTupleOrder.Data");
        
			return submitNodeTupleOrderResponse;
        }
    }
}
