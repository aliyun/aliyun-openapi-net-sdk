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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeDDosEventMaxResponseUnmarshaller
    {
        public static DescribeDDosEventMaxResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDDosEventMaxResponse describeDDosEventMaxResponse = new DescribeDDosEventMaxResponse();

			describeDDosEventMaxResponse.HttpResponse = _ctx.HttpResponse;
			describeDDosEventMaxResponse.RequestId = _ctx.StringValue("DescribeDDosEventMax.RequestId");
			describeDDosEventMaxResponse.Mbps = _ctx.LongValue("DescribeDDosEventMax.Mbps");
			describeDDosEventMaxResponse.Qps = _ctx.LongValue("DescribeDDosEventMax.Qps");
			describeDDosEventMaxResponse.Cps = _ctx.LongValue("DescribeDDosEventMax.Cps");
        
			return describeDDosEventMaxResponse;
        }
    }
}
