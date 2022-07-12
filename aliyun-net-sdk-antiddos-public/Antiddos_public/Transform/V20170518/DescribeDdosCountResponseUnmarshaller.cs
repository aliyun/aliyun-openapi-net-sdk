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
using Aliyun.Acs.antiddos_public.Model.V20170518;

namespace Aliyun.Acs.antiddos_public.Transform.V20170518
{
    public class DescribeDdosCountResponseUnmarshaller
    {
        public static DescribeDdosCountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDdosCountResponse describeDdosCountResponse = new DescribeDdosCountResponse();

			describeDdosCountResponse.HttpResponse = _ctx.HttpResponse;
			describeDdosCountResponse.RequestId = _ctx.StringValue("DescribeDdosCount.RequestId");

			DescribeDdosCountResponse.DescribeDdosCount_DdosCount ddosCount = new DescribeDdosCountResponse.DescribeDdosCount_DdosCount();
			ddosCount.BlackholeCount = _ctx.IntegerValue("DescribeDdosCount.DdosCount.BlackholeCount");
			ddosCount.InstacenCount = _ctx.IntegerValue("DescribeDdosCount.DdosCount.InstacenCount");
			ddosCount.DefenseCount = _ctx.IntegerValue("DescribeDdosCount.DdosCount.DefenseCount");
			describeDdosCountResponse.DdosCount = ddosCount;
        
			return describeDdosCountResponse;
        }
    }
}
