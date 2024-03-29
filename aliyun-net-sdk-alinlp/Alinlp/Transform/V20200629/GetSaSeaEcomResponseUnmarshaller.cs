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
using Aliyun.Acs.alinlp.Model.V20200629;

namespace Aliyun.Acs.alinlp.Transform.V20200629
{
    public class GetSaSeaEcomResponseUnmarshaller
    {
        public static GetSaSeaEcomResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSaSeaEcomResponse getSaSeaEcomResponse = new GetSaSeaEcomResponse();

			getSaSeaEcomResponse.HttpResponse = _ctx.HttpResponse;
			getSaSeaEcomResponse.RequestId = _ctx.StringValue("GetSaSeaEcom.RequestId");
			getSaSeaEcomResponse.Data = _ctx.StringValue("GetSaSeaEcom.Data");
        
			return getSaSeaEcomResponse;
        }
    }
}
